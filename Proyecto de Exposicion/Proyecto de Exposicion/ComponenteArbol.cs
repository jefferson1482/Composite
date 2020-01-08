using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_Exposicion
{
    /*
     * 2.LO SEGUNDO QUE DEBEMOS SABER
     
     En este patron se aconseja utilizar clases ABSTRACTA , ya que con esto podremos implementar el máximo número de operaciones 
     en la clase Componente, de esta manera, tanto las Ramas como las Hojas que heredan de Componente ya tienen un comportamiento determinado
     
     NOTA:
     "En las clase abstracta pueden existir variables static, final o static final con cualquier modificador de acceso 
     (public, private, protected o default).En la interfaz sólo puedes tener constantes (public static final)"
     */
    public abstract class ComponenteArbol
    {
        //protected = es una palabra clave de un modificador de acceso de miembros
        protected ComponenteArbol(string nombreComponente)
        {
            Nombre = nombreComponente;
        }
        //Poder aplicar las mismas operaciones sobre cada uno de los nodos de la estructura
        protected string Nombre { get; }

        //Se crea una estructura de tipo árbol
        public abstract void Brotar(ComponenteArbol componente);
        public abstract void Cortar(ComponenteArbol componente);

        //Poder aplicar las mismas operaciones sobre cada uno de los nodos de la estructura
        public abstract void Pintar(int nivel);
    }
}
