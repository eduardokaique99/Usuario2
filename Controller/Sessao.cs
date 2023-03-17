using System;

namespace Controller
{
    public class Sessao
    {
        private static int valorTotal;

        public static void CadastrarSessao(
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
            Model.Cidade origem = Model.Cidade.BuscarCidade(int.Parse(origemId));
            Model.Cidade destino = Model.Cidade.BuscarCidade(int.Parse(destinoId));
            Model.Caminhao caminhao = Model.Caminhao.BuscarCaminhao(int.Parse(caminhaoId));
            DateTime dataConvert = DateTime.Parse(data);
            int valor = Int32.Parse(valore);
            Model.Rota.AlterarRota(idConvert, origem, destino, caminhao, dataConvert, valor);
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
        }
 
        public static List<string> ListarSessao()
        {
            List<string> stringSessao = new List<string>();
            IEnumerable<Model.Sessao> rotas = from rota in Model.Sessao.Rotas
                join origem in Model.Cidade.Cidades on rota.Origem.Id equals origem.Id
                join destino in Model.Cidade.Cidades on rota.Destino.Id equals destino.Id
                join caminhao in Model.Caminhao.Caminhoes on rota.Caminhao.Id equals caminhao.Id
                select rota;

            foreach (Model.Sessao rota in rotas) {
                stringSessao.Add($"Id: {rota.Id}, Origem: {rota.Origem.Nome}, Destino: {rota.Destino.Nome}, Caminhão: {rota.Caminhao.Placa}, Data: {rota.Data}, Valor: {rota.Valor}");
            }

            return stringSessao;
        }
    }
}