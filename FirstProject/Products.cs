using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Product{
    int Productid, ProductPrice;
    string ProductName;

    public Product(){

    }
    public Product(int id,string name,int price){
        this.Productid = id;
        this.ProductName = name;
        this.ProductPrice = price;
    }

    public string display(){
        return "Id : "+Productid+" Name : "+ProductName+" Price : "+ProductPrice;
    }

    public static void main(string[] args)
    {
        List<Product> list = new List<Product>();
        Product p = new Product();

        System.Console.WriteLine("Enter products");

        for(int i = 0 ; i<= 2 ; i++){
            int p_id = int.Parse(Console.ReadLine());
            string p_name  = Console.ReadLine();
            int p_price = int.Parse(Console.ReadLine());
            list.Add(new Product(p_id,p_name,p_price));
        }

        List<Product> sort = list.OrderBy(x => x.ProductPrice).ToList();

        foreach(var i in sort){
            System.Console.WriteLine(i.display());
        }
    }
}