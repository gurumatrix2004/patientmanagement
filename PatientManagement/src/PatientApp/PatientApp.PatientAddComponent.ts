import { Component } from '@angular/core';
import { Patient,PatientProblem,Treatment} from './PatientApp.PatientAddModel';
import {HttpClient} from '@angular/common/http'
import {distinct} from 'rxjs/operators'
import { MatTableDataSource } from "@angular/material/table";

@Component({
  templateUrl: './PatientApp.PatientAdd.html',
  styleUrls: ['./PatientApp.PatientAddStyle.css']
})
export class PatientAddComponent {

  displayedColumns: string[] = ['name','address','lstproblems'];
  displayedColumns2=['problem','treatments'];
  displayedColumns3=['treatmentName','treatmentDose'];
  
  title = 'PatientManagement';
  dataSourceone= null;dataSourcetwo= null;dataSourcethree= null;
  patientObj:Patient = new Patient();
  patientObjs:Array<Patient> = new Array<Patient>();


  patientProbnlemObj:PatientProblem = new PatientProblem();
  patientProblemObjs:Array<PatientProblem> = new Array<PatientProblem>();
  patientTreatment:Treatment = new Treatment();


  constructor(public httpObj:HttpClient){ 
    
  }
  
  getSourceTwo(data){
    const ELEMENT_DATA: PatientProblem[] =data;
    this.dataSourcetwo= new MatTableDataSource<PatientProblem>(ELEMENT_DATA);
    return this.dataSourcetwo;
  }

  getSourceThree(data){
    const ELEMENT_DATA: Treatment[] =data;
    this.dataSourcethree= new MatTableDataSource<Treatment>(ELEMENT_DATA);
    return this.dataSourcethree;
  }
  
  AddTreatmentInMemory(){
    this.patientProbnlemObj.treatments.push(this.patientTreatment);
    this.patientTreatment = new Treatment();
  }
  AddProblemInMemory(){
    this.patientObj.lstproblems.push(this.patientProbnlemObj);
    this.patientProbnlemObj = new PatientProblem();
  }
  AddInMemory(){
    this.patientObjs.push(this.patientObj);
    this.patientObj = new Patient();
    console.log(this.patientObjs);
    const ELEMENT_DATA: Patient[] =this.patientObjs;
    this.dataSourceone= new MatTableDataSource<Patient>(ELEMENT_DATA);
  }

  AddAll(){
    console.log(this.patientObjs);
    var observable = this.httpObj.post("https://localhost:44328/api/PatientApi",this.patientObjs);
    observable.pipe(distinct((p: Patient) => p.name));
    observable.subscribe(res=>this.Success(res),res=>this.ErrorResult(res));

  }
  Success(res){
    this.patientObjs = res;
  }
  ErrorResult(res){

  }


}
