using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndMovingTilesFromHackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
            int queryNumber = Convert.ToInt32(Console.ReadLine());
            double root2 = Math.Pow(2.0, 0.5);

            for(int i=0;i<queryNumber;i++)
            {
                ulong area = Convert.ToUInt64(Console.ReadLine());
                double length = Math.Pow((double)area, 0.5);
                double fark = (input[0] - length) * 2;
                double result = fark / (root2);
                Console.WriteLine(result);
            }
        }
    }
}
