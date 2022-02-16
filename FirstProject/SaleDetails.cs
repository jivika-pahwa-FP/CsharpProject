using System;

namespace FirstProject {


    class SaleDetails{
        private const string V = "18/01/2022";
        int Salesno,Productno,Price,Qty,TotalAmount;
         DateTime dateofsale;

        public SaleDetails(int Salesno,int Productno,int Price,int Qty,int TotalAmount,DateTime dateofsale){
            this.Salesno = Salesno;
            this.Productno = Productno;
            this.Price = Price;
            this.Qty = Qty;
            this.TotalAmount = this.Qty*this.Price;
            this.dateofsale = dateofsale;
        }
        
        public void Sales(){
            System.Console.WriteLine("Total Amount : {0} ", (this.Price*this.Qty) );

        }
       /* public static void Main(){
            
            SaleDetails obj = new SaleDetails(101,20,2000,5,0,DateTime.Now);
            obj.Sales();

        }*/

    }
}