namespace Calculator.Test.Unit
{
    public class ComputingTest
    {
        [Fact]
        public void OddOrEvent_Should_Return_Odd_When_Input_Is_OddValue()
        {
            var computing = new Computing();

            var result = computing.OddOrEvent(3);

            Assert.Equal("odd",result);
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
    }
}
