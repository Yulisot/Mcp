import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { environment } from 'config';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'MCP';
  clients: any[] = [];
  searchTerm: string = '';
  clientInfo: any = null;
  selectedClient: any;
  selectedCompany: any;


  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.fetchClients();
  }

  fetchClients(): void {
    this.http.get(`${environment.apiUrl}`).subscribe({
      next: (response: any) => {
        this.clients = response['$values'];
        console.log('Clients:', this.clients);
      },
      error: error => console.error(error),
      complete: () => console.log('Request has completed')
    });
  }

  fetchUsersByClientId(clientId: number): void {
    const url = `${environment.apiUrl}/ByClient/${clientId}`;
    this.http.get(url).subscribe({
      next: (response: any) => {
        console.log('Fetched Users:', response);
        this.clientInfo = response;
      },
      error: error => console.error('Error fetching users:', error),
      complete: () => console.log('User request has completed')
    });
  }

  fetchUsersByCompanyId(companyId: number): void {
    const url = `${environment.apiUrl}/ByCompany/${companyId}`;
    this.http.get(url).subscribe({
      next: (response: any) => {
        console.log('Fetched Users by Company:', response);
        this.clientInfo = response;
      },
      error: error => console.error('Error fetching users by Company:', error),
      complete: () => console.log('User request by Company has completed')
    });
  }

  search(): void {
    if (this.searchTerm.trim() !== '') {
      const foundClient = this.clients.find((client: any) =>
        client.name.toLowerCase().includes(this.searchTerm.toLowerCase()) ||
        client.id.toString() === this.searchTerm.trim()
      );

      if (foundClient) {
        this.selectedClient = foundClient;
        this.fetchUsersByClientId(foundClient.id);
      } else {
        this.selectedClient = null;
        this.clientInfo = null;
      }
    }
  }

  getClientCompanies(clientId: number): any[] {
    const client = this.clients.find((c: any) => c.id === clientId);

    if (!client || !client.companies || !client.companies.$values) {
      return [];
    }

    return client.companies.$values;
  }

  clearSearch(): void {
    this.searchTerm = '';
    this.clientInfo = null;
    this.selectedClient = null;
  }

  selectClient(client: any) {
    this.selectedClient = client;
    this.fetchUsersByClientId(client.id);
  }

  selectCompany(company: any) {
    this.selectedCompany = company;
    this.fetchUsersByCompanyId(company.id);
  }

}


