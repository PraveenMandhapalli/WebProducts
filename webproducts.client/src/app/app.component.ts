import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import {  ColDef } from 'ag-grid-community';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  ColumnDefs: any; 
  rowData: any;
  countrycodes: any
  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getForecasts();
  }

  getForecasts() {
    this.ColumnDefs = [
      { headerName: 'Name', field: 'name', sortable: true, filter: true },
      { headerName: 'Price', field: 'price', sortable: true, filter: true },
      { headerName: 'Description', field: 'description', sortable: true, filter: true },
      { headerName: 'CurrencyCode', field: 'CurrencyCode', sortable: true, filter: true },
      {
        headerName: 'CountryCode', field: 'CountryCode', sortable: true, filter: true, editable: true, cellEditor: 'agSelectCellEditor',
        cellEditorParams: {
          values: ["USA", "DEU", "AUS"]
        }
      }
       
    ];  
    this.http.get('http://localhost:5279/Products/GetProducts').subscribe(
      (result) => {
        this.rowData = result;
      },
      (error) => {
        console.error(error);
      }
    );
  }

   generalForemen() {

     this.http.get('http://localhost:5279/Products/GetCountryCode').subscribe(
      (result) => {
        this.countrycodes = result;
      },
      (error) => {
        console.error(error);
      }
    );
     return this.countrycodes;
  }
  title = 'webproducts.client';
}
