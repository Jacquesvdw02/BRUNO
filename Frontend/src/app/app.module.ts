import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomePageComponent } from './Components/home-page/home-page.component';
import { TableComponent } from './Shared/Components/table/table.component';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { MatTableModule } from '@angular/material/table';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatDialogModule } from '@angular/material/dialog';
import { MatFormField } from '@angular/material/form-field';
import { MatOption } from '@angular/material/core';
import { MatLabel } from '@angular/material/form-field';
import {MatDatepickerModule} from '@angular/material/datepicker';
import { HttpClientModule } from '@angular/common/http';
import { AddClientModalComponent } from './Shared/Components/add-client-modal/add-client-modal.component';
import { ReactiveFormsModule } from '@angular/forms';
import { AddCarModalComponent } from './Shared/Components/add-car-modal/add-car-modal.component';
import { AddRentalModalComponent } from './Shared/Components/add-rental-modal/add-rental-modal.component';
import { MatError } from '@angular/material/form-field';
import { FormlyModule } from '@ngx-formly/core';
import { FormlyMaterialModule } from '@ngx-formly/material';
import {FormlyMatDatepickerModule} from '@ngx-formly/material/datepicker';
import { MatNativeDateModule, MAT_DATE_LOCALE, DateAdapter, NativeDateAdapter } from '@angular/material/core';
import { LoginComponent } from './Components/login/login.component';


@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    TableComponent,
    AddClientModalComponent,
    AddCarModalComponent,
    AddRentalModalComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatTableModule,
    MatButtonModule,
    MatIconModule,
    MatDialogModule,
    MatDatepickerModule,
    MatFormField,
    MatOption,
    MatLabel,
    HttpClientModule,
    ReactiveFormsModule,
    MatError,
    FormlyModule.forRoot(),
    FormlyMaterialModule,
    FormlyMatDatepickerModule,
    MatNativeDateModule,
    FormsModule
  ],
  providers: [
    provideAnimationsAsync(),
    { provide: MAT_DATE_LOCALE, useValue: 'en-GB' },
    { provide: DateAdapter, useClass: NativeDateAdapter, deps: [MAT_DATE_LOCALE] }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
