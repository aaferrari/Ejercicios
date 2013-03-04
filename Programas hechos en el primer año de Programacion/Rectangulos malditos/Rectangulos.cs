using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangulo
{
    public class Rectangulo
    {
        private int ancho;
        private int alto;
        
        public int Ancho
        {
            set { ancho = value; }
            get { return ancho; }
        }
        public int Alto
        {
            set { alto = value; }
            get { return alto; }
        }

        public int superficie()
       /* { set {superficie = value;} //Como convertir un llamado de atributo en metodo en pocos segundos ;)
          get */ {return ancho * alto;}

        public int perimetro()
      /* {
           set { perimetro = value;}
           get */{return ancho*2 + alto*2;}

        
        public Rectangulo(int anc, int alt)
        {
            ancho = anc;
            alto = alt;
        }

        public string toString()
        {
            return "Ancho: " + ancho + "\n" +
               "Alto: " + alto +
            	"\nSuperficie: " +superficie()+ 
            	"\nPerimertro: " +perimetro();
        }
    }
}
