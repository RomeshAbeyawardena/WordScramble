using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordScramble.Contracts
{
    public interface IWordSolverService
    {
        bool SolveWord(string originalWord, string answer);
    }
}
