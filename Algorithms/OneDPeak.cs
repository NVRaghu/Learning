
namespace Algorithms
{
using System;
using System.Diagnostics;

public class OneDPeak
{
        static int[] input  = new int[]{1,2,3,4,5,7,64,32,10,13,7};

        public static void Run()
        {
           
            foreach(int i in input) Console.Write("{0} ",i);

            Console.WriteLine("");

            var stopWatch =Stopwatch.StartNew();
            Peak(input,input.Length/2);
            stopWatch.Stop();
            Console.WriteLine( "Time elapse in milliseconds : {0}", stopWatch.ElapsedMilliseconds);
        }

       static void Peak(int[] values, int positionOfInterest )
        {

            Console.WriteLine("Value at Position {0} is {1}",positionOfInterest,values[positionOfInterest]);

            if(positionOfInterest == values.Length && values[positionOfInterest] >values[positionOfInterest -1] )
            {
                   Console.WriteLine("Peak is {0} at {1}",values[positionOfInterest],positionOfInterest);
                   return ;
            }
            
            if( positionOfInterest >0 && values[positionOfInterest] < values[positionOfInterest -1])
            {
                 Peak(values,positionOfInterest -1);
            }
            else if( positionOfInterest < values.Length -1 && values[positionOfInterest] < values[positionOfInterest + 1])
            {
                 Peak(values,positionOfInterest+1);
            }
            else{
                Console.WriteLine("Peak is {0} at {1}",values[positionOfInterest],positionOfInterest);
                return;
            }
        }
    }
}

