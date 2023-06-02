import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from './user'

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient) { }

  private readonly url  = 'https://localhost:7042/api/';

  getAllUsers() {
    return this.http.get<User[]>(this.url + "Users");
  }


  addUser(userToAdd: User) {
    return this.http.post(this.url + "Users", userToAdd);
  }

}
