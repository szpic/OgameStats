using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OgameStats.DataBase;
using OgameStats.Dtos;
using OgameStats.WebserviceConnection.Interfaces;

namespace OgameStats.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IPlayerEndPoint _getPlayers;
        private readonly IUniverseEndPoint _getUniverse;
        private readonly OgameStatsContext _context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger
            , IPlayerEndPoint getPlayers
            , IUniverseEndPoint getUniverse,
            OgameStatsContext context)
        {
            _logger = logger;
            _getPlayers = getPlayers;
            _getUniverse = getUniverse;
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            //PlayersListDto players = await _getPlayers.ExecuteAsync();
            //UniverseDto universe = await _getUniverse.ExecuteAsync();
            var data =  await _context.Players.ToListAsync();
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
