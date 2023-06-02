import { Component } from '@angular/core';
import { UsersService } from '../users.service';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { AppUser } from '../app-user';

@Component({
  selector: 'app-user-form',
  templateUrl: './user-form.component.html',
  styleUrls: ['./user-form.component.css']
})
export class UserFormComponent {

  constructor(private userService: UsersService, private formBuilder: FormBuilder) {
    this.userForm = this.formBuilder.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      emailAddress: ['', [Validators.email, Validators.required]]
    });
  }

  userForm: FormGroup;

  onSubmit(){
    if(this.userForm.valid){

    const user: AppUser = this.userForm.value

    this.userService.users.push(user);

    this.userForm.reset();
    }
  }

}
