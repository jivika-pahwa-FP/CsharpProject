using System;

namespace FirstProject{
    class Shape{
        public string name = "Jivika";
        public Shape(){
            System.Console.WriteLine("invoked");
        }
        public virtual void  display(){
            System.Console.WriteLine("shape displayed !");
        }
        public virtual void about(){
            System.Console.WriteLine("i m new method");
        }
    }

    class Rectangle : Shape{
        public override void  display(){
            System.Console.WriteLine("Rectangle displayed !");
        }
        public new void about(){
            System.Console.WriteLine("i m new method -- derived ");
        }
    }

    }

