using System;

namespace FirstProject{

    class BankingException : Exception{
            public BankingException(string message) : base(message){

            }
    }

    class ATM {
        int amount;
         int balance = 20000;
        public void checkWithdraw(){

            System.Console.WriteLine("Account Balance : {0} ",balance);
            System.Console.WriteLine("Enter Amount to withdraw: ");
            bool ans = int.TryParse(Console.ReadLine(),out amount); //return boolean value

            if(ans == true){
            if(amount > 20000 || amount >= 19000 ){
                    throw new BankingException("Either amount is excedding the limit or its below minimal !");
            }
            else{
                    balance -= amount;
                    System.Console.WriteLine("Updated Bank Balance : {0} ",balance);
            }
            }
            else{
                System.Console.WriteLine("Amount entered in wrong format !");
            }

        }
    }
}