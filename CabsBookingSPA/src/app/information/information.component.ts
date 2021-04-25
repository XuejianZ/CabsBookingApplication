import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BookingHistoryService } from '../core/services/booking-history.service';
import { Bookings } from '../shared/models/bookings';
import { BookingsHistory } from '../shared/models/bookingsHistory';

@Component({
  selector: 'app-information',
  templateUrl: './information.component.html',
  styleUrls: ['./information.component.css']
})
export class InformationComponent implements OnInit {

  id : number | undefined;

  bHistory : BookingsHistory[] | undefined

  bCurrent : Bookings[] | undefined

  i:number =0;

  
  constructor(private  bookingHistoryService: BookingHistoryService, private _route: ActivatedRoute) { }

  ngOnInit(): void {


      console.log('test');

      this._route.paramMap.subscribe(

      params =>{
        this.id = +params.getAll('id');

        this.bookingHistoryService.getBookingHistorybyId(this.id).subscribe(
          m =>{
            this.bHistory = m;
          }
        )
      }

    )

  this._route.paramMap.subscribe(

    params =>{
      this.id = +params.getAll('id');

      this.bookingHistoryService.getCurrentBookingsById(this.id).subscribe(
        m =>{
          this.bCurrent = m;
        }
      )
    }
  )
}

}
