using System;

namespace lab1ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Ex4
            Scrieti un program care va verifica daca un numar citit de la tastatura este par sau impar
           In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”. */

            int number;

            Console.WriteLine("Enter any number: ");
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else if (number % 2 != 0)
            {
                Console.WriteLine("The number is odd");
            }

        }
    }
}
