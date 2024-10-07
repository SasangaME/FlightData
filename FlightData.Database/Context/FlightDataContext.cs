﻿using FlightData.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlightData.Database.Context;

public class FlightDataContext(DbContextOptions<FlightDataContext> options) : DbContext(options)
{
    public DbSet<Role> Roles { get; set; }
}