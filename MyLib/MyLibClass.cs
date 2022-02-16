using System;

namespace MyLib
{
    public class MyLibClass : IMyService
    {
        public void getAge()
        {
            System.Console.WriteLine("My Age is 23");
        }

        public void getName()
        {
            System.Console.WriteLine("My Name is Jivika ");
        }
    }
}
