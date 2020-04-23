using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolveWordResponse = WordScramble.Domains.Responses.SolveWord;

namespace WordScramble.Domains.Requests
{
    public class SolveWord : IRequest<SolveWordResponse>
    {
        public string OriginalWord { get; set; }

        public string Answer { get; set; } 
    }
}
