using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstProject {
    class Cricket{

        List<double> score = new List<double>();
      public void  Pointscalculation(int no_of_matches) {
        
        System.Console.WriteLine("Enter number of matches : ");
        int noOfmatches = int.Parse(Console.ReadLine());
        var sum = 0.0 ;
        var  avg = 0.0;
        
        System.Console.WriteLine("Enter {0} Marks per match ",noOfmatches);
        for(int i = 0 ; i < noOfmatches ; i++){
            double marks = double.Parse(Console.ReadLine());
            score.Add(marks);
            sum = score.Where(marks=> marks>0).Sum();
            avg = score.Where(marks => marks > 0 ).Average();
        }
        System.Console.WriteLine("Sum of scores : {0} ",sum);
        System.Console.WriteLine("Average of scores : {0} ",avg);
      }

      public static void main(string[] args)
      {
          Cricket c = new Cricket();
          c.Pointscalculation(0);

      }
    }
}