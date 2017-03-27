using Acucafe.Tests.UnitTests.Fixtures;
using AcuCafe;
using AcuCafe.Models;
using Moq;
using Ploeh.AutoFixture.Xunit2;
using Shouldly;
using Xunit;

namespace Acucafe.Tests.UnitTests
{
    public class AcuCafeTests
    {
        [Theory]
        [InlineAutoMoqData(false, true, true, "We are unable to prepare your drink.")]
        [InlineAutoMoqData(true, false, true, "We are unable to prepare your drink.")]
        [InlineAutoMoqData(true, false, false, "Preparation Message.")]
        public void OrderDrink_Should_Validate_And_Prepare_Order(bool validation, bool returnNullValidator, bool returnNullDrink,
            string expectedMessage, Mock<Drink> expectedDrink,
            [Frozen]Mock<IDrinkFactory> drinkFactory, [Frozen]Mock<IDrinkValidatorFactory> drinkValidatorFactory, [Frozen]Mock<IDrinkValidator> drinkValidator,
            AcuCafe.AcuCafe sut)
        {
            if (!returnNullValidator)
            {
                drinkValidatorFactory.Setup(x => x.Get(It.IsAny<string>())).Returns(drinkValidator.Object);
                drinkValidator.Setup(x => x.Validate(It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<Topping>())).Returns(validation);
            }
            else
            {
                drinkValidatorFactory.Setup(x => x.Get(It.IsAny<string>())).Returns(default(IDrinkValidator));
            }

            if (!returnNullDrink)
            {
                drinkFactory.Setup(x => x.Get(It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>())).Returns(expectedDrink.Object);
                expectedDrink.Setup(x => x.Prepare()).Returns(expectedMessage);
            }
            else
            {
                drinkFactory.Setup(x => x.Get(It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>())).Returns(default(Drink));
            }

            var result = sut.OrderDrink(It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>());
            result.Item1.ShouldBe(expectedMessage);
            if (!returnNullDrink && !returnNullValidator)
            {
                result.Item2.ShouldNotBeNull();
            }
            else
            {
                result.Item2.ShouldBeNull();
            }
        }
    }
}
