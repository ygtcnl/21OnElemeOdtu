using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantMail
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputChar = input.ToCharArray();
            //true ise sona false ise basa ekleyecek
            bool beginOrEnd = true;
            string result = "";
            string temp = "";
            bool test = false;
            for(int i=0;i<input.Length;i++)
            {
                if (input[i] == '[')
                {
                    beginOrEnd = false;
                    result = result + temp;
                    temp = "";

                }
                if (input[i] == ']')
                {
                    beginOrEnd = true;
                    result = temp + result;
                    temp = "";

                }
                else if(beginOrEnd==true&&(input[i]!='['))
                {
                    temp = temp + input[i];
                }
                else if(beginOrEnd==false && (input[i] != '['))
                {
                    temp = temp + input[i];
                }
            }
            if (beginOrEnd == true)
                result =result+temp;
            else
                result = temp+result;
        }
    }
}
