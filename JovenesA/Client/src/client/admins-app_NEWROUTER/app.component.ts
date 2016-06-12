import {Component} from '@angular/core';
import {ROUTER_DIRECTIVES, Routes} from '@angular/router';

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
    component: HomeComponent
  },
  {
    path: '/profile',
    component: ProfileComponent
  }
])
export class AppComponent {}
