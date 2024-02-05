import { Component } from '@angular/core';
import { CarService } from '../../Shared/Core/Services/car/car.service';
import { ClientService } from '../../Shared/Core/Services/client/client.service';
import { RentalService } from '../../Shared/Core/Services/rental/rental.service';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.scss'
})
export class HomePageComponent {
  public carColumns: string[] = ['Colour', 'Make', 'Model', 'Registration', 'DailyRate', 'Rented Out'];
  public rentalColumns: string[] = ['Car Registration', 'Client Name', 'Start Date', 'End Date'];
  public clientColumns: string[] = ['Name', 'Phone', 'Email', 'Address', 'LicenseNumber'];

  public dataSource: any = [];
  public displayedColumns: string[] = [];

  constructor(private _carService:CarService, private _clientService:ClientService, private _rentalService:RentalService) { }

  ngOnInit(): void {
    // this.dataSource = this._carService.getAllCars();
    // this.displayedColumns = this.carColumns;
  }

  public showCars(): void {
    this.dataSource = this._carService.getAllCars();
    this.displayedColumns = this.carColumns;
  }

  public showRentals(): void {
    this.dataSource = this._rentalService.getAllRentals();
    this.displayedColumns = this.rentalColumns;
  }

  public showClients(): void {
    this.dataSource = this._clientService.getAllClients();
    this.displayedColumns = this.clientColumns;
  }
}
