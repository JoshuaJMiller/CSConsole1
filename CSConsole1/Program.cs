using System;
using System.IO;

namespace CSConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter filename >");

                String filename = "..\\..\\..\\" + Console.ReadLine() + ".txt";

                StreamWriter SW = new StreamWriter(filename);
                Console.WriteLine("Enter first line to write to file. (QUIT to quit)");

                String line2 = "";
                while (line2 != "QUIT")
                {
                    line2 = Console.ReadLine();
                    SW.WriteLine(line2);
                }

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
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("Program terminated.");
            }





            //String s;
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello World!!");
            //s = Console.ReadLine();
            //Console.WriteLine(s + '!');
        }
    }
}
