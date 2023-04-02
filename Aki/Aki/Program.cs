using System;
using static System.Console;
using static System.Convert;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader a = new StreamReader("1.txt");
            StreamReader b = new StreamReader("2.txt");

            FileStream c = new FileStream("3.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter d = new StreamWriter(c);
            string k = default;
            foreach (char i in a.ReadToEnd())
            {
                if (i == ' ')
                {
                    k = default;
                }
                else
                {
                    k = i.ToString();
                    if (k != default)
                    {
                        k.Append(i);
                    }
                }
                if (ToInt32(k) % 2 == 0 && k != default)
                {
                    d.Write(k);
                }
            }
            k = default;
            foreach (char i in b.ReadToEnd())
            {
                if (i == ' ')
                {
                    k = default;
                }
                else
                {
                    k = i.ToString();
                    if (k != default)
                    {
                        k.Append(i);
                    }
                }
                if (ToInt32(k) % 2 != 0 && k != default)
                {
                    d.Write(k);
                }
            }
            a.Close();
            b.Close();
            c.Close();
        }
    }
}