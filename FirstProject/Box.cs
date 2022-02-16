using System;

namespace FirstProject{

    class Box {

       public int length ,  breadth;

        public static Box operator +(Box c1, Box c2){
            
            c1.length = c1.length + c2.length;
            c1.breadth = c1.breadth + c2.breadth;
            return c1 ;
        }
        
    }

    class Test{
        Box c1 = new Box();
        Box c2 = new Box();
        public Test(){
            
            c1.length = 4; c1.breadth = 5;
            c2.length = 6; c2.breadth = 7;

            c1 = c1 + c2;
            System.Console.WriteLine("Total Length : {0}cm ",c1.length);
            System.Console.WriteLine("Total Breadth : {0}cm ",c1.breadth);
        }
    }
}