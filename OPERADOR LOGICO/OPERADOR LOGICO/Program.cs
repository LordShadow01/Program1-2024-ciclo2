using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERADOR_LOGICO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores logicos ejemplo
            int respuesta = 5 + 8 - 2 * 5 / 4 + 1; //12.00
            Console.WriteLine("La respuesta es: {0})", respuesta);

            Console.WriteLine("La division de 5/4 es {0}", 5 / 4);
            //pausa
            Console.ReadLine();
        }
    }
}
