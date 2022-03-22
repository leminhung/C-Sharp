using System;
using System.IO;

namespace TapTin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFileName = @"C:\Users\Le Minh Hung\Desktop\input.txt";
            try
            {
                string text = "";

                StreamReader sr = new StreamReader(inputFileName);

                while (!sr.EndOfStream)
                {
                    text += sr.ReadLine().ToUpper();
                }
                Console.WriteLine("text: " + text.Length);
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Connot open file " + inputFileName);
                Console.WriteLine("Errors: " + e.Message.ToString());
            }
            Console.ReadLine();
        }
    }
}
