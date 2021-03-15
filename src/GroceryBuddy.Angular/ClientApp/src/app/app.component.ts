import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'Grocery Buddy';

  public items: MenuItem[] = [];

  constructor() { }

  ngOnInit(): void {

    this.items = [
      {label: 'Home', icon: 'pi pi-plus', routerLink: ['/']},
      {label: 'Counter', icon: 'pi pi-download', routerLink: ['/counter']},
      {label: 'Fetch data', icon: 'pi pi-download', routerLink: ['/fetch-data']}
    ];
  }
}
