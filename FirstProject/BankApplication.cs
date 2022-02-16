using System;
using System.Collections.Generic;
using BankLibrary;
using BankFunctionality;

public class BankApplication{
         public static void Main(string[] args)
        {

            List<SBAccountClass> list = new List<SBAccountClass>();

            BankRepository bank = new BankRepository();
            SBAccountClass acc = new SBAccountClass();
            
           BankFunc bankFunc = new BankFunc();

            string ch = "No";
            int choice = 0;
            bool result = false;
            while(ch != "Yes" && ch != "yes"){
            
            System.Console.WriteLine("Menu Driven Application : \n 1. New Account \n 2. Get Account Details \n 3. Get All Accounts \n 4. DepositAmount \n 5. WithdrawAmount \n 6. GetTransactions \n 7. Transfer Fund \n 8. Raise Loan ");
            System.Console.WriteLine("Kindly enter your choice : ");
            result = int.TryParse(Console.ReadLine(),out choice);

            if(result){

             switch(choice){

                case 1 : bank.NewAccount(acc);
                break; 
                case 2 : bank.GetAccountDetails(0);
                break;
                case 3 : bank.GetAllAccounts();
                break;
                case 4 : bank.DepositAmount(0,2000);
                break;
                case 5 : try{bank.WithdrawAmount(0,28000);} catch(Exception){}
                break;
                case 6 : bank.GetTransactions(0);
                break;
                case 7 : bankFunc.FundTransfer();
                break;
                case 8 : bankFunc.RaiseLoan();
                break;
                default :  
                System.Console.WriteLine("wrong choice entered");
                 break;
             }
             System.Console.WriteLine("Want to exit ? enter Yes or yes");
             ch = Console.ReadLine();
            }
            
            if(!result){
                System.Console.WriteLine("Choice in Wrong format entered !!");
                break;
            }
            }
        
        }
}