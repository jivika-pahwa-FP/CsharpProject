// using System;
// using System.Linq;

// namespace practice{
//     class lambda{
//         public static void Main(string[] args)
//         {
//             int[] numbers = {2,3,4,5,6};
//             var squareOfNumbers = numbers.Select(x=> x*x);
//             var evenNumbers = numbers.Count(x=> x%2 == 0);
//             var oddnumbers = numbers.Count() - evenNumbers;

//             System.Console.WriteLine("Even numbers : {0} \n Odd Numbers : {1} ",evenNumbers,oddnumbers);
            
//             foreach (var item in squareOfNumbers)
//             {
//                 System.Console.Write(" \t "+item);
//             }
//         }
//     }
// }