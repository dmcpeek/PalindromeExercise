using System;
using Xunit;

using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("strawnotoostupidafadiputsootonwarts", true)]
        [InlineData("dendrobatesazureus", false)]
        [InlineData("a", true)]
        [InlineData("wasitacarisaw", false)]
        [InlineData("ab", false)]
        [InlineData("11011011", true)]
        [InlineData("palidrome", false)]
        public void Test1(string word, bool expected)
        {
            //Arrange
            var testIt = new WordSmith();

            //Act
            var actual = testIt.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
