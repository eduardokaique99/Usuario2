using System;
using System.Collections.Generic;

namespace Controller
{
    public class Perfil
    {
        /*public static void CadastrarPerfil(string id, Usuario Id, string permissao)
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            Model.Perfil perfil = new Model.Perfil(idConvert, Id, permissao);
        }

        public static void AlterarPerfil(string id,  Usuario Id, string permissao)
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            
            Model.Perfil.AlterarPerfil(idConvert, Id, permissao);
        }

        public static void ExcluirPerfil(string id) 
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            
            Model.Perfil.ExcluirPerfil(idConvert);
        }

        public static Model.Perfil BuscarPerfil(string id) 
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            
            return Model.Perfil.BuscarPerfil(idConvert);
        }

        public static List<Model.Perfil> ListarPerfils()
        {
            return Model.Perfil.Perfils;
        }*/

        public static Model.Perfil CadastrarPerfil( // Cadastro do PERFIL
            string idUsuario,
            string tipo
        )
        {
            int idUsuarioInt = int.Parse(idUsuario);
            Model.Usuario usuario = Model.Usuario.BuscarUsuario(idUsuarioInt);

            return new Model.Perfil(usuario.Id, tipoPerfil);
        }

        public static void ExcluirPerfil(// Excluir PERFIL
            string id
        )
        {
            int idInt = int.Parse(id);
            Model.Perfil.ExcluirPerfil(idInt);
        }

        public static List<Model.Perfil> ListarPerfis()// Listar PERFIL
        {
            return Model.Perfil.ListarPerfis();
        }
    }
}