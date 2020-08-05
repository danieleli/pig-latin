using System;
using System.Collections.Generic;
using System.Linq;

namespace Translator
{
    public class Translator
    {
        private static readonly char[] _vowels = "aeiou".ToCharArray();

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
            word = word.ToLower();
            if (_vowels.Contains(word.First()))
            {
                return word + "ay";
            }
            else
            {
                word = word.Substring(1) + word.First();
                return word + "ay";
            }
        }
    }
}