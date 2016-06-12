import {Injectable, Provider, provide} from '@angular/core';
import {Http, Headers, RequestOptions, Response} from '@angular/http';
import {Observable} from 'rxjs/Rx';
import {Admin} from '../admin';

@Injectable()
export class SqlResource {

  constructor(private http: Http) {}


  public getAdmin(adminId: Number): Observable<Admin> {
    let url: string = 'http://localhost:57378/api/v1/admins/' + adminId;
    return this.http.get(url)
      .map((response:Response) => response.json())
      .catch(this.handleError);
      // .subscribe(
      //     data => {mentor = data;},
      //     err => console.error(err),
      //     () => console.log('done')
      //);


  }

  public postAdmin(admin: Admin):void {

    let url: string = '/api/v1/admins/';

    let body = JSON.stringify({ admin });
    // strip outer 'admin' name
    let x = JSON.parse(body);
    body = JSON.stringify(x.admin);
    let headers = new Headers({ 'Content-Type': 'application/json' });
    let options = new RequestOptions({ headers: headers });

    this.http.post(
      url,
      body,
      options
      )
      .subscribe((res: Response) => {res.json();});
  }

  private handleError (error: any) {
    let errMsg = (error.message) ? error.message :
      error.status ? `${error.status} - ${error.statusText}` : 'Server error';
    console.error(errMsg); // log to console instead
    return Observable.throw(errMsg);
  }

}


export var SQL_RESOURCE_PROVIDERS:Provider[] = [
      provide(SqlResource, {useClass: SqlResource}),
    ];



