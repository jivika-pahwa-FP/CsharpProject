using System;

namespace FirstProject{

    class overloadingClass{

        public int a, b, c;
        public string str1,str2,str3;
        public void swap(int a,int b){
           
            this.a = a; // 2
            this.b = b; // 4
            
             System.Console.WriteLine("before swapping \n a : {0} and b : {1} ",this.a,this.b);

             this.c = this.a; // 2
             this.a = this.b; // a = 4;
             this.b = this.c; // b = 2;
             System.Console.WriteLine("after swapping \n a : {0} and b : {1} ",this.a,this.b);

        }

        public void swap(string a,string b){

            this.str1 = a; // aa
            this.str2 = b; // bb
            
             System.Console.WriteLine("before swapping \n String1 : {0} and string2 : {1} ",this.str1,this.str2);

             this.str3 = this.str1; // aa
             this.str1 = this.str2; // bb
             this.str2 = this.str3; // aa
             System.Console.WriteLine("after swapping \n String1 : {0} and string2 : {1} ",this.str1,this.str2);

        }

        
    }
}