import {Component, OnInit} from '@angular/core';
import {CORE_DIRECTIVES, FORM_DIRECTIVES} from '@angular/common';
import {RouteParams} from '@angular/router-deprecated';
import {SqlResource} from '../shared/services/sql-resource';
import {TruncatePipe} from '../shared/components/truncate-pipe';
import {MyLogger} from '../shared/services/my-logger';
import {RptMentorReport} from '../shared/mentor-report';

@Component({
  moduleId: module.id,
  //selector: 'sd-monthly-report',
  pipes: [TruncatePipe],
  templateUrl: './monthlyReports.component.html',
  styleUrls: ['./monthlyReports.component.css'],
  directives: [FORM_DIRECTIVES, CORE_DIRECTIVES]
})

export class MonthlyReportsComponent implements OnInit {
  data: Object;
  loading: boolean;
  errorMessage: string;
  successMessage: string;
  studentId: number;
  mentorId: number;
  mentorReports: Array<RptMentorReport>;
  smileys: Array<string>;
  routeParams: RouteParams;
  
  constructor(
              //public routeParams: RouteParams,
              public myLogger: MyLogger,
              public sqlResource: SqlResource) {

    this.myLogger.log('monthlyReports constructor');
    this.smileys = [];
    this.smileys[0] = '/Client/dist/dev/assets/images/frownSmiley.jpg';
    this.smileys[1] = '/Client/dist/dev/assets/images/neutralSmiley.jpg';
    this.smileys[2] = '/Client/dist/dev/assets/images/greenSmiley.jpg';

  }

 ngOnInit() {
        this.myLogger.log('monthlyReports ngOnInit');
        this.myLogger.log('param as Number: ' + Number(this.routeParams.get('mentorId')));
        this.mentorId = 58; Number(this.routeParams.get('mentorId'));
        this.studentId = 185; //Number(this.routeParams.get('studentId'));
this.myLogger.log('mentorId ' + this.mentorId);
this.myLogger.log('studentId ' + this.studentId);
        this.sqlResource.getMentorReports(this.mentorId, this.studentId)
          .subscribe(
            data => {this.mentorReports = data;},
            err => console.error('Subscribe error: ' + err),
            () => console.log('done: ' + this.mentorReports[0].reportDateTime)
          );
  }

}

