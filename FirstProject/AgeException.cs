using System;

namespace FirstProject{

    class AgeException : Exception{
            public AgeException(string message) : base(message){

            }
    }

    class VotingSystem {
        int age;
        public void checkAge(){

            System.Console.WriteLine("Enter Age : ");
            bool ans = int.TryParse(Console.ReadLine(),out age); //return boolean value

            if(ans == true){
            if(age >= 18 ){
                System.Console.WriteLine("eligible to vote ");
            }
            else{
                    throw new AgeException("not eligible to vote !");
            }
            }
            else{
                System.Console.WriteLine("Age entered in wrong format !");
            }

        }
    }
}