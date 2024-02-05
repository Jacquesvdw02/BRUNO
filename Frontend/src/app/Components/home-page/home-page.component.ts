import { Component } from '@angular/core';
import { CarService } from '../../Shared/Core/Services/car/car.service';
import { ClientService } from '../../Shared/Core/Services/client/client.service';
import { RentalService } from '../../Shared/Core/Services/rental/rental.service';
import { MatDialog } from '@angular/material/dialog';
import { AddClientModalComponent } from '../../Shared/Components/addClient/add-client-modal.component';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.scss'
})
export class HomePageComponent {
  public carColumns: string[] = ['Colour', 'Make', 'Model', 'Registration', 'Daily Rate', 'Rented Out', 'Mileage', 'Service Mileage'];
  public rentalColumns: string[] = ['Car Registration', 'Client Name', 'Start Date', 'End Date'];
  public clientColumns: string[] = ['Name', 'Phone', 'Email', 'Address', 'LicenseNumber'];

  public dataSource: any = [];
  public displayedColumns: string[] = [];

  public activeTab: string = 'cars';

  constructor(private dialog: MatDialog, private _carService:CarService, private _clientService:ClientService, private _rentalService:RentalService) { }

  public showCars(): void {
    this.dataSource = this._carService.getAllCars();
    this.displayedColumns = this.carColumns;
    this.activeTab = 'cars';
    console.log(this.dataSource);
  }

  public showRentals(): void {
    this.dataSource = this._rentalService.getAllRentals();
    this.displayedColumns = this.rentalColumns;
    this.activeTab = 'rentals';
  }

  public showClients(): void {
    this.dataSource = this._clientService.getAllClients();
    this.displayedColumns = this.clientColumns;
    this.activeTab = 'clients';
  }

  openAddClientModal(): void {
    this.dialog.open(AddClientModalComponent, {
      width: '300px'
    });
  }

  ngOnInit(): void {
    this.dataSource = this._carService.getAllCars();
    this.displayedColumns = this.carColumns;
  }
}