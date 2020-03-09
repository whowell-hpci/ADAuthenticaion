import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { HomeComponent } from './home/home.component';
import { PolicyService } from './_Services/policy.service';
import { AlertifyService } from './_Services/alertify.service';

@NgModule({
   declarations: [
      AppComponent,
      NavbarComponent,
      HomeComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      HttpClientModule,
      FormsModule

   ],
   providers: [
     PolicyService,
     AlertifyService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
