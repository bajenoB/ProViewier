using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public partial class NaviController : Controller
    {
        private static int id = 0;

        private static List<Player> parts = new List<Player>()
        {
            new Player(++id,"Solo",31,TeamController.teams[0]),
            new Player(++id,"General",27,TeamController.teams[0]),
            new Player(++id,"VTune",22,TeamController.teams[0]),
            new Player(++id,"Noone",24,TeamController.teams[0]),
            new Player(++id,"Alohadance",25,TeamController.teams[0]),
            new Player(++id,"Miposhka",27,TeamController.teams[1]),
            new Player(++id,"Yatoro",18,TeamController.teams[1]),
            new Player(++id,"Collapse",22,TeamController.teams[1]),
            new Player(++id,"Mira",19,TeamController.teams[1]),
            new Player(++id,"TORONTOTOKYO",23,TeamController.teams[1]),

        };




        private readonly ILogger<NaviController> _logger;

        public NaviController(ILogger<NaviController> logger)
        {
            _logger = logger;
        }
        

        [HttpPost(Name = "PostPlayer")]
        public StatusCodeResult Post(string w_name, int w_age, string team)
        {
            int index = TeamController.teams.FindIndex(x => x.Name == team);
            if (index == -1 || w_name == null || w_age == null )
            {
                return StatusCode(204);
            }
            parts.Add(new Player(++id, w_name, w_age, TeamController.teams[index]));
            return StatusCode(200);
        }

        [HttpDelete(Name = "DeletePlayerById")]
        public StatusCodeResult Delete(int id)
        {
            int index = parts.FindIndex(x => x.Id == id);
            if (index == -1)
            {
                return StatusCode(204);
            }
            parts.RemoveAt(index);
            return StatusCode(200);
        }

        [HttpPatch(Name = "PatchPlayer")]
        public StatusCodeResult Patch(int oldId, string w_name, int w_age, string team)
        {
            int index = parts.FindIndex(x => x.Id == oldId);
            int teamIndex = TeamController.teams.FindIndex(x => x.Name == team);
            if (index == -1 || teamIndex == -1 || w_name == null || w_age == -1 )
            {
                return StatusCode(204);
            }

            parts[index] = new Player(oldId, w_name, w_age,  TeamController.teams[teamIndex]);
            return StatusCode(200);
        }

    }
}
