// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Linq;

// namespace practice{
//         class FileHandling{

//             public static void Main(string[] args)
//             {
//                 List<Employee> list = new List<Employee>();
//                 list.Add(new Employee(101,"Raam"));
//                 list.Add(new Employee(102,"Shyaam"));
//                 list.Add(new Employee(103,"Seeta"));
//                 list.Add(new Employee(104,"Geeta"));

//                 try{
//                     using(FileStream file = new FileStream("File.txt",FileMode.OpenOrCreate)){
//                     //   using(StreamWriter sw = new StreamWriter(file)){
//                     //         foreach(var emp in list){
//                     //         sw.Write(emp.ToString()+"\t");
//                     //     }
//                     string line = "";
//                     using(StreamReader sr = new StreamReader(file)){
//                         while( (line = sr.ReadLine() ) != null )
//                             System.Console.WriteLine(line);
//                         }
//                       }
//                     }
//                     //System.Console.WriteLine("File Created !!");
//                 catch(Exception e){
//                     System.Console.WriteLine(e.Message);
//                 }
//                 // finally{
//                 //     sw.Flush();
//                 //     file.Close();
//                 // }

//             }

//         }
//     }
