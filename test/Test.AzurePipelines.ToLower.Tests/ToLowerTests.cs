using Xunit;

namespace Test.AzurePipelines.ToLower.Tests
{
    public class ToLowerTests
    {
        [Fact]
        public void ToLower_ConvertsCharactersInMessageToLowercase()
        {
            var testSubject = new Class1();

            string result = testSubject.ToLower("TEST");

            Assert.Equal("test", result);
        }
    }
}