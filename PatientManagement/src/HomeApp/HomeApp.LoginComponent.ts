import { Component } from '@angular/core';
import { MySecurity } from '../Security/Security.MySecurity'
import {Router} from "@angular/router"
import {HttpClient,HttpHeaders} from '@angular/common/http'

@Component({
    templateUrl: './HomeApp.Login.html',
})
export class LoginComponent {
    username: string="";
    userpwd: string="";
    
    constructor(public securityObj:MySecurity, private _router: Router, public httpObj:HttpClient){

    }

    Login(){
        const headers = new HttpHeaders().set('Content-Type', 'application/json; charset=utf-8');
        console.log(this.username);
        var observable = this.httpObj.post("https://localhost:44328/api/Security",JSON.stringify(this.username),{headers,responseType: 'text'});
        observable.subscribe(res=>this.Success(res),res=>this.ErrorResult(res));

    }

  Success(res){
    console.log(res);
    this.securityObj.token=res;
    this._router.navigate(['/Master']);
  }
  ErrorResult(res){
    console.log(res);
  }


}
