using System;
using System.Collections.Generic;

namespace Model
{
    public class Usuario // Criando a classe com os atributos do CIDADE
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public static List<Usuario> Usuarios { get; set; } = new List<Usuario>();
        // get e set declarados dos atributos
        public Usuario(int id, string nome, string email, string senha)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;

            Usuarios.Add(this);
        } // Construtor

        public override string ToString() // override para zerar o valor 
        {
            return $"Id: {Id}, Nome: {Nome}, Email: {Email}, Senha: {Senha}";
        } // Imprime as informações

        /*public static void AlterarUsuario( // Metodo para alterar a CIDADE
            int id,
            string nome,
            string email,
            string senha
        )
        {
            Usuario usuario = BuscarUsuario(id);
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = senha;
        }

        public static void ExcluirUsuario(int id) // Metodo para deletar a CIDADE pelo id
        {
            Usuario usuario = BuscarUsuario(id);
            Usuarios.Remove(usuario);
        }

        public static Usuario BuscarUsuario(int id) // Metodo para buscar a CIDADE pelo id
        {
            Usuario? usuario = Usuarios.Find(c => c.Id == id);
            if (usuario == null) {
                throw new Exception("Usuario não encontrada");
            }
            return usuario;
        }*/
        public static Model.Usuario BuscarUsuario( //Metodo para buscar no banco algum usuario
            int id
        )
        {
            Database db = new Database();
            try
            {
                Model.Usuario usuario = (from u in db.Usuarios
                                     where u.Id == id
                                     select u).First();
                return usuario;
            } catch
            {
                throw new System.Exception("Usuário não encontrado");
            }
            
        }

        public static Usuario AlterarUsuario( //Metodo para alterar os dados de algum usuario do banco
            int id,
            string nome,
            string email,
            string senha
        )
        {
            try
            {
                Usuario usuario = BuscarUsuario(id);
                usuario.Email = email;
                usuario.Nome = nome;
                usuario.Senha = senha;
                Database db = new Database();
                db.Usuarios.Update(usuario);
                db.SaveChanges();

                return usuario;
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static void ExcluirUsuario( //Metodo para excluir algum usuario do banco
            int id
        )
        {
            try
            {
                Model.Usuario usuario = BuscarUsuario(id);
                Database db = new Database();
                db.Usuarios.Remove(usuario);
                db.SaveChanges();
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static List<Model.Usuario> ListarUsuarios() { // Metodo para listar os usuarios
            Database db = new Database();
            List<Model.Usuario> usuarios = (from u in db.Usuarios
                                        select u).ToList();
            return usuarios;
        }

        public static Model.Usuario BuscarPorEmail(string email) { // Metodo para buscar usuario pelo e-mail
            try {
                Database db = new Database();
                Model.Usuario usuario = (from u in db.Usuarios
                                            where u.Email == email
                                            select u).First();
                return usuario;
            } catch {
                throw new System.Exception("Usuário não encontrado");
            }
        }
    }
}