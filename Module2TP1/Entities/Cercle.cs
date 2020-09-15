using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Module2TP1
{
    public class Cercle : Forme
    {

         private int rayon;
        
        public Cercle(double rayon, double aire, int perimetre)
        {
            this.rayon = rayon;
            this.aire = aire;
            this.perimetre = perimetre;
            
        }

        public int Rayon
        {
            get { return rayon; }
            set { rayon = value; }
        }
       

        public double Aire
        {
            get { return aire; }
            set { aire = Math.PI*rayon*rayon; }
        }


        public int Perimetre
        {
            get { return perimetre; }
            set { perimetre = 2*Math.PI*rayon; }
        }


        public override void Show()
        {
        Console.WriteLine(String.Format("{0} {1} {2}", this.rayon, this.aire, this.perimetre));
        }
    }
}
