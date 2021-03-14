using System;
using Xunit;



namespace StackLibrary.Tests
{
    public class PaliToolsTests
    {
        [Theory]
        [InlineData("Spacecar", false)]
        public void SouldReturnFalse(string input, bool expected)
        {
            //Arange
            bool actual;
            PaliTools Palindrome = new PaliTools();

            //Act
            actual = Palindrome.IsPalindrome(input);

            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData("Racecar", true)]
        public void ShouldReturnTrue(string input, bool expected)
        {
            //Arragne
            bool actual;
            PaliTools Palindrome = new PaliTools();

            //Act
            actual = Palindrome.IsPalindrome(input);


            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("", true)]
        public void WhatDoesAnEmptyStringDo(string input, bool expected)
        {
            //Arragne
            bool actual;
            PaliTools Palindrome = new PaliTools();

            //Act
            actual = Palindrome.IsPalindrome(input);


            //Assert
            Assert.Equal(expected, actual);
        }


    }
}
