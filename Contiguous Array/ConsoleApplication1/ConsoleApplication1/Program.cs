using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Solution
    {
        public static int FindMaxLength(int[] nums)
        {
            // looks like a hashmap problem
            // not sure how to begin though

            /*
             * one other strategy: two stacks
             * stack up ones and stack up zeros
             * if, at any point, the count of the ones stack equals the count of the zeros stack...
             * current longest array = [# of ones] + [# of zeros]
             * 
             * [0,0,1,0,0,0,1,1]
             * 0, 0, 1 -> (2) and (1)
             * 0, 0, 0, 1 -> (5) and (2)
             * 1 -> (5) and (3)
             * 
             * how to decide in this case? pop as much as possible?
             * until the bigger stack equals the lower stack? then add them?
             * need another example...
             * 
             * [1,1,1,0,1,0,0,0,1,0]
             * 
             * 1,1,1,0 -> (3) and (1)
             * 1,0 -> (4) and (2)
             * 0,0 -> (4) and (4); so, current longest = 4 + 4 = 8
             * 1,0 -> (5) and (5)
             * current longest is no longer 8
             * current longest = 5 + 5 = 10
             * 
             * one more example...
             * 
             * [1,1,0,0,1,1,0,1,1]
             * 
             * 1,1,0 -> (2) and (1)
             * 0,1 -> (3) and (2)
             * 1,0 -> (4) and (3)
             * 1,1 -> (6) and (3)
             * 
             * at no point did the longest subarray reveal itself
             * but does the logic check out? seems to...
             * there are 6 ones and 3 zeroes; if 3 ones are removed...
             * the longest subarray SHOULD be length of 6
             * and one DOES exist - it is [1,(1,0,0,1,1,0),1,1]
             * ... but this isn't completely sound logic
             * 
             * [0,1,1,0,1,1,1,0]
             * 
             * 0,1 -> (1) and (1); current longest is 2
             * 1,0 -> (2) and (2); current longest is 4
             * 1,1,1,0 -> (5) and (3)
             * 
             * at a glance, the longest subarray is clearly the second longest (4)
             * because (0,1,1,0)...
             * but based on the logic above, it comes up as 6
             * and no subarray with length 6 exists...
             * 
             */

            /*
            Stack<int> ones = new Stack<int>();
            Stack<int> zeros = new Stack<int>();

            int i = 0;
            while (i != nums.Length)
            {
                if (nums[i] == 1)
                {
                    ones.Push(1);
                    if (ones.Count() == zeros.Count())
                        res = ones.Count() + zeros.Count();
                }
                else if (nums[i] == 0)
                {
                    zeros.Push(0);
                    if (ones.Count() == zeros.Count())
                        res = ones.Count() + zeros.Count();
                }
                else // ignore anything that isn't 0 or 1
                    i++;
                i++;
            }

            if (res != 0)
                return res;
            else if (ones.Count() > zeros.Count())
            {
                while (ones.Count() > zeros.Count())
                    ones.Pop();
            }
            else
            {
                while (zeros.Count() > ones.Count())
                    zeros.Pop();
            }
            res = ones.Count() + zeros.Count();
            return res;
            */

            // so using two stacks doesn't seem like it will work...
            // 477 / 564 passed
            // hashmap is the way to go

            int res = 0;
            int diff = 0;

            Dictionary<int, int> dict = new Dictionary<int, int>();

            dict[0] = -1; 
            // can't start out with an actual value... no length
            // so use -1 instead of 0

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                    diff += 1;
                else
                    diff -= 1;

                if (dict.ContainsKey(diff))
                    res = Math.Max(res, i - dict[diff]);
                else
                    dict[diff] = i;
            }

            return res;

            /* [0,1,1,0,1,1,1,0]
             * same example as before
             * 
             * 0 -> first diff will be -1
             * not a key in the dictionary, so add an entry
             * 1 -> second diff will be 0
             * an entry for 0 already exists; the initializer
             * if the diff is 0, that means a subarray has been found
             * so current max length will be whichever is currently bigger
             * that is, (current result) or ([however far into array] - [current existing entry for diff])
             */
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 0, 1, 0, 0, 1, 1, 0, 1, 0, 0, 1, 1, 1, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0, 1, 1 };
            int result = Solution.FindMaxLength(nums);
            Console.WriteLine(result);
        }
    }
}
