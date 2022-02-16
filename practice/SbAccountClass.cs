using System;
using System.Collections.Generic;
using System.Linq;
using practice.Models;

namespace practice{

    public class SbAccountClass{
        
        public int? AccountNo;
        public int CurrentBalance;
        public string AccountId, CustomerName , CustomerAddress;
        public SbAccountClass(){}
           public SbAccountClass(string id,int acc,string name,string addr,int bal){
            this.AccountId = id;
            this.AccountNo = acc;
            this.CustomerName = name;
            this.CustomerAddress = addr;
            this.CurrentBalance = bal;

            }
    }
}
    