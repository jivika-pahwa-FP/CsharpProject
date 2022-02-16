using System;

namespace FirstProject{

    abstract class Student{
       /* string Name;
        int  StudentId;
        float Grade;*/

       public abstract  bool Ispassed(float grade);
    }

    class Undergraduate : Student{
       public override bool Ispassed(float grade){
           bool b = false;
           if(grade > 70.0){
                 b  = true;
                return b;
           }
            return b;
       }
    }

    class Graduate : Student{
        public override bool Ispassed(float grade){
           bool b = false;
           if(grade > 80.0){
                 b  = true;
                return b;
           }
            return b;
       }
    }

    class display{
        public static void main(string[] args)
        {
            Graduate gr = new Graduate();
            Undergraduate un = new Undergraduate();
            bool gr_grade = gr.Ispassed(60.19f);
            if(gr_grade == false){
                System.Console.WriteLine("Graduate grade : Fail");
            }
            else{
                System.Console.WriteLine("Graduate grade : Pass");
            }

            bool un_grade = un.Ispassed(82.89f);
            if(un_grade == false){
                System.Console.WriteLine("UnderGraduate grade : Fail");
            }
            else{
                System.Console.WriteLine("UnderGraduate grade : Pass");
            }

        }
    }
}