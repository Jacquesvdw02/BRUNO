import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import {MatDialogModule, MatDialogRef} from '@angular/material/dialog';
import {MatFormField} from '@angular/material/form-field';
import { MatError } from '@angular/material/form-field';
import {FormlyFieldConfig} from '@ngx-formly/core';

@Component({
  selector: 'app-add-car-modal',
  templateUrl: './add-car-modal.component.html',
  styleUrl: './add-car-modal.component.scss'
})
export class AddCarModalComponent {
  form = new FormGroup({});
  model = { };
  fields: FormlyFieldConfig[] = [
    {
      key: 'make',
      type: 'input',
      props: {
        label: 'Make',
        placeholder: 'Enter make',
        required: true,
      },
    },
    {
      key: 'model',
      type: 'input',
      props: {
        label: 'Model',
        placeholder: 'Enter model',
        required: true,
      },
    },
    {
      key: 'brand',
      type: 'input',
      props: {
        label: 'Brand',
        placeholder: 'Enter brand',
        required: true,
      },
    },
    {
      key: 'year',
      type: 'input',
      props: {
        label: 'Year',
        placeholder: 'Enter year',
        required: true,
        min: 1900,
        max: new Date().getFullYear(),
      },
    },
    {
      key: 'colour',
      type: 'input',
      props: {
        label: 'Colour',
        placeholder: 'Enter colour',
        required: true,
      },
    },
    {
      key: 'mileage',
      type: 'input',
      props: {
        label: 'Mileage',
        placeholder: 'Enter mileage',
        required: true,
      },
    },
    {
      key: 'dailyRate',
      type: 'input',
      props: {
        label: 'Daily Rate',
        placeholder: 'Enter daily rate',
        required: true,
      },
    },
    {
      key: 'transmission',
      type: 'input',
      props: {
        label: 'Transmission',
        placeholder: 'Enter transmission',
        required: true,
      },
    },
    {
      key: 'fuelType',
      type: 'select',
      props: {
        label: 'Fuel Type',
        placeholder: 'Select fuel type',
        required: true,
        options: [
          { label: 'Petrol', value: 'Petrol' },
          { label: 'Gasoline', value: 'Gasoline' },
          { label: 'Electric', value: 'Electric' },
          { label: 'Hybrid', value: 'Hybrid' },
        ],
      },
    },
    {
      key: 'engineSize',
      type: 'input',
      props: {
        label: 'Engine Size',
        placeholder: 'Enter engine size in CC',
        required: true,
      },
    },
    {
      key: 'bodyStyle',
      type: 'input',
      props: {
        label: 'Body Style',
        placeholder: 'Enter body style',
        required: true,
      },
    },
    {
      key: 'driveTrain',
      type: 'input',
      props: {
        label: 'Drive Train',
        placeholder: 'Enter drive train',
        required: true,
      },
    },
    {
      key: 'datePurchased',
      type: 'datepicker',
      props: {
        label: 'Date Purchased',
        placeholder: 'Select date',
        required: true,
      },
    },
    {
      key: 'registration',
      type: 'input',
      props: {
        label: 'Registration',
        placeholder: 'Enter registration',
        required: true,
      },
    },
    {
      key: 'rentedOut',
      type: 'checkbox',
      props: {
        label: 'Rented Out',
      },
    },
    {
      key: 'serviceMileage',
      type: 'input',
      props: {
        label: 'Service Mileage',
        placeholder: 'Enter service mileage',
        required: true,
      },
    },
  ];

  constructor(public dialogRef: MatDialogRef<AddCarModalComponent>) {}

  onSubmit(model: any): void {
      console.log('Form submitted:', model);
      this.close();
  }

  close(): void {
    this.dialogRef.close();
  }
}
