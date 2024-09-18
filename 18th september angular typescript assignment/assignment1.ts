class Product{
    public Productid:number;
    public ProductName:string;
    public UnitPrice:number;
    public Quantity:number;
    constructor(Productid:number,ProductName:string="",UnitPrice:number=0,Quantity:number=0){
        this.Productid=Productid;
        this.ProductName=ProductName;
        this.UnitPrice=UnitPrice;
        this.Quantity=Quantity;
    }
    public getTotal():number{
        return this.UnitPrice*this.Quantity;
    }
    public showDetails():void{
        console.log(`Product id: ${this.Productid},Product Name: ${this.ProductName},Unit Price:${this.UnitPrice} ,Quantity:${this.Quantity}`);
    }
 }
var arr:Product[]=[];
arr.push(new Product(1,"tan",14235,1));
arr.push(new Product(2,"tanfs",145,2));
arr.push(new Product(3,"hp",40000,1));
arr.push(new Product(2,"dell",120000,3));
function totalproducts(products:Product[]):number{
    var total:number=0;
    for(let product of products){
        total+=product.getTotal();
    }
    return total;
}
function showDetails(products:Product[]):void{
    for(let product of products){
        product.showDetails();
    }
}
console.log("Total Price:"+totalproducts(arr));
showDetails(arr);
