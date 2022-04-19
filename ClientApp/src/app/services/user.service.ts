import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { catchError } from 'rxjs/operators'
import { User } from '../../app/models/User';
@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http : HttpClient) { }

  public getUsers() {
    return this.http.get<User[]>(`${environment.api}User`)
      .pipe(
        catchError(error => {
          console.log(error);
          return  []; 
        })
      );
  }

  public removeUser(id : number){
    const options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    }
    return this.http.delete<void>(`${environment.api}User/${id}`, options)
      .pipe(
        catchError(error => {
          alert("Some error(s) deleting the user");
          console.log(error);
          return  []; 
        })
      );
  }
  public modifyUser(user : User){

    return this.http.put<void>(`${environment.api}User`, user)
      .pipe(
        catchError(error => {
          alert("Some error(s) modifing the user");
          console.log(error);
          return  []; 
        })
      );
  }
  public addUser(user : User){

    return this.http.post<void>(`${environment.api}User`, user)
      .pipe(
        catchError(error => {
          alert("Some error(s) adding the user");
          console.log(error);
          return  []; 
        })
      );
  }

}
