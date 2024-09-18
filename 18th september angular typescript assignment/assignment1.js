var Product = /** @class */ (function () {
    function Product(Productid, ProductName, UnitPrice, Quantity) {
        if (ProductName === void 0) { ProductName = ""; }
        if (UnitPrice === void 0) { UnitPrice = 0; }
        if (Quantity === void 0) { Quantity = 0; }
        this.Productid = Productid;
        this.ProductName = ProductName;
        this.UnitPrice = UnitPrice;
        this.Quantity = Quantity;
    }
    Product.prototype.getTotal = function () {
        return this.UnitPrice * this.Quantity;
    };
    Product.prototype.showDetails = function () {
        console.log("Product id:" + this.Productid + "Product Name:" + this.ProductName + "Unit Price:" + this.UnitPrice + "Quantity:" + this.Quantity);
    };
    return Product;
}());
var arr = [];
arr.push(new Product(1, "tan", 14235, 1));
arr.push(new Product(2, "tanfs", 145, 2));
arr.push(new Product(3, "hp", 40000, 1));
arr.push(new Product(2, "dell", 120000, 3));
function totalproducts(products) {
    var total = 0;
    for (var _i = 0, products_1 = products; _i < products_1.length; _i++) {
        var product = products_1[_i];
        total += product.getTotal();
    }
    return total;
}
function showDetails(products) {
    for (var _i = 0, products_2 = products; _i < products_2.length; _i++) {
        var product = products_2[_i];
        console.log(product.showDetails());
    }
}
console.log(totalproducts(arr));
console.log(showDetails(arr));
