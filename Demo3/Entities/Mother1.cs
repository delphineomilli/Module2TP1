using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.Entities
{
    public abstract class Mother1 : Interface2
    {
        public abstract void DoSmt1();

        public int DoSmt2()
        {
            return 2;
        }

        protected void DoSmt3()
        {
            Console.WriteLine("DoSMT3 - Mother1");
        }

         protected void DoSmt4()
        {
            Console.WriteLine("DoSMT4 - Mother1");
        }

    }


}
