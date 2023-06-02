import { Component, OnInit } from '@angular/core';
import { UsersService } from '../users.service';
import { AppUser } from '../app-user';

@Component({
  selector: 'app-email-list',
  templateUrl: './email-list.component.html',
  styleUrls: ['./email-list.component.css']
})
export class EmailListComponent implements OnInit {


  constructor(private userService: UsersService) {}


  users: AppUser[] = [];


  ngOnInit(): void {
    this.getUsers();
  }




  getUsers(){
    this.userService.getAllUsers().subscribe(

      result => {
        this.users = result
        console.log(result)
      }

    );
  }

}
