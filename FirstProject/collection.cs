using System;
using System.Collections;
using System.Collections.Generic;

namespace FirstProject{

    class collection{

        public static void main()
        {
            
            // Generic Collections
            List<int> list = new List<int>();
            list.Add(12); list.Add(62); list.Add(19); list.Add(120);

            foreach(var i in list){
                System.Console.Write(i+"\t");
            }

            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict.Add(101,"Emp1");
            dict.Add(102,"Emp2");
            dict.Add(103,"Emp3");
            dict.Add(104,"Emp4");
            dict.Add(105,"Emp5");

            foreach(KeyValuePair<int,string> dt in dict){
                System.Console.WriteLine(dt.Key+" : "+dt.Value);
            }

            System.Console.WriteLine("Enter key to find : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if(dict.ContainsKey(choice)){
                System.Console.WriteLine(dict[choice]);
            }
            else{
                System.Console.WriteLine("not found ! ");
            }

            
            HashSet<string> set = new HashSet<string>();
            set.Add("delhi");
            set.Add("mumbaii");
            set.Add("chennai");
            set.Add("delhi");
            set.Add("mumbaii");
            set.Add("chennai");
            set.Add("delhi");
            set.Add("mumbaii");
            set.Add("chennai");

            foreach(string i in set){
                System.Console.WriteLine(i);
            }
            
            // Non Generic Collections
            /* Hashtable hash = new Hashtable();
            hash.Add(101,"Emp1");
            hash.Add(102,"Emp2");
            hash.Add(103,"Emp3");
            hash.Add(104,"Emp4");
             hash.Add(105,"Emp5");

             foreach(var key in hash.Keys){
                System.Console.WriteLine(key);
            }
            foreach(var value in hash.Values){
                System.Console.WriteLine(value);
            } 

            foreach(DictionaryEntry dt in hash){
                System.Console.WriteLine(dt.Key + " : "+ dt.Value);
            }

            System.Console.WriteLine("Enter key to find : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if(hash.Contains(choice)){
                System.Console.WriteLine(hash[choice]);
            }
            else{
                System.Console.WriteLine("not found ! ");
            }*/

            
            /* ArrayList numbers = new ArrayList();
            numbers.Add(23); numbers.Add(83); numbers.Add(123); numbers.Add(903);
            numbers.Sort();

            ArrayList arr = new ArrayList();
            arr.Add("Mango");
            arr.Add(22);
            arr.Add("Banana");
            arr.Add("Grapes");
            arr.Add(true);
            arr.Add("Cherry");
            arr.InsertRange(2,numbers);
            arr.Insert(5,"Litchiii");
            arr.RemoveAt(5);
            arr.Remove("Cherry");


            foreach(var i in arr){ // we will use var for typecasting into dataype at compilation.
                System.Console.WriteLine(i);
            }

            System.Console.WriteLine("Index of Cherry : "+arr.IndexOf("Cherry"));
            System.Console.WriteLine("Count : "+arr.Count);
            System.Console.WriteLine("Capacity : "+arr.Capacity);
            

            foreach(var i in numbers){ // we will use var for typecasting into dataype at compilation.
                System.Console.WriteLine(i);
             } */


        }

    }
}