import {provide, enableProdMode} from '@angular/core';
import {bootstrap} from '@angular/platform-browser-dynamic';
import {ROUTER_PROVIDERS} from '@angular/router';
import {APP_BASE_HREF, LocationStrategy, HashLocationStrategy} from '@angular/common';
import {HTTP_PROVIDERS} from '@angular/http';
import 'rxjs/add/operator/map';

import {AppComponent} from './app.component';
import {LOGGER_PROVIDERS} from './shared/services/my-logger';
import {SQL_RESOURCE_PROVIDERS} from './shared/services/sql-resource';

if ('<%= ENV %>' === 'prod') { enableProdMode(); }

bootstrap(AppComponent, [
  ROUTER_PROVIDERS,
  HTTP_PROVIDERS,
  LOGGER_PROVIDERS,
  SQL_RESOURCE_PROVIDERS,
  provide (LocationStrategy, {useClass: HashLocationStrategy}),
  provide(APP_BASE_HREF, { useValue: '<%= APP_BASE %>' }
  )
]);

// In order to start the Service Worker located at "./worker.js"
// uncomment this line. More about Service Workers here
// https://developer.mozilla.org/en-US/docs/Web/API/Service_Worker_API/Using_Service_Workers
//
// if ('serviceWorker' in navigator) {
//   (<any>navigator).serviceWorker.register('./worker.js').then((registration: any) =>
//       console.log('ServiceWorker registration successful with scope: ', registration.scope))
//     .catch((err: any) =>
//       console.log('ServiceWorker registration failed: ', err));
// }
