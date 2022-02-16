using System;

namespace FirstProject {

    class Scholarship{

        
        public void Merit(){

            int marks = int.Parse(Console.ReadLine());
            int fees = int.Parse(Console.ReadLine());
            double scholarshipAmount;

            if(marks >=70 && marks <=80 ){
                scholarshipAmount = fees*0.2;
            System.Console.WriteLine("Scholarship Amount : {0} ",scholarshipAmount);
            }
            if(marks > 80 && marks <= 90 ){
                scholarshipAmount = fees*0.3;
            System.Console.WriteLine("Scholarship Amount : {0} ", scholarshipAmount );
            }
            if(marks > 90 ){
                scholarshipAmount = fees*0.5;
                System.Console.WriteLine("Scholarship Amount : {0} ",scholarshipAmount);
            }

        }
      /* public static void Main(){
            
            Scholarship obj = new Scholarship();
            obj.Merit();

        }*/

    }
}