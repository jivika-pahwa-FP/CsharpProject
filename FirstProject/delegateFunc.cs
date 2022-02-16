using System;
using System.IO;

namespace FirstProject{

    public class delegateFunc{

        public delegate int deladd(int a , int b); // delegate declrn.
        public delegate void delDisplay(string msg); // delegate declrn.

        public delegate void printmsg(string data);

        public static void printtoConsole(string data){
                System.Console.WriteLine("data entered : "+data);
        }

        public static void printtoFile(string data){
            FileStream log = new FileStream("logs.txt",FileMode.Append,FileAccess.Write);
            StreamWriter stream = new StreamWriter(log);
            stream.WriteLine(data+" "+DateTime.Now);
            log.Flush();
            stream.Close();
        }
        public static int add(int a,int b){
            return a+b;
        }

        public static int mul(int a,int b){
            return a*b;
        }

        public static void message(string a){
            System.Console.WriteLine("message : "+a);
        }        
        public static void main(string[] args)
        {
            deladd d1 = new deladd(delegateFunc.add);
            deladd d2 = new deladd(delegateFunc.mul);
            delDisplay d3 = new delDisplay(delegateFunc.message);

            // MultiCast delegate
            printmsg d4 = new printmsg(delegateFunc.printtoConsole);
            printmsg d5 = new printmsg(delegateFunc.printtoFile);
            printmsg d6 = d4+d5;

            System.Console.WriteLine("Enter your data : ");
            string data = Console.ReadLine();
            d6(data);

        /*
            int result = d1(2,8);
            int product = d2(2,8);
            d3("C# Programning");

            System.Console.WriteLine("add : "+result);
            System.Console.WriteLine("mult : "+product);
            */

        }
    }
}