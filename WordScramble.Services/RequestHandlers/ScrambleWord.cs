using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScrambleWordRequest = WordScramble.Domains.Requests.ScrambleWord;
using ScambleWordResponse = WordScramble.Domains.Responses.ScrambleWord;
using System.Threading;
using WordScramble.Contracts;

namespace WordScramble.Services.RequestHandlers
{
    public class ScrambleWord : ResultRequestHandlerBase<ScrambleWordRequest, ScambleWordResponse, string>
    {
        private readonly IWordScrambleService wordScrambleService;

        public override Task<ScambleWordResponse> Handle(ScrambleWordRequest request, CancellationToken cancellationToken)
        {
            return SuccessAsync(wordScrambleService.Scramble(request.Word));
        }

        public ScrambleWord(IWordScrambleService wordScrambleService)
        {
            this.wordScrambleService = wordScrambleService;
        }
    }
}
