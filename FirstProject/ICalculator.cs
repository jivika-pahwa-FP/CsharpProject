using System;

namespace FirstProject{
    interface ICalculator{

        void add();
        void subt();
        void mult();
        void divi();
    }

    class A : ICalculator{
        public void add()
        {
            System.Console.WriteLine("add");
        }
        public void subt()
        {
            System.Console.WriteLine("subt");
        }
        public void mult()
        {
            System.Console.WriteLine("mult");
            
        }
        public void divi()
        {
            System.Console.WriteLine("divi");
        }
    }



    }

