import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import {MatDialogModule, MatDialogRef} from '@angular/material/dialog';
import { MatLabel } from '@angular/material/form-field';
import { MatOption } from '@angular/material/core';
import {MatFormField} from '@angular/material/form-field';
import {MatDatepickerControl, MatDatepickerModule, MatDatepickerPanel} from '@angular/material/datepicker';

@Component({
  selector: 'app-add-rental-modal',
  templateUrl: './add-rental-modal.component.html',
  styleUrl: './add-rental-modal.component.scss'
})
export class AddRentalModalComponent implements OnInit {
  public entryForm!: FormGroup;
  public carOptions!: string[];
  public clientOptions!: string[];
  public startDate!: MatDatepickerPanel<MatDatepickerControl<any>,any,any>;
  public endDate!: MatDatepickerPanel<MatDatepickerControl<any>,any,any>;

  constructor(
    private dialogRef: MatDialogRef<AddRentalModalComponent>,
    private formBuilder: FormBuilder
  ) { }

  ngOnInit(): void {
    this.entryForm = this.formBuilder.group({
      carOptions: ['', Validators.required],
      clientOptions: ['', Validators.required],
      startDate: ['', Validators.required],
      endDate: ['', Validators.required],
    });
  }

  get fc() {
    return this.entryForm.controls;
  }

  submit(): void {
    if (this.entryForm?.valid) {
      // You can handle form submission here
      console.log('Form submitted:', this.entryForm.value);
      this.close();
    }
  }

  close(): void {
    this.dialogRef.close();
  }
}
