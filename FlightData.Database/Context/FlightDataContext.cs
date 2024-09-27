using Microsoft.EntityFrameworkCore;

namespace FlightData.Database.Context;

public class FlightDataContext(DbContextOptions<FlightDataContext> options) : DbContext(options)
{
    
}