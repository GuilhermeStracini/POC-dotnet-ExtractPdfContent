using POCExtractPdfContent.Extractors;
using FluentAssertions;
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
            var data = Helper.CreateSamplePdfFile();

            // Act
            var result = textSharpExtractor.Extract(data);

            // Assert
            result.Should().Be("Hello World - PDF Extractor example!");
        }
    }
}
