using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Module2TP1
{
    public class Rectangle : Forme
    {

        private int longueur;
		private int largeur;


         public int Longueur
	     {
		    get { return longueur;}
		    set { longueur = value;}
	     }

		 public int Largeur
	     {
		    get { return largeur;}
		    set { largeur = value;}
	     }

		public override double Aire
	    {
		    get { return aire;}
		    set { aire = longueur*largeur;}
	    }

		public int Perimetre
	     {
		    get { return perimetre;}
		    set { perimetre = longueur*largeur*2;}
	     }

		 public override void Show()
         {
			Console.WriteLine(String.Format("{0} {1} {2} {3}", this.longueur, this.largeur, this.aire, this.perimetre));
         } 

    }
}