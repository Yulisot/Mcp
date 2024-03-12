import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'config';
import { ClientCompanyService } from '../services/client-company.service';

@Component({
  selector: 'app-client',
  templateUrl: './client.component.html',
  styleUrls: ['./client.component.css']
})
export class ClientComponent implements OnInit {
  clients: any[] = [];
  selectedClient: any;


  constructor (private http: HttpClient, private clientCompanyService: ClientCompanyService) {}

  ngOnInit(): void {
    this.fetchClients();
  }


  fetchClients(): void{
    this.http.get(`${environment.apiUrl}client`).subscribe({
      next:(response:any) => {
        this.clients = response;
        console.log('Clients',this.clients);
      },
      error:error => console.error(error),
      complete: () => console.log('Request has completed')
    })
  }

  selectClient(client: any): void {
    this.selectedClient = client;
    this.clientCompanyService.setSelectedClientId(client.id);
  }}


