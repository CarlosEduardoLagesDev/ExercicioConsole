using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Título
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Conversor Teclado Alfanumérico");
                Console.ReadKey();
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite a palavra que queira converter");
            //string Palavras = Console.ReadLine();
            string[] Array = new string[] {Console.ReadLine()};            
            string Mensagem = string.Empty;

            Dictionary<string, int> Dicionario = new Dictionary<string, int>();
            Dicionario.Add("A", 2);
            Dicionario.Add("B", 22);
            Dicionario.Add("C", 222);
            Dicionario.Add("D", 3);
            Dicionario.Add("E", 33);
            Dicionario.Add("F", 333);
            Dicionario.Add("G", 4);
            Dicionario.Add("H", 44);
            Dicionario.Add("I", 444);
            Dicionario.Add("J", 5);
            Dicionario.Add("K", 55);
            Dicionario.Add("L", 555);
            Dicionario.Add("M", 6);
            Dicionario.Add("N", 66);
            Dicionario.Add("O", 666);
            Dicionario.Add("P", 7);
            Dicionario.Add("Q", 77);
            Dicionario.Add("R", 777);
            Dicionario.Add("S", 7777);
            Dicionario.Add("T", 8);
            Dicionario.Add("U", 88);
            Dicionario.Add("V", 888);
            Dicionario.Add("W", 9);
            Dicionario.Add("X", 99);
            Dicionario.Add("Y", 999);
            Dicionario.Add("Z", 9999);
            Dicionario.Add(" ", 0);


            //
            int Valor;
            //Dictionary<string, int>.ValueCollection values = Dicionario.Values;
            //for (int i = 0; i < Array.Length; i++)
            //{
            //    if(Dicionario.TryGetValue(Array[i], out Valor))
            //    {
            //        Mensagem += Valor;
            //    }

            //}
            //Console.WriteLine(Mensagem);
            //Console.ReadLine();




            foreach (string value in Array)
            {

                if (Dicionario.ContainsKey(value))
                {
                    Mensagem += value;
                }
                //Console.WriteLine("{0}", value);
                    
                        
                    
                
            }

            {
                
                //if (Dicionario.ContainsKey(Array))
                //{
                //    //int code = Dicionario[key];
                //    Console.WriteLine("{0}");
                //    Console.ReadLine();
                //}

            }
            

          

            Console.WriteLine(Mensagem);
            Console.ReadLine();
            

        }
    }
}
