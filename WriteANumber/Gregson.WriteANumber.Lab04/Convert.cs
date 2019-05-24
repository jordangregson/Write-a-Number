using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gregson.WriteANumber.Lab04
{
    class Convert
    {
        public Convert()
        {

        }

        public string thousands(string number)
        {
            string result = "";

            if (number.Length > 3)
            {
                for (int n = 0; n < number.Length - 3; n++)
                {
                    number += number[n];
                    
                }

                result += threeCharNumberToWords(number) + " thousand ";
            }

            return result += threeCharNumberToWords(number);


        }

        public char findChar(string number, int digit)
        {
            char character;
            int numChars = number.Length;

            numChars -= digit;

            character = number[numChars];

            return character;
        }

        public String threeCharNumberToWords(String theNumber)
        {
            String theResult;

            theResult = decodeHundreds(theNumber);

            theResult += decodeTens(theNumber);

            if (theNumber.Length > 1 && findChar(theNumber, 2) != '1')
                theResult += decodeOnes(theNumber);

            return theResult;
        }


        public String decodeOnes(String theNumber)
        {
            char theChar = findChar(theNumber, 1);

            return decodeOnesAndHundredsChar(theChar);
        }

        public String decodeTens(String theNumber)
        {
            if (theNumber.Length > 1)
            {
                char theChar = findChar(theNumber, 2);

                if (theChar == '1')
                {
                    return decodeTeens(theNumber);
                }
                else
                {
                    return decodeTensChar(theChar, theNumber) + " ";
                }
            }

            return "";
        }

        public String decodeHundreds(String theNumber)
        {
            if (theNumber.Length > 2)
            {
                char theChar = findChar(theNumber, 3);

                return decodeOnesAndHundredsChar(theChar) + " hundred ";
            }

            return "";
        }
        public String decodeOnesAndHundredsChar(char theChar)
        {
            String theWord;

            switch (theChar)
            {
                case '0':
                    theWord = "";
                    break;
                case '1':
                    theWord = "one";
                    break;
                case '2':
                    theWord = "two";
                    break;
                case '3':
                    theWord = "three";
                    break;
                case '4':
                    theWord = "four";
                    break;
                case '5':
                    theWord = "five";
                    break;
                case '6':
                    theWord = "six";
                    break;
                case '7':
                    theWord = "seven";
                    break;
                case '8':
                    theWord = "eight";
                    break;
                case '9':
                    theWord = "nine";
                    break;
                default:
                    theWord = "error";
                    break;
            }

            return theWord;
        }

        public String decodeTeens(String theNumber)
        {
            // given: the tens char is a '1'
            String theWord;
            char theChar = findChar(theNumber, 1);

            switch (theChar)
            {
                case '0':
                    theWord = "ten";
                    break;
                case '1':
                    theWord = "eleven";
                    break;
                case '2':
                    theWord = "twelve";
                    break;
                case '3':
                    theWord = "thirteen";
                    break;
                case '4':
                    theWord = "fourteen";
                    break;
                case '5':
                    theWord = "fifteen";
                    break;
                case '6':
                    theWord = "sixteen";
                    break;
                case '7':
                    theWord = "seventeen";
                    break;
                case '8':
                    theWord = "eighteen";
                    break;
                case '9':
                    theWord = "nineteen";
                    break;
                default:
                    theWord = "error";
                    break;
            }

            return theWord;
        }

        public String decodeTensChar(char theChar, String theNumber)
        {
            String theWord;

            switch (theChar)
            {
                case '0':
                    theWord = "";
                    break;
                case '1':
                    theWord = decodeTeens(theNumber);
                    break;
                case '2':
                    theWord = "twenty";
                    break;
                case '3':
                    theWord = "thirty";
                    break;
                case '4':
                    theWord = "fourty";
                    break;
                case '5':
                    theWord = "fifty";
                    break;
                case '6':
                    theWord = "sixty";
                    break;
                case '7':
                    theWord = "seventy";
                    break;
                case '8':
                    theWord = "eighty";
                    break;
                case '9':
                    theWord = "ninety";
                    break;
                default:
                    theWord = "error";
                    break;
            }

            return theWord;
        }
    }
}
