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

        public static void AlterarUsuario( // Metodo para alterar a CIDADE
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
        }
    }
}