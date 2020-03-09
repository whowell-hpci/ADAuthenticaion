import { Component, OnInit } from '@angular/core';
import { Policy } from '../_Models/Policy';
import { PolicyService } from '../_Services/policy.service';
import { AlertifyService } from '../_Services/alertify.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  policy: any = {}

  constructor(private policyService: PolicyService, private alertify: AlertifyService) { }

  ngOnInit() {
  }

  loadPolicy() {
    this.policyService.getPolicy(this.policy.policyNumber).subscribe((res) => {
      this.policy.url = res.url;

    }, error => {
      this.alertify.error(error);
    })
  }

}
