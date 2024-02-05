import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

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

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    TableComponent,
    AddClientModalComponent,
    AddCarModalComponent,
    AddRentalModalComponent
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
    MatError
  ],
  providers: [
    provideAnimationsAsync()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
