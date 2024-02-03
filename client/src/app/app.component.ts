import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'MCV';
  clients: any[] = [];
  searchTerm: string = '';
  clientInfo: any = null;
  selectedClient: any;


  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.fetchClients();
  }

  fetchClients(): void {
    this.http.get("https://localhost:5003/api/user").subscribe({
      next: (response: any) => {
        this.clients = response['$values'];
      },
      error: error => console.log(error),
      complete: () => console.log('Request has completed')
    });
  }

  search(): void {
    if (this.searchTerm.trim() !== '') {
      const foundClient = this.clients.find((client: any) =>
        client.name.toLowerCase().includes(this.searchTerm.toLowerCase()) ||
        client.id.toString() === this.searchTerm.trim()
      );

      this.clientInfo = foundClient ? foundClient : null;
      this.selectedClient = foundClient ? foundClient : null;

    }
  }

  getClientCompanies(clientId: number): any[] {
    const client = this.clients.find((c: any) => c.id === clientId);
    return client && client.companies ? client.companies.$values : [];
  }

  clearSearch(): void {
    this.searchTerm = '';
    this.clientInfo = null;
    this.selectedClient = null;
  }

  selectClient(client: any) {
    this.selectedClient = client;
  }




}
