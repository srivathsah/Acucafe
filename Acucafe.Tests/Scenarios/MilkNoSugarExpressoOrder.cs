﻿using Acucafe.Tests.Stories;
using AcuCafe;
using Shouldly;
using System;

namespace Acucafe.Tests.Scenarios
{
    public class MilkNoSugarExpressoOrder : ScenarioFor<AcuCafe.AcuCafe, OrderStory>
    {
        public string _drinkName;
        private bool _shouldAddMilk;
        private bool _shouldAddSugar;
        private Tuple<string, Drink> _result;

        public void Given_the_drink_name_is_Expresso()
        {
            _drinkName = "Expresso";
        }

        public void AndGiven_milk_should_be_added()
        {
            _shouldAddMilk = true;
        }

        public void AndGiven_no_Sugar_should_be_added()
        {
            _shouldAddSugar = false;
        }

        public void When_the_order_is_placed()
        {
            _result = SUT.OrderDrink(_drinkName, _shouldAddMilk, _shouldAddSugar);
        }

        public void Then_the_result_should_be_tea_as_expected()
        {
            _result.Item2.ShouldBe(null);
            _result.Item1.ShouldBe("We are unable to prepare your drink.");
        }
    }
}
