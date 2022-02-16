/*using System;

namespace FirstProject {

    class Customer{
        int Customerid,Age,Phone;
        string Name,City;
         DateTime dateofsale;

        public Customer(){
            System.Console.WriteLine("Default Constructor!");
        }

        public Customer(int Customerid,int Age,int Phone,string Name,string City){
            this.Customerid = Customerid;
            this.Age = Age;
            this.Phone = Phone;
            this.Name = Name;
            this.City = City;
        }
        
        public static void DisplayCustomer(Customer obj){
            System.Console.WriteLine("Customer ID : {0} ", obj.Customerid );
            System.Console.WriteLine("Customer Name : {0} ", obj.Name );
            System.Console.WriteLine("Customer Age : {0} ", obj.Age );
            System.Console.WriteLine("Customer Phone : {0} ", obj.Phone );
            System.Console.WriteLine("Customer city : {0} ", obj.City );

        }

        public static void Display(string first,string last){
            System.Console.WriteLine("First Name : {0} \n Second Name : {1} ", first,last.ToUpper());
        }

        public void SumOfDigit(int num){
            int sum = 0, rem = 0;
            while(num != 0){
                rem = num%10;
                sum += rem;
                num = num/10;
            }
            System.Console.WriteLine("sum : "+sum);
        }

        public static void Main()
        {
            
            Customer obj = new Customer(101,23,90909090,"Jivika","Delhi");
            Customer.DisplayCustomer(obj);

            string first = Console.ReadLine();
            string last = Console.ReadLine();
            Customer.Display(first,last);

            int number = Convert.ToInt32(Console.ReadLine());
            obj.SumOfDigit(number);
        
        }

    }
}*/