import {Component, OnInit} from '@angular/core';
import {FormBuilder, Validators, ControlGroup, FORM_DIRECTIVES, FORM_PROVIDERS} from '@angular/common';
import {MyLogger} from '../shared/services/my-logger';
import {SqlResource} from '../shared/services/sql-resource';
import {Admin} from '../shared/admin';
import {ControlErrors} from '../shared/components/control-errors.component';
import { Router, RouteSegment } from '@angular/router';

@Component({
  selector: 'admin-profile',
  templateUrl: './profile.component.html',
  styleUrls:  ['./profile.component.css'],
  directives: [FORM_DIRECTIVES,  ControlErrors],
  providers: [FORM_PROVIDERS]
})
export class ProfileComponent implements OnInit {
  data: Object;
  loading: boolean;
  profileForm: ControlGroup;
  statuses: [{statusId: string, label: string}];
  errorMessage: string;
  successMessage: string;
  firstNames: string;
  lastNames: string;
  admin: Admin;
  private curSegment: RouteSegment;

  constructor(
              public myLogger: MyLogger,
              public sqlResource: SqlResource,
              public fb: FormBuilder,
              private router: Router) {
    myLogger.log('hi from profile.component constructor');
    this.statuses = [
      { statusId: '1024', label: 'None' },
      { statusId: '1025', label: 'Basic' },
      { statusId: '1026', label: 'Intermediate' },
      { statusId: '1027', label: 'Advanced' },
      { statusId: '1028', label: 'Native' },
    ];

    this.profileForm = fb.group({
      inputAdminFName: ['', Validators.required],
      // // above equivalent     to
      // this.profileForm = new ControlGroup({
      //   inputAdminFName: new Control(['inputAdminFName',Validators.required],
      inputAdminLName: ['',Validators.required],
      inputAdminPhone: ['',Validators.required],
      inputMonthsInSMA: ['',Validators.required],
      SpanishLevelSelector: ['',Validators.required],
      EnglishLevelSelector: ['',Validators.required],
    });
    this.admin = new Admin();
  }
 ngOnInit() {
        this.myLogger.log('ngOnInit');
        this.sqlResource.getAdmin(1216)
          .subscribe(
            data => {this.admin = data;},
            err => console.error('Subscribe error: ' + err),
            () => console.log('done')
          );

  }

//   routerOnActivate(curr: RouteSegment) {
//     this.curSegment = curr;

//     //let id = +curr.getParam('id');
//     // this.service.getCrisis(id).then(crisis => {
//     //   if (crisis) {
//     //     this.editName = crisis.name;
//     //     this.crisis = crisis;
//     //   } else { // id not found
//     //     this.gotoCrises();
//     //   }
//     //});
//   }

//   gotoProfile() {
//     //let crisisId = this.crisis ? this.crisis.id : null;
//     // Pass along the hero id if available
//     // so that the CrisisListComponent can select that hero.
//     // Add a totally useless `foo` parameter for kicks.
//     // Absolute link
//     this.router.navigate(['/profile/:adminId', {adminId: 1216}]);

//     // Relative link
//     // this.router.navigate(['../', {id: crisisId, foo: 'foo'}], this.curSegment);
//   }
//   gotoHeroes() {
//     //let heroId = this.hero ? this.hero.id : null;
//     // Pass along the hero id if available
//     // so that the HeroList component can select that hero.
//     // Add a totally useless `foo` parameter for kicks.
//     this.router.navigate(['/profile/:adminId', {adminId: 1216}]);
//     //this.router.navigate([`/heroes`, {id: heroId, foo: 'foo'}]);
//   }

//   saveProfile(): any {
//     this.myLogger.log('saving ');
//       //this.submitted = true;
//         this.sqlResource.postAdmin(this.admin);
//   }

}
