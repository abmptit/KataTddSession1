namespace KataTddSession1
{
    using FooBarQixProject;
    using Xunit;
    public class XunitTestFooBarQix
    {
        [Fact]
        public void Comupute_EnterThree_RetrunFooFoo()
        {
            //Act 
            string input = "3";
            //Arrange
            var actualResult = FooBarQix.Compute(input);

            //Assert
            string expectedResult = "FooFoo";
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
