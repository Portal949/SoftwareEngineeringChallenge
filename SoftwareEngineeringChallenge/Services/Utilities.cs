using SoftwareEngineeringChallenge.Entities;
using SoftwareEngineeringChallenge.Interfaces;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoftwareEngineeringChallenge.Services
{
    public class Utilities : IUtilities
    {
        /// <summary>
        /// Returns a list of Marbles by specyfic weight
        /// </summary>
        /// <param name="marbles">Marbles List</param>
        /// <param name="weight"> Weight to get </param>
        /// <returns></returns>
        public IEnumerable<Marble> GetByWeight(IEnumerable<Marble> marbles, float weight)
        {
            //Use Linq to get all weight of marbles where the param equals to weight property
            IEnumerable<Marble> marblesByWeight = marbles
                .Where(item => item.Weight <= weight).ToArray();

            return marblesByWeight;
        }

        /// <summary>
        /// Returns marble List with palindrome names
        /// </summary>
        /// <param name="marbles">Marble List</param>
        /// <returns></returns>
        public IEnumerable<Marble> GetPalindrome(IEnumerable<Marble> marbles)
        {
            List<Marble> palindromeMarbles = new List<Marble>();

            //Walk through marble list
            foreach (var marble in marbles)
            {
                //Replace all spaces in string
                var orginalMarbleName = marble.Name.Trim().ToLower().Replace(" ", "");

                //Use regex to replace all special characters in string
                var regexReplaceName = Regex.Replace(orginalMarbleName, @"[^0-9a-zA-Z]+", string.Empty);

                //Use reverse function and create a new string with the function returns
                var reverMarbleName = new string(regexReplaceName.Reverse().ToArray());

                //If both string are equal then add this marble into a list
                if (regexReplaceName.Equals(reverMarbleName))
                {
                    palindromeMarbles.Add(marble);
                }
            }

            return palindromeMarbles;
        }

        /// <summary>
        /// Order the given List according to specific rules
        /// </summary>
        /// <param name="marbles">Marble List</param>
        /// <returns></returns>
        public IEnumerable<Marble> SortByColor(IEnumerable<Marble> marbles)
        {
            //Rules to order the list (you can change this code line instead of confg.json params).
            List<String> preferences = new List<String> { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };//ROYGBIV

            //Use linq to order list according preference
            IEnumerable<Marble> orderedData = marbles
                .OrderBy(item => preferences
                .IndexOf(item.Color));

            return orderedData;
        }
    }
}
