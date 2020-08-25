using System;
using System.Collections.Generic;

namespace filtro_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> myList = new List<int>();
                foreach (var item in args)
                {
                    int element = int.Parse(item);
                    myList.Add(element);
                }
                foreach (var item in myList)
                {
                    if(item % 2 == 0)
                    {
                        Console.Out.WriteLine(item);
                        
                    }

                }
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
