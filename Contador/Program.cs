using System;

namespace Contador
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int contador = int.Parse(args[0]);
                for(int i = 1; i<= contador; i++)
                {
                    Console.Out.WriteLine(i);
                }
                Console.Out.Write("\n");
            }
            catch (Exception ex)
            {

                Console.Out.WriteLine(ex.Message);
            }
        }
    }
}
