using System;

namespace FirstProject{

   public class Employee{
         int Empid ;
         string Empname ;
         float Salary ;

        public Employee(){
            
        }
         public Employee(int id,string name,float salary){
             this.Empid = id;
             this.Empname = name;
             this.Salary = salary;
         }
    }

    public class ParttimeEmployee  : Employee {
            int wages;
            public ParttimeEmployee(int wages){
                this.wages = wages;
                System.Console.WriteLine("Employee Wages : "+wages);
            }

    } 

    class mainClass{
        public static void main(string[] args)
        {
            // base class reference to call derived class constructor.
            Employee emp = new ParttimeEmployee(23000);   //  runtime polymorphism          
        }
    }  

}