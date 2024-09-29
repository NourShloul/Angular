import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class URLService {

  constructor(private http: HttpClient) { }
  staticData ="https://localhost:7267/api"
  getServices(): Observable<any> {
    return this.http.get<any>(`${this.staticData}/Service/getAllServices`);
  }
  getsubServicesbyServiceId(id: any): Observable<any> {
    return this.http.get<any>(`https://localhost:7267/api/Subservice/GetSubServicesbyServiceID?id=${id}`);
  }
}
