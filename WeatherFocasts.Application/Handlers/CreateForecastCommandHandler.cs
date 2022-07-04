using MediatR;
using WeatherFocasts.Application.Commands;
using WeatherFocasts.Core;
using WeatherFocasts.Infrastructure;

namespace WeatherFocasts.Application.Handlers;

public class CreateForecastCommandHandler : IRequestHandler<CreateWeatherForecastCommand, WeatherForecast>
{
    private readonly DataContext _dataContext;

    public CreateForecastCommandHandler(DataContext dataContext)
    {
        _dataContext = dataContext;
    }
    public async Task<WeatherForecast> Handle(CreateWeatherForecastCommand request, CancellationToken cancellationToken)
    {
        _dataContext.Forecast.Add(request.NewWeatherForecast);
        await _dataContext.SaveChangesAsync();
        return request.NewWeatherForecast;
    }
}
