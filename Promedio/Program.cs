using System;
using System.Collections.Generic;

namespace Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> myList = new List<int>();
                float result = 0;
                foreach (var item in args)
                {
                    int element = int.Parse(item);
                    myList.Add(element);
                }
                foreach (var item in myList)
                {
                    result += item;

                }
                result = result / myList.Count;
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
