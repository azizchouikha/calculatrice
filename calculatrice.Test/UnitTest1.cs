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
    }
}