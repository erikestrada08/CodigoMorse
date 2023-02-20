using System;
using System.Collections.Generic;
using System.Linq;

namespace morse
{
    class Program
    {
        //metodo para generar el codigo morse
        public static void morse(string palabra)
        {
            const int punto = 300;
            const int ralla = punto * 2;
            Dictionary<char, string> abecedario = new Dictionary<char, string>()
            {
                {'a',".-" },
                {'b', "-..."},
                {'c', "-.-." },
                {'d', "-.." },
                {'e', "." },
                {'f', "..-." },
                {'g',"--." },
                {'h', "...."},
                {'i', ".." },
                {'j', ".---" },
                {'k', "-.-" },
                {'l', ".-.." },
                {'m', "--"},
                {'n', "-." },
                {'o', "---" },
                {'p', ".--." },
                {'q', "--.-" },
                {'r', ".-."},
                {'s', "..." },
                {'t', "-" },
                {'u', "..-" },
                {'v', "...-" },
                {'w', ".--"},
                {'x', "-..-" },
                {'y', "-.--" },
                {'z', "--.." },
                {' ', " " }
            };
            Console.WriteLine(palabra);
            Console.WriteLine(" ");
            try
            {
                //

                for (int i = 0; i < palabra.Length; i++)
                {
                    char letra = palabra[i]; //asigna la letra
                    if (letra == ' ')
                    {
                        Console.WriteLine(" ");
                        System.Threading.Thread.Sleep(punto * 4); //espacio de entre palabras
                    }
                    else
                    {
                        Console.WriteLine($"{palabra[i]}: {abecedario[letra]}");
                        foreach (char caracter in abecedario[letra])
                        {
                            if (caracter == '.')
                            {
                                Console.Beep(300, punto);
                            }
                            else
                            {
                                Console.Beep(300, ralla);
                            }
                        }
                        System.Threading.Thread.Sleep(punto * 3); //espacio de entre letras

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }



        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Escriba la palabra: ");
                string texto = Console.ReadLine();
                string palabra = texto.ToLower();
                Console.WriteLine(" ");
                morse(palabra);
                Console.WriteLine(" ");
            }
        }
    }
}
