using System;
using System.Collections;
using System.Collections.Generic;

namespace FirstProject{

    class Emp{
        static int Eid;
        string name;
        float sal;
        DateTime doj;
        public Emp(int id,string name,float sal,DateTime date){
        Emp.Eid = id;
        this.name = name;
        this.sal = sal;
        this.doj = date;
    }

    public override string  ToString(){
          return string.Format(Eid+" "+name+" Rs."+sal+" "+doj);
    }

     public string AddAccount(){
        return string.Format(Emp.Eid+" "+name+" Rs."+sal+" "+doj);
    } 

    }

    
}