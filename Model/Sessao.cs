using System;
using System.Collections.Generic;

namespace Model
{
    public class Sessao 
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
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
            return $"Id: {Id}, Token: {Token}, DataCriacao: {DataCriacao}, DataExpiracao: {DataExpiracao}";
        } 

        /*public static void AlterarRota( 
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
        }*/
        public static Sessao AlterarSessao(int id, DateTime dataExpiracao)
        {
            Database db = new Database();
            try
            {
                Sessao sessao = (from s in db.Sessoes
                                 where s.Id == id
                                 select s).First();
                sessao.DataExpiracao = dataExpiracao;
                db.SaveChanges();
                return sessao;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<Sessao> ListarSessoes()
        {
            Database db = new Database();
            try
            {
                List<Sessao> sessoes = db.Sessoes.Include("Usuario").ToList();
                return sessoes;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}