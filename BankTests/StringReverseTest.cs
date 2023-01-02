using StringHelper;

namespace BankTests
{
    [TestClass]
    public class StringReverseTests
    {
        [TestMethod]
        public void Reverse_WhenPassingString_ReturnsReversedString()
        {
            //arrange
            string initialString = "abcdefghij";

            //act
            string reversedInitialString = StringReverse.Reverse(initialString);


            //assert
            Assert.AreEqual("jihgfedcba", reversedInitialString);

        }
    }
}