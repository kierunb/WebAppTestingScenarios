using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApplication.Services
{
    public class AdvancedMathEngine : IAdvancedMathEngine
    {
        public bool VerifyInput(int input)
        {
            return input % 2 == 0;
        }
    }
}
