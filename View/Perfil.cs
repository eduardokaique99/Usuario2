using System;

namespace View
{
    public class Perfil
    {
        public static void CadastrarPerfil() //Solicitando os dados parar cadastrar o perfil
        {
            Console.WriteLine("Cadastrar perfil");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            Console.WriteLine("Permissão:");
            string permissao = Console.ReadLine();
            try {
                Model.Perfil.CadastrarPerfil(id, permissao);
                Console.WriteLine("Perfil cadastrado com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao cadastrar perfil: {e.Message}");
            }
        } 

        /*public static void AlterarPerfil()
        {
            Console.WriteLine("Alterar perfil");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            Console.WriteLine("Placa:");
            string permissao = Console.ReadLine();
            Console.WriteLine("Motorista:");
            string usuario_Id = Console.ReadLine();
            try {
                Controller.Perfil.AlterarPerfil(id, permissao, usuario_Id);
                Console.WriteLine("Perfil alterado com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao alterar perfil: {e.Message}");
            }
        } */

        public static void ExcluirPerfil()//Solicitando o ID do perfil, para exclui-lo
        {
            Console.WriteLine("Excluir perfil");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            try {
                Controller.Perfil.ExcluirPerfil(id);
                Console.WriteLine("Perfil excluído com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao excluir perfil: {e.Message}");
            }
        } 

        public static void ListarPerfils() { //Listar os perfies
            Console.WriteLine("Listar perfil");
            foreach (Model.Perfil perfil in Controller.Perfil.ListarPerfils()) {
                Console.WriteLine(perfil);
            }
        } 
    }
}