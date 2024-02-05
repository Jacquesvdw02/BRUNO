import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, catchError } from 'rxjs';
import { Rental } from '../../Interfaces/Rental.interface';

@Injectable({
  providedIn: 'root'
})
export class RentalRepository {
  private received = false;

  constructor(private _httpClient: HttpClient) { }

  public getAllRentals(): Observable<Rental[]> {
    this.received = false;
    return this._httpClient.get<Rental[]>('https://localhost:44338/api/rental');
  }

  public createRental(rental: any): Observable<Rental> {    
    // format startDate and endDate to be yyyy-mm-dd
    rental.startDate = rental.startDate.toISOString().split('T')[0];
    rental.endDate = rental.endDate.toISOString().split('T')[0];

    if (!this.received) {
      this.received = true;
      return this._httpClient.post<Rental>('https://localhost:44338/api/rental', rental);
    }
    else {
      return new Observable<Rental>();
    }
  }
}
