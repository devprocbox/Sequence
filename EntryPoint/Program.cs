using SequenceGenerator;
using System;

namespace EntryPoint {
    class Program {
        static void Main(string[] args)
        {
            bool proceed = true;
            Console.WriteLine("Hello,");
            while (proceed)
            {
                Console.WriteLine("To generate Tribonacci number press (g), press any key for exit:");
                char key = Console.ReadKey().KeyChar;
                if (key == 'g')
                {
                    Console.WriteLine("\nInput Tribonacci number index:");
                    int index = 0;
                    try { index = Convert.ToUInt16(Console.ReadLine()); }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Wrong key was pressed. You will get 0 index Tribonacci value.");
                    }
                    finally
                    {
                        int tribonacci = Generator.Tribonacci(index);
                        Console.WriteLine($"Result: {tribonacci}");
                    }
                }
                else
                {
                    proceed = false;
                    break;
                }
            }
        }
    }
}
