import { Injectable } from '@angular/core';
import { Rental } from '../../Interfaces/rental.interface';
import { RentalRepository } from '../../Repositories/rental/rental.repository';

@Injectable({
  providedIn: 'root'
})
export class RentalService {
  public rentals: Rental[] = [];

  constructor(private _rentalRepository: RentalRepository) { }
}
