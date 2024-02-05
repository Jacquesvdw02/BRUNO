import { Component, OnInit } from '@angular/core';
import { CarService } from '../../Shared/Core/Services/car/car.service';
import { ClientService } from '../../Shared/Core/Services/client/client.service';
import { RentalService } from '../../Shared/Core/Services/rental/rental.service';
import { MatDialog } from '@angular/material/dialog';
import { AddClientModalComponent } from '../../Shared/Components/add-client-modal/add-client-modal.component';
import { Car } from '../../Shared/Core/Interfaces/Car.interface';
import { AddRentalModalComponent } from '../../Shared/Components/add-rental-modal/add-rental-modal.component';
import { AddCarModalComponent } from '../../Shared/Components/add-car-modal/add-car-modal.component';
import {MatIconModule} from '@angular/material/icon';
import { DataService } from '../../Shared/Core/Services/data.service';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.scss'
})
export class HomePageComponent implements OnInit {
  public activeTab: string = 'cars';
  public dataSource: any;
  public displayedColumns: string[] = [];

  constructor(private _dataService:DataService, private dialog: MatDialog, private _carService:CarService, private _clientService:ClientService, private _rentalService:RentalService) { }

  public showCars(): void {
    this._dataService.updateDataForCars();
    this._dataService.dataSource$.subscribe((data: any) => {
      this.dataSource = data;
      this.displayedColumns = this._dataService.carColumns;
    });
    this.activeTab = 'cars';
  }

  public showRentals(): void {
    this._dataService.updateDataForRentals();
    this._dataService.dataSource$.subscribe((data: any) => {
      this.dataSource = data;
      this.displayedColumns = this._dataService.rentalColumns;
    });
    this.activeTab = 'rentals';
  }

  public showClients(): void {
    this._dataService.updateDataForClients();
    this._dataService.dataSource$.subscribe((data: any) => {
      this.dataSource = data;
      this.displayedColumns = this._dataService.clientColumns;
    });
    this.activeTab = 'clients';
  }

  openAddClientModal(): void {
    this.dialog.open(AddClientModalComponent, {
      width: '450px'
    });
  }

  openAddRentalModal(): void {
    this.dialog.open(AddRentalModalComponent, {
      width: '450px'
    });
  }

  openAddCarModal(): void {
    this.dialog.open(AddCarModalComponent, {
      width: '450px'
    });
  }

  ngOnInit(): void {
    this.showCars();
  }
}