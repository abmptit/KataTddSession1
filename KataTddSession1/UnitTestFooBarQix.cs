namespace KataTddSession1
{
    using FooBarQixProject;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTestFooBarQix
    {
        [TestMethod]
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
