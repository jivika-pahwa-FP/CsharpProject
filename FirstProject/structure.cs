using System;

namespace FirstProject{

    struct Books{

   private string title, author, subject;
   private int book_id;

   public void GetValues(string title,string author,string subject,int id){
       this.title = title;
       this.author = author;
       this.subject = subject;
       this.book_id = id;

   }
   public void ShowValues(){
       System.Console.WriteLine("BookID : {0} \n Title : {1} \n Author : {2} \n Subject : {3} "
       ,this.book_id,this.title,this.author,this.subject);
   }

    }

    class TestStructures {
        Books b ;
        public TestStructures(){
        b.GetValues("Harry Potter","J.K. Rowling","English",121);
        b.ShowValues();
        }

    }
}