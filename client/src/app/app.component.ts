import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { environment } from 'config';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'MCP';
  clients: any[] = [];
  clientInfo: any = null;
  selectedClient: any;
  selectedCompany: any;
  managerList: any[] = [];
  clientCompanies: any[] =[];
  LogoUrl = 'https://www.hilan.co.il/images/bg-logo-new.png';


  constructor(private http: HttpClient, private titleService: Title) {}

  ngOnInit(): void {
    this.titleService.setTitle(this.title);
    this.fetchClients();

  }

  fetchClients(): void {
    this.http.get(`${environment.apiUrl}client`).subscribe({
      next: (response: any) => {
        this.clients = response;
        console.log('Clients:', this.clients);
      },
      error: error => console.error(error),
      complete: () => console.log('Request has completed')
    });
  }

  fetchUsersByClientId(clientId: number): void {
    const url = `${environment.apiUrl}user/${clientId}/users`;
    this.http.get(url).subscribe({
      next: (response: any) => {
        console.log('Fetched Users:', response);
        this.clientInfo = response;
      },
      error: error => console.error('Error fetching users:', error),
      complete: () => console.log('User request has completed')
    });
  }

  fetchCompanyByClientId(clientId: number): void {
    const url = `${environment.apiUrl}Companies/${clientId}/companies`;
    this.http.get(url).subscribe({
      next: (response: any) => {
        console.log('Fetched Companies by Client:', response);
        this.clientCompanies = response;
      },
      error: error => console.error('Error fetching companies by Client:', error),
      complete: () => console.log('Company request by Client has completed')
    });
  }

  search(inputValue: string): void {
    if (inputValue.trim() !== '') {
      const foundClient = this.clients.find((client: any) =>
        client.name.toLowerCase().includes(inputValue.toLowerCase()) ||
        client.id.toString() === inputValue.trim()
      );

      if (foundClient) {
        this.selectedClient = foundClient;
        this.fetchUsersByClientId(foundClient.id);
        this.fetchCompanyByClientId(foundClient.id)
      } else {
        this.selectedClient = null;
        this.clientInfo = null;
      }
    } else {
      alert('Please insert a value in the search field.');
    }
  }

  getClientCompanies(clientId: number): any[] {
    const client = this.clients.find((c: any) => c.id === clientId);

    if (!client || !client.companies) {
      return [];
    }

    return client.companies;
  }

  clearSearch(searchInput: HTMLInputElement): void {
    this.clientInfo = null;
    this.selectedClient = null;
    this.managerList = [];
    this.clientCompanies=[];
    searchInput.value = '';
  }

  selectClient(client: any) {
    this.selectedClient = client;
    this.fetchCompanyByClientId(client.id);
    this.fetchUsersByClientId(client.id);
  }

  // selectCompany(company: any) {
  //   this.selectedCompany = company;
  //   this.fetchCompanyByClientId(company.id);
  // }

  getFilteredClients(): any[] {
    if (this.selectedClient) {
      return this.clients.filter(client => client.id === this.selectedClient.id);
    }
    return this.clients;
  }


  // updateManagerList(user: any): void {
  //   user.selected = !user.selected;
  //   if (user.selected) {
  //     this.managerList.push({
  //       id: user.idNum,
  //       firstName: user.firstName,
  //       lastName: user.lastName,
  //       companyId: user.companyId
  //     });
  //   } else {
  //     this.managerList = this.managerList.filter(manager => manager.id !== user.idNum);
  //   }
  // }

}


