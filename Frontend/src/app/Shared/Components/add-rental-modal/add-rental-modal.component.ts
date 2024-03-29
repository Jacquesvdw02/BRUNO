import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogModule, MatDialogRef } from '@angular/material/dialog';
import { MatLabel } from '@angular/material/form-field';
import { MatOption } from '@angular/material/core';
import { MatFormField } from '@angular/material/form-field';
import {
  MatDatepickerControl,
  MatDatepickerModule,
  MatDatepickerPanel,
} from '@angular/material/datepicker';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { RentalService } from '../../Core/Services/rental/rental.service';
import { CarService } from '../../Core/Services/car/car.service';
import { ClientService } from '../../Core/Services/client/client.service';
import { map } from 'rxjs';
import { DataService } from '../../Core/Services/data.service';

@Component({
  selector: 'app-add-rental-modal',
  templateUrl: './add-rental-modal.component.html',
  styleUrl: './add-rental-modal.component.scss',
})
export class AddRentalModalComponent {
  form = new FormGroup({});
  model = {};

  constructor(
    public dialogRef: MatDialogRef<AddRentalModalComponent>,
    private _rentalService: RentalService,
    private _carService: CarService,
    private _clientService: ClientService,
    private _dataService: DataService
  ) {}

  private carOptions = this._carService
    .getAllCars()
    .pipe(
      map((cars) =>
        cars.map((car) => ({ label: car.registration, value: car.id }))
      )
    );
  private clientOptions = this._clientService
    .getAllClients()
    .pipe(
      map((clients) =>
        clients.map((client) => ({
          label: client.firstName + ' ' + client.lastName,
          value: client.id,
        }))
      )
    );
  fields: FormlyFieldConfig[] = [
    {
      key: 'carId',
      type: 'select',
      props: {
        label: 'Select Car',
        placeholder: 'Select a car',
        required: true,
        options: this.carOptions,
      },
    },
    {
      key: 'clientId',
      type: 'select',
      props: {
        label: 'Select Client',
        placeholder: 'Select a client',
        required: true,
        options: this.clientOptions,
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

  onSubmit(model: any): void {
    this._rentalService.createRental(model).subscribe(
      (res) => {
        console.log(res);
        this._dataService.updateDataForRentals();
      }
    );
    this.close();
  }

  close(): void {
    this.dialogRef.close();
  }
}
