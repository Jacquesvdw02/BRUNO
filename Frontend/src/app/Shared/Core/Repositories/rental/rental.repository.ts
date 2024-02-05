import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Rental } from '../../Interfaces/Rental.interface';

@Injectable({
  providedIn: 'root'
})
export class RentalRepository {

  constructor(private _httpClient: HttpClient) { }

  public getAllRentals(): Observable<Rental[]> {
    return this._httpClient.get<Rental[]>('https://localhost:44338/api/rental');
  }

  public createRental(rental: any): Observable<Rental> {
    
    // format startDate and endDate to be yyyy-mm-dd
    rental.startDate = rental.startDate.toISOString().split('T')[0];
    rental.endDate = rental.endDate.toISOString().split('T')[0];

    console.log(rental);
    return this._httpClient.post<any>('https://localhost:44338/api/rental', rental,
      { headers: { 'Content-Type': 'application/json' } });
  }
}
