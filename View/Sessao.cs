using System;

namespace View
{
    public class Sessao
    {
        public static void CadastrarSessao() {
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
        } 

        public static void ListarSessao() {
            Console.WriteLine("Listar Sessaos");
            foreach (string sessao in Controller.Sessao.ListarSessao()) {
                Console.WriteLine(sessao);
            }
        } 
    } 
}