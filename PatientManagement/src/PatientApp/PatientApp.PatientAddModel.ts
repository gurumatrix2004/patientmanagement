import { NgForm,FormGroup,FormControl, FormBuilder, Validators } from "@angular/forms";
export class Patient{

    formgroup:FormGroup = null;
    name:string = "";
    address:string = "";
    //email:string = "";
    lstproblems:Array<PatientProblem> = new Array<PatientProblem>();
    constructor(){
        var _builder = new FormBuilder();
        this.formgroup = _builder.group({});
        this.formgroup.addControl("PatientNameControl",new FormControl('', Validators.required));
        //var validationcollection = [];
        //validationcollection.push(Validators.required);
        //validationcollection.push(Validators.pattern("^[a-z]{1,10}@[a-z]{1,10}.[a-z]{1,10}$"));
        //this.formgroup.addControl("EmailControl",new FormControl('', Validators.compose(validationcollection)));
        //this.name="Shiv";
        //this.address="Mulund"
    }

}

export class PatientProblem{

    problem:string="";
    treatments:Array<Treatment> = new Array<Treatment>();
}

export class Treatment{

    treatmentName:string="";
    treatmentDose:string="";
}