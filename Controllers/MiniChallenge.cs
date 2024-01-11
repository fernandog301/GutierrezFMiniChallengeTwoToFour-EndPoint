using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GutierrezFMiniChallengeTwoToFour_EndPoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MiniChallenge : Controller
    {
        [HttpGet]
        [Route("")]
        private readonly MiniChallengeOne _miniChallenge;

        public MiniChallenge(MiniChallengeOne miniChallenge)
        {
            _miniChallenge = miniChallenge;
        }
        
    }
}