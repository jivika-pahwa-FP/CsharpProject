using System;
using System.Collections.Generic;
using System.Linq;
using practice.Models;

namespace practice{

    public class EFCore{
        readonly DatabaseTrainingContext db = new DatabaseTrainingContext();
       readonly JivikaSbaccount table = new JivikaSbaccount();

        public EFCore(){}

        public void display(){
            
            //SbAccountClass account = new SbAccountClass();

            // List<SbAccountClass> temp = new List<SbAccountClass>();
            
            foreach(var i in db.JivikaSbaccounts){
                
              // temp.Add( new SbAccountClass(i.Id,(int)i.AccountNo,i.CustomerName,
              // i.CustomerAddress,(int)i.CurrentBalance ));
                System.Console.WriteLine(i.Id+" : "+i.CustomerName+" : "+i.CurrentBalance);
            }
        }

        public void addAccount(string id,int acc,string name,string addr,int bal){
            
            table.Id = id;
            table.AccountNo = acc;
            table.CustomerName = name;
            table.CustomerAddress = addr;
            table.CurrentBalance = bal;

            try{
            db.JivikaSbaccounts.Add(table);
            db.SaveChanges();
            System.Console.WriteLine("Account added !!");
            }
            catch(Exception e){System.Console.WriteLine(e.Message);}
        
        }
        public static void Main(string[] args)
        {
            EFCore obj = new EFCore();
            obj.addAccount("106",106,"Ajay","Delhi",25000);
            obj.display();
            
        }
    }
}