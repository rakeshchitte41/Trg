import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GraphicalComponent } from './graphical/graphical.component';
import { GraphicalrouteComponent } from './graphicalroute/graphicalroute.component';
import { RegistrationComponent } from './registration/registration.component';

const routes: Routes = [
  {path:"",component:GraphicalComponent},
  {path:"graphicalroute", component:GraphicalrouteComponent},
  {path:"Registration",component:RegistrationComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
