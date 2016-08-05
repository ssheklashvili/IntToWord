using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntWords
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("sheiyvanet ricxvi:");
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine("minus " + TransferIntToWord(-number));
                }
                else
                {
                    Console.WriteLine(TransferIntToWord(number));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("araswori formati");
            }
            catch (OverflowException)
            {
                Console.WriteLine("int-is zomas gadaacharba");
            }



        }



        static string TransferIntToWord(int number)
        {
            string[] words1 = new string[] {"nuli","erti","ori","sami","otxi","xuti","eqvsi",
                "shvidi","rva","cxra","ati","tertmeti","tormeti","cameti","totxmeti","txutmeti", 
                "teqvsmeti","chvidmeti","tvrameti","cxrameti","oci"};
            string[] words2 = new string[] { "ati", "oci", "ocdaati", "ormoci", "ormocdaati",
                "samoci", "samocdaati", "otxmoci", "otxmocdaati","asi" };

            if (number <= 20)
            {
                return words1[number];
            }
            else if (number <= 100)
            {
                if (number == 100) return words2[9];
                if (number % 10 == 0)
                {
                    return words2[(number / 10) - 1];
                }
                else
                {
                    int i = number / 10 - 1;
                    if (i % 2 == 1)
                    {
                        return words2[i].Substring(0, words2[i].Length - 1) + "da" + words1[number % 10];

                    }
                    else
                    {
                        i = i - 1;
                        return words2[i].Substring(0, words2[i].Length - 1) + "da" + words1[number % 10 + 10];

                    }

                }
            }

            else if (number <= 1000)
            {
                string hundred = "as ";
                string upTo = words1[number / 100];


                if (number == 800 || number == 900)
                {
                    return upTo + hundred.Substring(0, hundred.Length - 1) + "i";
                }
                if (number / 100 == 8 || number / 100 == 9)
                {
                    return upTo + hundred + TransferIntToWord(number%100);
                }
                if (number / 100 == 1)
                {
                    return hundred + TransferIntToWord(number % 100);
                }
                if (number % 100 == 0)
                {
                    return upTo.Substring(0, upTo.Length - 1) + hundred.Substring(0, hundred.Length - 1) + "i";
                }
                else
                {
                    return upTo.Substring(0, upTo.Length - 1) + hundred + TransferIntToWord(number % 100);
                }
                            }




            else if(number<1000000)
            {
                string atas = "atas ";
                if (number / 1000 > 1 && number % 1000 != 0)
                {
                    return TransferIntToWord(number / 1000) + " " + atas + TransferIntToWord(number % 1000);
                }
                else
                if (number == 1000)
                {
                    return atas.Substring(0, atas.Length - 1) + "i";
                }
                else if (number % 1000 == 0)
                {
                    return TransferIntToWord(number / 1000) + " " + atas.Substring(0, atas.Length - 1) + "i";
                }

                else
                {
                    return atas + TransferIntToWord(number % 1000);
                }



            }

            
            else if (number < 1000000000)
            {
                string million = "milion ";
                if (number / 1000000 > 1 && number % 1000000 != 0)
                {
                    return TransferIntToWord(number / 1000000) + " " + million + TransferIntToWord(number % 1000000);
                }else
                if (number == 1000000)
                {
                    return million.Substring(0, million.Length - 1) + "i";
                }else if(number % 1000000 == 0)
                {
                    return TransferIntToWord(number / 1000000) + " " + million.Substring(0, million.Length - 1) + "i";
                }
               
                else
                {
                    return  million + TransferIntToWord(number % 1000000);
                }
                
 
            }
            else
            {
                string billion = "miliard ";
                if (number / 1000000000 > 1 && number % 1000000000 != 0)
                {
                    return TransferIntToWord(number / 1000000000) + " " + billion + TransferIntToWord(number % 1000000000);
                }
                else
                if (number == 1000000000)
                {
                    return billion.Substring(0, billion.Length - 1) + "i";
                }
                else if (number % 1000000000 == 0)
                {
                    return TransferIntToWord(number / 1000000000) + " " + billion.Substring(0, billion.Length - 1) + "i";
                }

                else
                {
                    return billion + TransferIntToWord(number % 1000000000);
                }
            }
           
        }
    }
}
