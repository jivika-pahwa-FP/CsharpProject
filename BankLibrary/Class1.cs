using System;
using System.Collections.Generic;
using System.IO;
using BankLibrary.Models;
using System.Linq;

namespace BankLibrary
{
    public class SBAccountClass
    {
        public int AccountNo;
        public int CurrentBalance;
        public string AccountId, CustomerName , CustomerAddress;
        
            public SBAccountClass(){

            }
           public SBAccountClass(string id,int acc,string name,string addr,int bal){
            this.AccountId = id;
            this.AccountNo = acc;
            this.CustomerName = name;
            this.CustomerAddress = addr;
            this.CurrentBalance = bal;

            }
    }

    public class SBTransactionClass
    {
        public  int TransactionId,AccountNo,Amount;
        public  string TransactionType;
       public   DateTime TransactionDate;

        public SBTransactionClass(){}
       public SBTransactionClass(int TransactionId,DateTime dot,int AccountNo,int bal,string type){
            this.TransactionId = TransactionId;
            this.TransactionDate =  dot;
            this.AccountNo = AccountNo;
            this.Amount = bal;
            this.TransactionType =  type;
            
            }
    }

    public class BankRepository : IBankRepository{
        
        List<SBAccountClass> customer_list = new List<SBAccountClass>();
        List<SBTransactionClass> trans_list = new List<SBTransactionClass>();
        DatabaseTrainingContext db = new DatabaseTrainingContext();
        JivikaSbaccount table = new JivikaSbaccount();
        JivikaSbtransaction trans_table = new JivikaSbtransaction();

        public void NewAccount(SBAccountClass  acc){
            
        FileStream Log_file = new FileStream("Log_File.txt",FileMode.Append,FileAccess.Write);
        StreamWriter stream = new StreamWriter(Log_file);

            System.Console.WriteLine(" Enter following details : ");

            System.Console.WriteLine("Enter Account ID ");
            string acc_id = Console.ReadLine();

            System.Console.WriteLine("Enter Account Number ");
            int acc_no = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your Name ");
            string cust_name = Console.ReadLine();

            System.Console.WriteLine("Enter your Address ");
            string cust_add = Console.ReadLine();

            System.Console.WriteLine("Enter Current Balance ");
            int acc_bal = int.Parse(Console.ReadLine());

            table.Id = acc_id;
            table.AccountNo = acc_no;
            table.CustomerName = cust_name;
            table.CustomerAddress = cust_add;
            table.CurrentBalance = acc_bal;

            customer_list.Add(new SBAccountClass(acc_id,acc_no,cust_name,cust_add,acc_bal));
            db.JivikaSbaccounts.Add(table);
            db.SaveChanges();
        
            System.Console.WriteLine("New Account Successfully Added !");
            try{

            System.Console.WriteLine("Account number : {0} \n CustomerName : {1} \n CustomerAddress : {2} \n CurrentBalance : {3} ",
            acc_no,cust_name,cust_add,acc_bal);

            stream.WriteLine("Account number : {0} \t CustomerName : {1} \t CustomerAddress : {2} \t CurrentBalance : {3} \t Time : {4} ",
            acc_no,cust_name,cust_add,acc_bal,DateTime.Now);

            }
            catch(Exception e)
            {System.Console.WriteLine("Exception : "+e); }

            finally{ Log_file.Flush(); stream.Close(); }
        }
         public SBAccountClass GetAccountDetails(int accno){

             SBAccountClass sb = new SBAccountClass();
                bool flag = false;

           // System.Console.WriteLine("Enter account number : ");
            // accno = int.Parse(Console.ReadLine());

                foreach(var i in db.JivikaSbaccounts){
                if(i.AccountNo == accno ){
                    flag  = true;
                   //sb = i;
                System.Console.WriteLine("Account number present in the list : "+accno);
               // System.Console.WriteLine("Account number : {0} \n CustomerName : {1}",
                // i.AccountNo,i.CustomerName);
                }
                }
                if(flag){
                    return sb;
                }
                else {
                    System.Console.WriteLine("Account not found : "+accno);
                return null;
                }
         }

         public List<SBAccountClass> GetAllAccounts(){
             List<SBAccountClass> temp = new List<SBAccountClass>();

             foreach(var i in db.JivikaSbaccounts){

               temp.Add( new SBAccountClass(i.Id,i.AccountNo,i.CustomerName,
               i.CustomerAddress,i.CurrentBalance ));
                System.Console.WriteLine("Account number : {0} \n CustomerName : {1} \n CustomerAddress : {2} \n CurrentBalance : {3} ",
                 i.AccountNo,i.CustomerName,i.CustomerAddress,i.CurrentBalance);

             }
             return temp;
         }

         public void DepositAmount(int accno, int amt){
        
            int transId = db.JivikaSbtransactions.OrderByDescending(x => x.Id).FirstOrDefault().Id;
                bool b = false;

            FileStream Log_file = new FileStream("Log_File.txt",FileMode.Append,FileAccess.Write);
            StreamWriter stream = new StreamWriter(Log_file);

            SBAccountClass sb = new SBAccountClass();
            SBTransactionClass st = new SBTransactionClass();

            
            // System.Console.WriteLine("Enter account number : ");
            //  accno = int.Parse(Console.ReadLine());

                try{
                foreach(var i in db.JivikaSbaccounts){
                    if(i.AccountNo == accno){
                    i.CurrentBalance += amt;
                    b = true;
                    System.Console.WriteLine("Account balance updated  : "+i.CurrentBalance);

                     trans_table.Id = ++transId;
                    trans_table.Dot = DateTime.Now;
                    trans_table.Balance = i.CurrentBalance;
                    trans_table.AccountNo = i.AccountNo;
                    trans_table.Type = "Deposit";
                   st.TransactionType = "Deposited Rs."+amt;

                    stream.WriteLine("Account number : {0} \t TransactionType : {1} \t Time : {2} ",
                    i.AccountNo,st.TransactionType,DateTime.Now);
                    }
                }
                if(b == false){
                 System.Console.WriteLine("Account not found "+accno);
                }
                }
                catch(Exception e){System.Console.WriteLine(e);}
                finally{ Log_file.Flush(); stream.Close(); }
                
                    db.JivikaSbtransactions.Add(trans_table);
                    db.SaveChanges();
          }

        public void WithdrawAmount(int accno, int amt){
            
            int transId = db.JivikaSbtransactions.OrderByDescending(x => x.Id).FirstOrDefault().Id;
            bool b = false;

            FileStream Log_file = new FileStream("Log_File.txt",FileMode.Append,FileAccess.Write);
            StreamWriter stream = new StreamWriter(Log_file);
            SBAccountClass sb = new SBAccountClass();
            SBTransactionClass st = new SBTransactionClass();

            
            // System.Console.WriteLine("Enter account number : ");
            //  accno = int.Parse(Console.ReadLine());
            
                try{
                foreach(var details in db.JivikaSbaccounts){
                    if(details.AccountNo == accno){
                        if(details.CurrentBalance >= amt){
                            b = true;
                        details.CurrentBalance -= amt;

                        System.Console.WriteLine("Account balance updated  : "+details.CurrentBalance);
                   
                    trans_table.Id = ++transId;
                    trans_table.Dot = DateTime.Now;
                    trans_table.Balance = details.CurrentBalance;
                    trans_table.AccountNo = accno;
                    trans_table.Type = "Withdraw";
                    st.TransactionType = "Withdraw Rs."+amt;

                    stream.WriteLine("Account number : {0} \t TransactionType : {1} \t Time : {2} ",
                     details.AccountNo,st.TransactionType,DateTime.Now);

                    }
                    else{
                    throw new WithdrawnException(" Sorry !! Amount is Excedding the limit ! \n Your Acount have only : "
                    +details.CurrentBalance);
                    }
                    }
             }
             if(b == false){
                 System.Console.WriteLine("Account not found "+accno);
             }
                }
                catch(WithdrawnException e){ System.Console.WriteLine(e.Message);}
                catch(Exception e){System.Console.WriteLine(e);}
                finally{ Log_file.Flush(); stream.Close(); }
                
                    db.JivikaSbtransactions.Add(trans_table);
                    db.SaveChanges();
          }

         public void GetTransactions(int accno){
             
            System.Console.WriteLine("Enter account number : ");
             accno = int.Parse(Console.ReadLine());

            bool b = false;
            SBTransactionClass st = new SBTransactionClass();
            
            foreach(var i in db.JivikaSbtransactions){
                if(i.AccountNo == accno){
                    b = true;
                    Console.WriteLine("Account number : {0} \t TransactionType : {1} \t Time : {2} ",
                    i.AccountNo,i.Type,i.Dot);
                }
            }
            if(b == false){
                System.Console.WriteLine("Account number not found : "+accno);
            }
         }
    }
}
