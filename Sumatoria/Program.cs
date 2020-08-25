using System;

namespace Sumatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int result = 0;
                for (int i = 0; i < args.Length; i++)
                {
                    int element = int.Parse(args[i]);
                    result += element;
                }
                Console.Out.WriteLine(result);
                Console.Out.WriteLine("\n");
            }
            catch (Exception ex)
            {

                Console.Out.WriteLine(ex.Message);
                Console.Out.WriteLine("\n");
            }
        }
    }
}
