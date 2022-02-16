using System;

public class EMIException : Exception {
    public EMIException(string msg) : base(msg){

    }
}
class LoanProcess {
    int Loan_no;
    string Customer_Name;
    double LoanAmount, EMI_Amount, Account_Balance;

    public LoanProcess(int loan_no,string Customer_Name,double LoanAmount,int Account_Balance){
        this.Loan_no = loan_no;
        this.Customer_Name = Customer_Name;
        this.LoanAmount = LoanAmount;
        this.Account_Balance = Account_Balance;
    }
    public void calculate_EMI(){
        EMI_Amount = LoanAmount*0.13*3;
        System.Console.WriteLine("EMI Amount : "+EMI_Amount);
    }

    public void CheckBalance(){
        if(Account_Balance < EMI_Amount){
            throw new EMIException("Not Sufficient Balance to repay Loan");
        }
        else{
            System.Console.WriteLine("Sufficient Balance to repay Loan");
        }
    }

    public static void main(string[] args)
    {
        LoanProcess loan = new LoanProcess(101,"A",20000,1000);

        loan.calculate_EMI();

        try{
        loan.CheckBalance();
        }
        catch(Exception e){
            System.Console.WriteLine(e.Message);
        }
        finally{
            System.Console.WriteLine("Program Executed !!");
        }
    }
}