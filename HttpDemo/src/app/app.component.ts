import { Component } from '@angular/core';
import { WebHookSiteService } from './web-hook-site.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'HttpDemo';


  requestType?: string;

  constructor(private webHookSiteService: WebHookSiteService) {}

  sendGetRequest() {

this.requestType = "request made ...";

    this.webHookSiteService.sendGetRequest().subscribe( 
      
      result => {
        
        this.requestType = result.requestType;
        
        console.log(result);

        }
      );
  }

  sendPostRequest() {
    this.webHookSiteService.sendPostRequest().subscribe( result => console.log(result) );
  }
  sendDeleteRequest() {
    this.webHookSiteService.sendDeleteRequest().subscribe( result => console.log(result) );
  }

}


