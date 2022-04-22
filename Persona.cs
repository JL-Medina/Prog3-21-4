/*Crear un programa en C# que solicite al usuario tres nombres de personas y los almacene 
en un lista de objetos de tipo Persona. Para ello, crear primero una clase Persona 
que tenga una propiedad Nombre de tipo string. 
Además, la clase persona debe sobreescribir el método ToString() produciendo el siguiente resultado: "Hola! mi nombre es {Nombre}.".
Finalizar el programa ejecutando el método ToString() para cada persona en la pantalla.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3_21_4
{
    public class Persona
    {
        private string _Name;
        public Persona(string name)
        {
            _Name = name;

        }

        public override string ToString()
        {
            return $"Hola! Mi nombre es {_Name}";
        }
    }
}
