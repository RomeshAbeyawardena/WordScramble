using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordScramble.Contracts
{
    public interface IWordDictionaryService
    {
        Task<string> GetWordAtLineIndexFromDictionary(IFile file, int index, int minimumWordLength);
    }
}
