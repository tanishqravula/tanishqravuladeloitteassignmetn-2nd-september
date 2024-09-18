class Customer
{
    public cid:number = 0;
    public cname:string  = "";
    public city:string  = "";
 
    constructor(cid:number = 0, cname:string = "", city:string = "")
    {
        this.cid = cid;
        this.cname = cname;
        this.city = city;
    }
  

    public showDetails():void
    {
        console.log(`Customer Details  ::   Id : ${this.cid}, Name : ${this.cname}, City : ${this.city}`);
    }
}

let c1:Customer = new Customer();
let c2:Customer = new Customer(10256);
let c3:Customer = new Customer(10256, "Scott");
let c4:Customer = new Customer(10256, "Scott", "Hyd");

c1.showDetails();
c2.showDetails();
c3.showDetails();
c4.showDetails();
  