using Acucafe.Tests.Stories;
using AcuCafe;
using AcuCafe.Models;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acucafe.Tests.Scenarios
{
    public class ChocolateToppingExpressoOrder : ScenarioFor<AcuCafe.AcuCafe, ToppingsStory>
    {
        public string _drinkName;
        private Topping _topping;
        private Tuple<string, Drink> _result;

        public void Given_the_drink_name_is_Expresso()
        {
            _drinkName = "Expresso";
        }

        public void AndGiven_chocolate_topping_should_be_added()
        {
            _topping = new ChocolateTopping();
        }

        public void When_the_order_is_placed()
        {
            _result = SUT.OrderDrink(_drinkName, false, false, _topping);
        }

        public void Then_the_result_should_be_tea_as_expected()
        {
            _result.Item2.ShouldNotBe(null);
            _result.Item2.Topping.ShouldNotBeNull();
            _result.Item1.ShouldNotBe("We are unable to prepare your drink.");
        }
    }
}
