using System;
using System.Collections.Generic;

namespace Controller
{
    public class Usuario
    {
        /*public static void CadastrarUsuario(string id, string nome, string email, string senha)
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
        }*/
        public static Model.Usuario CriarUsuario( //Cadastrar
            string nome,
            string email,
            string senha
        )
        {

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            if (!match.Success)
                throw new Exception("Email inválido");

            Model.Usuario usuario = new Model.Usuario(
                nome,
                email,
                senha
            );
            return usuario;
        }

        public static Model.Usuario AlterarUsuario(
            string id,
            string nome,
            string email,
            string senha
        )
        {
            try
            {
                int idUsuario = Int32.Parse(id);

                return Model.Usuario.AlterarUsuario(
                    idUsuario,
                    nome,
                    email,
                    senha
                );
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static void ExcluirUsuario(
            string id
        )
        {
            try
            {
                int idUsuario = Int32.Parse(id);

                Model.Usuario.ExcluirUsuario(idUsuario);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static List<Model.Usuario> ListarUsuarios() {
            return Model.Usuario.ListarUsuarios();
        }


        public static Model.Usuario BuscarPorEmail(string email) {
            return Model.Usuario.BuscarPorEmail(email);
        }

    }
}