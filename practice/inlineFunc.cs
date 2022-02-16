// using System;

// namespace practice{
//     class inlineFun{

//         public delegate void inline();
//         public delegate int anony(int a,int b);
//         public delegate void myName();
//         public delegate int add();

//         public void name(){
//             System.Console.WriteLine("void delegate");
//         }

//         public int sum(){
//             return 2+8;
//         }

//         public static void Main(string[] args)
//         {
//             inlineFun obj = new inlineFun();

//             myName del = new myName(obj.name);
//             add del2 = new add(obj.sum);

//             inline inlineObj = delegate(){
//                 System.Console.WriteLine("Inline/Anonymous Function using delegate");
//             };

//             anony anonyObj = delegate(int a,int b){
//                 return a+b;
//             };

//             del();
//             inlineObj();
//             System.Console.WriteLine(del2());
//             System.Console.WriteLine(" anonymous function with int return type {0} ",anonyObj(2,9));
//         }
//     }
// }