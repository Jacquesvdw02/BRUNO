import { Injectable } from '@angular/core';
import { ClientRepository } from '../../Repositories/client/client.repository';
import { Observable } from 'rxjs';
import { Client } from '../../Interfaces/Client.interface';

@Injectable({
  providedIn: 'root'
})
export class ClientService {
  public clients: Client[] = [];

  constructor(private _clientRepository: ClientRepository) { }

  public getAllClients(): Observable<Client[]> {
    return this._clientRepository.getAllClients();
  }

  public createClient(client: any): void {
    // add a dateJoined property to the client object with the current date in format "yyyy-mm-dd"
    client.dateJoined = new Date().toISOString().split('T')[0];
    this._clientRepository.createClient(client);
  }
}
