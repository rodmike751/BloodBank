import { Component, OnInit } from '@angular/core';
import { BankService } from './bank.service';
import { Banks } from '../model';

@Component({
  selector: 'app-bank',
  templateUrl: './bank.component.html',
  styleUrls: ['./bank.component.scss']
})
export class BankComponent implements OnInit { 

  banks: Banks[];

  constructor(private bankService: BankService) { }

  ngOnInit() { 
    this.getAllBanks();
  }

  getAllBanks() {
    this.bankService.getBanks().subscribe((response) => {
      if(response.Status) {
        this.banks = response.Data;
      }
    });
  }
}
