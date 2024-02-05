import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import {MatDialogModule, MatDialogRef} from '@angular/material/dialog';
import {MatFormField} from '@angular/material/form-field';
import {FormlyFieldConfig} from '@ngx-formly/core';

@Component({
  selector: 'app-add-client-modal',
  templateUrl: './add-client-modal.component.html',
  styleUrl: './add-client-modal.component.scss'
})
export class AddClientModalComponent {
  form = new FormGroup({});
  model = { };
  fields: FormlyFieldConfig[] = [
    {
      key: 'firstName',
      type: 'input',
      props: {
        label: 'First Name',
        placeholder: 'Enter first name',
        required: true,
      },
    },
    {
      key: 'lastName',
      type: 'input',
      props: {
        label: 'Last Name',
        placeholder: 'Enter last name',
        required: true,
      },
    },
    {
      key: 'phone',
      type: 'input',
      props: {
        label: 'Phone Number',
        placeholder: 'Enter phone number',
        required: true,
        pattern: /^\d{10}$/,
      },
    },
    {
      key: 'email',
      type: 'input',
      props: {
        label: 'Email Address',
        placeholder: 'Enter email',
        required: true,
        pattern: /^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$/,
      },
    },
    {
      key: 'address',
      type: 'input',
      props: {
        label: 'Address',
        placeholder: 'Enter address',
        required: true,
      },
    },
    {
      key: 'city',
      type: 'input',
      props: {
        label: 'City',
        placeholder: 'Enter city',
        required: true,
      },
    },
    {
      key: 'province',
      type: 'input',
      props: {
        label: 'Province',
        placeholder: 'Enter province',
        required: true,
      },
    },
    {
      key: 'postalCode',
      type: 'input',
      props: {
        label: 'Postal Code',
        placeholder: 'Enter postal code',
        required: true,
        pattern: /^[0-9A-Za-z]{4,10}$/,
      },
    },
    {
      key: 'dateJoined',
      type: 'input',
      props: {
        label: 'Date Joined',
        placeholder: 'Select date',
        required: true,
      },
    },
    {
      key: 'licenseNumber',
      type: 'input',
      props: {
        label: 'License Number',
        placeholder: 'Enter license number',
        required: true,
      },
    }
  ];

  constructor(public dialogRef: MatDialogRef<AddClientModalComponent>) {}

  onSubmit(model: any): void {
      console.log('Form submitted:', model);
      this.close();
  }

  close(): void {
    this.dialogRef.close();
  }
}

