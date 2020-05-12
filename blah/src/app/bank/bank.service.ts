import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ReturnObject } from '../model';

@Injectable({
  providedIn: 'root' 
})
export class BankService { 

  constructor(private http: HttpClient) { }

  getBanks() {
    return this.http.get<ReturnObject>('api/banks/getall')
  }
}
