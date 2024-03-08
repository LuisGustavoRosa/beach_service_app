using Microsoft.EntityFrameworkCore;
using Beach_Service_API.Domain.Entitites;
using Beach_Service_API.Domain.Interfaces.Repositorio;

namespace Beach_Service_API.Infrastructure.Data.Repositories;

public class RepositorioUsuario(AppDbContext _db) : IRepositorioUsuario
{
    public Usuario CriarUsuario(Usuario p_user)
    {
        _db.usuario.Add(p_user);
        _db.SaveChanges();
        return p_user;
    }

    public Usuario EditarUsuario(int id, Usuario p_usuario)
    {
        _db.Attach(p_usuario);
        _db.Entry(p_usuario).State = EntityState.Modified;
        _db.SaveChanges();
        return p_usuario;
    }

    public List<Usuario> ListarTodosOsUsuarios()
    {
        return _db.usuario.ToList();
    }
}
