
namespace Algorithms{
    using System;
    using System.Collections.Generic;

    public class threeSum
    {

        public static void Run()
        {
            var output =  new threeSum().ThreeSum(new int[]{-1, 0, 1, 2, -1, -4});

            // foreach(var values in output){
                
            //     string strg = "{" ;
            //     foreach(int value in values){
            //         strg = strg + "," + value;
            //     }
            //     strg = strg + "}" ;

            //     Console.Write(strg);
            // }


        }
        public IList<IList<int>> ThreeSum(int[] nums) {

            var results = new  List<IList<int>>();

            var combination = new List<int>();
            FindSumHelper(nums,combination,ref results);

            return results;
        }


        public void FindSumHelper(int[] nums, List<int> combinations, ref List<IList<int>> results)
        {
            if(combinations.Count == 3)
            {
                if(CheckZeroSum(combinations)) {
                    results.Add(combinations);
                }
            }
            else{
                
                for(int i = 0 ; i < nums.Length;i++)
                {
                    //Choose
                    combinations.Add(nums[i]);

                    //Remove
                    var subArray = new int[nums.Length -1];
                   // nums.CopyTo(subArray,i +1);
                    Array.Copy(nums,1,subArray,0,subArray.Length);
                    FindSumHelper(subArray,combinations, ref results);

                    //unchoose
                    combinations.RemoveAt(combinations.Count - 1 );

                }
            }

        }


        private bool CheckZeroSum(List<int> solutions){

            int sum = 0;

            foreach(int i in solutions){
                sum += i;
            }

            if(sum ==0) return true;
            else return false;
        }
    }
}



// public class Solution {
//     public IList<IList<int>> ThreeSum(int[] nums) {
        
//     }
// }