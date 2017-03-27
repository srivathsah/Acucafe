using Acucafe.Tests.Stories;
using AcuCafe;
using Shouldly;
using System;

namespace Acucafe.Tests.Scenarios
{
    public class NoMilkSugarTeaOrder : ScenarioFor<AcuCafe.AcuCafe, OrderStory>
    {
        public string _drinkName;
        private bool _shouldAddMilk;
        private bool _shouldAddSugar;
        private Tuple<string, Drink> _result;

        public void Given_the_drink_name_is_HotTea()
        {
            _drinkName = "Tea";
        }

        public void AndGiven_no_milk_should_be_added()
        {
            _shouldAddMilk = false;
        }

        public void AndGiven_no_Sugar_should_be_added()
        {
            _shouldAddSugar = true;
        }

        public void When_the_order_is_placed()
        {
            _result = SUT.OrderDrink(_drinkName, _shouldAddMilk, _shouldAddSugar);
        }

        public void Then_the_result_should_be_tea()
        {
            var result = _result.Item2 as Tea;
            result.ShouldNotBe(null);
            result.HasSugar.ShouldBe(_shouldAddSugar);
            result.HasMilk.ShouldBe(_shouldAddMilk);
        }
    }
}
