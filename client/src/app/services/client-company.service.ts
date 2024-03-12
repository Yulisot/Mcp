import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ClientCompanyService {
  private selectedClientIdSource = new BehaviorSubject<number | null>(null);
  selectedClientId$ = this.selectedClientIdSource.asObservable();

  setSelectedClientId(clientId: number): void {
    this.selectedClientIdSource.next(clientId);
  }
}
