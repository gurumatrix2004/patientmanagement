import { Component } from '@angular/core';
import { MySecurity } from '../Security/Security.MySecurity'

@Component({
  templateUrl: './HomeApp.MasterHome.html',

})
export class MasterHomeComponent {
  
  constructor(public securityObj:MySecurity){

  }
}
