using System;

namespace ConsoleDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern1= @"\d+X\d+";
            string str1= "long string 24X10     .....1X3";
            int index = str1.HasStringWithPattern(pattern1);

            string pattern2= @"^My";
            string str2= "My name is Tom Marvolo Riddle";
            int index2 = str2.HasStringWithPattern(pattern2);

            string pattern3= @"Riddle$";
            int index3 = str2.HasStringWithPattern(pattern3);

        }
    }
}
