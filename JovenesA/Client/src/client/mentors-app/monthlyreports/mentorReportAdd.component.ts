import {Component, OnInit} from '@angular/core';
import {CORE_DIRECTIVES, FORM_DIRECTIVES} from '@angular/common';
import {RouteParams} from '@angular/router-deprecated';
import {SqlResource} from '../shared/services/sql-resource';
import {TruncatePipe} from '../shared/components/truncate-pipe';
import {MyLogger} from '../shared/services/my-logger';
import {MentorReport} from '../shared/mentor-report';

@Component({
  moduleId: module.id,
  //selector: 'sd-monthly-report',
  pipes: [TruncatePipe],
  templateUrl: './monthlyReports.component.html',
  styleUrls: ['./monthlyReports.component.css'],
  directives: [FORM_DIRECTIVES, CORE_DIRECTIVES]
})

export class MonthlyReportAddComponent implements OnInit {
  data: Object;
  loading: boolean;
  errorMessage: string;
  successMessage: string;
  studentId: number;
  mentorId: number;
  mentorReport: MentorReport;
  smileys: Array<string>;

  constructor(
              public routeParams: RouteParams,
              public myLogger: MyLogger,
              public sqlResource: SqlResource) {
    myLogger.log('Hi from monthlyReportAddComponent');

    //var MentorReportResource = $resource("/api/v1/mentorReports/:mentorId/:studentId");
    this.mentorReport = new MentorReport();
    this.mentorReport.mentorId = 58; //Number(this.routeParams.get('mentorId'));
    this.mentorReport.studentId = 185; //Number(this.routeParams.get('studentId'));
    //this.mentorReport.reportIndex = 0;
    this.mentorReport.reportDateTime = new Date();
    this.mentorReport.lastContactDate = null;
    this.mentorReport.followUpNeeded = '';
    this.mentorReport.recentSuccess = '';
    this.mentorReport.recentSetback = '';


    // this.lastContactDatePickerIsOpen = false;
    // this.lastContactDatePickerOpen = function () {
    //   this.lastContactDatePickerIsOpen = true;
    // };

    // this.submit = function (isValid) {
    //   Log4.trace("Hi from mentor Report Submit with isValid:" + isValid)
    //   //Log4.trace(this.mentorReport);
    //   if (isValid) {
    //     this.mentorReport.$save(function (data) {
    //       toastr.success("Save Successful");
    //       $state.go('mentorReportList', { mentorId: $stateParams.mentorId,  studentId: $stateParams.studentId} );
    //     })
    //   } else {
    //     toastr.error("Please complete each entry. Maximum length is 2000 characters.");
    //   }
    // };

    // this.cancel = function () {
    //   $state.go('mentorReportList', { mentorId: $stateParams.mentorId,  studentId: $stateParams.studentId} );
    // };

  }


 ngOnInit() {
        this.myLogger.log('monthlyReports ngOnInit');
        this.myLogger.log('param as Number: ' + Number(this.routeParams.get('mentorId')));
        this.mentorId = 58; Number(this.routeParams.get('mentorId'));
        this.studentId = 185; //Number(this.routeParams.get('studentId'));
this.myLogger.log('mentorId ' + this.mentorId);
this.myLogger.log('studentId ' + this.studentId);
        this.sqlResource.addMentorReport(this.mentorId, this.studentId)
          .subscribe(
            data => {this.mentorReport = data;},
            err => console.error('Subscribe error: ' + err),
            () => console.log('done: ' + this.mentorReport.reportDateTime)
          );
  }

}
