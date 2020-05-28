using CurrencyConverter.ViewModel;
using System;
using Xunit;

namespace MathModel.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void PLN_100_to_EUR_format_test()
        {
            var vm = new MathViewModel();
            
            vm.Amount = 100.0;
            ////przykladowy kurs euro dla zlotowki
            vm.Currency = 0.2260295647;

            vm.ConvertAmountToAnotherCurrencyCommand.Execute(null);
            ////Assert
           
            Assert.True(vm.Result.ToString("0.00") == "22,60", "vm.Result != 22.60 !");
           
        }
        [Fact]
        public void EUR_1_how_many_PLN()
        {
            var vm = new MathViewModel();
         
            ////przykladowy kurs euro dla zlotowki
            vm.Currency = 0.2260295647;

            vm.RateForSpecificCurrencyCommand.Execute(null);
            ////Assert
            Console.WriteLine("result" + vm.Result);
            Assert.True(vm.Result.ToString("0.00") == "4,42", "vm.Result != 4.42 !");

        }
    }
}
