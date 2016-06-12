import {Component} from '@angular/core';
import {ROUTER_DIRECTIVES, Routes} from '@angular/router';
import {MyLogger} from './shared/services/my-logger';


// import { AboutComponent } from './+about/index';
import { HomeComponent } from './+home/index';
import {ProfileComponent} from './profile/index';
import {MonthlyReportsComponent} from './monthlyreports/index';
import { NameListService, NavbarComponent } from './shared/index';

@Component({
  moduleId: module.id,
  selector: 'sd-app',
  viewProviders: [NameListService],
  templateUrl: './app.component.html',
  directives: [ROUTER_DIRECTIVES, NavbarComponent]
})
@Routes([
  {
    path: '/',
    //name: 'Home',
    component: HomeComponent
  }
  ,
  {
    path: '/profile/:mentorId',
    //name: 'Profile',
    component: ProfileComponent
  },
  {
    path: '/monthly-reports/:mentorId',
    //name: 'MonthlyReports',
    component: MonthlyReportsComponent
  }
])
export class AppComponent {
  constructor(public myLogger: MyLogger ) {
    myLogger.log('mentors-app AppComponent constructor');
  }

}
