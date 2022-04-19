import { Component,  OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { UserService } from '../services/user.service';
import { User } from '../models/User';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html'
})
export class UsersComponent implements OnInit {
  public users: User[];
  public showTable : boolean = true;
  public currentUser : User;
  public addUserBoolean : boolean = false;
  public roles = [
    {idRole: 1 , roleName: "Normal user" },
    {idRole: 2 , roleName: "VIP user" },
    {idRole: 3 , roleName: "Premium user" }
  ]
  constructor( private userService : UserService) {
;
  }
  public async ngOnInit(): Promise<void> {
    this.users = await this.userService.getUsers().toPromise();
    console.log(this.users)
  }
  public async removeUser(id : number) : Promise<void> {
    await this.userService.removeUser(id).toPromise();
    this.users = this.users.filter(e =>{
      return e.userId != id;
    });
    alert("The user has been removed.")
  }

  public addUser() : void{
    this.currentUser = new User();
    this.showTable = false;
    this.addUserBoolean = true;
  }
  public modifyUser(id : number) : void {
    this.currentUser = this.users.filter(e =>{
      return e.userId == id;
    })[0];
    this.currentUser.birthday=this.currentUser.birthday.toString().split("T")[0];
    this.showTable = false;
  }


  public cancel() : void {
    this.showTable = true;
    this.addUserBoolean = false;
  } 
  public async save() : Promise<void> {
    this.currentUser.cellphone = this.currentUser.cellphone.toString();
    if(this.addUserBoolean){
      await this.userService.addUser(this.currentUser).toPromise();
      this.users.push(this.currentUser);
    }
    else{
      await this.userService.modifyUser(this.currentUser).toPromise();
    }
    this.showTable = true;
    alert(`The user has been ${this.addUserBoolean ? 'added' : 'modified'} properly !`)
    this.addUserBoolean = false;
  } 



}
