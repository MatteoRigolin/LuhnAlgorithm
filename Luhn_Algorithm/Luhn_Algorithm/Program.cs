using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luhn_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string risposta;
            do
            {
                Console.WriteLine("Inserisci il codice PAN da verificare:\n");
                string codice = Console.ReadLine();
                bool codValido = AlgoritmoDiLuhn(codice);
                if (codValido)
                {
                    Console.WriteLine("\nIl codice PAN è valido");
                }
                else
                {
                    Console.WriteLine("\nIl codice PAN non è valido");
                }
                Console.WriteLine("Inserisci 'x' per inserire di nuovo il codice o un'altra lettera per terminare il programma:\n");
                risposta = Console.ReadLine();
            }
            while (risposta == "x");
            Console.ReadKey();
        }
        static bool AlgoritmoDiLuhn(string codice) 
        {
            int somma = 0;
            char[] numeri = codice.ToArray();
            bool posizionePari = false;
            for (int i = codice.Length - 1; i >= 0; i--)
            {             
                int num = int.Parse(numeri[i].ToString());
                if (posizionePari)
                {
                    num *= 2;

                    if (num > 9)
                    {
                        num = (num % 10) + 1;
                    }
                }
                somma += num;
                posizionePari = !posizionePari;
            }
            if (somma % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}