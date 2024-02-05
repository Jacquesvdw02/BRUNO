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

  public createClient(client: any): Observable<Client> {
    return this._clientRepository.createClient(client);
  }
}
