import { DecimalPipe } from "@angular/common";

export interface BookingsHistory{


    id:number;
    email:string;
    bookingDate: Date;
    bookingTime: string;
    fromPlace: number;
    toPlace: number;
    pickupAddress: number;
    landmark:string;
    pickupDate: Date;
    pickupTime: string;
    cabTypeId:number;
    contactNo:string;
    status:string;
    comp_time:string;
    charge:DecimalPipe;
    feedback:string;




}