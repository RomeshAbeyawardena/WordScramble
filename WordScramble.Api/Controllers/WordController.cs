using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordScramble.Domains.ViewModels;
using ScrambleWordRequest = WordScramble.Domains.Requests.ScrambleWord;
using GetWordRequest = WordScramble.Domains.Requests.GetWord;
using SolveWordRequest = WordScramble.Domains.Requests.SolveWord;
using System.Threading;

namespace WordScramble.Api.Controllers
{
    public class WordController : ControllerBase
    {
        [HttpGet, ActionName("Scramble")]
        public async Task<IActionResult> ScrambleWord(ScrambleWordRequestViewModel viewModel, CancellationToken cancellationToken)
        {
            var request = Mapper
                .Map<ScrambleWordRequest>(viewModel);

            var response = await Mediator
                .Send(request, cancellationToken);

            return ValidateResponse(response);
        }

        [HttpGet, ActionName("Random")]
        public async Task<IActionResult> GetRandomWord(GetWordRequestViewModel viewModel, CancellationToken cancellationToken)
        {
            var request = Mapper
                .Map<GetWordRequest>(viewModel);

            var response = await Mediator
                .Send(request, cancellationToken);

            return ValidateResponse(response);
        }

        [HttpGet, ActionName("Solve")]
        public async Task<IActionResult> SolveScrambledWord(SolveWordRequestViewModel viewModel, CancellationToken cancellationToken)
        {
            var request = Mapper
                .Map<SolveWordRequest>(viewModel);

            var response = await Mediator
                .Send(request, cancellationToken);

            return ValidateResponse(response);
        }


        public WordController(IMediator mediator, IMapper mapper)
            : base(mediator, mapper)
        {

        }
    }
}
