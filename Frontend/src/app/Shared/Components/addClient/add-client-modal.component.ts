import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import {MatDialogModule, MatDialogRef} from '@angular/material/dialog';
import {MatFormField} from '@angular/material/form-field';

@Component({
  selector: 'app-add-client-modal',
  templateUrl: './add-client-modal.component.html',
  styleUrl: './add-client-modal.component.scss'
})
export class AddClientModalComponent {
  entryForm!: FormGroup;

  constructor(
    private dialogRef: MatDialogRef<AddClientModalComponent>,
    private formBuilder: FormBuilder
  ) { }

  ngOnInit(): void {
    this.entryForm = this.formBuilder.group({
      title: ['', Validators.required],
      description: ['', Validators.required]
    });
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

