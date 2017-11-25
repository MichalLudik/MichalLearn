import { Component } from '@angular/core';

@Component({ // decorator
  selector: 'app-root',
  template: `
  <div>
    <h1>{{title}}</h1>
    <pm-products></pm-products>
  </div>
  `
})

export class AppComponent {
  title = 'Katalog Produktov';
}