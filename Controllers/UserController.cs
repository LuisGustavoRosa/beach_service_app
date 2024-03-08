using Beach_Service_API.Domain.Entitites;
using Beach_Service_API.Domain.Interfaces.Repositorio;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BeachService_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(IRepositorioUsuario p_repositorioUsuario) : ControllerBase
{
 
    [HttpGet]
    public List<Usuario> Get()
    {
        return p_repositorioUsuario.ListarTodosOsUsuarios();
    }

    [HttpGet("{id}")]
    public string GetId(int id)
    {
        return "value";
    }

    
    [HttpPost]
    public void Post([FromBody] Usuario p_user)
    {
    }

  
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Usuario p_user)
    {
        p_repositorioUsuario.EditarUsuario(id, p_user);
    }

 
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
