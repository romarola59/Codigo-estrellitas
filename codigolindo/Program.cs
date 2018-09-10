using System;
using System.IO;
using static System.Net.WebRequestMethods;

namespace codigolindo
{
    class Program
    {
        static void Main(string[] args)
        {
                   Console.Clear();
            // dibujo de cada linea(bucle externo)
            for (int fila = 1; fila <= 7; fila++)
            {
                //dibuja espacios en blanco(bucle interno)
                for (int espacios = 7 -fila; espacios > 0; espacios--)
                {
                    Console.Write(" "); // espacio en blanco
                }
                // dibuja estrellas segundo bloque interno
                for (int conta = 1; conta < (2 * fila); conta++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                    Console.ReadKey();
                }

            }
        }
    }
}
