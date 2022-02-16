using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace FirstProject{

    class linq_Practice {

        public class emp {
            public string name;
            public int age;
        }
        public static void main(string[] args)
        {
            List<int> list = new List<int>(){1,2,3,4,5,6} ; // generic collection

            ArrayList e = new ArrayList(); // non-generic collection
            e.Add(new emp{name = "Jivika",age = 23});
            e.Add(new emp{name = "Pooja",age = 24});
            e.Add(new emp{name = "Ashish",age = 25});
            e.Add(new emp{name = "Gourav",age = 23});
            e.Add(new emp{name = "khushboo",age = 24});
            e.Add(new emp{name = "Neil",age=12});

            // Query Syntax
            var search = (from emp i in e
                        where i.age == 24
                        select i); // return object

            foreach(var x in search){
                System.Console.WriteLine(x.name + " : "+x.age);
            }

            // Method Syntax
            var result = list.Where(x => x%2 == 1).Select(x => x).ToList();

            foreach(var x in result){
            System.Console.WriteLine(x);
            }
            
        }

    }

}