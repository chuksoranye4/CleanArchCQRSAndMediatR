using MediatR;
using WeatherFocasts.Core;

namespace WeatherFocasts.Application.Queries;

public class GetAllForecastQuery : IRequest<List<WeatherForecast>>
{
}
