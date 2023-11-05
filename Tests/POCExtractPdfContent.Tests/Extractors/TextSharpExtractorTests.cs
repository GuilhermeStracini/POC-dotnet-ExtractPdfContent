using POCExtractPdfContent.Extractors;
using System;
using Xunit;

namespace POCExtractPdfContent.Tests.Extractors
{
    public class TextSharpExtractorTests
    {
        [Fact]
        public void Extract_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var textSharpExtractor = new TextSharpExtractor();
            string path = null;

            // Act
            var result = textSharpExtractor.Extract(path);

            // Assert
            Assert.True(false);
        }
    }
}
