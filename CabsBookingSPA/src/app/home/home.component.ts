import { Component, OnInit } from '@angular/core';
import { CabTypesService } from '../core/services/cab-types.service';
import { Cabs } from '../shared/models/cabs';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {


  cabs: Cabs[] | undefined;
  constructor(private cabTypeService: CabTypesService ) { }

  ngOnInit(): void {

    this.cabTypeService.getAllCabs().subscribe(
        c=>{
          this.cabs = c;
          console.table(this.cabs);
        }
    )
  }

  delete(id:number){

    this.cabTypeService.deleteOne(id).subscribe(
      (response)=>{
        if(response)
          console.log('delete successfully');
        else
          console.log('delete failed');
      }

    )

  }

}
