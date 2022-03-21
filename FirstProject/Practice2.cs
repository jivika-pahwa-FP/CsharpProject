using System;

namespace FirstProject
{
    class VoteException : Exception
    {
        public VoteException(string message) : base(message){}
    }
    class Practice2
    {
        public static void checkAge(int age)
        {
            if (age >= 18)
            {
                System.Console.WriteLine("Eligible to vote !! ");
            }
            else
            {
                throw new VoteException("Not Eligible to vote !! ");
            }
        }

        public static void main()
        {

            System.Console.WriteLine("back to csharp again !! ");
            System.Console.Write("Enter your Age : ");

            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (result)
            {
                try
                {
                    Practice2.checkAge(age);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine("Exception Message : " + e.Message);
                    System.Console.WriteLine("Exception Type : " + e.GetType());
                }
            }
            else
            {
                System.Console.WriteLine("wrong format entered !!");
            }


        }

    }
}