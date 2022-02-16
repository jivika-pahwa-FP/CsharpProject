using System;
using System.Collections.Generic;

namespace BankLibrary
{
    interface IBankRepository {
        public void NewAccount(SBAccountClass  acc);
        public  SBAccountClass  GetAccountDetails(int accno);
        public List<SBAccountClass> GetAllAccounts();
          public void DepositAmount(int accno, int amt);
         public void WithdrawAmount(int accno, int amt);
         public void GetTransactions(int accno);

    }
}