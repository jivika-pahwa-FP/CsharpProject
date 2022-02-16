using System;

namespace FirstProject
{
    public enum cities{
        delhi,mumbai,chennai
    }
    class Program3
    {

      /*  public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a and b : ");
            int c = 0;
            try{          
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                c = a/b; 
            }
            catch(Exception){
                //System.Console.WriteLine("message : "+e.Message);
                System.Console.WriteLine("Please enter a number  !");
            }
            finally{
            System.Console.WriteLine("result : {0} ",c);   
            }

            System.Console.WriteLine("enter city :");
            Enum.TryParse(Console.ReadLine(),out cities loc);
            System.Console.WriteLine(loc + " is located at above position ");

            string[] city = Enum.GetNames(typeof(cities));

            int totalcities=0;
            foreach(string i in city){
                System.Console.WriteLine(i);
                totalcities++;
            }
            System.Console.WriteLine("total cities in enum : {0} ",totalcities);

            int[] cityPos = (int [])Enum.GetValues(typeof(cities));
            foreach(int i in cityPos){
                System.Console.WriteLine(i);
            }

        }*/



    }
}
