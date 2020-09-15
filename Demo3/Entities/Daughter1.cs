using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.Entities
{
    public class Daughter1 : Mother1
    {
        public override void DoSmt1()
        {
           Console.WriteLine("DoSmt1 - Daughther1");
        }
        
        public override void DoSmt4()
        {
           Console.WriteLine("DoSmt4 - Daughther1");
        }
    }
}
