using System;
using System.Collections.Generic;

namespace Model
{
    public class Perfil // Criando a classe PERFIL
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Permissao { get; set; }
        public static List<Perfil> Perfils { get; set; } = new List<Perfil>();
        
        public Perfil(int id, int usuario_Id, string permissao)
        {
            Id = id;
            id = usuario_Id;
            Permissao = permissao;

            Perfils.Add(this);
        } 

        public override string ToString() 
        {
            return $"Id: {Id}, Id usuario: {id}, Permissão: {Permissao}";
        } 

        /*public static void AlterarPerfil( 
            int id,
            int usuario_Id,
            string permissao
        )
        {
            Perfil perfil = BuscarPerfil(id);
            perfil.id = usuario_Id;
            perfil.Permissao = permissao;
        }

        public static void ExcluirPerfil(int id) 
        {
            Perfil perfil = BuscarPerfil(id);
            Perfils.Remove(perfil);
        }

        public static Perfil BuscarPerfil(int id) 
        {
            Perfil? perfil = Perfils.Find(c => c.Id == id);
            if (perfil == null) {
                throw new Exception("Perfil não encontrado");
            }
            return perfil;
        }*/

        public static Perfil BuscarPerfil(int id) {//Metodo para buscar algum perfil no banco
            Database db = new Database();
            try
            {
                Perfil perfil = (from p in db.Perfis
                                 join u in db.Usuarios on p.UsuarioId equals u.Id
                                 where p.Id == id
                                 select p).First();
                return perfil;
            }
            catch (Exception)
            {
                throw new Exception("Perfil não encontrado");
            }
        }

        public static Perfil BuscarPerfilPorUsuario(int UsuarioId) {
            Database db = new Database();
            try
            {
                Perfil perfil = (from p in db.Perfis
                                 where p.UsuarioId == UsuarioId
                                 select p).First();
                return perfil;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void ExcluirPerfil(int id) {//Metodo para excluir algum perfil do banco
            Database db = new Database();

            Perfil perfil = BuscarPerfil(id);
            db.Perfis.Remove(perfil);
            db.SaveChanges();
        }

        public static List<Perfil> ListarPerfis()//Metodo para listar os perfies
        {
            Database db = new Database();
            return db.Perfis.Include("Usuario").ToList();            
        }
    }
}