using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WordScramble.Contracts;
using SolveWordRequest = WordScramble.Domains.Requests.SolveWord;
using SolveWordResponse = WordScramble.Domains.Responses.SolveWord;

namespace WordScramble.Services.RequestHandlers
{
    public class SolveWord : ResultRequestHandlerBase<SolveWordRequest, SolveWordResponse, bool>
    {
        private readonly IWordSolverService wordSolverService;

        public override Task<SolveWordResponse> Handle(SolveWordRequest request, CancellationToken cancellationToken)
        {
            return SuccessAsync(wordSolverService
                .SolveWord(request.OriginalWord, request.Answer));
        }

        public SolveWord(IWordSolverService wordSolverService)
        {
            this.wordSolverService = wordSolverService;
        }
    }
}
