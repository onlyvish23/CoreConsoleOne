using System;

namespace ConsoleDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1= "long string 24X10     .....1X3";
            string str2= "My name is Tom Marvolo Riddle";

            string pattern1= @"\d+X\d+";            
            int index = str1.HasStringWithPattern(pattern1);

            string pattern2= @"^My";            
            int index2 = str2.HasStringWithPattern(pattern2);

            string pattern3= @"Riddle$";
            int index3 = str2.HasStringWithPattern(pattern3);

            // Check for any number in the string.
            string pattern4= @"\d+";
            int index4 = str1.HasStringWithPattern(pattern4);

            // Regex to test only for AlphaNumeric characters
            string pattern5 = @"^[a-zA-Z0-9]*$";
            int index5 = ("helloworld234234").HasStringWithPattern(pattern5);  // True
            index5 = ("Hello#$").HasStringWithPattern(pattern5);                //False


        }
    }
}
