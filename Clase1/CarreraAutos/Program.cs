using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAutos
{
    class AutoCarreras
    {
        
      public class AutoCarreras
        
        public float Peso;
        public string Modelo;
        public int Velocidad;

        static void Main(string[] args)
        {

            AutoCarreras Ferrari = new AutoCarreras();
                Ferrari.Modelo = "Ferrari F150";
                Ferrari.Peso = 1.3F;
                Ferrari.Velocidad = 230;

                AutoCarreras McLaren = new AutoCarreras();
                McLaren.Modelo = "McLaren A45S";
                McLaren.Peso = 0.98F;
                McLaren.Velocidad = 280;

            PistaCarreras hnsRodriguez = new PistaCarreras();
            hnsRodriguez.nombre = "Autodromo Hermanos Rodriguez"
        hnsRodriguez.longitud = 5.6f;
        hnsRodriguez.Competir(Ferrari, McLane)

        Console.Readline();

        }
    }
}
