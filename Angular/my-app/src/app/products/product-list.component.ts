import { Component } from '@angular/core';

@Component({
    selector: 'pm-products',
    templateUrl: './product-list.component.html'
})

export class ProductListComponent{
    pageTitle: string = 'Zoznam produktov';
    products: any[];
}