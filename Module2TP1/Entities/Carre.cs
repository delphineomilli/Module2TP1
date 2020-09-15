using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Module2TP1
{
    public class Carre : Rectangle
    {
        private int longueur;
 
         public int Longueur
	     {
		    get { return longueur;}
		    set { longueur = value;}
	     }

        
	    public double Aire
	    {
		    get { return aire;}
		    set { aire = longueur*longueur;}
	    }

		 public int Perimetre
	     {
		    get { return perimetre;}
		    set { perimetre = longueur*4;}
	     }

		 public override void Show()
         {
			Console.WriteLine(String.Format("Carré de côté = {0} \n {1} \n {2}", this.longueur, this.aire, this.perimetre));
         } 
		
        
    }
}