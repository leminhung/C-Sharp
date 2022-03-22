
FileStream fs = new FileStream("D:\\EX .NET\\BTHB1\\Bai3\\TepTin\\fs.txt", FileMode.Open); // mở file
StreamReader rd = new StreamReader(fs);

String giaTri = rd.ReadToEnd();
rd.Close();
giaTri = giaTri.Trim();
char[] vs = giaTri.ToCharArray();
int c = 0;
for (int i = 0; i < vs.Length; i++)
    if (((i > 0) && (vs[i] != ' ') && (vs[i - 1] == ' ')) || ((vs[0] != ' ') && (i == 0)))
        c++;

giaTri = giaTri.ToUpper();

FileStream cr = new FileStream("D:\\EX .NET\\BTHB1\\Bai3\\TepTin\\input.txt", FileMode.Create); // tạo ra 1 file tại đường dẫn
StreamWriter sw = new StreamWriter(cr);

sw.WriteLine(giaTri);
sw.Write(c);

sw.Flush();

cr.Close();