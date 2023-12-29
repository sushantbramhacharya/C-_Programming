using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_in_C_
{

    internal class InheritanceParent
    {
        protected InheritanceParent()
        {
            Console.WriteLine("This is Constructor of Parent");
        }
        internal void ParentMethod()
        {
            Console.WriteLine("Champa");
        }

        
    }

    class InheritanceChild:InheritanceParent
    {
        //Base Constructor
        //Parent Method Classes
        internal InheritanceChild() : base()
        {
            base.ParentMethod();
        }

    }
}
