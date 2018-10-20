using Xunit;

namespace Test.AzurePipelines.Tests
{
    public class Class1Tests
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
