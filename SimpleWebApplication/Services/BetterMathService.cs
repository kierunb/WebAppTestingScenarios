using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApplication.Services
{
    public class BetterMathService
    {
        public int BetterAdd(int a, int b)
        {
            if (a == 666) return -666;

            return a + b;
        }
    }
}
