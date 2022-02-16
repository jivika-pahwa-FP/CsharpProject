using System;

namespace FirstProject{

    class Practice {

        public delegate void getDetails(string name,int age);
        public delegate void calculator(int a,int b);
        public delegate void inline();        
        public delegate void inline2(int a);

        public static void getEmpDetails(string name,int age){
            System.Console.WriteLine("Name : {0} Age : {1} ",name,age);
        }
        public static void add(int a,int b){
            System.Console.WriteLine("Add : {0} ",(a+b));
        }
        public static void subt(int a,int b){
            System.Console.WriteLine("Sub : {0} ",(a-b));
        }
        public static void mult(int a,int b){
            System.Console.WriteLine("Mul : {0} ",(a*b));
        }
        public static void div(int a,int b){
            System.Console.WriteLine("Div : {0} ",(a/b));
        }
        public static void main(string[] args)
        {
            // delegate
            getDetails del = new getDetails(Practice.getEmpDetails);
            del("Jivika",23);

            // multicast delegate (only works with void)
            calculator c1 = new calculator(Practice.add);
            calculator c2 = new calculator(Practice.subt);
            calculator c3 = new calculator(Practice.mult);
            calculator c4 = new calculator(Practice.div);

            calculator c5 = c1+c2+c3+c4;
            c5(60,40);

            // inline or anonymous function 
            inline i = delegate(){
                System.Console.WriteLine("I am an anonymous function ");
            };
            i();

            inline2 x = delegate(int a){
                System.Console.WriteLine("Anonymous function with parameter :  "+a);
            };
            x(23);

        }
    }
}