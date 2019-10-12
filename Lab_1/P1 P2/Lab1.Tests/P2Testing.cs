using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab1.Tests
{
    [TestClass]
    public class P2Testing
    {
        [TestMethod]
        public void check_ConvertType_True()
        {
            //arrange
            String tNum = "1000";
            String mbNum = "1500";
            Boolean expected = true;

            //act
            Tariff.check(tNum, mbNum);
            Boolean result = Tariff.checkType;

            //assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void processing1000and1500_45returned() // mbNum double 
        {
            //arrange
            int tNum = 1000;
            double mbNum = 1500.5;
            int expected = 45;

            //act
            int result = Tariff.processing(tNum, mbNum);


            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void processing1000and900_20returned() // mbNum double 
        {
            //arrange
            int tNum = 1000;
            double mbNum = 900.5;
            int expected = 20;

            //act
            int result = Tariff.processing(tNum, mbNum);


            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void processing2000and2500_55returned() // mbNum double
        {
            //arrange
            int tNum = 2000;
            double mbNum = 2500.5;
            int expected = 55;

            //act
            int result = Tariff.processing(tNum, mbNum);


            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void processing2000and1500_35returned() // mbNum double
        {
            //arrange
            int tNum = 2000;
            double mbNum = 1500.5;
            int expected = 35;

            //act
            int result = Tariff.processing(tNum, mbNum);


            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void processing5000and5500_95returned() // mbNum double
        {
            //arrange
            int tNum = 5000;
            double mbNum = 5500.5;
            int expected = 95;

            //act
            int result = Tariff.processing(tNum, mbNum);


            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void processing5000and4200_95returned() // mbNum double
        {
            //arrange
            int tNum = 5000;
            double mbNum = 4200.5;
            int expected = 85;

            //act
            int result = Tariff.processing(tNum, mbNum);


            //assert
            Assert.AreEqual(expected, result);
        }

    }
}
