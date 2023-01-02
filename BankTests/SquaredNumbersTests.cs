using SquaredNumbersNS;


namespace BankTests
{
    [TestClass]
    public class SquaredNumbersTests
    {
        [TestMethod]
        public void ContainsAllSquared_WhenPassingSquaredList_True()
        {
            //arrange
            List<int> initialNumbers = new List<int>() { 2, 4, 6, 12 };
            List<int> squaredNumbers = new List<int>() { 4, 16, 144, 36 };

            //act
            bool containsAllNumbersSquared = SquaredNumbers.containsAllSquared(initialNumbers, squaredNumbers);


            //assert
            Assert.IsTrue(containsAllNumbersSquared);
        }

        [TestMethod]
        public void ContainsAllSquared_WhenPassingNotSquaredList_False()
        {
            //arrange
            List<int> initialNumbers = new List<int>() { 2, 4 };
            List<int> squaredNumbers = new List<int>() { 3, 16 };

            //act
            bool containsAllNumbersSquared = SquaredNumbers.containsAllSquared(initialNumbers, squaredNumbers);


            //assert
            Assert.IsFalse(containsAllNumbersSquared);
        }
        [TestMethod]
        public void ContainsAllSquared_WhenPassingEmptyList_True()
        {
            //arrange
            List<int> initialNumbers = new List<int>() {  };
            List<int> squaredNumbers = new List<int>() {  };

            //act
            bool containsAllNumbersSquared = SquaredNumbers.containsAllSquared(initialNumbers, squaredNumbers);


            //assert
            Assert.IsTrue(containsAllNumbersSquared);
        }
    }
}