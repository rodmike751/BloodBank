import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ReturnObject } from '../model';

@Injectable({
  providedIn: 'root'
})
export class DonorService {

  constructor(private http: HttpClient) { }

  getDonors() {
    return this.http.get<ReturnObject>('api/donors/getall');
  }
}
