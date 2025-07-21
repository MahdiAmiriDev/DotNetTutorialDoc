using FluentAssertions;

namespace Calculator.Test.Unit
{
    public class ComputingTest
    {
        [Fact]
        public void OddOrEvent_Should_Return_Odd_When_Input_Is_OddValue()
        {
            var computing = new Computing();

            var result = computing.OddOrEvent(3);

            //Assert.Equal("odd",result);

            result.Should().Be("odd");

            //result.Should().BeLowerCased()
            //result.Should().Equals()
            //result.Should().BeOfType<>()

        }

        //[Fact(DisplayName = "OddOrEvent_Should_Return_Even_When_Input_Is_EvenValue")]
        [Theory(DisplayName = "CustomMethodName")]
        //[ClassData()]
        //[MemberData()]
        [InlineData(12)]
        public void EvenValue(int value)
        {
            var computing = new Computing();

            var result = computing.OddOrEvent(value);

            Assert.Equal("even", result);
        }

        [Fact(DisplayName = "CalcAgeOne")]
        public void CalculateAge_Should_Return_Zero_When_BirthdayYear_IsLessThan_Zero()
        {
            var computing = new Computing();

            var result = computing.CalculateAge(-1, 2025);

            result.Should().Be(0);
        }

        [Fact(DisplayName = "CalcAgeTwo")]
        public void CalculateAge_Should_Throw_Ex_When_BirthdayYear_Is_Zero()
        {
            var computing = new Computing();

            var result = new Action(() =>
            {
                computing.CalculateAge(0, 2025);
            });

            result.Should().Throw<ArgumentException>();
        }
    }
}