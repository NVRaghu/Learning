namespace Algorithms{
    using System;

    public class TwoDPeakType1{

        public static void Run()
        {
            int[][] input = new []{    new int[]{1,2,3,4,6},
                                       new int[]{4,5,6,7,1},
                                       new int[]{9,19,3,4,6},
                                       new int[]{3,5,7,9,11},
                                       new int[]{5,7,3,7,9}};
            foreach(int[] rows in input){
                foreach(int cell in rows)
                {
                    Console.Write("{0} ",cell);
                }
                Console.WriteLine();
            }
        }
    }

}