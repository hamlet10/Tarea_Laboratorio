using System;
using System.Collections.Generic;

namespace Cuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            try
            {
                foreach (var item in args)
                {
                    int listElement = int.Parse(item);
                    myList.Add(listElement);
                }

                foreach (var item in myList)
                {
                    Console.Out.WriteLine(item * item);
                    
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
