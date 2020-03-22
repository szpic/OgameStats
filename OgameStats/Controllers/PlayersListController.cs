using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OgameStats.DataBase;
using OgameStats.DataBase.DatabaseModels;
using OgameStats.Dtos;
using OgameStats.WebserviceConnection.Interfaces;

namespace OgameStats.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerListController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IPlayerEndPoint _getPlayers;
        private readonly IUniverseEndPoint _getUniverse;
        private readonly OgameStatsContext _context;

        public PlayerListController(ILogger<WeatherForecastController> logger
            , IPlayerEndPoint getPlayers,
            OgameStatsContext context)
        {
            _logger = logger;
            _getPlayers = getPlayers;
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Player>> Get()
        {
            //PlayersListDto players = await _getPlayers.ExecuteAsync();
            //UniverseDto universe = await _getUniverse.ExecuteAsync();
            return await _context.Players.ToListAsync();

        }
    }
}
