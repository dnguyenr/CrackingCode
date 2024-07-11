using System;  
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyUnique;

namespace MyConsoleApp{
class Program
{
    static void Main(string[] args)
    {
        {
            string input = "hello" ;
            bool result = UniqueChar.Unique(input);
            Console.WriteLine($"Is the string \"{input}\" unique? {result}");   

            input = "world";
            result = UniqueChar.Unique(input);
            Console.WriteLine($"Is the string \"{input}\" unique? {result}");
        }
    }
}
}
