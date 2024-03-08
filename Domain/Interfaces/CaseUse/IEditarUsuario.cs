using Beach_Service_API.Domain.Entitites;

namespace Beach_Service_API.Domain.Interfaces.CaseUse
{
    public interface IEditarUsuario
    {
        Usuario EditarUsuario(int id, Usuario p_usuario);
    }
}
