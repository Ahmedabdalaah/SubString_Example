using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubString_Example
{
    internal class Substringg
    {
        public Substringg(string input,int first , int last)
        {
            try
            {
                string result = "";
                    result += input.ToString().Substring(first, last);
                Console.WriteLine(result);
            }
           catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
