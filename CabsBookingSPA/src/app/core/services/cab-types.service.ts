import { ApiService } from './api.service';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Cabs } from 'src/app/shared/models/cabs';



@Injectable({
  providedIn: 'root'
})

export class CabTypesService {

  constructor(private apiService: ApiService) { }


  getAllCabs():Observable<Cabs[]>{

    return this.apiService.getAll('CabTypes/GetAll');

  }

  
  deleteOne(id:number):Observable<any>{

    return this.apiService.delete('CabTypes/Delete/',id,id);

  }

  




}
