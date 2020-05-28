using System;
using CurrencyConverter.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CurrencyConverter.UnitTest
{
    [TestClass]
    public class MathUnitTest
    {
        [TestMethod]
        public void AddTest()
        {
            ////Arrange
            var vm = new MathViewModel();

            vm.Amount = 100.0;
            vm.Currency = 0.2;
            ////act
            vm.AddCommand.Execute(null);
            ////Assert
            Assert.IsTrue(vm.Result == 20.0, "vm.Result != 10 !");
            //string amount = "100";
            //double currencyPLNtoEUR = 1.5;
            //double amountInDouble=double.Parse(amount);
            //double result = amountInDouble * currencyPLNtoEUR;


            //Assert.IsTrue(result.ToString() == "150", "result != 22.54 !");

        }
    }
}
