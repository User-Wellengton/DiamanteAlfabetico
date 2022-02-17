using System;

namespace DiamanteAlfabetico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string letra;
            int letraDiamente;


            Console.WriteLine("Digite uma letra para executar o diamente:");
            letra = Console.ReadLine();
            letra = letra.ToUpper();
            string alfabeto = " ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alfabetoChar = alfabeto.ToCharArray();  // ciração a Arrey 
            letraDiamente = Convert.ToChar(letra); // Tabela ASCII

            letraDiamente = letraDiamente - 64;     // convertendo a letra A para numero 1 


            // parte superior 
            for (int i = 0; i < letraDiamente; i++)
            {

                if (i == 0) // quebrar linha para A
                {
                    for (int j = 0; j < letraDiamente - i; j++)
                    {
                        Console.Write(" ");

                    }

                    Console.Write(alfabetoChar[i + 1]);

                    Console.WriteLine();
                }

                else
                {


                    for (int j = 0; j < letraDiamente - i; j++)
                    {
                        Console.Write(" ");

                    }
                    Console.Write(alfabetoChar[i + 1]);

                    int contador = (2 * i) + 1;

                    for (int j = 0; j < contador -2; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(alfabetoChar[i + 1]);


                    Console.WriteLine();


                }

            }


            // parte inferior 

            for (int i = letraDiamente -2 ; i >= 0 ; i--)
            {

                if (i == 0) 
                {
                    for (int j = 0; j < letraDiamente - i; j++)
                    {
                        Console.Write(" ");

                    }

                    Console.Write(alfabetoChar[i + 1]);

                    Console.WriteLine();
                }

                else
                {


                    for (int j = 0; j < letraDiamente - i; j++)
                    {
                        Console.Write(" ");

                    }
                    Console.Write(alfabetoChar[i + 1]);

                    int contador = (2 * i) + 1;

                    for (int j = 0; j < contador - 2; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(alfabetoChar[i + 1]);


                    Console.WriteLine();


                }

            }


            Console.ReadLine();

        }
    }
}
