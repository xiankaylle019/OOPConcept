using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public sealed class SealedClass
    {
        public void DoWork() {

            StaticMethodOverloading staticMethod = new StaticMethodOverloading();

            int twoNumbers =  staticMethod.SumNumbers(1, 2);

            int threeNumbers = staticMethod.SumNumbers(1, 2, 3);

            int thfourNumbers = staticMethod.SumNumbers(1, 2, 3, 4);
        }
    }
}
