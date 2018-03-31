using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //base class
    public class ClassA : IAction
    {
        //accessible all
        public static int publicInt;
        //access only in the same assembly
        internal static int internalInt;
        //within the same class only
        private static int privateInt;
        //can be access by derived class
        protected static int protectedInt;
        //can be access by derived class and same assembly
        protected internal static int protectedInternalInt;

        public virtual void DoWork()
        {
           //logic implementation
        }
    }
}
