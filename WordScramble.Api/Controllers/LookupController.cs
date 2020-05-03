using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordScramble.Domains;
using WordScramble.Domains.ViewModels;

namespace WordScramble.Api.Controllers
{
    public class LookupController : ControllerBase
    {
        private readonly ApplicationSettings applicationSettings;

        public LookupController(ApplicationSettings applicationSettings, IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {
            this.applicationSettings = applicationSettings;
        }

        [HttpGet, Route("[controller]/{word}")]
        public IActionResult Index([FromRoute]string word)
        {
            return View(new LookupIndexViewModel { 
                DictionaryUriFormat = applicationSettings.DictionaryUriFormat,
                Word = word
            });
        }
    }
}
