using System;
using System.Collections;
using System.Collections.Generic;

namespace FirstProject{

    class Practice4{

        public static void Main() {
            
            int[] arr = {2,3,4,5,67,8};

            ArrayList list = new ArrayList();
            List<int> list2 = new List<int>();
            

            foreach(var i in arr){
                list.Add(i);
                list2.Add(i);
                // System.Console.Write(i+"\t");
            }

            foreach(var i in list){
                // list.Add(i);
                System.Console.Write(i+"\t");
            }       
            System.Console.WriteLine();
            foreach(var i in list2){
                // list.Add(i);
                System.Console.WriteLine( i*2 +"\t");
            }
        }
            
    }

    

}