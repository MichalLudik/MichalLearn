import { Component, OnInit } from '@angular/core';
import { IProduct } from './products'

@Component({
    selector: 'pm-products',
    templateUrl: './product-list.component.html',
    styleUrls: ['./product-list.components.css']
})

export class ProductListComponent implements OnInit{
    
    pageTitle: string = 'Zoznam produktov';
    imageWidth: number = 50;
    imageMargin : number = 2;
    showImage: boolean = false;
    listFilter: string = 'cart';
    products: IProduct[] = [
        {
            "productId": 2,
            "productName": "Garden Cart",
            "productCode": "GDN-0023",
            "releaseDate": "March 18, 2016",
            "description": "50 litrov",
            "price": 32.999,
            "starRating": 4.2,
            "imageUrl": "https://openclipart.org/download/58471/garden-cart.svg"
        },
        {
            "productId": 5,
            "productName": "Televizor",
            "productCode": "DSB-25L",
            "releaseDate": "December 28, 2012",
            "description": "3 dvere",
            "price": 299.99,
            "starRating": 3.5,
            "imageUrl": "https://openclipart.org/download/137809/hdtv.svg"
        }
    ];

    zobrazObrazky():void{
        this.showImage = !this.showImage;
    }

    ngOnInit(): void {
        console.log("In OnInit.");
    }
}