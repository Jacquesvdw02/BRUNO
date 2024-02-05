import { Injectable } from '@angular/core';
import { Rental } from '../../Interfaces/Rental.interface';
import { RentalRepository } from '../../Repositories/rental/rental.repository';
import { CarService } from '../car/car.service';
import { ClientService } from '../client/client.service';
import { Car } from '../../Interfaces/Car.interface';
import { Client } from '../../Interfaces/Client.interface';

@Injectable({
  providedIn: 'root'
})
export class RentalService {
  public rentals: Rental[] = [];

  constructor(private _rentalRepository: RentalRepository, private _carService:CarService, private _clientService:ClientService) { }

  public getAllRentals() {
    let rentals: Rental[] = [];
    let cars: Car[] = [];
    let clients: Client[] = [];

    let rentalObservable$ = this._rentalRepository.getAllRentals();
    rentalObservable$.subscribe((data: any) => {
      this.rentals = data;
    });

    let carObservable$ = this._carService.getAllCars();
    carObservable$.subscribe((data: any) => {
      cars = data;
    });

    let clientObservable$ = this._clientService.getAllClients();
    clientObservable$.subscribe((data: any) => {
      clients = data;
    });

    // Return an object that contains the car registration, client name, and rental start and end dates for each rental
    return rentals.map((rental) => {
      let car = cars.find((car) => car.id === rental.carId);
      let client = clients.find((client) => client.id === rental.clientId);
      return {
        carRegistration: car?.registration,
        clientName: client?.firstName + ' ' + client?.lastName,
        startDate: rental.startDate,
        endDate: rental.endDate
      };
    }
    );
  }
}
