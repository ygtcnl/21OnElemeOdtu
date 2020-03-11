using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_OyunSalonu
{
    class Program
    {
        static void Main(string[] args)
        {
            string gameType = Console.ReadLine();

            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
        }
    }
}
