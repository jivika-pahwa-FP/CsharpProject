using System;

namespace FirstProject{
    
    public delegate void FavColor(string color);
   public  class inlineFunc{

       public static void main(string[] args)
       {
           FavColor f = delegate(string color){ // anonymous or inline func
               System.Console.WriteLine("My fav Color : "+color);
           };
           f("Red");
       }
    }
}