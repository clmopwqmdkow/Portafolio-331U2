using System;
//Espacio de nombres
namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Unidad 1 : Estructuras de control II
            //Unidad 2: Funciones II
            //Sesión 12: Instrucción while 30092026
            //Sintaxis: while
            //inicialización;
            //while(expresión)
            //{
            //      //Bloque de instrucciones
            //      iterador;
            //}
            //Iterar: repetir
            //Ejemplo 1: Ciclo ascendente (rango: 1-3)
            int m = 1; //Inicialización
            while (m <= 3) //Expresión
            {
                //Bloque de instruccioes 
                Console.WriteLine($"m: {m}");
                m += 1; //Iterador
            }
            //Ejercitación
            //1.Definir un ciclo para imprimir tu nombre 5 veces
            //Nota:Para la expresión utilizar el operador <
            //a.Ciclo ascendente
            int n = 1;
            while (n < 6)
            {
                Console.WriteLine($"Alejandra:{n}");
                n += 1;
            }
            //b. Ciclo descendente
            int d = 3;
            while (d >= 1)
            {
                Console.WriteLine($"d: {d}");
                d -= 1;
            }
            //c. Incrementos
            //Secuencia: 3 6 9 12 15 18
            int i = 3;
            while (i <= 18)
            {
                Console.WriteLine($"i: {i}");
                i += 3;
            }
            //d. Decrementos
            //Ejercitación
            //1.Definir un ciclo para imprimir "331" 8 veces
            int a = 24;
            while (a > 8)
            {
                Console.WriteLine($"331");
                a -= 2;
            }
            //Actividad 1: Ciclo infinito
            //1. Definir un ciclo infinito ascendente.
            //2. Definir un ciclo infinito descendente.
            //Nota: Para la solución, utilizar el operador de diferencia.
            //1.Ascendente
            int b = 1;
            while (b > 0)
            {
                Console.WriteLine($"b: {b}");
            }
            //2.Descendente
            int c = 1;
            while (c != 0)
            {
                Console.WriteLine($"c: {c}");
            }
        }
    }
}
