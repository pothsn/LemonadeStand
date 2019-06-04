using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace LemonadeStandTest
{
    [TestClass]
    public class PitcherTest
    {
        [TestMethod]
        public void CheckPitcher_IsTrue_IfNotEmpty()
        {
            //Arrange
            Inventory inventory = new Inventory();
            Pitcher pitcher = new Pitcher();
            pitcher.cupsInPitcher = 5;
            bool actual;

            //Act
            actual = pitcher.CheckPitcher(inventory);

            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckPitcher_IsFalse_IfEmpty()
        {
            //Arrange
            Inventory inventory = new Inventory();
            Pitcher pitcher = new Pitcher();
            pitcher.cupsInPitcher = 0;
            bool actual;

            //Act
            actual = pitcher.CheckPitcher(inventory);

            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckIfCanRefillPitcher_IsTrue_IfHasIngredients()
        {
            //Arrange
            Inventory inventory = new Inventory();
            Pitcher pitcher = new Pitcher();
            inventory.cupsOfSugar = 5;
            inventory.lemons = 5;
            inventory.iceCubes = 5;
            inventory.paperCups = 1;
            pitcher.cupsOfSugar = 5;
            pitcher.lemons = 5;
            pitcher.iceCubes = 5;
            bool actual;

            //Act
            actual = pitcher.CheckIfCanRefillPitcher(inventory);

            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckIfCanRefillPitcher_IsFalse_IfNoHasIngredients()
        {
            //Arrange
            Inventory inventory = new Inventory();
            Pitcher pitcher = new Pitcher();
            inventory.cupsOfSugar = 4;
            inventory.lemons = 5;
            inventory.iceCubes = 5;
            inventory.paperCups = 1;
            pitcher.cupsOfSugar = 5;
            pitcher.lemons = 5;
            pitcher.iceCubes = 5;
            bool actual;

            //Act
            actual = pitcher.CheckIfCanRefillPitcher(inventory);

            //Assert
            Assert.IsFalse(actual);
        }
    }



    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void PourCup_Decrements_LemonadeFromPitcher()
        {
            //Arrange
            Player player = new Player();
            player.pitcher.cupsInPitcher = 5;
            int expectedResult = 4;

            //Act
            player.PourCup();
            int actual = player.pitcher.cupsInPitcher;

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void PourCup_Decrements_PlayerPaperCups()
        {
            //Arrange
            Player player = new Player();
            player.inventory.paperCups = 5;
            int expectedResult = 4;

            //Act
            player.PourCup();
            int actual = player.inventory.paperCups;

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void PourCup_Incriments_PlayerMoney()
        {
            //Arrange
            Player player = new Player();
            player.money = 5;
            double expectedResult = (player.money + player.pitcher.cupPrice);

            //Act
            player.PourCup();
            double actual = player.money;

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void RefillPitcher_Incriments_CupsInPitcher()
        {
            //Arrange
            Player player = new Player();
            player.pitcher.cupsInPitcher = 0;
            player.inventory.cupsOfSugar = 4;
            player.inventory.lemons = 4;
            player.inventory.iceCubes = 4;
            int expectedResult = 11;

            //Act
            player.RefillPitcher(player.inventory);
            int actual = player.pitcher.cupsInPitcher;

            //Assesrt
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void RefillPitcher_Decriments_InventoryCupsOfSugar()
        {
            //Arrange
            Player player = new Player();
            player.inventory.cupsOfSugar = 4;
            int expectedResult = 0;

            //Act
            player.RefillPitcher(player.inventory);
            int actual = player.inventory.cupsOfSugar;

            //Assesrt
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void RefillPitcher_Decriments_InventoryLemons()
        {
            //Arrange
            Player player = new Player();
            player.inventory.lemons = 4;
            int expectedResult = 0;

            //Act
            player.RefillPitcher(player.inventory);
            int actual = player.inventory.lemons;

            //Assesrt
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void RefillPitcher_Decriments_InventoryIceCubes()
        {
            //Arrange
            Player player = new Player();
            player.inventory.iceCubes = 4;
            int expectedResult = 0;

            //Act
            player.RefillPitcher(player.inventory);
            int actual = player.inventory.iceCubes;

            //Assesrt
            Assert.AreEqual(expectedResult, actual);
        }
    }
}
