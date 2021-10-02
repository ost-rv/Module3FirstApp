using System;

namespace Module3FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Jane";
            byte age = 27;
            bool havePet = true;
            float size = 37.5f;

            Console.WriteLine("My name is {0}", name);
            Console.WriteLine("My age is {0}", age);
            Console.WriteLine("Do I have a pet? {0}", havePet);
            Console.WriteLine("My shoe size is {0}", size);

            Console.ReadKey();
        }
    }
}
