import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Car } from '../../Interfaces/Car.interface'; // Adjust the import path as necessary

@Injectable({
  providedIn: 'root'
})
export class CarRepository {
  private received = false;

  constructor(private _httpClient: HttpClient) { }

  public getAllCars(): Observable<Car[]> {
    this.received = false;
    return this._httpClient.get<Car[]>('https://localhost:44338/api/car');
  }

  // public getCarByRegistration(registration: string) {
  //   return this._httpClient.get(`https://localhost:5001/api/car/${registration}`);
  // }

  public createCar(car: any) {
    if (!this.received) {
      this.received = true;
      return this._httpClient.post<Car>('https://localhost:44338/api/car', car);
    }
    else {
      return new Observable<Car>();
    }
  }

  // public updateCar(registration: string, car: any) {
  //   return this._httpClient.put(`https://localhost:5001/api/car/${registration}`, car);
  // }

  // public getCarByClient(clientId: number) {
  //   return this._httpClient.get(`https://localhost:5001/api/car/client/${clientId}`);
  // }
}
