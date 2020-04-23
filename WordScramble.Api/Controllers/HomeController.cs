using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordScramble.Api.Controllers
{
    public class HomeController : ControllerBase
    {
        public HomeController(IMediator mediator, IMapper mapper) 
            : base(mediator, mapper)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
