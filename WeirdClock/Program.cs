using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeirdClock
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
            double oran = 1;
            List<int> saatler = new List<int>();
            for(int i=0;i<input[1];i++)
            {
                int toIn = Convert.ToInt32(Console.ReadLine());
                saatler.Add(toIn);
            }
            int seconds = Convert.ToInt32(Console.ReadLine());
            foreach(int i in saatler)
            {
                oran *= (1-Math.Abs((double)i * (double)seconds / (double)input[0]));
            }
            Console.WriteLine(1-oran);
        }
    }
}
