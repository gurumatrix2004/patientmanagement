import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { PatientAddComponent } from './PatientApp.PatientAddComponent';
import {HttpClientModule} from '@angular/common/http'
import {RouterModule} from "@angular/router"
import {PatientRoutes} from "./PatientApp.Routing";
import { CommonModule } from "@angular/common";
import {MatTableModule} from '@angular/material/table';
import {MatInputModule} from '@angular/material/input';
import {MatPaginatorModule} from '@angular/material/paginator';
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner';
import {MatSortModule} from '@angular/material/sort';
//import {MyInterceptor} from "../Security/Security.Interceptor"


  
@NgModule({
  declarations: [
    PatientAddComponent
  ],
  imports: [
    CommonModule,FormsModule,ReactiveFormsModule,MatTableModule,MatInputModule,MatPaginatorModule,MatProgressSpinnerModule,MatSortModule,HttpClientModule,RouterModule.forChild(PatientRoutes)
    
  ],
  providers: [],
  bootstrap: [PatientAddComponent]
})
export class PatientAddModule { }
