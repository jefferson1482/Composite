using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_Exposicion
{
    class Program
    {
        /*
         * 1. LO PRIMERO QUE DEBEMOS SABER
         Este patron no cumple con el principio de RESPONSABILIDAD ÚNICA (SRP).
         El patrón define una clase que va a tener dos responsabilidades 
        */
        static void Main(string[] args)
        {
            var troncoArbol = new Rama("Tronco");

            var ramaPrincipal = new Rama("Rama principal");
            ramaPrincipal.Brotar(new Hoja("Hoja1"));

            var ramaSecundaria = new Rama("Rama secundaria");
            ramaSecundaria.Brotar(new Hoja("Hoja1"));
            ramaSecundaria.Brotar(new Hoja("Hoja2"));

            var ramaConMuchasHojas = new Rama("Rama con muchas hojas");
            ramaConMuchasHojas.Brotar(new Hoja("Hoja1"));
            ramaConMuchasHojas.Brotar(new Hoja("Hoja2"));
            ramaConMuchasHojas.Brotar(new Hoja("Hoja3"));

            troncoArbol.Brotar(ramaPrincipal);
            troncoArbol.Brotar(ramaSecundaria);
            troncoArbol.Brotar(ramaConMuchasHojas);

            troncoArbol.Pintar(1);
            Console.ReadLine();
        }
    }
}
