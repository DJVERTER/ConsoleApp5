using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> str = new List<string> { "true", "||", "false" };
            string result = str[2];
            bool myBool;
            
                if (bool.TryParse(result, out myBool))
                {
                    Console.WriteLine(myBool);
                }
                else if(result == str[1])
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine(myBool);
                }

        }
    }
}