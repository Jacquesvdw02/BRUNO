import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import {MatDialogModule, MatDialogRef} from '@angular/material/dialog';
import {MatFormField} from '@angular/material/form-field';
import { MatError } from '@angular/material/form-field';

@Component({
  selector: 'app-add-car-modal',
  templateUrl: './add-car-modal.component.html',
  styleUrl: './add-car-modal.component.scss'
})
export class AddCarModalComponent implements OnInit {
  entryForm!: FormGroup;
  isSubmitted = false;

  constructor(
    private dialogRef: MatDialogRef<AddCarModalComponent>,
    private formBuilder: FormBuilder
  ) { }

  ngOnInit(): void {
    this.entryForm = this.formBuilder.group({
      registration: ['', Validators.required],
      make: ['', Validators.required],
      model: ['', Validators.required],
      year: ['', Validators.required],
      color: ['', Validators.required],
      dailyRate: ['', Validators.required],
      mileage: ['', Validators.required],
      fuelType: ['', Validators.required],
      transmission: ['', Validators.required],
      engineSize: ['', Validators.required],
      bodyStyle: ['', Validators.required],
      driveTrain: ['', Validators.required],
      datePurchased: ['', Validators.required],
      serviceMileage: ['', Validators.required],
    });
  }

  get fc() {
    return this.entryForm.controls;
  }

  submit(): void {
    this.isSubmitted = true;
    if (this.entryForm?.valid) {
      // You can handle form submission here
      console.log('Form submitted:', this.entryForm.value);
      this.close();
      this.entryForm.reset();
    }
  }

  close(): void {
    this.dialogRef.close();
  }
}
