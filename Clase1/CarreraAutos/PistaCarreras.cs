using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAutos
{
    class PistaCarreras
    {
        public string nombre;
        public float longitud;

        public void Competir(AutoCarreras auto1, AutoCarreras auto2)
        {
            Console.WriteLine("Inciando carrera entre" + auto1.modelo + "y" + auto2.modelo)

            if (auto1.velocidad > auto2.velocidad)
            {
                Console.WriteLine("Ganó" + auto1.modelo);
            }

            else
            {
                Console.WriteLine("Hubo empate");
            }
            
   
    }
}
