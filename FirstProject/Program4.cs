using System;
using MyLib;

namespace FirstProject{

    public class test {
        public static string name;
        public static int balance;
        
    }
   public class test2 {
            public void getName(){
            test.name = "C# Programming";
            test.balance = 23000;
            System.Console.WriteLine(test.name);
        }

           public void deposit(int amount){
            test.balance += amount;
            System.Console.WriteLine(test.balance);
        }
    }
    class Program4{

       /*  public static void Main(string[] args)
        {
            MyLibClass obj = new MyLibClass();
            obj.getName();
            obj.getAge();

                test2 t2 = new test2();
                t2.getName();
                t2.deposit(23000);

        }*/
    }
}