using System;
using System.Threading;


namespace FirstProject{

    class threadClass{

        public static void main(string[] args)
        {
            Thread t = new Thread(WriteY);
            t.Start();
            Thread.Sleep(1000);
            t.Join();
            for(int i = 0 ; i< 1000 ; i++){
            System.Console.Write("X");
            }
        }
        static void WriteY(){
            for(int i = 0 ; i< 1000 ; i++){
            System.Console.Write("Y");
            }
        }
    }
}