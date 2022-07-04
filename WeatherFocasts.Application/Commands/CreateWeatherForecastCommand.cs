using MediatR;
using WeatherFocasts.Core;

namespace WeatherFocasts.Application.Commands;

public class CreateWeatherForecastCommand : IRequest<WeatherForecast>
{
    public WeatherForecast NewWeatherForecast { get; set; }
}
