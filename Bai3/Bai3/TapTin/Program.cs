using System;
using System.IO;

namespace TapTin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFileName = @"input.txt";
            /*string outputFileName = "input.txt";

            StreamWriter streamWriter = null;*/
            StreamReader streamReader = null;


            try
            {
                streamReader = new StreamReader(@"input.txt");
                string temp;
                int N;
                temp = streamReader.ReadLine();
                N = Convert.ToInt32(temp);

                Console.WriteLine("temp = " + temp);
                Console.WriteLine("N = " + N);

                for (int i = 0; i < N; i++)
                {
                    temp = streamReader.ReadLine();
                    int x = Convert.ToInt32(temp);
                }

                /* streamWriter = new StreamWriter(outputFileName);
                 streamWriter.WriteLine("hello le minh hung");
                 Console.WriteLine("done!")*/;



            }
            catch (Exception e)
            {
                Console.WriteLine("Connot open file " + inputFileName);
                Console.WriteLine("Errors: " + e.Message.ToString());
            }
            finally
            {
                if(streamReader != null)
                {
                    streamReader.Close();
                }
            }
            Console.ReadLine();
        }
    }
}
