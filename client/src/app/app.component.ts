import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

// "decorator"
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  // "interpolation"
  title = 'The Dating app';
  users: any; // bye bye type safety T_T
  localhostUrl: string = 'https://localhost:5001';
  apiUrl: string = 'api';
  usersUrl: string = 'users';

  // dependency injection - naturally an async request
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getUsers();
  }

  getUsers() {
    this.http.get(this.localhostUrl + '/' + this.apiUrl + '/' + this.usersUrl)
      .subscribe(res => {
        this.users = res;
      }, error => {
        console.log(error);
      });
  }
}