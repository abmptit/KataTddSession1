namespace KataTddSession1
{
    using FooBarQixProject;
    using NUnit.Framework;


    public class NunitTestFooBarQix
    {
        [Test]
        public void Comupute_EnterThree_RetrunFooFoo()
        {
            //Act 
            string input = "3";
            //Arrange
            var actualResult = FooBarQix.Compute(input);

            //Assert
            string expectedResult = "FooFoo";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
