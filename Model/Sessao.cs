using System;
using System.Collections.Generic;

namespace Model
{
    public class Sessao 
    {
        public int Id { get; set; }
        public Usuario id { get; set; }
        public string Token { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataExpiracao { get; set; }
        public static List<Sessao> Sessoes { get; set; } = new List<Sessao>();
        
        public Sessao(
            int id,
            string token,
            DateTime dataCriacao,
            DateTime dataExpiracao
        )
        {
            Id = id;
            Token = token;
            DataCriacao = dataCriacao;
            DataExpiracao = dataExpiracao;

            Sessoes.Add(this);
        } 

        public override string ToString() 
        {
            return $"Id: {Id}, Token: {Token}, DataCriacao: {DataCriacao}, DataExpiracao}: {DataExpiracao}";
        } 

        public static void AlterarRota( 
            int id,
            string token,
            DateTime dataCriacao,
            DateTime dataExpiracao
        )
        {
            Sessao sessao = BuscarRota(id);
            sessao.Id = id;
            sessao.Token = token;
            sessao.DataCriacao = dataCriacao;
            sessao.DataExpiracao = dataExpiracao;
        }

        public static void ExcluirRota(int id) 
        {
            Sessao sessao = BuscarRota(id);
            Sessoes.Remove(sessao);
        }

        public static Sessao BuscarRota(int id) 
        {
            Sessao? sessao = Sessoes.Find(r => r.Id == id);
            if (sessao == null) {
                throw new Exception("Sessão não encontrada");
            }

            return sessao;
        }
    }
}