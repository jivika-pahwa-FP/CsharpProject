using System;
using System.Collections;

namespace FirstProject{

    class Practice5{
        
        public static void Main(){

            string[] fruitsName = {"mango","cherry","banana","litchii"};
            Queue fruits = new Queue();

            foreach(var i in fruitsName){
                fruits.Enqueue(i);
            }

            System.Console.WriteLine("elements in queue : "+fruits.Count);
            System.Console.WriteLine("element at Beginning : "+fruits.Peek());
            foreach(var i in fruits){
                System.Console.Write(i+"\t");
            }

            // stack Operation

            string[] stationery = {"pencil","pen","eraser","rubber"};
            Stack stationery_stack = new Stack();

            System.Console.WriteLine("\n stack operation.... #PUSH");
            foreach(var i in stationery){
                stationery_stack.Push(i);
            }

            System.Console.WriteLine("elements in Stack : "+stationery_stack.Count);
            System.Console.WriteLine("element at Beginning : "+stationery_stack.Peek());

            foreach(var i in stationery_stack){
                System.Console.Write(i+"\t");
            }

            System.Console.WriteLine("\n stack operation.... #POP");

            // System.Console.WriteLine(stationery_stack.Pop());
            
            for(var i = stationery_stack.Count ; i > 0 ; i--){
                System.Console.Write(stationery_stack.Peek()+"\t");
                stationery_stack.Pop();
            }

        }
    }
}