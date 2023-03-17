using System;
using System.Collections.Generic;

namespace Controller
{
    public class Usuario
    {
        public static void CadastrarUsuario(string id, string nome, string email, string senha)
        {
            int idConvert = 0;
            try
            {
                idConvert = int.Parse(id);
            }
            catch (Exception)
            {
                throw new Exception("Id inválido");
            }
            Model.Usuario usuario = new Model.Usuario(idConvert, nome, email, senha);
        }

        public static void AlterarUsuario(string id, string nome, string email, string senha) // Metodo para alterar as informacoes da CIDADE
        {
            int idConvert = 0;
            try
            {
                idConvert = int.Parse(id);
            }
            catch (Exception)
            {
                throw new Exception("Id inválido");
            }

            Model.Usuario.AlterarUsuario(idConvert, nome, email, senha);
        }

        public static void ExcluirUsuario(string id)
        {
            int idConvert = 0;
            try
            {
                idConvert = int.Parse(id);
            }
            catch (Exception)
            {
                throw new Exception("Id inválido");
            }

            Model.Usuario.ExcluirUsuario(idConvert);
        }

        public static Model.Usuario BuscarUsuario(string id)
        {
            int idConvert = 0;
            try
            {
                idConvert = int.Parse(id);
            }
            catch (Exception)
            {
                throw new Exception("Id inválido");
            }

            return Model.Usuario.BuscarUsuario(idConvert);
        }

        public static List<Model.Usuario> ListarUsuarios()
        {
            return Model.Usuario.Usuarios;
        }
    }
}