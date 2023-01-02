using BinaryNS;

namespace BankTests
{
    class MockBinaryConverter: BinaryConverter
    {
        string toReturn;

        public MockBinaryConverter(string toReturn)
        {
            this.toReturn = toReturn;
        }

        public string ConvertToBinary(int decimalNumber)
        {
            return toReturn;
        }
    }

    [TestClass]
    public class BinaryTests
    {
        [TestMethod]
        public void Binary_WhenPassingInt_ReturnsMaxNumberOfZeros()
        {
            //arrange
            BinaryConverter converter = new MockBinaryConverter("10000100101");

            //act
            int countedZeros = new BinaryGap(converter).Count(0);


            //assert
            Assert.AreEqual(4, countedZeros);

        }
        [TestMethod]
        public void Binary_WhenIntIsZero_ReturnsOne()
        {
            //arrange
            BinaryConverter converter = new MockBinaryConverter("0");

            //act
            int countedZeros = new BinaryGap(converter).Count(0);


            //assert
            Assert.AreEqual(1, countedZeros);

        }
        [TestMethod]
        public void Binary_WhenBinaryHasNoZeros_Returns0()
        {
            //arrange
            BinaryConverter converter = new MockBinaryConverter("1111111");

            //act
            int countedZeros = new BinaryGap(converter).Count(0);


            //assert
            Assert.AreEqual(0, countedZeros);
        }
    }
}