using System;
using System.Collections.Generic;

namespace Model
{
    public class Perfil // Criando a classe com os atributos do CAMINHAO
    {
        public int Id { get; set; }
        public Usuario id { get; set; }
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

        public static void AlterarPerfil( 
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
        }
    }
}