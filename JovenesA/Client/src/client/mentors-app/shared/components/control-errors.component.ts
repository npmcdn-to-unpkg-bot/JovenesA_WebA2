
import {Component, Input, Host} from '@angular/core';
import {NgFormModel} from '@angular/common';

@Component({
  template: `<div>{{currentError}}</div>`,
  selector: 'control-errors'
})
export class ControlErrors {
  @Input() errors: Object;
  @Input() control: string;
  constructor(@Host() private formDir: NgFormModel) {}
  get currentError() {
    let control = this.formDir.form.controls[this.control];
    let errorMessages: Array<string> = [];
    if (control && control.touched) {
      errorMessages = Object.keys(this.errors)
        .map(k => control.hasError(k) ? (<any> this.errors)[k] : null)
        .filter(error => !!error);
    }
    return errorMessages.pop();
  }
}
