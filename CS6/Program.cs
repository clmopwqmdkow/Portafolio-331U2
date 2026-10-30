using System;
using System.Security;
namespace CS6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sesión 13: Iteradores
            double recorrido = 0;
            double zancadas = 0;
            //double pausas = 0;
            int numero_hidratación = 0;
            int recorrido_hidratación = 0;
            while (recorrido < 21000)
            {
                recorrido += .63;
                //if (zancadas % 3500 == 0)
                // {
                // pausas += 1;
                // }
                zancadas += 1;
                if (recorrido >= recorrido_hidratación)
                {
                    numero_hidratación += 1;
                    recorrido_hidratación += 2000;
                    //Console.WriteLine($"Recorrido: {recorrido} m\n Hidratació:{numero_hidratación} ");
                }
            }

            //Console.WriteLine($"Zancadas: {zancadas}");

            //Console.WriteLine($"Pausas de hidratación:{pausas}");

            //1.Ciclo for
            /* Sintaxis ciclo for
            for(incialización; expresión; iterador)
            {
                // Bloque de instrucciones

            }
            */
            //Ejemplo: Secuencia 35-41
            for (int m = 35; m <= 41; m += 1)
            {
                Console.WriteLine($"m:{m}");
            }
            //Sesión 14: Ciclo for 141402026
            //1.Definir un ciclo for para la siguiente secuencia: -33, -34, -35, -36, -37, -38, -39
            Console.WriteLine($"Ciclo 1: Descendente");
            for (int z = -33; z >= -39; z -= 1)
            {
                Console.WriteLine($"a: {z * (-1)}");
            }
            Console.WriteLine("Ciclo 2: Ascendente");
            for (int a = 9; a <= 15; a += 1)
            {
                if (a != 13)
                {
                    Console.WriteLine($"a:{a}");
                }
            }

            //Ejercitación:
            //Un libro tiene un titulo distinto por cada 88 paginas
            int titulo = 1;
            int paginas = 1;
            int nuevo = 1;
            while (paginas <= 539)
            {
                if (paginas >= nuevo)
                {
                    Console.WriteLine($"Titulo:{titulo}");
                    Console.WriteLine($"En la pagina: {paginas}");
                    titulo += 1;
                    nuevo += 88;
                }
                paginas += 1;
            }

        }
    }
}