using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Formas
    {
        class Corazon : Paint
        {
            ///Contructor de los objetos tipo Corazón, y define de forma automática el atributo nombre de ese objeto como la cadena de texto "corazón" 
            ///
            public Corazon()
            {
                Nombre = "Corazon";
            }

            public string Nombre { get; }
        }

        class Estrella : Paint
        {
            public Estrella()
            {
                Nombre = "Estrella";
            }

            public string Nombre { get; }
        }

        class Rayo : Paint
        {
            public Rayo()
            {
                Nombre = "Rayo";
            }

            public string Nombre { get; }
        }
    }


}

