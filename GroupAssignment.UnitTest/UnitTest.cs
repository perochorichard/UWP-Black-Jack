
using System;
using System.Collections.Generic;
using GroupAssignment.GameEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GroupAssignment.UnitTest
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void GetPointsValueOf_CardRange1To52_ReturnsProperPointsValue()
        {
            // Arrange
            var game = new Game();
            var ace_result = new int();
            var num_result = new int();
            var face_result = new int();

            // Assert
            ace_result = game.GetPointsValueOf(4, 11);
            num_result = game.GetPointsValueOf(40, 1);
            face_result = game.GetPointsValueOf(52, 1);

            // Act
            Assert.AreEqual(1, ace_result);
            Assert.AreEqual(10, num_result);
            Assert.AreEqual(10, face_result);

        }
    }
}
