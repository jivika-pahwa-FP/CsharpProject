using System;

namespace FirstProject{

    sealed class SealedClass {

        public void test(){
            System.Console.WriteLine("Use this Exact !!");
        }
    }

    static class StaticClass {

        static int age{get;set;}
            
        public static int A {
            set{
                StaticClass.age = value;
            }
            get{
                return StaticClass.age;
            }
        }
        public static void check(){
            System.Console.WriteLine("static class can't be instantiated nor inherit "+StaticClass.A);
        }
    }
}