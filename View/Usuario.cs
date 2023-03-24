using System;

namespace View
{
    public class Usuario
    {
        public static void CadastrarUsuario() //Solicitando os dados para cadastrar o usuario
        {
            Console.WriteLine("Digite o id do usuario:");
            string id = Console.ReadLine();
            Console.WriteLine("Digite o nome do usuario:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o id do usuario:");
            string email = Console.ReadLine();
            Console.WriteLine("Digite o nome do usuario:");
            string senha = Console.ReadLine();
            try {
                Controller.Usuario.CriarUsuario(id, nome, email, senha);
                Console.WriteLine("Usuario cadastrada com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao cadastrar usuario: {e.Message}");
            }
        } 

        public static void AlterarUsuario()//Solicitando alteração dos dados do usuario
        {
            Console.WriteLine("Digite o id da usuario:");
            string id = Console.ReadLine();
            Console.WriteLine("Digite o nome da usuario:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o id da usuario:");
            string email = Console.ReadLine();
            Console.WriteLine("Digite o nome da usuario:");
            string senha = Console.ReadLine();
            try {
                Controller.Usuario.AlterarUsuario(id, nome, email, senha);
                Console.WriteLine("Usuario alterada com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao alterar usuario: {e.Message}");
            }
        } 

        public static void ExcluirUsuario()//Solicitando ID do usuario para excluir-lo
        {
            Console.WriteLine("Digite o id da usuario:");
            string id = Console.ReadLine();
            try {
                Controller.Usuario.ExcluirUsuario(id);
                Console.WriteLine("Usuario excluída com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao excluir usuario: {e.Message}");
            }
        } 

        public static void ListarUsuarios() {//Listando os usuarios cadastrados
            Console.WriteLine("Listar usuarios");
            foreach (Model.Usuario usuario in Controller.Usuario.ListarUsuarios()) {
                Console.WriteLine(usuario);
            }
        } 
    }
}