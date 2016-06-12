import {Component} from '@angular/core';
import {RouteConfig, ROUTER_DIRECTIVES} from '@angular/router-deprecated';
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
@RouteConfig([
  {
    path: '/',
    name: 'Home',
    component: HomeComponent
  },
  {
    path: '/profile/:adminId',
    name: 'Profile',
    component: ProfileComponent
  }
])
export class AppComponent {}
