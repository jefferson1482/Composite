using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_Exposicion
{
    /*
     *3.LO TERCERO QUE DEBEMOS SABER
     
     Deberemos escoger entre TRANSPARENCIA o SEGURIDAD cuando utilizamos este patrón se selecciona cuidadosamente 
     lo que mas no interesa: las transparencia (código sencillo) o la seguridad (código que no falla).
     * */
    public class Rama : ComponenteArbol
    {
        private readonly List<ComponenteArbol> componentes;

        public Rama(string nombre) : base(nombre)
        {
            componentes = new List<ComponenteArbol>();
        }

        public override void Brotar(ComponenteArbol componente)
        {
            componentes.Add(componente);
        }

        public override void Cortar(ComponenteArbol componente)
        {
            componentes.Remove(componente);
        }

        public override void Pintar(int nivel)
        {
            Console.WriteLine(new String('-', nivel) + " " + Nombre);

            foreach (ComponenteArbol hojaORama in componentes)
            {
                hojaORama.Pintar(nivel + 1);
            }
        }
    }
}
