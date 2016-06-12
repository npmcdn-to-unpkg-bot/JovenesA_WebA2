import {Component} from '@angular/core';
import {Routes, ROUTER_DIRECTIVES} from '@angular/router';
import { NameListService, NavbarComponent} from './shared/index';
import { HomeComponent } from './+home/index';
import { ProfileComponent } from './profile/index';

@Component({
  moduleId: module.id,
  selector: 'sd-app',
  viewProviders: [NameListService],
  templateUrl: './app.component.html',
  directives: [ROUTER_DIRECTIVES, NavbarComponent],
})
@Routes([
  {
    path: '/',
    //name: 'Home',
    component: HomeComponent
  },
  {
    path: '/profile/:adminId',
    //name: 'Profile',
    component: ProfileComponent
  }
])
export class AppComponent {}
