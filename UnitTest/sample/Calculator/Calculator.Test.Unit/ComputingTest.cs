using Calculator.Test.Unit.ClassFixture;
using FluentAssertions;

namespace Calculator.Test.Unit
{
    public class ComputingTest:IClassFixture<ComputingClassFixture>
    {
        private readonly Computing _computing;


        //این یک setup fixture
        //است که قبل از هر چیزی اجرا می شود
        //نام
        //transient fresh fixture

        //هوک های که می دهد اولی 
        //ctro است که اجر می شود
        //و دومی اگر 
        //IDisposable
        //را ارث ببریم بعد هر تست اجرا می شود در آخر
        public ComputingTest(ComputingClassFixture c)
        {
            //_computing = new Computing();

            _computing = c._computing;
        }

        [Fact]
        public void OddOrEvent_Should_Return_Odd_When_Input_Is_OddValue()
        {

            //arrange

            //inline 

            //var computing = new Computing();

            //act

            var result = _computing.OddOrEvent(3);


            //asserts

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

            var result = _computing.OddOrEvent(value);

            Assert.Equal("even", result);
        }

        [Fact(DisplayName = "CalcAgeOne")]
        public void CalculateAge_Should_Return_Zero_When_BirthdayYear_IsLessThan_Zero()
        {

            var result = _computing.CalculateAge(-1, 2025);

            result.Should().Be(0);
        }

        [Fact(DisplayName = "CalcAgeTwo")]
        public void CalculateAge_Should_Throw_Ex_When_BirthdayYear_Is_Zero()
        {

            var result = new Action(() =>
            {
                _computing.CalculateAge(0, 2025);
            });

            result.Should().Throw<ArgumentException>();
        }
    }
}