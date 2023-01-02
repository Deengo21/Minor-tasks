using TicTacToeNamespace;

namespace BankTests
{
    [TestClass]
    public class TicTacToeMoveTests
    {
        [TestMethod]
        public void Move_WhenMovedToSpecificField_ReturnsProperArrayValue()
        {

            for (int i = 0; i < 9; i++)
            {
                //arrange
                var game = new TicTacToe();

                //act
                game.Move(i, 'x');

                //assert
                Assert.AreEqual('x', game.GetValue(i));

            }

        }
        [TestMethod]
        public void GetWinner_WhenThreeXsVertical_ReturnsWinner()
        {
            //arrange
            var game = new TicTacToe();

            //act
            game.Move(2, 'x');
            game.Move(5, 'x');
            game.Move(8, 'x');

            //assert
            Assert.AreEqual('x', game.GetWinner());



        }
        [TestMethod]
        public void GetWinner_WhenThreeXsHorizontal_ReturnsWinner()
        {

            //arrange
            var game = new TicTacToe();

            //act
            game.Move(0, 'x');
            game.Move(1, 'x');
            game.Move(2, 'x');

            //assert
            Assert.AreEqual('x', game.GetWinner());

        }
        [TestMethod]
        public void GetWinner_WhenThreeXsDiagonal_ReturnsWinner()
        {

            //arrange
            var game = new TicTacToe();

            //act
            game.Move(0, 'x');
            game.Move(4, 'x');
            game.Move(8, 'x');

            //assert
            Assert.AreEqual('x', game.GetWinner());

        }
        [TestMethod]
        public void GetWinner_WhenThreeOsHorizontal_ReturnsWinner()
        {

            //arrange
            var game = new TicTacToe();

            //act
            game.Move(0, 'o');
            game.Move(4, 'o');
            game.Move(8, 'o');

            //assert
            Assert.AreEqual('o', game.GetWinner());

        }
    }
}

