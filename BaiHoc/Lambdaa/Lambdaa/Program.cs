using System;
using System.Text;

namespace Lambdaa
{
    class Program
    {

        delegate int MyDelegate(string s);

        static void Main(string[] args)
        {
            //==========================Lambdaa
            //Action<string> del1 = s => Console.Write(s);

            //del1("\nLe Minh Hung\n");

            //Action del2 = () => Console.Write("Hung");
            //del2();

            //Func<int, int ,int> func = (x, y) => x + y;
            //Console.WriteLine($"\n 3 + 5 = {func(3,5)}");

            //Console.ReadLine();
            //==========================Lambdaa


            Console.OutputEncoding = Encoding.Unicode;
            MyDelegate convertToInt = new MyDelegate(ConvertStringToInt);
            MyDelegate showString = new MyDelegate(ShowString);
            MyDelegate multicast = convertToInt + showString;

            string numberSTR = "35";
            int valueConverted = convertToInt(numberSTR);
            Console.WriteLine("Giá trị đã convert thành int:" + valueConverted);


            Console.WriteLine("Kết quả khi gọi multicast delegate");
            multicast(numberSTR);
            Console.ReadLine();

        }

        static int ConvertStringToInt(string stringValue)
        {
            int valueInt = 0;
            Int32.TryParse(stringValue, out valueInt);
            Console.WriteLine("Đã ép kiểu dữ liệu thành công");
            return valueInt;
        }

        static int ShowString(string stringValue)
        {
            Console.WriteLine(stringValue);
            return 0;
        }
    }
}
