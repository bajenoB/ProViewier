using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    public partial class TeamController
    {
        [HttpGet]
        public IEnumerable<Team> Get()
        {
            return teams;
        }
    }
}