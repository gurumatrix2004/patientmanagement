import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http'
import {RouterModule} from "@angular/router"

import {MySecurity} from '../Security/Security.MySecurity'
import {MyAuthServiceGuard} from '../Security/Security.AuthGuard'
import {HomeRoutes} from "./HomeApp.Routing";
import {LoginComponent} from './HomeApp.LoginComponent'
import {IndexComponent} from './HomeApp.IndexComponent'
import {MasterHomeComponent} from './HomeApp.MasterHomeComponent'
import { HomeComponent } from "./HomeApp.HomeComponent";
import {MyInterceptor} from "../Security/Security.Interceptor";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations'

@NgModule({
  declarations: [
    HomeComponent,MasterHomeComponent,IndexComponent,LoginComponent
  ],
  imports: [
    BrowserModule,FormsModule,HttpClientModule,RouterModule.forRoot(HomeRoutes), BrowserAnimationsModule
    
  ],
  providers: [MySecurity,MyAuthServiceGuard,
    { provide: HTTP_INTERCEPTORS, 
      useClass: MyInterceptor , multi:true  }
  
  ],
  bootstrap: [IndexComponent]
})
export class HomeModule { }
