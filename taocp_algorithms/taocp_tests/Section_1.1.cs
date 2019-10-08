using System;
using NUnit.Framework;

namespace taocp_tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EuclidTest()
        {
            // Arrange
            var m = 7;
            var n = 3;
            var expect = 1;
            var result = 0;
            // Act
            result = GetGreatestCommonFactor(m, n);

            // Assert
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void EuclidTest2()
        {
            // Arrange
            var m = 119;
            var n = 544;
            // Act
            var result = GetGreatestCommonFactor(m, n);

            // Assert
            Assert.AreEqual(m % result , n % result);
        }

        private int GetGreatestCommonFactor(int m, int n)
        {
            if (m == 0 || n == 0)
                throw new ArgumentException("Invalid parameters");
            var rest = m % n;
            while (rest != 0)
            {
                m = n;
                n = rest;
                rest = m % n;
            }

            return n;

        }
    }
}