import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ReturnObject } from '../model';

@Injectable({
  providedIn: 'root'
})
export class RegionService {

  constructor(private http: HttpClient) { }

  getRegions() {
    return this.http.get<ReturnObject>('api/regions/getall');
  }

  saveRegion(data: any) {
    if(data.Id) {return this.http.put<ReturnObject>('api/regions/Update', data); }
    return this.http.post<ReturnObject>('api/regions/create', data);
  }

  getOneRegion(id: number) {
    return this.http.get<ReturnObject>('api/regions/GetOne?id=' + id);
  }
}
