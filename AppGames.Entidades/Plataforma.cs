using System;
using System.Collections.Generic;
using System.Text;

namespace AppGames.Entidades
{
    public class Plataforma
    {
        public int IdPlataforma { get; set; }
        public string Nome { get; set; }

        public Plataforma()
        {

        }

        public Plataforma(int idPlataforma, string nome)
        {
            IdPlataforma = idPlataforma;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"Id da Plataforma: {IdPlataforma}, Nome: {Nome}";
        }
    }
}
