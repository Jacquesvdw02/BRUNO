import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CarRepository {

  constructor(private _httpClient: HttpClient) { }
}
