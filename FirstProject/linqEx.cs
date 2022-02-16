using System;
using System.Linq;
using System.Collections;

using System.Collections.Generic;

namespace FirstProject{

    class productStore{
            public string productName { get; set; }
            public int productPrice { get; set; }         

    }
    class linqEx{
        public static void main(string[] args)
        {
            List<int> list = new List<int>(){1,2,3,4,5,6,7,8};

            // use of querymethod in collections
            ArrayList arr = new ArrayList();
            arr.Add(new productStore{productName = "Dell", productPrice = 45000 });
            arr.Add(new productStore{productName = "Hp", productPrice = 35000 });
            arr.Add(new productStore{productName = "Dell", productPrice = 30000 });

            var search = (from productStore x in arr 
                    where x.productName.Contains("Dell")
                    select x);

            foreach(var i in search){
                System.Console.WriteLine(i.productName+" : "+i.productPrice);
            }
/*
            // Query Syntax
            var result = (from i in list 
                where i%2 == 0 
                select i).ToList();

                foreach(var k in result){
                System.Console.WriteLine(k);
                }

            System.Console.WriteLine("Method Syntax in LINQ : ");
            // Method Syntax

            var result2 = list.Where(x => x%2 == 0).Select(x=>x).ToList();
            foreach(var k in result2){
                System.Console.WriteLine(k);
                }
*/
        }
    }
}