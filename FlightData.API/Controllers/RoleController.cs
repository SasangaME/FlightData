using AutoMapper;
using FlightData.BusinessLogic.Services;
using FlightData.Models.Dto;
using FlightData.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FlightData.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RoleController(IRoleService roleService, IMapper mapper) : ControllerBase
{
    // GET: api/<RoleController>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<RoleDto>>> Get()
    {
        var roles = await roleService.FindAll();
        return Ok(mapper.Map<IEnumerable<RoleDto>>(roles));
    }

    // GET api/<RoleController>/5
    [HttpGet("{id:int}")]
    public async Task<ActionResult<RoleDto>> Get(int id)
    {
        var role = await roleService.FindById(id);
        return Ok(mapper.Map<RoleDto>(role));
    }

    // POST api/<RoleController>
    [HttpPost]
    public async Task<ActionResult<RoleDto>> Post([FromBody] RoleDto request)
    {
        var role = await roleService.Create(mapper.Map<Role>(request));
        return Ok(mapper.Map<RoleDto>(role));
    }

    // PUT api/<RoleController>/5
    [HttpPut("{id:int}")]
    public async Task<ActionResult<RoleDto>> Put(int id, [FromBody] RoleDto request)
    {
        var role = await roleService.Update(id, mapper.Map<Role>(request));
        return Ok(mapper.Map<RoleDto>(role));
    }
}