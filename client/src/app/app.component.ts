import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'MCV';
  users:any;
  searchId: number=0;
  searchName: string = '';
  clientInfo: any;

  constructor(private http:HttpClient) {}
  ngOnInit(): void {
    this.http.get("https://localhost:5003/api/user").subscribe({
      next: response => this.users=response,
      error:error=> console.log(error),
      complete: ()=> console.log('Request has completed')
    })
  }

  searchById() {
    this.clientInfo = this.users.find((user: { id: number; }) => user.id === this.searchId);
  }

  searchByName() {
    this.clientInfo = this.users.find((user: { clientName: string; }) => user.clientName.toLowerCase() === this.searchName.toLowerCase());
  }

  clearSearchByName() {
    this.searchName = '';
  }

  clearSearchById() {
    this.searchId = 0;
  }


}
