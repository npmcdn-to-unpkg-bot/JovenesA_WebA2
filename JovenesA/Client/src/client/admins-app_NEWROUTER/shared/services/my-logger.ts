import {Injectable, Provider, provide} from '@angular/core';

@Injectable()
export class MyLogger {

  public log(logMsg:string) {
    console.log(logMsg);
  }
}

export var LOGGER_PROVIDERS:Provider[] = [
      provide(MyLogger, {useClass: MyLogger}),
    ];
