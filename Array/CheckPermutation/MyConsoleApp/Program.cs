using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
             string[][] testCases = new string[][]
        {
            new string[] { "listen", "silent", "True" },
            new string[] { "triangle", "integral", "True" },
            new string[] { "apple", "pale", "False" },
            new string[] { "hello", "billion", "False" }
        };

        foreach (var testCase in testCases)
        {
            string str1 = testCase[0];
            string str2 = testCase[1];
            bool expected = bool.Parse(testCase[2]);

            bool result = CheckPer(str1, str2);

            Console.WriteLine($"CheckPer(\"{str1}\", \"{str2}\") = {result} (Expected: {expected})");
            if (result == expected)
            {
                Console.WriteLine("Test Passed!");
            }
            else
            {
                Console.WriteLine("Test Failed!");
            }
            Console.WriteLine();
        }
    
    }
}