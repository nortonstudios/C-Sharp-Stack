using System;
using Xunit;


namespace StackLibrary.Tests
{
    public class StackClassTests
    {

        [Theory]
        [InlineData( 7, 7)]
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
    }
}
