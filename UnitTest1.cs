using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfTwoSmallest;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckToNull()
        {
            // исходные данные
            double[] arr = null;
            int count = 2;          //количество суммируемых чисел

            // получение значения с помощью тестируемого метода
            SumOfMass funcsum = new SumOfMass();

            // сравнение полученного исключения
            Assert.ThrowsException<ArgumentNullException>(() => funcsum.SumOfSmallest(arr, count));
        }
        [TestMethod]
        public void CheckToZeroElems()
        {
            // исходные данные
            double[] arr = { };
            int count = 2;          //количество суммируемых чисел

            // получение значения с помощью тестируемого метода
            SumOfMass funcsum = new SumOfMass();

            // сравнение полученного исключения
            Assert.ThrowsException<ArgumentNullException>(() => funcsum.SumOfSmallest(arr, count));
        }
        [TestMethod]
        public void CheckToIndexOfRange()
        {
            // исходные данные
            double[] arr  = {1, 3, -10, 105, 34, 44, 47, 25, 44};
            int count = 10;          //количество суммируемых чисел

            // получение значения с помощью тестируемого метода
            SumOfMass funcsum = new SumOfMass();

            // сравнение полученного исключения
            Assert.ThrowsException<IndexOutOfRangeException>(() => funcsum.SumOfSmallest(arr, count));
        }
    }
}
