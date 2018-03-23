using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
   
        public class Output 
        {

            public Func<string> Read { get; set; }
            public Action<string> Write { get; set; }
            /*Constructor de los objetos tipo Output*/
            public Output(Func<string> leer, Action<string> escribir)
            {
                Write = escribir;
                Read = leer;
            }

        }
    }




