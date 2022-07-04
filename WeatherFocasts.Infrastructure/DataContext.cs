using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherFocasts.Core;

namespace WeatherFocasts.Infrastructure
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<WeatherForecast> Forecast { get; set; }
    }
}
