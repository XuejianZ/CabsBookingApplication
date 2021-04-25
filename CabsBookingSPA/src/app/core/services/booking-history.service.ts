import { BookingsHistory } from './../../shared/models/bookingsHistory';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Bookings } from 'src/app/shared/models/bookings';

@Injectable({
  providedIn: 'root'
})
export class BookingHistoryService {




  constructor(private apiService: ApiService) { }

  getBookingHistorybyId(id:number):Observable<BookingsHistory[]>{

    return this.apiService.getAllById('CabTypes/GetAllBookingHistory/', id);

  }


  getCurrentBookingsById(id:number):Observable<Bookings[]>{

    return this.apiService.getAllById('CabTypes/GetAllCurrentBookings/', id);

  }

}
