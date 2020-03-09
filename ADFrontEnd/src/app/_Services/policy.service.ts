import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Policy } from '../_Models/Policy';

@Injectable({
  providedIn: 'root'
})
export class PolicyService {
  baseUrl = environment.baseUrl;

  constructor(private http: HttpClient) { }

  getPolicy(id): Observable<Policy> {
    return this.http.get<Policy>(this.baseUrl + 'policy/' + id);
  }

}
