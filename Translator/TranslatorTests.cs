using System;
using Xunit;

namespace Translator
{
    public class TranslatorTests
    {
        [Fact]
        public void SampleTest()
        {
            // arrange
            var input          = "Birds of feather flock together";
            var expectedOutput = "irdsbay ofay eatherfay lockfay ogethertay";
            var translator     = new Translator();

            // act
            var output         = translator.Translate(input);

            // assert
            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void NullReturnsNull()
        {
            // arrange
            string input          = null;
            string expectedOutput = null;
            var translator        = new Translator();

            // act
            var output = translator.Translate(input);

            // assert
            Assert.Equal(expectedOutput, output);
        }
    }
}
