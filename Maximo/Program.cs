using System;
using System.Collections.Generic;

namespace Maximo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> myList = new List<int>();
                int max = 0;
                foreach (var item in args)
                {
                    int element = int.Parse(item);
                    myList.Add(element);
                }
                foreach (var item in myList)
                {
                    if(max < item)
                    {
                        max = item;
                    }
                    

                }
                Console.Out.WriteLine(max);
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
