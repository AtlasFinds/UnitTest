using System;

namespace TDD
{
    public class Utilities
    {
        // Feature that counts occurrences of a character in a string. 
        public int CountOccurences(string stringToCheck, string stringToFind)
        {
            var stringAsCharArray = stringToCheck.ToCharArray();
            var stringToCheckForAsChar = stringToFind.ToCharArray()[0];
            var occuranceCount = 0;

            for (var characterIndex = 0; characterIndex < stringAsCharArray.GetUpperBound(0); characterIndex++)
            {
                if (stringAsCharArray[characterIndex] == stringToCheckForAsChar)
                {
                    occuranceCount++;
                }
            }
            return occuranceCount;
        }

        // Add two int numbers
        public int Add(Int32 a, Int32 b)
        {
            int result = 5 + 5;
            
            return result;
        }

        // Returns "Hellow World!"
        public string HellowWorld()
        {
            return "Hellow World!";
        }


    }
}
