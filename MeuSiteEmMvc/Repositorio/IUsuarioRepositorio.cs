﻿using MeuSiteEmMvc.Models;

namespace MeuSiteEmMvc.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel BuscarPorLogin(string login);

        UsuarioModel BuscarPorEmailELogin(string email,string login);
        UsuarioModel ListarPorId(int id);


        List<UsuarioModel> BuscarTodos();
      
        UsuarioModel Adicionar(UsuarioModel contato);

        UsuarioModel Atualizar(UsuarioModel contato);

        UsuarioModel AlterarSenha(AlterarSenhaModel alterarSenhaModel);

        bool Apagar(int id);


    }
}
