using MarsRover.Core.Concrete;
using MarsRover.Core.Enums;
using MarsRover.Core.Models;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class MarsRoverTest
    {
        /// <summary>
        /// Test: Check function success, Check function result
        /// Input: XCoord: 1, YCoord: 2, Direction: N, Plateau W: 5, H: 5, Moves: LMLMLMLMM
        /// Output: XCoord: 1, YCoord: 3, Direction: N 
        /// </summary>
        [Test]
       public void FirstTestScenario()
        {
            var process = new ProcessManager();
            var coordinateModel = new CoordinateModel { XCoord = 1, YCoord = 2 };
            var result = process.StartMoveOrientation(coordinateModel , "LMLMLMLMM", new PlateauModel { Height = 5, Width = 5 }, DirectionEnum.N);
            if (!result.Success)            
                Assert.IsTrue(result.Success);            
            else            
                Assert.AreEqual("XCoord : " + 1 + " YCoord : " + 3 + " Direction : N", result.Result);
            
        }

        /// <summary>
        /// Test: Check function success, Check function result
        /// Input: XCoord: 3, YCoord: 3, Direction: E, Plateau W: 5, H: 5 : Moves: MMRMMRMRRM
        /// Output: XCoord: 1, YCoord: 3, Direction: N 
        /// </summary>
        [Test]
        public void SecondTestScenario()
        {
            var process = new ProcessManager();
            var coordinateModel = new CoordinateModel { XCoord = 3, YCoord = 3 };
            var result = process.StartMoveOrientation(coordinateModel, "MMRMMRMRRM", new PlateauModel { Height = 5, Width = 5 }, DirectionEnum.E);
            if (!result.Success)
                Assert.IsTrue(result.Success);
            else
                Assert.AreEqual("XCoord : " + 5 + " YCoord : " + 1 + " Direction : E", result.Result);
        }

    }
}