import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { HeaderComponent } from './core/layout/header/header.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HttpClientModule } from '@angular/common/http';
import { InformationComponent } from './information/information.component';
import { BookingHistoryComponent } from './shared/components/booking-history/booking-history.component';
import { BookingsComponent } from './shared/components/bookings/bookings.component';
import { PlacesComponent } from './shared/components/places/places.component';
import { BookingDetailsComponent } from './booking-details/booking-details.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    InformationComponent,
    BookingHistoryComponent,
    BookingsComponent,
    PlacesComponent,
    BookingDetailsComponent
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,   
    HttpClientModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
