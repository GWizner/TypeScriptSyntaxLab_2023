import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { WebHookResponse } from './web-hook-response';

@Injectable({
  providedIn: 'root'
})
export class WebHookSiteService {

  constructor(private http: HttpClient) { }

  url: string = "https://webhook.site/85417d62-19a8-4dc5-a8f8-1fc5b65af291"

  sendGetRequest() {
    return this.http.get<WebHookResponse>(this.url);
  }

  sendPostRequest() {
    const postData = {
      "localMachine" : "Okay"
    }
    return this.http.post(this.url, postData);
  }

  sendDeleteRequest() {
    return this.http.delete(this.url);
  }

}
