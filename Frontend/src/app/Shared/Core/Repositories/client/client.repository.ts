import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ClientRepository {

  constructor(private _httpClient: HttpClient) { }

  public getAllClients() {
    // return this._httpClient.get('https://localhost:5001/api/client');

    // hard coded data
    const data = [
      {
        "ID": 1,
        "Name": "John Doe",
        "DateOfBirth": "2000-01-01",
        "Email": "sdf",
        "Phone": "1234567890",
        "Address": "123 Main St",
        "LicenseNumber": "ABC123"
      },
      {
        "ID": 2,
        "Name": "Jane Doe",
        "DateOfBirth": "2000-01-01",
        "Email": "sdf",
        "Phone": "1234567890",
        "Address": "123 Main St",
        "LicenseNumber": "DEF456"
      },
      {
        "ID": 3,
        "Name": "John Smith",
        "DateOfBirth": "2000-01-01",
        "Email": "sdf",
        "Phone": "1234567890",
        "Address": "123 Main St",
        "LicenseNumber": "GHI789"
      }
    ];

    // return an observable
    return new Observable((observer) => {
      observer.next(data);
      observer.complete();
    });
  }
}
