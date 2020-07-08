using System;
using TDDDemoApp;
using Xunit;

namespace TDDDemoAppTests
{
    public class TextAnalyzerUnitTest
    {
        [Fact]
        public void GetTotalWordCount_WhenPassedRegularText_ShouldReturnExpectedCount()
        {
            const string textToAnalize = @"We've just created a test-driven class and method - sweet! This process is very";

            var analyzer = new TextAnalyzer();

            var count = analyzer.GetTotalWordCount(textToAnalize);

            Assert.Equal(14, count);
        }

        [Fact]
        public void GetWordIsNullOrEmpty_WhenPassedRegularText_ShouldReturnExpectedTrue()
        {
            const string textToAnalize = @"";

            var analyzer = new TextAnalyzer();

            var ok = analyzer.GetWordNullOrEmpty(textToAnalize);

            Assert.True(ok);
        }
    }
}
