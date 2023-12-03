using MeuSiteEmMvc.Models;

namespace MeuSiteEmMvc.Repositorio
{
    public interface IContatoRepositorio
    {


        ContatoModel ListarPorId(int id);


        List<ContatoModel> BuscarTodos(int usuarioId);
        ContatoModel Adicionar(ContatoModel usuario);

        ContatoModel Atualizar(ContatoModel usuario);

        bool Apagar(int id);


    }
}
