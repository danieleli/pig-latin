using System;
using Xunit;
using Xunit.Abstractions;

namespace Translator
{
    public class TranslatorTests
    {
        private readonly ITestOutputHelper _console;
        private readonly Translator        _translator;

        public TranslatorTests(ITestOutputHelper console)
        {
            _console     = console;
            _translator = new Translator();
        }

        [Fact]
        public void SampleTest()
        {
            // arrange
            var input          = "Birds of feather flock together";
            var expectedOutput = "irdsbay ofay eatherfay lockfay ogethertay";

            // act
            var output         = _translator.Translate(input);

            // assert
            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Null_Returns_Null()
        {
            // arrange
            string input          = null;
            string expectedOutput = null;

            // act
            var output = _translator.Translate(input);

            // assert
            Assert.Equal(expectedOutput, output);
        }

        [Theory]
        [InlineData("Above", "aboveay")]
        [InlineData("each", "eachay")]
        [InlineData("island", "islanday")]
        [InlineData("of","ofay")]
        [InlineData("unary", "unaryay")]
        public void WordStartsWithVowel_Appends_Ay(string word, string expectedOutput)
        {
            // act
            var output = _translator.TranslateWord(word);

            // assert
            Assert.Equal(expectedOutput, output);
        }
    }
}
