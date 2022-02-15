using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApplication.Services
{
    public class AdvancedMathService
    {
        private readonly IAdvancedMathEngine _engine;

        public AdvancedMathService(IAdvancedMathEngine engine)
        {
            _engine = engine;
        }
        public int BetterAdd(int a, int b)
        {
            _engine.VerifyInput(a);

            if (a == 666) return -666;

            return a + b;
        }
    }
}
