using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Request for the input
            Console.WriteLine("Enter a number");
            //Reads in the user input for conversion
            string Input = Console.ReadLine();
            Input = Convert.ToDouble(Input).ToString();
            int CInput = Convert.ToInt32(Input);
            //Creating a dictionary for integers from 1 to 19
            Dictionary<int, string> dictTens = new Dictionary<int, string>();
            dictTens.Add(1, "One");
            dictTens.Add(2, "Two");
            dictTens.Add(3, "Three");
            dictTens.Add(4, "Four");
            dictTens.Add(5, "Five");
            dictTens.Add(6, "Six");
            dictTens.Add(7, "Seven");
            dictTens.Add(8, "Eight");
            dictTens.Add(9, "Nine");
            dictTens.Add(10, "Ten");
            dictTens.Add(11, "Eleven");
            dictTens.Add(12, "Twelve");
            dictTens.Add(13, "Thirteen");
            dictTens.Add(14, "Fourteen");
            dictTens.Add(15, "Fifteen");
            dictTens.Add(16, "Sixteen");
            dictTens.Add(17, "Seventeen");
            dictTens.Add(18, "Eighteen");
            dictTens.Add(19, "Nineteen");
            //creating variables to store the result
            string result;
            int leng = Input.Length;
            //checking if the input falls between 1 to 19
            if (dictTens.ContainsKey(CInput) && dictTens.TryGetValue(CInput, out result))
            {
                //prints the output
                Console.WriteLine(result);
                Console.ReadLine();
            }
            //runs the next part if the input is not equal to 0 
            else if (!dictTens.ContainsKey(CInput) && CInput != 0)
            { 
                switch (leng)
                {
                    case 1:
                    case 2: // If the input is in the category of tens
                        Tens(Input);

                        break;
                    case 3://Category of hundred
                        Hundred(Input);
                        break;
                    case 4://Category of thousands
                        string touS = Input.Substring(0, 1);
                        string touF = Input.Substring(1, 3);
                        Input = touS;
                        newTens(Input);
                        Input = touF;
                        Hundred(Input);
                        break;
                    case 5://Category of thousand
                        string secIn = Input.Substring(2);
                        string firIn = Input.Substring(0, 2);
                        Input = firIn;
                        newTens(Input);
                        Input = secIn;
                        Hundred(Input);
                        Console.ReadLine();
                        break;
                    case 6:
                        secIn = Input.Substring(3);
                        firIn = Input.Substring(0, 3);
                        Input = firIn;
                        Hundred(Input);
                        Console.Write(" Thousand ");
                        Input = secIn;
                        Hundred(Input);
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Please input a valid number from 1 to 999,999");
                        break;
                }
                
                Console.ReadLine();
            }else
            {
                //Output incase the user inputs any
                Console.WriteLine("Zero");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Please refresh and input a number, not zero please.");
                Console.ReadLine();
            }
            
        }
        //function for numbers from 1 to 99
        static String Tens (String Input)
        {
            //A dictionary 
            Dictionary<int, string> dictTens = new Dictionary<int, string>();
            dictTens.Add(1, "One");
            dictTens.Add(2, "Two");
            dictTens.Add(3, "Three");
            dictTens.Add(4, "Four");
            dictTens.Add(5, "Five");
            dictTens.Add(6, "Six");
            dictTens.Add(7, "Seven");
            dictTens.Add(8, "Eight");
            dictTens.Add(9, "Nine");
            dictTens.Add(10, "Ten");
            dictTens.Add(11, "Eleven");
            dictTens.Add(12, "Twelve");
            dictTens.Add(13, "Thirteen");
            dictTens.Add(14, "Fourteen");
            dictTens.Add(15, "Fifteen");
            dictTens.Add(16, "Sixteen");
            dictTens.Add(17, "Seventeen");
            dictTens.Add(18, "Eighteen");
            dictTens.Add(19, "Nineteen");
            //Creating a dictionary for integers in tens i.e 20 , 30 .... 90
            Dictionary<int, string> dictUnit = new Dictionary<int, string>();
            dictUnit.Add(20, "Twenty");
            dictUnit.Add(30, "Thirty");
            dictUnit.Add(40, "Fourty");
            dictUnit.Add(50, "Fifty");
            dictUnit.Add(60, "Sixty");
            dictUnit.Add(70, "seventy");
            dictUnit.Add(80, "Eighty");
            dictUnit.Add(90, "Ninety");
            string firstResult;
            string secResult;
            //adds zero as a string to the first sub string
            string firstHalf = Input.Substring(0, 1) + "0";
            int CfirstHalfs = Convert.ToInt32(firstHalf);
            //saves the last sub string
            string secHalf = Input.Substring(1);
            int CsecHalf = Convert.ToInt32(secHalf);
            // check if the input is in the dictionary created "unit"
            if (dictUnit.ContainsKey(CfirstHalfs) && dictUnit.TryGetValue(CfirstHalfs, out firstResult))
            {
                Console.Write("{0} ", firstResult);
                //checks if the input is the dictionary created "tens"
                if (dictTens.ContainsKey(CsecHalf) && dictTens.TryGetValue(CsecHalf, out secResult))
                {
                    Console.Write(secResult);
                }
            }
            return Input;
        }
        //function for numbers from 100 to 999
        static String Hundred (String Input)
        {
            string firstResult;
            Dictionary<int, string> dictHund = new Dictionary<int, string>();
            dictHund.Add(100, "One Hundred");
            dictHund.Add(200, "Two Hundred");
            dictHund.Add(300, "Three Hundred");
            dictHund.Add(400, "Four Hundred");
            dictHund.Add(500, "Five Hundred");
            dictHund.Add(600, "Six Hundred");
            dictHund.Add(700, "Seven Hundred");
            dictHund.Add(800, "Eight Hundred");
            dictHund.Add(900, "Nine Hundred");
            string hunT = Input.Substring(0, 1) + "00";
            int ChunT = Convert.ToInt32(hunT);
            // check if the input is in the dictionary created
            if (dictHund.ContainsKey(ChunT) && dictHund.TryGetValue(ChunT, out firstResult))
            {
                Console.Write("{0} and ",firstResult);
                Input = Input.Substring(1, 2);
                Tens(Input);
                
            }
            return Input;
        }
        //duplicated function for numbers witin 1 to 19
        static String newTens (String Input)
        {
            string firstResult;
            string touS = Input;
            int CtouS = Convert.ToInt32(touS);
            //Creating a dictionary for integers from 1 to 19
            Dictionary<int, string> dictTens = new Dictionary<int, string>();
            dictTens.Add(1, "One");
            dictTens.Add(2, "Two");
            dictTens.Add(3, "Three");
            dictTens.Add(4, "Four");
            dictTens.Add(5, "Five");
            dictTens.Add(6, "Six");
            dictTens.Add(7, "Seven");
            dictTens.Add(8, "Eight");
            dictTens.Add(9, "Nine");
            dictTens.Add(10, "Ten");
            dictTens.Add(11, "Eleven");
            dictTens.Add(12, "Twelve");
            dictTens.Add(13, "Thirteen");
            dictTens.Add(14, "Fourteen");
            dictTens.Add(15, "Fifteen");
            dictTens.Add(16, "Sixteen");
            dictTens.Add(17, "Seventeen");
            dictTens.Add(18, "Eighteen");
            dictTens.Add(19, "Nineteen");
            if (dictTens.ContainsKey(CtouS) && dictTens.TryGetValue(CtouS, out firstResult))
            {
                Console.Write("{0} Thousand ", firstResult);
            }
            return Input;
        }
    }
}