import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Client } from '../../Interfaces/Client.interface';

@Injectable({
  providedIn: 'root'
})
export class ClientRepository {
  private received = false;

  constructor(private _httpClient: HttpClient) { }

  public getAllClients(): Observable<Client[]> {
    this.received = false;
    return this._httpClient.get<Client[]>('https://localhost:44338/api/client');
  }

  public createClient(client: any): void {
    if (!this.received) {
      this.received = true;
      this._httpClient.post<Client>('https://localhost:44338/api/client', client,
        { headers: { 'Content-Type': 'application/json' } });
    }
    else {
      return;
    }
  }
}
