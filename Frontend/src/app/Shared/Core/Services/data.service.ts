import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { CarService } from './car/car.service';
import { ClientService } from './client/client.service';
import { RentalService } from './rental/rental.service';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  private dataSourceSubject = new BehaviorSubject<any[]>([]);
  private displayedColumnsSubject = new BehaviorSubject<string[]>([]);

  public carColumns: string[] = ['colour', 'make', 'model', 'registration', 'dailyRate', 'rentedOut', 'mileage', 'serviceMileage', 'year', 'transmission', 'fuelType', 'engineSize', 'bodyStyle', 'driveTrain', 'datePurchased'];
  public rentalColumns: string[] = ['carRegistration', 'client', 'startDate', 'endDate'];
  public clientColumns: string[] = ['firstName', 'lastName', 'phone', 'email', 'address', 'city', 'province', 'postalCode', 'dateJoined', 'licenseNumber'];

  dataSource$ = this.dataSourceSubject.asObservable();
  displayedColumns$ = this.displayedColumnsSubject.asObservable();

  constructor(
    private _carService: CarService,
    private _clientService: ClientService,
    private _rentalService: RentalService
  ) {}

  public updateDataForCars(): void {
    this._carService.getAllCars().subscribe((data: any) => {
      this.dataSourceSubject.next(data);
      this.displayedColumnsSubject.next(this.carColumns);
    });
  }

  public updateDataForRentals(): void {
    this._rentalService.getAllRentals().subscribe((data: any) => {
      this.dataSourceSubject.next(data);
      this.displayedColumnsSubject.next(this.rentalColumns);
    });
  }

  public updateDataForClients(): void {
    this._clientService.getAllClients().subscribe((data: any) => {
      this.dataSourceSubject.next(data);
      this.displayedColumnsSubject.next(this.clientColumns);
    });
  }
}