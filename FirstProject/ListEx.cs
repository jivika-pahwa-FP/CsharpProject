using System;
using System.Collections;
using System.Collections.Generic;

namespace FirstProject{

    class ListEx{

        public static void main(string[] args)
        {
            List<Emp> emp = new List<Emp>();
            emp.Add( new Emp (101,"Jivika",25000,DateTime.Now) );
            emp.Add( new Emp (102,"Pooja",15000,DateTime.Now) );
            emp.Add( new Emp (103,"Ashish",25000,DateTime.Now) );
            emp.Add( new Emp (104,"Harsh",15000,DateTime.Now) );
/* 
            Console.WriteLine("find ID ");
            int id = int.Parse(Console.ReadLine());
            Emp emp1 = emp.Find(x=> x.Eid == id ); */

            foreach(var i in emp){
                System.Console.WriteLine(i.AddAccount());
            }

        }
    }

    }