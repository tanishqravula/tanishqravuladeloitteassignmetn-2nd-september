var Customer = /** @class */ (function () {
    function Customer(cid, cname, city) {
        if (cid === void 0) { cid = 0; }
        if (cname === void 0) { cname = ""; }
        if (city === void 0) { city = ""; }
        this.cid = 0;
        this.cname = "";
        this.city = "";
        this.cid = cid;
        this.cname = cname;
        this.city = city;
    }
    Customer.prototype.showDetails = function () {
        console.log("Customer Details  ::   Id : ".concat(this.cid, ", Name : ").concat(this.cname, ", City : ").concat(this.city));
    };
    return Customer;
}());
var c1 = new Customer();
var c2 = new Customer(10256);
var c3 = new Customer(10256, "Scott");
var c4 = new Customer(10256, "Scott", "Hyd");
c1.showDetails();
c2.showDetails();
c3.showDetails();
c4.showDetails();
