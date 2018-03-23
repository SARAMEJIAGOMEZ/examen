using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class1
    {
        ///Definimos los atributos para las clases hijas de formas
        ///
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string borde;
        public string Borde
        {
            get { return borde; }
            set { borde = value; }
        }
        private string fondo;
        public string Fondo
        {
            get { return fondo; }
            set { fondo = value; }
        }
        ///Definimos las funciones y acciones para la clase hija Output
        Func<string> Read { get; set; }
        Action<string> Write { get; set; }
        ///Generamos el método ImprimirForma que imprimirá las caracteristicas de las formas
        ///
        ///Principio D ya que la función siguiente puede ser trasladada a otro código y seguir funcionando
        ///
        public void ImprimirForma()
        {
            Console.WriteLine("El nombre de la figura es " + Nombre + " cuyo color de borde es " + Borde + " y el color de fondo es " + Fondo);
        }



    }
}

