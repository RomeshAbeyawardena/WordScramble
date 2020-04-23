using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetWordResponse = WordScramble.Domains.Responses.GetWord;

namespace WordScramble.Domains.Requests
{
    public class GetWord : IRequest<GetWordResponse>
    {
        public int MinimumLength { get; set; }
    }
}
