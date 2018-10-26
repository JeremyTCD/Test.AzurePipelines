using Xunit;

namespace Test.AzurePipelines.ToUpper.Tests
{
    public class ToUpperTests
    {
        [Fact]
        public void ToUpper_ConvertsCharactersInMessageToUppercase()
        {
            var testSubject = new Class1();

            string result = testSubject.ToUpper("test");

            Assert.Equal("TEST", result);
        }
    }
}
