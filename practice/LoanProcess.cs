// using System;

// namespace practice{

//     public class LoanProcess{
//         int loanno;
//         string customername;
//         int loanAmount;
//         double emiAmount;
//         double accBal;

//         public LoanProcess(int loanno,string customername,double accBal){
//             this.loanno = loanno;
//             this.customername = customername;
//             this.accBal = accBal;
//         }

//         public void calculateEMI(int loanAmount){
//             this.emiAmount = loanAmount*0.13*3;
//             System.Console.WriteLine("EMI Amount : {0} ",emiAmount);
//         }

//         public void CheckBalance(){
//             if(accBal < emiAmount){
//                 throw new EMIException("Not Sufficient balancy to pay the Loan EMI");
//             }
//             else{
//                 accBal -= emiAmount;
//                 System.Console.WriteLine("Balance is sufficient : {0} ",accBal);
//             }
//         }

//         public static void Main(string[] args)
//         {
//             LoanProcess obj = new LoanProcess(101,"Jivika",5000);
//             obj.calculateEMI(35000);
//             try{
//                  obj.CheckBalance();
//             }
//             catch(EMIException e){
//                 System.Console.WriteLine(e.Message);
//             }
//             finally{
//                 System.Console.WriteLine("update your balance to stop inconvenience in future");
//             }

//         }
    
//     }
// }