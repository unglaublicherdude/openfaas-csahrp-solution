using Xunit;

namespace ToUpper.Test
{
    public class FunctionHandlerTest
    {
        [Theory]
        [InlineData("foobar")]
        [InlineData("Foobar")]
        [InlineData("fooBar")]
        [InlineData("foobaR")]
        public void Handle_GetsNotFullyUpperCaseStrings_ReturnsUpperCaseStrings(string input)
        {
            const string expected = "FOOBAR";
            Assert.Equal(expected, FunctionHandler.Handle(input));
        }        

        [Fact]
        public void Handle_GetsUpperCaseString_ReturnsTheSameString()
        {
            const string input = "FOOBAR";
            Assert.Equal(input, FunctionHandler.Handle(input));
        }        
    }
}
