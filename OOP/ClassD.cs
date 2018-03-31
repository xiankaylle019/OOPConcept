using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class ClassD : ClassC
    {
        public override void DoWork()
        {
           //implentation
        }
        public override void DoWorkA()
        {
            // implement do work a
        }

        public sealed override void DoWorkB()
        {
           // implement do work b
        }
    }
}
