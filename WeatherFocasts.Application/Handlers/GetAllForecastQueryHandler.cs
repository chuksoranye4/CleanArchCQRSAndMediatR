using MediatR;
using Microsoft.EntityFrameworkCore;
using WeatherFocasts.Application.Queries;
using WeatherFocasts.Core;
using WeatherFocasts.Infrastructure;

namespace WeatherFocasts.Application.Handlers;

public class GetAllForecastQueryHandler : IRequestHandler<GetAllForecastQuery, List<WeatherForecast>>
{
    private readonly DataContext _dataContext;

    public GetAllForecastQueryHandler(DataContext dataContext)
    {
        _dataContext = dataContext;
    }
    public async Task<List<WeatherForecast>> Handle(GetAllForecastQuery request, CancellationToken cancellationToken)
    {
        return await _dataContext.Forecast.ToListAsync();
    }
}
