
using System.Collections.Generic;

namespace firstmvcproj.Models{

    public class Stu {
        public int stud_id {get;set;}
        public string stud_name {get;set;}
        public int stud_age {get;set;}

        public Stu(){ }

        public Stu(int id,string name,int age){
            stud_id = id;
            stud_name = name;
            stud_age = age;
        }

        public static List<Stu> GetAllDetails(){

            List<Stu> list = new List<Stu>();
            list.Add(new Stu(101,"Raam",22));
            list.Add(new Stu(102,"Shyaam",20));
            list.Add(new Stu(103,"Arun",21));
            return list;
            
        }

    }
}