using FlightData.Database.Context;
using FlightData.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlightData.Repositories.Repositories;

public interface IRoleRepository
{
    Task<IEnumerable<Role>> FindAll();
    Task<Role?> FindById(int id);
    Task<int> Create(Role role);
    Task Update(Role role);
}

public class RoleRepository(FlightDataContext context) : IRoleRepository
{
    public async Task<IEnumerable<Role>> FindAll()
    {
        return await context.Roles.ToListAsync();
    }

    public async Task<Role?> FindById(int id)
    {
        return await context.Roles.FindAsync(id);
    }

    public async Task<int> Create(Role role)
    {
        await context.Roles.AddAsync(role);
        await context.SaveChangesAsync();
        return role.Id;
    }

    public async Task Update(Role role)
    {
        context.Entry(role).State = EntityState.Modified;
        await context.SaveChangesAsync();
    }
}