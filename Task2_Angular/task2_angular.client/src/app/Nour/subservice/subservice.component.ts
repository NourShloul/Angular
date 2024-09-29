import { Component } from '@angular/core';
import { URLService } from '../NourURL/url.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-subservice',
  templateUrl: './subservice.component.html',
  styleUrl: './subservice.component.css'
})
export class SubserviceComponent {
  parameter: any
  servicesArray: any
  ngOnInit() {
    this.parameter = this._route.snapshot.paramMap.get("id");
    this.getsubServices(this.parameter);
  }
  subServiceData: any
  constructor(private _ser: URLService, private _route: ActivatedRoute) { }
  getsubServices(id: number) {
  this._ser.getsubServicesbyServiceId(id).subscribe((data) => {
    this.subServiceData = data
    console.log("this.subServiceData", this.subServiceData)
  })
  }

}
