using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class FizzBuzz
    {
        public string printNo(int limit)
        {
           
                if((limit%5==0) && (limit%3 == 0))
                {
                    return "FizzBuzz";
                }
                else if(limit%3 == 0)
                {
                    return "Fizz";
                }else if (limit%5 == 0)
                {
                    return "Buzz";
                }
           
            return "";
        }
    }
}
