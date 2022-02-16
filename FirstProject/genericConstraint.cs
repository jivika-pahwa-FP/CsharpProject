/* using System;
using System.Collections.Generic;

namespace FirstProject{
public class List<T> where T : IEmployee{

}

public interface IEmployee{
    public void display();
}

public class customer : IEmployee{
    public void display(){
        System.Console.WriteLine("Displaying....");
    }
}

public class genericConstraint{
    public static void Main(string[] args)
    {
        List<customer> list = new List<customer>();
        
    }
}

}
 */