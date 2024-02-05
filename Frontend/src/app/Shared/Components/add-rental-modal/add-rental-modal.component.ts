import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import {MatDialogModule, MatDialogRef} from '@angular/material/dialog';
import { MatLabel } from '@angular/material/form-field';
import { MatOption } from '@angular/material/core';
import {MatFormField} from '@angular/material/form-field';
import {MatDatepickerControl, MatDatepickerModule, MatDatepickerPanel} from '@angular/material/datepicker';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { RentalService } from '../../Core/Services/rental/rental.service';

@Component({
  selector: 'app-add-rental-modal',
  templateUrl: './add-rental-modal.component.html',
  styleUrl: './add-rental-modal.component.scss'
})
export class AddRentalModalComponent {
  form = new FormGroup({});
  model = { };
  fields: FormlyFieldConfig[] = [];


  constructor(public dialogRef: MatDialogRef<AddRentalModalComponent>, private _rentalService:RentalService) {}

  loadFormFields() {
    // Assuming getCars and getClients are methods that fetch the data
    // const carOptions = this.getCars().map(car => ({ label: `${car.make} ${car.model}`, value: car.id }));
    // const clientOptions = this.getClients().map(client => ({ label: `${client.firstName} ${client.lastName}`, value: client.id }));

    this.fields = [
      {
        key: 'carId',
        type: 'select',
        props: {
          label: 'Select Car',
          placeholder: 'Select a car',
          required: true,
          //options: carOptions,
        },
      },
      {
        key: 'clientId',
        type: 'select',
        props: {
          label: 'Select Client',
          placeholder: 'Select a client',
          required: true,
          //options: clientOptions,
        },
      },
      {
        key: 'startDate',
        type: 'datepicker',
        props: {
          label: 'Start Date',
          placeholder: 'Select start date',
          required: true,
        },
      },
      {
        key: 'endDate',
        type: 'datepicker',
        props: {
          label: 'End Date',
          placeholder: 'Select end date',
          required: true,
        },
      },
    ];
  }

  onSubmit(model: any): void {
      this._rentalService.createRental(model);
      this.close();
  }

  close(): void {
    this.dialogRef.close();
  }
}
