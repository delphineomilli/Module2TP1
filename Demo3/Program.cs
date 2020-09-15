using Demo3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    public class Program
    {
        static void Main(string[] args)
        {
        Daughter1 d1 = new Daughter1();
        Mother1 d2 = new Daughter1();
        //  Mother1 d3 = new Mother1();  impossible

            d1.DoSmt1();
            d1.DoSmt4();
            (d1 as Mother1).DoSmt4();
            
            d2.DoSmt1();
            d2.DoSmt4();

            Console.ReadKey();
        }
    }
}
