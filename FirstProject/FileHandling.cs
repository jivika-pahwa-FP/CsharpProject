using System;
using System.Collections.Generic;
using System.IO;

namespace FirstProject{

    class FileHandling{
        public static void main(string[] args)
        {
                List<Emp> emp = new List<Emp>();
                emp.Add(new Emp( 101," Employee1 ",35000,DateTime.Now) );
                emp.Add(new Emp( 102," Employee2 ",35000,DateTime.Now) );
                emp.Add(new Emp( 103," Employee3 ",35000,DateTime.Now) );
                
                FileStream  file = new FileStream("file1.txt",FileMode.Append,FileAccess.Write);
                StreamWriter sw = new StreamWriter(file);
            try{
                foreach(var i in emp){
                sw.WriteLine( i.AddAccount() );
                }
                System.Console.WriteLine("Data Written !!");
            }
            catch(Exception e){
                System.Console.WriteLine(e.Message);
            }
            finally{
                sw.Flush();
                file.Close();
            }
        }
    }
}