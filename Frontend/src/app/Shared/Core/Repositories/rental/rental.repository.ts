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
    return this._httpClient.get<Rental[]>('https://localhost:44338/api/client');
  }

  public createRental(rental: any): Observable<Rental> {
    return this._httpClient.post<Rental>('https://localhost:44338/api/client', rental,
      { headers: { 'Content-Type': 'application/json' } });
  }
}
