using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string stringToTest)
        {
            char[] charArray = stringToTest.ToCharArray(); // Look ma, only one array!
            int length = charArray.Length;
            for (int i = 0; i < length - 1; i++)
            {
                if (charArray[i] != charArray[(length - 1) - i]) // Just to make it prettier
                {
                    return false;
                }
            }
            return true;
            //throw new NotImplementedException();
        }
    }
}