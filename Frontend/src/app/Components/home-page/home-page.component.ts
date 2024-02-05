import { Component } from '@angular/core';
import { CarService } from '../../Shared/Core/Services/car/car.service';
import { ClientService } from '../../Shared/Core/Services/client/client.service';
import { RentalService } from '../../Shared/Core/Services/rental/rental.service';
import { MatDialog } from '@angular/material/dialog';
import { AddClientModalComponent } from '../../Shared/Components/add-client-modal/add-client-modal.component';
import { Car } from '../../Shared/Core/Interfaces/Car.interface';
import { AddRentalModalComponent } from '../../Shared/Components/add-rental-modal/add-rental-modal.component';
import { AddCarModalComponent } from '../../Shared/Components/add-car-modal/add-car-modal.component';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.scss'
})
export class HomePageComponent {
  public carColumns: string[] = ['colour', 'make', 'model', 'registration', 'dailyRate', 'rentedOut', 'mileage', 'serviceMileage', 'year', 'transmission', 'fuelType', 'engineSize', 'bodyStyle', 'driveTrain', 'datePurchased'];
  public rentalColumns: string[] = ['CarId', 'ClientId', 'startDate', 'endDate'];
  public clientColumns: string[] = ['firstName', 'lastName', 'phone', 'email', 'address', 'city', 'province', 'postalCode', 'dateJoined', 'licenseNumber'];

  public dataSource: any = [];
  public displayedColumns: string[] = [];

  public activeTab: string = 'cars';

  constructor(private dialog: MatDialog, private _carService:CarService, private _clientService:ClientService, private _rentalService:RentalService) { }

  public showCars(): void {
    let observable$ = this._carService.getAllCars();
    observable$.subscribe((data: any) => {
      this.dataSource = data;
    });
    this.displayedColumns = this.carColumns;
    this.activeTab = 'cars';
  }

  public showRentals(): void {
    this.dataSource = this._rentalService.getAllRentals();
    this.displayedColumns = this.rentalColumns;
    this.activeTab = 'rentals';
  }

  public showClients(): void {
    let observable$ = this._clientService.getAllClients();
    observable$.subscribe((data: any) => {
      this.dataSource = data;
    });
    this.displayedColumns = this.clientColumns;
    this.activeTab = 'clients';
    console.log(this.dataSource);
  }

  openAddClientModal(): void {
    this.dialog.open(AddClientModalComponent, {
      width: '450px'
    });
  }

  openAddRentalModal(): void {
    this.dialog.open(AddRentalModalComponent, {
      width: '450px'
    });
  }

  openAddCarModal(): void {
    this.dialog.open(AddCarModalComponent, {
      width: '450px'
    });
  }

  ngOnInit(): void {
    this.dataSource = this._carService.getAllCars();
    this.displayedColumns = this.carColumns;
  }
}