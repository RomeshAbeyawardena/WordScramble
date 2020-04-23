using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordScramble.Contracts;

namespace WordScramble.Services
{
    public class WordSolverService : IWordSolverService
    {
        public bool SolveWord(string originalWord, string answer)
        {
            return originalWord.All(c => answer.Contains(c)) 
                && answer.Length == originalWord.Length;
        }
    }
}
