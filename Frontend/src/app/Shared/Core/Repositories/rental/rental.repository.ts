import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RentalRepository {

  constructor(private _httpClient: HttpClient) { }

  public getAllRentals() {
    // return this._httpClient.get('https://localhost:5001/api/rental');

    // hard coded data
    const data = [
      {
        "CarRegistration": "ABC123",
        "CustomerID": 1,
        "RentalDate": "2021-01-01",
        "ReturnDate": "2021-01-02",
        "TotalCost": 100
      },
      {
        "CarRegistration": "DEF456",
        "CustomerID": 2,
        "RentalDate": "2021-01-01",
        "ReturnDate": "2021-01-02",
        "TotalCost": 100
      },
      {
        "CarRegistration": "GHI789",
        "CustomerID": 3,
        "RentalDate": "2021-01-01",
        "ReturnDate": "2021-01-02",
        "TotalCost": 100
      }
    ];

    // return an observable
    return new Observable((observer) => {
      observer.next(data);
      observer.complete();
    });
  }
}
