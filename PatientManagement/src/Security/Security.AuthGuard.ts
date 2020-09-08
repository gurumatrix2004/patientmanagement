import { Injectable } from '@angular/core'; 
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { MySecurity } from './Security.MySecurity'
import { Observable } from 'rxjs';

@Injectable()
export class MyAuthServiceGuard implements CanActivate {  
    
    constructor(public _mytoken: MySecurity, public _router: Router) {}  canActivate(next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean> | Promise<boolean> | boolean {
    if (this._mytoken.token.length != 0) {
       
      return true;
    }

    this._router.navigate(['/Login']);
    return false;


  }}
