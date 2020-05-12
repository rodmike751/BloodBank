import { Component, OnInit } from '@angular/core';
import { DonorService } from './donor.service';
import { Donors } from '../model';

@Component({
  selector: 'app-donor',
  templateUrl: './donor.component.html',
  styleUrls: ['./donor.component.scss']
})
export class DonorComponent implements OnInit {

  donors: Donors[];

  constructor(private donorService: DonorService) { }

  ngOnInit() { 
    this.getAllDonors();
  }

  getAllDonors() {
    this.donorService.getDonors().subscribe((response) => {
      if(response.Status) {
        this.donors = response.Data;
      }
    });
  }
}
