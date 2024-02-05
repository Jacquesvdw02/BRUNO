import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CarRepository {

  constructor(private _httpClient: HttpClient) { }

  public getAllCars() {
    // return this._httpClient.get('https://localhost:5001/api/car');

    // hard coded data
    const data = [
      {
        "Colour": "Black",
        "Make": "Toyota",
        "Model": "Corolla",
        "Registration": "ABC123",
        "DailyRate": 100,
        "RentedOut": false
      },
      {
        "Colour": "White",
        "Make": "Toyota",
        "Model": "Corolla",
        "Registration": "DEF456",
        "DailyRate": 100,
        "RentedOut": false
      },
      {
        "Colour": "Red",
        "Make": "Toyota",
        "Model": "Corolla",
        "Registration": "GHI789",
        "DailyRate": 100,
        "RentedOut": false
      }
    ];

    // return an observable
    return new Observable((observer) => {
      observer.next(data);
      observer.complete();
    });
  }

  // public getCarByRegistration(registration: string) {
  //   return this._httpClient.get(`https://localhost:5001/api/car/${registration}`);
  // }

  // public createCar(car: any) {
  //   return this._httpClient.post('https://localhost:5001/api/car', car);
  // }

  // public updateCar(registration: string, car: any) {
  //   return this._httpClient.put(`https://localhost:5001/api/car/${registration}`, car);
  // }

  // public getCarByClient(clientId: number) {
  //   return this._httpClient.get(`https://localhost:5001/api/car/client/${clientId}`);
  // }
}
