using Microsoft.VisualStudio.TestTools.UnitTesting;
using GruppArbete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppArbete.Tests
{
    public struct CategoryName
    {
        public const string Unit = "Unit";
        public const string Integration = "Integration";
    }


    [TestClass()]
    public class GameItemTests
    {

        [TestMethod()]
        [TestCategory(CategoryName.Unit)]
        public void GameItemTest()
        {
            Game game = new Game();
            GameItem gameCharacter = new GameItem();

            game.Gameboard[1, 8] = gameCharacter.character;

            Assert.AreEqual(2, gameCharacter.character);
        }

        
    }


}