import { Component } from '@angular/core';

@Component({ // decorator
  selector: 'app-root',
  template: `
  <h1>{{title}}</h1>
nazdarek
  `,
  // templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'Katalog Produktov';
}
