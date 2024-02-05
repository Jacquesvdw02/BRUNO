import { Component, Input } from '@angular/core';
import {MatTableModule} from '@angular/material/table';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrl: './table.component.scss'
})
export class TableComponent {
  @Input() dataSource!: any;
  @Input() displayedColumns!: string[];

  constructor() { }

  ngOnInit(): void {
  }
}
