import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RegionComponent } from './region/region.component';
import { BankComponent } from './bank/bank.component';
import { DonorComponent } from './donor/donor.component';
import { RegionFormComponent } from './region/region-form/region-form.component';

const routes: Routes = [
  {path: 'regions', component: RegionComponent},
  {path: 'banks', component: BankComponent},
  {path: 'donors', component: DonorComponent},
  {path: 'region-form/:id', component: RegionFormComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
