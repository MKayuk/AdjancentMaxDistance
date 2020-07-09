using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentMaxDistance_Test
{
    class Solution
    {
        public int Resolve(int[] A)
        {
            int maxDistance = 0;
            int auxDistance = 0;
            int i = 0;

            while (i < A.Length)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A.Any(x => (x > A[i] && x < A[j]) || (x > A[j] && x < A[i])))
                        continue;
                    else
                    {
                        auxDistance = A[i] - A[j];
                        if (auxDistance > maxDistance)
                            maxDistance = auxDistance;
                    }
                }
                i++;
            }
            return maxDistance;
        }
    }
}
