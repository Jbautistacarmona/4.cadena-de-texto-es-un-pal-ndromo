using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.cadena_de_texto_es_un_palíndromo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Verificador de Palíndromos");//Un palíndromo, también llamado palíndroma o palindroma, es una palabra o frase que se lee igual en un sentido que en otro
            Console.WriteLine("--------------------------");

            Console.Write("Ingrese la cadena de texto: ");
            string input = Console.ReadLine().ToLower();//representa secuencia de texto, 

            if (IsPalindrome(input))//la bifurcación condicional. El cuerpo de una instrucción if se ejecuta si el valor de la expresión es distinto de cero.
            {
                Console.WriteLine("\nLa cadena es un palíndromo.");
            }
            else//Es usada para ejecutar una instrucción o bloque de instrucciones solo si una condición es cumplida
            {
                Console.WriteLine("\nLa cadena no es un palíndromo.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static bool IsPalindrome(string input) // Este método analiza el argumento de cadena como un booleano.
        {
            int left = 0;
            int right = input.Length - 1;

            while (left < right)//la sentencia se repetirá mientras la condición sea cierta.
            {
                if (input[left] != input[right]) //la bifurcación condicional. El cuerpo de una instrucción if se ejecuta si el valor de la expresión es distinto de cero.
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}
