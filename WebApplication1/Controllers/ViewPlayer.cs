using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Controllers
{

    

    public partial class NaviController
    {

        [HttpGet(Name = "GetNavi")]
        public IEnumerable<Player> Get()
        {
            return parts;

        }

        

    }
}
