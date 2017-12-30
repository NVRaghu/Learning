using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "0";

            if(args.Length >0){
                input = args[0];
                goto start;
            }

            Console.WriteLine("What do you what to Do ?");
            Console.WriteLine("1. One Dimention Peak with Binary Search");
            Console.WriteLine("2. Two Dimention Peak with Gready Ascend Algorith");
            Console.WriteLine("3. Two Dimention Peark with Binary Search with Column Splitting ");
            Console.WriteLine("3. Two Dimention Peark with Binary Search with Window Splitting ");

            input = Console.ReadLine(); 

            start:
            switch(input)
            {
                case "1":
                    OneDPeak.Run();
                    break;
                case "2":
                    TwoDPeakType1.Run();
                    break;
                case "3":
                    TwoDPeakType2.Run();
                    break;
                
            }

        
             //Peak(input,midpoint );
        }

        
    }
}
