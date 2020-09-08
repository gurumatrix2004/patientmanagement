import {HomeComponent} from './HomeApp.HomeComponent'
import {MasterHomeComponent} from './HomeApp.MasterHomeComponent'
//import {IndexComponent} from './HomeApp.IndexComponent'
import {MyAuthServiceGuard} from '../Security/Security.AuthGuard'
import { LoginComponent } from './HomeApp.LoginComponent'
export const HomeRoutes = [
    { path: '', component: MasterHomeComponent, canActivate:[MyAuthServiceGuard]},
    { path: 'Master', component: MasterHomeComponent, canActivate:[MyAuthServiceGuard]},
    { path: 'Login', component: LoginComponent},
    { path: 'Home', component: HomeComponent, canActivate:[MyAuthServiceGuard] },
    { path: 'Patient', loadChildren: () => import('../PatientApp/PatientApp.PatientAddModule').then(m => m.PatientAddModule),canActivate:[MyAuthServiceGuard] }
]
