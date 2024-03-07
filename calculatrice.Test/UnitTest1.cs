using Xunit;
using calculatrice;

namespace calculatrice.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Add_ReturnsZero_WhenInputIsEmpty()
        {
            
            var calculator = new StringCalculator();
            var input = "";

            
            var result = calculator.Add(input);

            
            Assert.Equal(0, result);
        }

        [Fact]
        public void Add_ReturnsSum_WhenInputIsValid()
        {
            
            var calculator = new StringCalculator();
            var input = "5,3";

            
            var result = calculator.Add(input);

            
            Assert.Equal(8, result);
        }

        [Fact]
        public void Add_ThrowsFormatException_WhenInputIsInvalid()
        {
            
            var calculator = new StringCalculator();
            var input = "a,b";

            
            Assert.Throws<FormatException>(() => calculator.Add(input));
        }
        [Theory]
        [InlineData("1,2,3", 6)]
        [InlineData("4,5,6", 15)]
        [InlineData("7,8,9,10", 34)]
        public void Add_ShouldFail_WhenMoreThanTwoNumbersAreProvided(string input, int expectedSum)
        {
            var calculator = new StringCalculator();
            var result = calculator.Add(input);
            Assert.Equal(expectedSum, result); 
        }
        [Theory]
        [InlineData("1,1,1", 3)]
        [InlineData("1, 1, 1", 3)]
        [InlineData("1,1, 1, 1", 3)]
        [InlineData(" 1, 1,1 ", 3)]
        public void Add_ToleratesSpacesAnywhere(string input, int expectedSum)
        {
            var calculator = new StringCalculator();
            var result = calculator.Add(input);

            Assert.Equal(expectedSum, result); 
        }
    }
}