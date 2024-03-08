using Beach_Service_API.Domain.Entitites;

namespace Beach_Service_API.Domain.Interfaces.Repositorio;

public interface IRepositorioUsuario
{
    Usuario CriarUsuario(Usuario p_usuario);
    List<Usuario> ListarTodosOsUsuarios();

    Usuario EditarUsuario(int id, Usuario p_usuario);
}
