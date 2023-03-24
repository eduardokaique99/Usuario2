using System;

namespace View
{
    public class Sessao
    {
        /*public static void CadastrarSessao() {
            Console.WriteLine("Cadastrar Sessao");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            Console.WriteLine("Caminhão:");
            string token = Console.ReadLine();
            Console.WriteLine("Data:");
            string dataCriacao = Console.ReadLine();
            Console.WriteLine("Valor:");
            string dataExpiracao = Console.ReadLine();
            try {
                Controller.Sessao.CadastrarSessao(id, token, dataCriacao, dataExpiracao);
                Console.WriteLine("Sessao cadastrada com sucesso");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        } 

        public static void AlterarSessao() {
            Console.WriteLine("Alterar Sessao");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            Console.WriteLine("Caminhão:");
            string token = Console.ReadLine();
            Console.WriteLine("Data:");
            string dataCriacao = Console.ReadLine();
            Console.WriteLine("Valor:");
            string dataExpiracao = Console.ReadLine();
            try {
                Controller.Sessao.AlterarSessao(id, token, dataCriacao, dataExpiracao);
                Console.WriteLine("Sessao alterada com sucesso");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        } 

        public static void ExcluirSessao() {
            Console.WriteLine("Excluir Sessao");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            try {
                Controller.Sessao.ExcluirSessao(id);
                Console.WriteLine("Sessao excluída com sucesso");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        } */
        public static void Login() //Solicitando os dados para fazer o login do usuario
        {
            Console.Clear();
            Console.WriteLine("Login");
            Console.WriteLine("Digite o email");
            string email = Console.ReadLine();
            Console.WriteLine("Digite a senha");
            string senha = Console.ReadLine();
            try
            {
                Model.Sessao sessao = Controller.Sessao.Login(email, senha);
                Console.WriteLine("Login efetuado com sucesso");
                Console.WriteLine(sessao);
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ListarSessao() { //Listando as sessões
            Console.WriteLine("Listar Sessões");
            foreach (string sessao in Controller.Sessao.ListarSessao()) {
                Console.WriteLine(sessao);
            }
        } 
    } 
}