import { Component, Input, OnInit } from '@angular/core';
import { BookingsHistory } from '../../models/bookingsHistory';

@Component({
  selector: 'app-booking-history',
  templateUrl: './booking-history.component.html',
  styleUrls: ['./booking-history.component.css']
})
export class BookingHistoryComponent implements OnInit {



  @Input() booking: BookingsHistory | undefined;

  constructor() { }

  ngOnInit(): void {
  }

}
