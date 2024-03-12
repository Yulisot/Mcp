import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { environment } from 'config';
import { ClientCompanyService } from '../services/client-company.service';


@Component({
  selector: 'app-company',
  templateUrl: './company.component.html',
  styleUrls: ['./company.component.css']
})
export class CompanyComponent implements OnInit {
clientCompanies: any[] =[];




  constructor (private http:HttpClient, private clientCompanyService: ClientCompanyService) {}

  ngOnInit(): void {
    this.clientCompanyService.selectedClientId$.subscribe((clientId) => {
      if (clientId !== null) {
        this.fetchCompanyByClientId(clientId);
      }
    });
  }

  fetchCompanyByClientId(clientId: number): void {
    const url = `${environment.apiUrl}Companies/${clientId}`;
    this.http.get(url).subscribe({
      next: (response: any) => {
        console.log('Fetched Companies by Client:', response);
        this.clientCompanies = response;
      },
      error: error => console.error('Error fetching companies by Client:', error),
      complete: () => console.log('Company request by Client has completed')
    });
  }
}
