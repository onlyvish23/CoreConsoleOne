using System;
using System.Collections.Generic;

namespace ConsoleDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter reading :");
            //string input1 = Console.ReadLine();
            //int r= Convert.ToInt32(input1);
            BillCalculator obj = new BillCalculator();            
            Outcome res= obj.Calculate(1150);
            if(res!=null){
                foreach(var item in res.Values){
                    Console.WriteLine($"Cost for units {item.MinValue}-{item.MaxValue} \t : {item.CalculatedValue}");                    
                }
                Console.WriteLine($"Actual units charge\t :{res.TotalReadingCost}");
                Console.WriteLine($"Stable Charge\t\t :{res.StableCharge}");
                Console.WriteLine($"Equipment Charge\t :{res.EquipmentCharge.ToString("0.##")}");
                Console.WriteLine($"Accrued Interest\t :{res.AccruedCharge.ToString("0.##")}");
                Console.WriteLine($"\nTotal charge\t :{res.TotalCost.ToString("0.##")}");
            }
        }

        public void StringOperations(){
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
