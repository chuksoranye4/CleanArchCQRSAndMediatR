using MediatR;
using Microsoft.AspNetCore.Mvc;
using WeatherFocasts.Application.Commands;
using WeatherFocasts.Application.Handlers;
using WeatherFocasts.Application.Queries;
using WeatherFocasts.Core;

namespace WeatherFocasts.API.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IMediator _mediator;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }


    private static readonly string[] Summaries = new[]
    {
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};



    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _mediator.Send(new GetAllForecastQuery());
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] WeatherForecast weatherForecast)
    {
        var command = new CreateWeatherForecastCommand()
        {
            NewWeatherForecast = weatherForecast
        };

        var result = await _mediator.Send(command);
        return Ok(result);
    }
}
