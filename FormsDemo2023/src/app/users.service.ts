import { Injectable } from '@angular/core';
import { AppUser } from './app-user';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  constructor() { }

  users: AppUser[] = [
    {
      firstName: 'Juan',
      lastName: 'Dominguez',
      emailAddress: 'juan.dominguez@example.com'
    },
    {
      firstName: 'Yuki',
      lastName: 'Tanaka',
      emailAddress: 'yuki.tanaka@example.com'
    },
    {
      firstName: 'Amina',
      lastName: 'Kone',
      emailAddress: 'amina.kone@example.com'
    },
    {
      firstName: 'Mikhail',
      lastName: 'Ivanov',
      emailAddress: 'mikhail.ivanov@example.com'
    },
    {
      firstName: 'Xia',
      lastName: 'Li',
      emailAddress: 'xia.li@example.com'
    },
    {
      firstName: 'Isabella',
      lastName: 'Rossi',
      emailAddress: 'isabella.rossi@example.com'
    },
    {
      firstName: 'Liam',
      lastName: "O'Brien",
      emailAddress: 'liam.obrien@example.com'
    },
    {
      firstName: 'Aarav',
      lastName: 'Patel',
      emailAddress: 'aarav.patel@example.com'
    }
  ];

  getAllUsers(): Observable<AppUser[]>{
    const appUsers = of(this.users);
    return appUsers;
  }

  addUser(user: AppUser): Observable<AppUser[]> {
    this.users.push(user); 
  
    const appUsers = of(this.users);
    return appUsers;
  }

}
