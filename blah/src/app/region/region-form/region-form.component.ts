import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormControl, Validators } from '@angular/forms';
import { RegionService } from '../region.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-region-form',
  templateUrl: './region-form.component.html',
  styleUrls: ['./region-form.component.scss']
})
export class RegionFormComponent implements OnInit {

  form: FormGroup;

  constructor(private fb: FormBuilder, 
              private regionService: RegionService,
              private router: Router, 
              private ac: ActivatedRoute) { }

  ngOnInit() {
    this.createForm();
    const id = +this.ac.snapshot.paramMap.get('id');
    if(id) { this.getone(id); }
  }

    save() {
      const data = this.form.value;
      this.regionService.saveRegion(data).subscribe(res => {
        if(res.Status) {
          console.log(res.Msg);
          this.router.navigateByUrl('regions');
        } else {
          console.log(res.Msg);
        }
      });
    }

  private createForm() {
    this.form = this.fb.group({
      Id: new FormControl(),
      Name: new FormControl('', Validators.required)
    });
  }

  private getone(id: number) {
    this.regionService.getOneRegion(id).subscribe(res => {
      if(res.Status) {
        this.form.patchValue(res.Data);
      }
    });
  }
}
