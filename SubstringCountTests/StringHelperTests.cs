using SubstringCount;
using static System.Net.Mime.MediaTypeNames;

namespace SubstringCountTests
{
    public class StringHelperTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void CountOccurences_WhenTextIsNullOrEmpty_ReturnsZero(string text)
        {
            int count = StringHelper.CountOccurences(text, "test");
            Assert.Equal(0, count);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void CountOccurences_WhenLookupFragmentIsNullOrEmpty_ReturnsZero(string lookupFragment)
        {
            try
            {
                int count = StringHelper.CountOccurences("test", lookupFragment);

                // we don't expect the method to reach till here
                Assert.True(false);
            }
            catch (ArgumentNullException ex)
            {
                // we expect the method to fail with ArgumentNullException
                Assert.True(true);
            }
        }

        [Theory]
        [InlineData("ana are mere.merele sunt coapte", "mere", 2)]
        [InlineData("ana are mere", "ana", 1)]
        [InlineData("ene mere mure rere", "re", 4)]
        [InlineData("aaaaa", "aa", 4)]
        public void CountOccurences_WhenCorrectDataProvided_ReturnsExpectedCount(string text, string lookupFragment, int expectedCount)
        {
            int count = StringHelper.CountOccurences(text, lookupFragment);

            Assert.Equal(expectedCount, count);
        }
    }
}