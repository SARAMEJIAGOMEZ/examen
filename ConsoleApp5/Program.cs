using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Paint> lista = new List<Paint>();
            ///Generamos los objetos de las clases de forma
            ///
            var corazon = new Corazon();
            var estrella = new Estrella();
            var rayo = new Rayo();
            ///
            /// Añadimos los valores correspondientes a cada atributo de los objetos
            corazon.Borde = "negro";
            corazon.Fondo = "rojo";
            estrella.Borde = "amarillo";
            estrella.Fondo = "blanco";
            rayo.Borde = "negro";
            rayo.Fondo = "amarillo";
            ///
            /// Añadimos los objetos a la list lista
            lista.Add(corazon);
            lista.Add(estrella);
            lista.Add(rayo);
            ///Generamos el objeto salida, el comprobador de si alguien indica la salida
            ///
            var salida = new Output(Console.ReadLine, Console.WriteLine);
            ///
            /// Declaramos la variable exit como falsa

            var exit = false;
            do
            {
                ///
                /// Recorre la lista de objetos
                foreach (var forma in lista)
                {
                    forma.ImprimirForma();


                    ///
                    /// Imprime las características de las formas con el método ImprimirForma declarado en la clase Paint
                }
                ///
                /// Comprobante de que si después de imprimir las caracteristicas se escribe exit el valor de exit pasa a ser true
                exit = salida.Read() == "exit";

            } while (!exit);
            ///
            /// Realiza el bucle de impresión mientras no se escriba salida

        }

    }

}
  
