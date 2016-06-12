import {
  TestComponentBuilder,
  describe,
  expect,
  injectAsync,
  it
} from '@angular/core/testing';
import {Component} from '@angular/core';
import {DOM} from '@angular/src/platform/dom/dom_adapter';
import {profileComponent} from './monthlyReport.component';
import {NameListService} from '../../shared/index';


export function main() {
  describe('monthlyReport component', () => {
    it('should work',
      injectAsync([TestComponentBuilder], (tcb: TestComponentBuilder) => {
        return tcb.createAsync(TestComponent)
          .then(rootTC => {
            rootTC.detectChanges();

            let profileInstance = rootTC.debugElement.children[0].componentInstance;
            let profileDOMEl = rootTC.debugElement.children[0].nativeElement;
            let nameListLen = function () {
              return profileInstance.nameListService.names.length;
            };

            expect(profileInstance.nameListService).toEqual(jasmine.any(NameListService));
            expect(nameListLen()).toEqual(4);
            expect(DOM.querySelectorAll(profileDOMEl, 'li').length).toEqual(nameListLen());

            profileInstance.newName = 'Minko';
            profileInstance.addName();
            rootTC.detectChanges();

            expect(nameListLen()).toEqual(5);
            expect(DOM.querySelectorAll(profileDOMEl, 'li').length).toEqual(nameListLen());

            expect(DOM.querySelectorAll(profileDOMEl, 'li')[4].textContent).toEqual('Minko');
          });
      }));
  });
}

@Component({
  providers: [NameListService],
  selector: 'test-cmp',
  template: '<sd-monthlyReport></sd-monthlyReport>',
  directives: [profileComponent]
})
class TestComponent {}
