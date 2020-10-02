using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class NumberConverter
    {
        string[] SingleDigitUniqueNumbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        string[] TenToNineteen = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] ZeroUniqueNumbers = { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eigthy", "ninety" };
        string[] HundredAndThousands = { "hundred", "thousand" };

        public void ConvertNumber(int number)
        {
            
            string WrittenNumber = "";
            
            if (number < 10)
            {
                WrittenNumber += SingleDigitUniqueNumbers[number];
            }

            if (number > 9 && number < 20)
            {                
                WrittenNumber += TenToNineteen[number - 10];
            }

            if (number > 19 && number < 100)
            {
                int firstnumber, secondnumber;
                firstnumber = number / 10;
                secondnumber = number % 10;

                if (secondnumber == 0)
                {
                    WrittenNumber += ZeroUniqueNumbers[firstnumber - 1];
                }

                else
                {
                    WrittenNumber += ZeroUniqueNumbers[firstnumber - 1];
                    WrittenNumber += " " + SingleDigitUniqueNumbers[secondnumber];
                }
            }

            if (number > 99 && number < 1000)
            {
                int firstnumber, secondnumber, thirdnumber;
                firstnumber = (number / 10) / 10;
                secondnumber = (number / 10) % 10;
                thirdnumber = number % 10;

                if (secondnumber == 0 && thirdnumber == 0)
                {
                    WrittenNumber += SingleDigitUniqueNumbers[firstnumber];
                    WrittenNumber += " " + HundredAndThousands[0];
                }
                
                else if (thirdnumber == 0)
                {
                    WrittenNumber += SingleDigitUniqueNumbers[firstnumber];
                    WrittenNumber += " hundred and " + ZeroUniqueNumbers[secondnumber -1];
                }

                else if (secondnumber == 0)
                {
                    WrittenNumber += SingleDigitUniqueNumbers[firstnumber];
                    WrittenNumber += " hundred and " + SingleDigitUniqueNumbers[thirdnumber];
                }

                else if (secondnumber == 1)
                {
                    WrittenNumber += WrittenNumber += SingleDigitUniqueNumbers[firstnumber];
                    WrittenNumber += " hundred and " + TenToNineteen[thirdnumber];
                }

                else
                {
                    WrittenNumber += SingleDigitUniqueNumbers[firstnumber];
                    WrittenNumber += " hundred and " + ZeroUniqueNumbers[secondnumber - 1];
                    WrittenNumber += " " + SingleDigitUniqueNumbers[thirdnumber];
                }               

            }

            if (number > 999 && number < 10000)
            {
                int firstnumber, secondnumber, thirdnumber, fourthnumber;
                firstnumber = number / 1000;
                secondnumber = ((number / 10) / 10) % 10;
                thirdnumber = (number / 10) % 10;
                fourthnumber = number % 10;

                if (thirdnumber == 0 && fourthnumber == 0)
                {
                    WrittenNumber += SingleDigitUniqueNumbers[firstnumber] + " thousand ";
                    WrittenNumber += SingleDigitUniqueNumbers[secondnumber];
                    WrittenNumber += " " + HundredAndThousands[0];
                }

                else if (fourthnumber == 0)
                {
                    WrittenNumber += SingleDigitUniqueNumbers[firstnumber] + " thousand ";
                    WrittenNumber += SingleDigitUniqueNumbers[secondnumber];
                    WrittenNumber += " hundred and " + ZeroUniqueNumbers[thirdnumber - 1];
                }

                else if (thirdnumber == 0)
                {
                    WrittenNumber += SingleDigitUniqueNumbers[firstnumber] + " thousand ";
                    WrittenNumber += SingleDigitUniqueNumbers[secondnumber];
                    WrittenNumber += " hundred and " + SingleDigitUniqueNumbers[fourthnumber];
                }

                else if (thirdnumber == 1)
                {
                    WrittenNumber += SingleDigitUniqueNumbers[firstnumber] + " thousand ";
                    WrittenNumber += SingleDigitUniqueNumbers[secondnumber];
                    WrittenNumber += " hundred and " + TenToNineteen[fourthnumber];
                }

                else
                {
                    WrittenNumber += SingleDigitUniqueNumbers[firstnumber] + " thousand ";
                    WrittenNumber += SingleDigitUniqueNumbers[secondnumber];
                    WrittenNumber += " hundred and " + ZeroUniqueNumbers[thirdnumber - 1];
                    WrittenNumber += " " + SingleDigitUniqueNumbers[fourthnumber];
                }
            }

                Console.WriteLine(WrittenNumber);     
           
                        
        }

        


    }
}
