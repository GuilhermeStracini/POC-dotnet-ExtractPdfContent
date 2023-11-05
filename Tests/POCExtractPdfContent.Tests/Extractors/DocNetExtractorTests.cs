using FluentAssertions;
using POCExtractPdfContent.Extractors;
using Xunit;

namespace POCExtractPdfContent.Tests.Extractors
{
    public class DocNetExtractorTests
    {
        [Fact]
        public void Extract_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var textSharpExtractor = new DocNetExtractor();
            var data = Helper.CreateSamplePdfFile();

            // Act
            var result = textSharpExtractor.Extract(data);

            // Assert
            result.Should().Be("Hello World - PDF Extractor example!");
        }
    }
}
