import { Injectable } from '@angular/core'; 
import { Observable } from 'rxjs';
import { HttpInterceptor, HttpHandler, HttpRequest, HttpEvent, HttpResponse } from '@angular/common/http';
import { MySecurity } from './Security.MySecurity'


@Injectable()
export class MyInterceptor implements HttpInterceptor {
   constructor(private _mysecurity:MySecurity){} 
  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {

    req = req.clone({

        setHeaders:{
            Authorization : `Bearer ${this._mysecurity.token}`
        }
    });
    return next.handle(req);


  }

}
