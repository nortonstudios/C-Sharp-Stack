using System;
using Xunit;


namespace StackLibrary.Tests
{
    public class StackClassTests
    {

        [Theory]
        [InlineData(7, 7)]
        public void ShouldPushAndPopValueWithoutProblem(int pushed, int expected)
        {
            //Arrange
            StackClass TestStack = new StackClass();

            //Act
            TestStack.Push(pushed);
            int actual = (int)TestStack.Pop();

            //Assert
            Assert.Equal(actual, expected);

        }

        [Theory]
        [InlineData(5, 5)]
        public void StackSizeShouldBeFive(int size, int expected)
        {
            //Arange
            StackClass TestStack = new StackClass();

            //Act
            for (int i = 0; i < size; i++)
            {
                TestStack.Push("test");
            }

            int actual = TestStack.StackSize;

            //Assert
            Assert.Equal(actual, expected);
        }

        
        [Theory]
        [InlineData("!!looc era uoY", "You are cool!!")]
        public void ShouldReverseString(string input, string expected)
        {
            //Arrange
            StackClass TestStack = new StackClass();
            string actual = "";

            //
            for (int i = 0; i < input.Length; i++)
            {
                TestStack.Push(input[i]);
            }

            while (TestStack.StackSize > 0)
            {
                actual = $"{actual}{TestStack.Pop()}";  
            }

            //Assert
            Assert.Equal(actual, expected);
        }
        

    }
}
