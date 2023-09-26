import { Component } from "@angular/core";

@Component({
    selector: "product-list",
    templateUrl: 'productListView.component.html'
})

export default class ProductListView {

    public products:any[] = [];

    constructor() {
        //this.products = store.products;
    }

    //public products = [{
    //    sTitle: "Cricket",
    //    price: "20"
    //},
    //{
    //    sTitle: "Football",
    //    price: "50"
    //},
    //{
    //    sTitle: "Golf",
    //    price: "30"
    //},
    //];
}

