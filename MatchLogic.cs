using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using TinyCsvParser;

namespace Matches
{
    public class MatchLogic
    {
        public static void DoWOrk(string[] inputArray)
        {
    
            Dictionary<char, int> map = new Dictionary<char, int>();
            StringBuilder lettercount = new StringBuilder();


            Character(inputArray);
            CharacterConvertor(map);

            Console.WriteLine($"'Final Value after first iteration {lettercount}");

            string finalSUm = Iterations.SecondIterationForTwoDigits(lettercount.ToString());
            while (finalSUm.Length > 2)
            {
                finalSUm = Iterations.SecondIterationForTwoDigits(finalSUm);
            }
            int FinalScore = Convert.ToInt32(finalSUm);
            if (FinalScore >= 80) 
            {
                Console.WriteLine($" {inputArray[0]} matches {inputArray[2]} {FinalScore} %  , good match");

            }
            else
            {
                Console.WriteLine($" {inputArray[0]} matches {inputArray[2]} {FinalScore} %");
            }
           


            StringBuilder Nums = new StringBuilder();

            int sum = 0;


            Console.ReadKey();
            // METHODS


 


            Dictionary<char, int> Character(string[] inputArray)
            {

                foreach (string s in inputArray)
                {
                    foreach (char c in s.ToArray())
                    {
                        if (!map.ContainsKey(c))
                        {
                            map.Add(c, 1);
                        }

                        else
                        {
                            map[c] = map[c] + 1;
                        }
                    }


                }
                return map;
            }



            StringBuilder CharacterConvertor(Dictionary<char, int> character)
            {
                foreach (var mapitem in character.Keys)
                {
                    Console.WriteLine($"'{mapitem}' repeats {character[mapitem]} time(s)");
                    lettercount.Append(character[mapitem]);
                }

                return lettercount;

            }


        }
    }
}

