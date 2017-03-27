using Acucafe.Tests.Stories;
using AcuCafe;
using Shouldly;
using System;

namespace Acucafe.Tests.Scenarios
{
    public class NoMilkSugarExpressoOrder : ScenarioFor<AcuCafe.AcuCafe, OrderStory>
    {
        public string _drinkName;
        private bool _shouldAddMilk;
        private bool _shouldAddSugar;
        private Tuple<string, Drink> _result;

        public void Given_the_drink_name_is_Expresso()
        {
            _drinkName = "Expresso";
        }

        public void AndGiven_no_milk_should_be_added()
        {
            _shouldAddMilk = false;
        }

        public void AndGiven_Sugar_should_be_added()
        {
            _shouldAddSugar = true;
        }

        public void When_the_order_is_placed()
        {
            _result = SUT.OrderDrink(_drinkName, _shouldAddMilk, _shouldAddSugar);
        }

        public void Then_the_result_should_be_Expresso()
        {
            _result.Item2.ShouldNotBe(null);
            var result = _result.Item2 as Expresso;
            result.HasSugar.ShouldBe(_shouldAddSugar);
            _result.Item1.ShouldNotBe("We are unable to prepare your drink.");
        }
    }
}
