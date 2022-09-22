import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { CustomerDetailsComponent } from './customer-details/customer-details.component';
import { CustomerDetailFormComponent } from './customer-details/customer-detail-form/customer-detail-form.component';

@NgModule({
  declarations: [
    AppComponent,
    CustomerDetailsComponent,
    CustomerDetailFormComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
