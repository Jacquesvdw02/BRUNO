import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Client } from '../../Interfaces/Client.interface';

@Injectable({
  providedIn: 'root'
})
export class ClientRepository {

  constructor(private _httpClient: HttpClient) { }

  public getAllClients(): Observable<Client[]> {
    return this._httpClient.get<Client[]>('https://localhost:44338/api/client');
  }

  public createClient(client: any): Observable<Client> {
    return this._httpClient.post<Client>('https://localhost:44338/api/client', client);
  }
}
