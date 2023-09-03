using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Solution
    {
        public static bool StoneGame(int[] piles)
        {
            /*
            bool res = true;
            ConcurrentDictionary<int, int> stones = new ConcurrentDictionary<int, int>();

            for (int i = 0; i < piles.Length; i++)
                stones[i] = piles[i];

            int alice = 0, bob = 0, turn = 0;

            var keys = new List<int>(stones.Keys);

            while (stones.Count != 0)
            {
                if (turn % 2 == 0) // alice's turn
                {
                    if (stones[keys[0]] > stones[keys[keys.Count - 1]])
                    {
                        int popped;
                        stones.TryRemove(keys[0], out popped);
                        alice += popped;
                        keys.RemoveAt(0);
                    }
                    else
                    {
                        int popped;
                        stones.TryRemove(keys[keys.Count - 1], out popped);
                        alice += popped;
                        keys.RemoveAt(keys.Count - 1);
                    }
                        
                    turn++;
                }
                else // bob's turn
                {
                    if (stones[keys[0]] > stones[keys[keys.Count - 1]])
                    {
                        int popped;
                        stones.TryRemove(keys[0], out popped);
                        bob += popped;
                        keys.RemoveAt(0);
                    }
                    else
                    {
                        int popped;
                        stones.TryRemove(keys[keys.Count - 1], out popped);
                        bob += popped;
                        keys.RemoveAt(keys.Count - 1);
                    }
                    turn++;
                }
            }

            if (bob > alice)
                res = false;
            return res;
            */

            // ... game theory problem
            // 1) both players play optimally; will only choose piles that can lead to winning
            // 2) Alice gets to go first; in optimal play, the game is already skewed towards who goes first
            // => 3) no scenario exists where Alice does not choose an edge that will lead to winning
            // => Alice always wins
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] piles = { 3, 7, 2, 3 };
            bool result = Solution.StoneGame(piles);
            Console.WriteLine(result);
        }
    }
}
