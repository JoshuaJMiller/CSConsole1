using System;
using System.IO;

namespace CSConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter filename >");

            String filename = "..\\..\\..\\" + Console.ReadLine() + ".txt";

            StreamWriter SW = new StreamWriter(filename);
            Console.WriteLine("Enter first line to write to file.");
            String line2 = Console.ReadLine();
            SW.WriteLine(line2);
            SW.Close();

            Console.WriteLine("r - read file\nq - quit\n>");
            String selection = Console.ReadLine();
            if (selection == "r")
            {

                StreamReader SR = new StreamReader(filename);
                String line = SR.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = SR.ReadLine();
                }
                SR.Close();
                Console.WriteLine();

                Console.Write(line);
            }
            else if (selection == "q") return;


           

            //String s;
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello World!!");
            //s = Console.ReadLine();
            //Console.WriteLine(s + '!');
        }
    }
}
