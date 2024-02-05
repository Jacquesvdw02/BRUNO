import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import {MatDialogModule, MatDialogRef} from '@angular/material/dialog';
import { MatLabel } from '@angular/material/form-field';
import { MatOption } from '@angular/material/core';
import {MatFormField} from '@angular/material/form-field';
import {MatDatepickerControl, MatDatepickerModule, MatDatepickerPanel} from '@angular/material/datepicker';
import { FormlyFieldConfig } from '@ngx-formly/core';

@Component({
  selector: 'app-add-rental-modal',
  templateUrl: './add-rental-modal.component.html',
  styleUrl: './add-rental-modal.component.scss'
})
export class AddRentalModalComponent {
  form = new FormGroup({});
  model = { };
  fields: FormlyFieldConfig[] = [
    {
      key: 'email',
      type: 'input',
      props: {
        label: 'Email address',
        placeholder: 'Enter email',
        required: true,
      }
    }
  ];

  constructor(public dialogRef: MatDialogRef<AddRentalModalComponent>) {}

  onSubmit(model: any): void {
      console.log('Form submitted:', model);
      this.close();
  }

  close(): void {
    this.dialogRef.close();
  }
}
