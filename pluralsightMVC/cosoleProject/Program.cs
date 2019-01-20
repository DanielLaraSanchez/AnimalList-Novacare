using System;
using Newtonsoft.Json;

namespace cosoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JsonConvert.SerializeObject(args));
            Console.WriteLine("Hello World!");
        }
    }
}
