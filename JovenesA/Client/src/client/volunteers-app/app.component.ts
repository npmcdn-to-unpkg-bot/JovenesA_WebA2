import {Component} from '@angular/core';
import {ROUTER_DIRECTIVES, RouteConfig} from '@angular/router-deprecated';

import { NavbarComponent } from './shared/navbar/index';
import { NameListService } from './shared/name-list/index';
import { HomeComponent } from './+home/index';

@Component({
  moduleId: module.id,
  //selector: 'sd-app',
  viewProviders: [NameListService],
  templateUrl: './app.component.html',
  directives: [ROUTER_DIRECTIVES, NavbarComponent]
})
@RouteConfig([
  {
    path: '/',
    //name: 'Home',
    component: HomeComponent
  }
])
export class AppComponent {}
