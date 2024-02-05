import { Injectable } from '@angular/core';
import { Rental } from '../../Interfaces/Rental.interface';
import { RentalRepository } from '../../Repositories/rental/rental.repository';
import { CarService } from '../car/car.service';
import { ClientService } from '../client/client.service';
import { Car } from '../../Interfaces/Car.interface';
import { Client } from '../../Interfaces/Client.interface';
import { Observable, forkJoin, map } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class RentalService {
  public rentals: Rental[] = [];

  constructor(
    private _rentalRepository: RentalRepository,
    private _carService: CarService,
    private _clientService: ClientService
  ) {}

  public getAllRentals() {
    let rentalObservable$ = this._rentalRepository.getAllRentals();
    let carObservable$ = this._carService.getAllCars();
    let clientObservable$ = this._clientService.getAllClients();

    return forkJoin([rentalObservable$, carObservable$, clientObservable$]).pipe(
      map(([rentals, cars, clients]) => {
        return rentals.map((rental) => {
          let car = cars.find((car) => car.id === rental.carId);
          let client = clients.find((client) => client.id === rental.clientId);
          return {
            carRegistration: car?.registration,
            client: client?.firstName + ' ' + client?.lastName,
            startDate: rental.startDate,
            endDate: rental.endDate,
          };
        });
      })
    );
  }

  public createRental(rental: any) {
    let clientObservable$ = this._clientService.getAllClients();
    let carObservable$ = this._carService.getAllCars();

    forkJoin([clientObservable$, carObservable$]).subscribe(
      ([clients, cars]) => {
        let foundClient = clients.find(
          (client: Client) => client.id === rental.clientId
        );
        let foundCar = cars.find((car: Car) => car.id === rental.carId);

        // Create the rental object
        let newRental: any = {
          carId: foundCar!.id,
          clientId: foundClient!.id,
          startDate: rental.startDate,
          endDate: rental.endDate,
          car: foundCar,
          client: foundClient,
        };

        this._rentalRepository.createRental(newRental).subscribe(
          (response) => {
            console.log(response);
          }
        );
      }
    );
  }
}
