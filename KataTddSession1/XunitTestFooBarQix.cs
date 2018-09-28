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


        [Theory]
        [InlineData("1", "1")]
        [InlineData("2", "2")]
        [InlineData("3", "FooFoo")]
        [InlineData("4", "4")]
        [InlineData("5", "BarBar")]
        [InlineData("6", "Foo")]
        [InlineData("7", "QixQix")]
        [InlineData("8", "8")]
        [InlineData("9", "Foo")]
        [InlineData("10", "Bar*")]
        [InlineData("13", "Foo")]
        [InlineData("15", "FooBarBar")]
        [InlineData("21", "FooQix")]
        [InlineData("33", "FooFooFoo")]
        [InlineData("51", "FooBar")]
        [InlineData("53", "BarFoo")]
        [InlineData("101", "1*1")]
        [InlineData("303", "FooFoo*Foo")]
        [InlineData("105", "FooBarQix*Bar")]
        [InlineData("10101", "FooQix**")]
        public void Comupute_EnterX_RetrunY(string x, string y)
        {
            //Act 
            string input = x;
            //Arrange
            var actualResult = FooBarQix.Compute(input);

            //Assert
            string expectedResult = y;
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
