import {
  TestComponentBuilder,
  describe,
  expect,
  injectAsync,
  it
} from '@angular/core/testing';
import {Component} from '@angular/core';
import {DOM} from '@angular/src/platform/dom/dom_adapter';
import {AboutComponent} from './about.component';

export function main() {
  describe('About component', () => {
    it('should work',
      injectAsync([TestComponentBuilder], (tcb: TestComponentBuilder) => {
        return tcb.createAsync(TestComponent)
          .then((rootTC: any) => {
            let aboutDOMEl = rootTC.debugElement.children[0].nativeElement;

            expect(DOM.querySelectorAll(aboutDOMEl, 'h2')[0].textContent).toEqual('Features');
          });
      }));
  });
}

@Component({
  selector: 'test-cmp',
  directives: [AboutComponent],
  template: '<sd-about></sd-about>'
})
class TestComponent {}
