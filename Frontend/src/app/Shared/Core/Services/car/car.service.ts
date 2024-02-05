import { Injectable } from '@angular/core';
import { Car } from '../../Interfaces/car.interface';
import { CarRepository } from '../../Repositories/car/car.repository';

@Injectable({
  providedIn: 'root'
})
export class CarService {
  public cars: Car[] = [];

  constructor(private _carRepository: CarRepository) { }

  public getAllCars(): Car[] {
    this._carRepository.getAllCars().subscribe((data: any) => {
      this.cars = data;
    });
    return this.cars;
  }

  // public getCarByRegistration(registration: string): Car {
  //   let car: Car = {} as Car;
  //   this._carRepository.getCarByRegistration(registration).subscribe((data: any) => {
  //     car = data;
  //   });
  //   return car;
  // }

  // public createCar(car: Car): void {
  //   this._carRepository.createCar(car).subscribe();
  // }

  // public updateCar(registration: string, car: Car): void {
  //   this._carRepository.updateCar(registration, car).subscribe();
  // }

  // public getCarsByClient(clientId: number): Car[] {
  //   this._carRepository.getCarByClient(clientId).subscribe((data: any) => {
  //     this.cars = data;
  //   });
  //   return this.cars;
  // }
}
