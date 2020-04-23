using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordScramble.Contracts;

namespace WordScramble.Services
{
    public class WordDictionaryService : IWordDictionaryService
    {
        public async Task<string> GetWordAtLineIndexFromDictionary(IFile file, int index, int minimumWordLength)
        {
            using var wordStream = file.OpenText();

            var lineIndex = 0;
            var lineIndexRange = index;
            var word = string.Empty;

            while (!wordStream.EndOfStream)
            {
                if(lineIndex++ < lineIndexRange)
                { 
                    word = await wordStream.ReadLineAsync();

                    if(word.Length < minimumWordLength)
                    {
                        lineIndex--;
                    }
                }
                else
                {
                    break;
                }
            }
            
            return word.Split("/", StringSplitOptions.RemoveEmptyEntries)[0];
        }

        public WordDictionaryService()
        {
            
        }
    }
}
