using System;
using System.Collections.Generic;
using System.Linq;

namespace Translator
{
    public class Translator
    {
        public string Translate(string input)
        {
            if (input == null) return null;

            var words = input.Split(' ');
            var rtnWords = new List<string>();

            foreach (var word in words)
            {
                var newWord = TranslateWord(word);
                rtnWords.Add(newWord);
            }

            return string.Join(' ', rtnWords);
        }

        public string TranslateWord(string word)
        {
            return word;
        }
    }
}