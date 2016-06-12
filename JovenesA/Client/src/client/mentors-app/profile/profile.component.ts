import {Component, OnInit} from '@angular/core';
import {Router, RouteParams} from '@angular/router-deprecated';
import {FormBuilder, Validators, ControlGroup, FORM_DIRECTIVES, FORM_PROVIDERS} from '@angular/common';
import {MyLogger} from '../shared/services/my-logger';
import {SqlResource} from '../shared/services/sql-resource';
import {Mentor} from '../shared/mentor';
import {ControlErrors} from '../shared/components/control-errors.component';


@Component({
  moduleId: module.id,
  //selector: 'mentor-profile',
  templateUrl: './profile.component.html',
  styleUrls:  ['./profile.component.css'],
  directives: [FORM_DIRECTIVES,  ControlErrors],
  providers: [FORM_PROVIDERS]
})
export class ProfileComponent implements OnInit {
  data: Object;
  loading: boolean;
  profileForm: ControlGroup;
  statuses: [{statusId: string, label: string}];
  errorMessage: string;
  successMessage: string;
  firstNames: string;
  lastNames: string;
  mentor: Mentor;
  routeParams: RouteParams;

  constructor(
              public myLogger: MyLogger,
            //  public routeParams: RouteParams,
              public sqlResource: SqlResource,
              public fb: FormBuilder) {
    myLogger.log('hi from profile.component constructor');
    this.statuses = [
      { statusId: '1024', label: 'None' },
      { statusId: '1025', label: 'Basic' },
      { statusId: '1026', label: 'Intermediate' },
      { statusId: '1027', label: 'Advanced' },
      { statusId: '1028', label: 'Native' },
    ];

    this.profileForm = fb.group({
      inputMentorFName: ['', Validators.required],
      // // above equivalent     to
      // this.profileForm = new ControlGroup({
      //   inputMentorFName: new Control(['inputMentorFName',Validators.required],
      inputMentorLName: ['',Validators.required],
      inputMentorPhone: ['',Validators.required],
      inputMonthsinSma: ['',Validators.required],
      SpanishLevelSelector: ['',Validators.required],
      EnglishLevelSelector: ['',Validators.required],
    });
    this.mentor = new Mentor();
  }
 ngOnInit() {
        this.myLogger.log('ngOnInit');
        let mentorId: number  = Number(this.routeParams.get('mentorId'));
        this.myLogger.log('param as Number: ' + mentorId);
        this.sqlResource.getMentor(mentorId)
          .subscribe(
            data => {this.mentor = data;},
            err => console.error('Subscribe error: ' + err),
            () => console.log('done with data: ' + this.mentor.lastNames)
          );
  }

  saveProfile(): any {
    this.myLogger.log('saving ');
      //this.submitted = true;
        this.sqlResource.postMentor(this.mentor);
  }

}
