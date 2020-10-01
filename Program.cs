using System;

namespace CalculoPesoEnem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {

                float[] peso;
                peso = new float[5];
                float total;

                for (int i = 0; i <= 4; i++)
                {
                    peso[i] = float.Parse(Console.ReadLine());
                }


                total = (peso[0] * 1 / 15) + (peso[1] * 2 / 15) + (peso[2] * 3 / 15) + (peso[3] * 4 / 15) + (peso[4] * 5 / 15);
                Console.WriteLine("Resultado:"+total);
                Console.WriteLine("continuar?:");
                string resposta = Console.ReadLine();
                if (resposta == "s") 
                {
                    Console.Clear();
                    continuar = true; 
                }else 
                { 
                    continuar = false; 
                }
                

            }

        }
    }
}
