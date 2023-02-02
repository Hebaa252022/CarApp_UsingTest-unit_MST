using CarApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CarAppTest_MST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //my first unit test method 
        public void TimeToCoverProvidedDistance_Distance100Velocity25_Time4()
        {
            // AAA
            //Arrange  { inputs for the test case & the expected output}
            double distance = 100;
            double Velocity = 25;
            double expectedOutput = 4;
            Car mycar = new Car(CarType.BMW, Velocity, DrivingMode.Forward);

            //Act 

            var actualResult = mycar.TimeToCoverProvidedDistance(distance);
            // Assert 
            Assert.AreEqual(expectedOutput, actualResult);

        }

        [TestMethod]
        public void TestCarGetDirection_ReverseDrivingMode()
        {
            // Arrange
            Car car = new Car(CarType.BMW, 0, DrivingMode.Reverse);

            // Act
            string direction = car.GetDirection();

            // Assert
            Assert.AreEqual("Reverse", direction);
        }

        [TestMethod]

        public void TestCarStop_StopMethodIsWorking()
        {
            // Arrange
            var car = new Car(CarType.Audi, 20, DrivingMode.Forward);

            // Act
            car.Stop();

            // Assert
            Assert.AreEqual(0, car.Velocity, "Velocity should be 0 after calling Stop method.");
            Assert.IsTrue(car.IsStopped(), "IsStopped should return true after calling Stop method.");

        }

        [TestMethod]
        public void TestCarVelocity_InitializeCorrectly()
        {
            // Arrange
            Car car = new Car(CarType.Mercedes, 30, DrivingMode.Stopped);

            // Act & Assert
            Assert.AreEqual(30, car.Velocity);
        }
        [TestMethod]
        public void GetDirection_CarForword_PrintFarword()
        {
            //Arange 
            var car = new Car();
            car.DrivingMode = DrivingMode.Forward;
            var expected = "Forward";

            //Act 
            var actualDirection = car.GetDirection();
            //Assert
            StringAssert.Matches(actualDirection, new System.Text.RegularExpressions.Regex(expected));

        }
        [TestMethod]
        public void TestCarGetDirection_StoppedDrivingMode()
        {
            // Arrange
            Car car = new Car(CarType.BMW, 30, DrivingMode.Stopped);

            // Act
            string direction = car.GetDirection();

            // Assert
            Assert.AreEqual("Stopped", direction);
        }


    }
    

}