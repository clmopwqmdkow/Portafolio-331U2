using System;
//Espacio de nombre
namespace CS
{
    //Clase principal
    class Program
    {
        //Función principal
        static void Main(string[] args)
        {
            //Bloque de la función
            //Sesión 15: Funciones 15102026
            /*
            Función: Bloque de instrucciones para realizar una tarea específica, que se ejecuta, únicamente, cuando es invocado.
            Sintaxis
            tipo_dato_devuelto identificador_función(parametros)
            {
                Bloque de instrucciones
            }
            Nota 1: Los parámetros se definen incluyendo tipo de dato
            Nota 2: Los parámetros van separados por comas.
            Sintaxis:Invocación función
            identificador_función(argumentos);
            Argumento: El valor del parámetro
            */
            //Ejemplo 1: Función vacía sin parámetros
            void Saludar()
            {
                string salón = "Exactas 331";
                Console.WriteLine($"Hola, {salón}!");
            }
            //Invocación
            Saludar();
            //Ejercitación
            //1.Definir e invocar una función sin parámetros para imprimir: nombre, clave y salón
            void ejercicio()
            {
                string nombre = "Alejandra";
                string clave = "331-01";
                string salón = "331";
                Console.WriteLine($"{nombre}, {clave}, {salón}");
            }
            ejercicio();
            //2. Definir e invocar una función para desplegar el horario de hoy
            void horario()
            {
                Console.WriteLine("7:00 Calculo");
                Console.WriteLine("7:50 Formación humana");
                Console.WriteLine("8:40 Programación");
                Console.WriteLine("9:50 Psicología");
                Console.WriteLine("10:40 Idioma");
                Console.WriteLine("11:50 Dibujo tecnico");
                Console.WriteLine("12:40 Dibujo Tenico");
            }
            horario();
            //Sesión 16: Función con parametros
            //return: Palabra reservads para terminar una función y devolver una expresión
            //Ejemplo 1: Doble
            int CalcularDoble(int número)
            {
                int resultado = 3 * número;
                return resultado;
            }
            //Invocación
            int devolución;
            devolución = CalcularDoble(9);
            Console.WriteLine($"Devolución : {devolución}");
            //Ejercitación
            //1. Definir e invocar una función que devuelva la evaluación de la siguiente expresión: f(x) = 4 x - 7 / 5 
            double f(double x)
            {
                double y;
                y = 4 * x - 7 / 5D;
                return y;
            }
            double d;
            d = f(0);
            Console.WriteLine($"f(0): {d}");
        }//Termino de la función principal
    }//Termino clase principal
}//Termino espacio de nombres