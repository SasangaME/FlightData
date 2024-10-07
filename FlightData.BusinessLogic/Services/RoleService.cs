using FlightData.Models.Entities;
using FlightData.Models.Exceptions;
using FlightData.Repositories.Repositories;

namespace FlightData.BusinessLogic.Services;

public interface IRoleService
{
    Task<IEnumerable<Role>> FindAll();
    Task<Role?> FindById(int id);
    Task<Role> Create(Role role);
    Task<Role> Update(int id, Role role);
}

public class RoleService(IRoleRepository roleRepository) : IRoleService
{
    public async Task<IEnumerable<Role>> FindAll()
    {
        return await roleRepository.FindAll();
    }

    public async Task<Role?> FindById(int id)
    {
        var role = await roleRepository.FindById(id);
        if (role is null)
        {
            throw new NotFoundException($"role not found for id: {id}");
        }

        return role;
    }

    public async Task<Role> Create(Role role)
    {
        role.CreatedAt = DateTime.Now;
        role.Id = await roleRepository.Create(role);
        return role;
    }

    public async Task<Role> Update(int id, Role role)
    {
        var existingRole = await FindById(id);
#nullable disable
        existingRole.Name = role.Name;
        existingRole.Description = role.Description;
        existingRole.UpdatedAt = DateTime.Now;
#nullable disable
        await roleRepository.Update(role);
        return role;
    }
}