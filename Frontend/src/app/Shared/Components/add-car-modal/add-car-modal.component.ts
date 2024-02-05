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
      key: 'email',
      type: 'input',
      props: {
        label: 'Email address',
        placeholder: 'Enter email',
        required: true,
      }
    }
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
