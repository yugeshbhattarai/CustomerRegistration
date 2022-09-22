import { Component, OnInit } from '@angular/core';
import { CustomerDetailService } from 'src/app/shared/customer-detail.service';
import{NgForm} from '@angular/forms';
import { CustomerDetail } from 'src/app/shared/customer-detail.model';

@Component({
  selector: 'app-customer-detail-form',
  templateUrl: './customer-detail-form.component.html',
  styleUrls: []
})
export class CustomerDetailFormComponent implements OnInit {

  constructor(public service: CustomerDetailService ) { }

  ngOnInit(): void {
  }
   onSubmit(form: NgForm){
     this.service.postCustomerDetail().subscribe(
    res=>{

     },
      
      
   );
        
 }

}
