/* namespace FirstProject {

    class data {
        public int eng,maths;

    }

    class DataType{

        public static void Main(){
            
        data d1 = new data();
        data d2 = new data();
        
        d2 = d1; // In class, both obj will share same memory space unlike, structures.

        d1.eng = 80;
        d1.maths = 100;

        System.Console.WriteLine("eng : {0} \n maths :{1} ",d1.eng,d1.maths);
        System.Console.WriteLine("eng : {0} \n maths :{1} ",d2.eng,d2.maths);

        }

    }
}*/