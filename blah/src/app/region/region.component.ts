import { Component, OnInit } from '@angular/core';
import { Region } from '../model';
import { RegionService } from './region.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-region',
  templateUrl: './region.component.html',
  styleUrls: ['./region.component.scss']
})
export class RegionComponent implements OnInit {

  regions: Region[];

  constructor(private regionService: RegionService, private router: Router) { }

  ngOnInit() {
   this.getAllRegions();
  }

  getAllRegions() {
    this.regionService.getRegions().subscribe((response) => {
      if(response.Status) {
        this.regions = response.Data;
      }
    });
  }

  openForm() {
    this.router.navigateByUrl('region-form');
  }

  editForm(id: number) {
    this.router.navigate(['region-form', id]);
  }
}
