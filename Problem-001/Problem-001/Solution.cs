using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_001
{
    internal class Solution
    {
        public static Boolean ContainsDuplicate(int[] nums)
        {
            HashSet<int> seenNumbers = [];

            foreach (int num in nums)
            {
                if (!seenNumbers.Add(num))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
