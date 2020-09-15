using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Module2TP1
{
    public abstract class Forme
    {
        private double aire;
        private int perimetre;


        public virtual double Aire { get => aire; private set => aire = value; }
        public virtual int Perimetre { get => perimetre; private set => perimetre = value; }

       public virtual void Show()
        {
        Console.WriteLine();
        }
    }
}