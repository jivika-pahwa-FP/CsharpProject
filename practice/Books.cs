using System;
using System.Collections;
using System.Collections.Generic;

namespace practice {
    public class Books {
        
        int BookID {get;set;}
        string BookName {get;set;}
        string AuthorName {get;set;}

        public Books(){}
        public Books(int id,string bookname,string authname){
            this.BookID = id;
            this.BookName = bookname;
            this.AuthorName = authname;
        }

        public void show(){
            System.Console.WriteLine("{0} {1} {2} ",BookID,BookName,AuthorName);
        }

    }
}