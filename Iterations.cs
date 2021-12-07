using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matches
{
    public class Iterations
    {
        public static bool ValidateName(string nameToValidate)
        {
            return string.IsNullOrEmpty(nameToValidate);

        }
        public static bool IsOnlyDigits(string inputString)
        {
            bool isValid = true;

            foreach (char c in inputString)
            {
                if (Char.IsDigit(c))
                    isValid = false;
            }
            return isValid;
        }
        public static string Display(string firstName, string secondName, string percentage)
        {
            string returnValue = $"{firstName} matches {secondName}  {percentage}%";
            if (ConvertToInt(percentage) >= 80)
            {
                returnValue = $"{firstName} matches {secondName}  {percentage}%, good match";
            }
            return returnValue;
        }

        public static string FirstIteration(string combinedWord)
        {
            //Iterate and count ocurances
            int start = 0;
            String returnResult = "";
            int numberOFAppearance = 0;
            char startChar;
            int noOfIterations = 0;
            string temp = combinedWord;

            while (!String.IsNullOrEmpty(temp))
            {
                startChar = temp[0];
                numberOFAppearance = 0;
                foreach (char letter in temp)
                {
                    noOfIterations++;
                    if (letter.Equals(startChar))
                    {
                        numberOFAppearance++;
                    }
                }
                returnResult += numberOFAppearance.ToString();
                temp = RemoveIteratedItem(temp, startChar);
                start++;
            }
            return returnResult;
        }


        public static string RemoveIteratedItem(string valueToMofidy, char valueToRemove)
        {
            string results = valueToMofidy;
            foreach (char item in results)
            {
                if (item == valueToRemove)
                {
                    results = results.Remove(results.IndexOf(valueToRemove), 1);
                }
            }
            return results.ToString();
        }

        public static string SecondIterationForTwoDigits(string sumstring)
        {
            // Iterate trough sum string until we reach two digits only

            int start = 0;
            string results = "";
            while (sumstring.Length > 0)
            {
                if (sumstring.Length == 3)
                {
                    results += (ConvertToInt(sumstring[0].ToString()) + ConvertToInt(sumstring[2].ToString())).ToString();
                    results += ((ConvertToInt(sumstring[1].ToString()))).ToString();
                     goto Finish;
                }
                results += (ConvertToInt(sumstring[start].ToString()) + ConvertToInt(sumstring[sumstring.Length - 1].ToString())).ToString();
                sumstring = RemoveFromLeftAndRight(sumstring);
            }
            Finish:
            return results;
        }


        public static int ConvertToInt(string valueToConvert)
        {
            return int.Parse(valueToConvert.ToString());
        }

        public static string RemoveFromLeftAndRight(string valueToModify)
        {
            string results = "";
            results = valueToModify.Remove(0, 1);
            results = results.Remove(results.Length - 1, 1);
            return results;
        }
    }
}
