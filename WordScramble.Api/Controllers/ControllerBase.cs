using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordScramble.Contracts;

namespace WordScramble.Api.Controllers
{
    public abstract class ControllerBase : Controller
    {
        protected ControllerBase(IMediator mediator, IMapper mapper)
        {
            Mediator = mediator;
            Mapper = mapper;
        }

        protected IMediator Mediator { get; }
        protected IMapper Mapper { get; }

        protected IActionResult ValidateResponse<TResult>(IResponse<TResult> response)
        {
            if (response.IsValid)
            {
                return Ok(response.Result);
            }

            return BadRequest(response.Errors);
        }
    }
}
