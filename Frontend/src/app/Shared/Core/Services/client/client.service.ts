import { Injectable } from '@angular/core';
import { Client } from '../../Interfaces/client.interface';
import { ClientRepository } from '../../Repositories/client/client.repository';

@Injectable({
  providedIn: 'root'
})
export class ClientService {
  public clients: Client[] = [];

  constructor(private _clientRepository: ClientRepository) { }
}
