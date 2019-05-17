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
            //else 
            else if (!dictTens.ContainsKey(CInput) && CInput != 0)
            { 
                switch (leng)
                {
                    case 1:
                    case 2: // Tens
                        Tens(Input);

                        break;
                    case 3:
                        Hundred(Input);
                        break;
                    case 4:
                        Thousand(Input);
                        break;
                    case 5:
                        Thousand(Input);
                        break;
                    case 6:
                        Thousand(Input);
                        break;

                    default:
                        Console.WriteLine("Please input a valid number");
                        break;
                }
                
                Console.ReadLine();
            }else
            {
                Console.WriteLine("Zero");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Please refresh and input a number, not zero please.");
                Console.ReadLine();
            }
            
        }
        static String Tens (String Input)
        {
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
        static String Thousand (String Input)
        {
            string firstResult;
            int inLeng = Input.Length;
            switch(inLeng)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Pass");
                    string touS = Input.Substring(0,1);
                    int CtouS= Convert.ToInt32(touS);
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
                    if (dictTens.ContainsKey(CtouS) && dictTens.TryGetValue(CtouS, out firstResult))
                    {
                        Console.Write("{0} Thousand ", firstResult);
                        Input = Input.Substring(1, 3);
                        Hundred(Input);
                    }
                        break;
            }
        return Input;
        }
    }
}