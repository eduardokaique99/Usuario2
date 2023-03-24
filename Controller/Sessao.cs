using System;

namespace Controller
{
    public class Sessao
    {
        /*public static void CadastrarSessao(
            int id,
            string token,
            string dataCriacao,
            string dataExpiracao
        )
        {
            int IdConvert = 0; 
            try {
                IdConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            DateTime dataCriacaoConvert = DateTime.Parse(dataCriacao);
            DateTime dataExpiracaoConvert = DateTime.Parse(dataExpiracao);
            Model.Sessao sessao = new Model.Sessao(idConvert, token, dataCriacaoConvert, dataExpiracaoConvert);
        }
 
        public static void AlterarSessao( 
            string id,
            string origemId,
            string destinoId,
            string caminhaoId,
            string data,
            string valore
        )
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
        }
 
        public static void ExcluirSessao(string id) 
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            
            Model.Sessao.ExcluirSessao(idConvert);
        }
 
        public static Model.Sessao BuscarSessao(string id) 
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            
            return Model.Sessao.BuscarSessao(idConvert);
        }*/
        public static Model.Sessao Login( //Fazer o login de acordo com o e-mail e senha
            string email,
            string password
        )
        {
            try {
                Model.Usuario usuario = Usuario.BuscarPorEmail(email);

                if (usuario.Senha != password) {
                    throw new Exception("Senha inválida");
                }

                return new Model.Sessao(usuario.Id);
            } catch
            {
                throw new Exception("Login inválido");
            }
        }
        public static List<Model.Sessao> ListarSessoes()//Listar as sessões
        {
            return Model.Sessao.ListarSessoes();
        }
    }
}