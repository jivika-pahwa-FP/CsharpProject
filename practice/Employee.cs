using System;
using System.Collections;
using System.Collections.Generic;

namespace practice {
    public class Employee {
        
        int empID {get;set;}
        string empName {get;set;}

        public Employee(int id,string name){
            this.empID = id;
            this.empName = name;
        }

        public override string ToString()
        {
            return (empID+" : "+empName);
        }
    }
}