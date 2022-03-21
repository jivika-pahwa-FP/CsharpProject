using System;

namespace FirstProject
{
    class Practice3
    {

        public delegate void heyDelegate();
        public delegate void MultiDelegate(int a,int b);

        public void heyFunction(){
            System.Console.WriteLine(" called through delegate....");
        }

        public void add(int a,int b){
            System.Console.WriteLine(" Add : {0}",(a+b) );
        }
        public void subt(int a,int b){
            System.Console.WriteLine(" Subtract : {0}",(a-b) );
        }
        public void mult(int a,int b){
            System.Console.WriteLine(" Multiplication : {0}",(a*b) );
        }

        public static void Main()
        {

            Console.WriteLine("Delegation and Multidelegation ");

            Practice3 p = new Practice3();
            heyDelegate obj = new heyDelegate(p.heyFunction);

            MultiDelegate m1 = new MultiDelegate(p.add);
            MultiDelegate m2 = new MultiDelegate(p.subt);
            MultiDelegate m3 = new MultiDelegate(p.mult);
            MultiDelegate m4 = m1+m2+m3;

            obj();
            m4(80,50);

        }

    }
}