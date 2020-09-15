using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Module2TP1
{
    public class Triangle : Forme
    {
        private int a;
		private int b;
		private int c;
		private int p;
       

         public int A
	     {
		    get { return a;}
		    set { a = value;}
	     }

         public int B
	     {
		    get { return b;}
		    set { b = value;}
	     }

         public int C
	     {
		    get { return c;}
		    set { c = value;}
	     }
    
          
	    public double Aire
	    {
		    get { return aire;}
		    set { 
				p = perimetre / 2;
				aire = Math.Sqrt(p*(p - a)*(p - b)*(p - c));
			}
	    }

		 public int Perimetre
	     {
		    get { return perimetre;}
		    set { perimetre = a + b + c;}
	     }

		 public override void Show()
			{
			Console.WriteLine(String.Format("{0} {1} {2} {3} {4} {5}", this.a, this.b, this.c, this.aire, this.perimetre));
			}

    }
}