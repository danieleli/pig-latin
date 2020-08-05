namespace Translator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Translator
    {
        private static readonly char[] _vowels = "aeiou".ToCharArray();
        private static readonly Regex _alphaOnlyRegEx = new Regex("[^a-zA-Z]");

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
            if (word.Length == 0) return "";

            word = _alphaOnlyRegEx.Replace(word, "");
            word = word.ToLower();

            var startsWithVowel = _vowels.Contains(word.First());

            if (!startsWithVowel)
            {
                word = word.Substring(1) + word.First();
            }

            return word + "ay";
        }
    }
}