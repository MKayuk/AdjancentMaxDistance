using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentMaxDistance_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine("Adjacent Max Distance: " + solution.Resolve(new int[] { 0, 3, 3, 7, 5, 3, 11, 1 }));
            Console.WriteLine("Adjacent Max Distance: " + solution.Resolve(new int[] { 0, 3, 3, 12, 5, 3, 7, 1 }));
            Console.ReadLine();
        }
    }
}
