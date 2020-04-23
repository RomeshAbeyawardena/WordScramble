using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordScramble.Contracts
{
    public interface IWordScrambleService
    {
        string Scramble(string value);
        char GetCharacterAtIndex(string value, int index);
    }
}
