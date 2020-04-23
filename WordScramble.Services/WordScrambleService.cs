using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordScramble.Contracts;

namespace WordScramble.Services
{
    public class WordScrambleService : IWordScrambleService
    {
        private readonly IRandomNumberGenerator randomNumberGenerator;

        public char GetCharacterAtIndex(string value, int index)
        {
            return value[index];
        }

        public string Scramble(string value)
        {
            var scrambledWord = string.Empty;
            var usedIndexList = new List<int>();

            while (scrambledWord.Length < value.Length)
            {
                var index = randomNumberGenerator.GetRandomNumber(value.Length);
                var nextCharacter = GetCharacterAtIndex(value, index);

                if (!usedIndexList.Contains(index))
                {
                    scrambledWord += nextCharacter;
                    usedIndexList.Add(index);
                }
            }

            return scrambledWord;
        }


        public WordScrambleService(IRandomNumberGenerator randomNumberGenerator)
        {
            this.randomNumberGenerator = randomNumberGenerator;
        }

    }
}
