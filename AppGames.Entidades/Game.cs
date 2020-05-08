using System;
using System.Collections.Generic;
using System.Text;

namespace AppGames.Entidades
{
    public class Game
    {
        public int IdGame { get; set; }
        public string Nome { get; set; }

        public int IdPlataforma { get; set; }
        public Plataforma Plataforma { get; set; }

        public Game()
        {

        }

        public Game(int idGame, string nome, int idPlataforma)
        {
            IdGame = idGame;
            Nome = nome;
            IdPlataforma = idPlataforma;
        }

        public override string ToString()
        {
            return $"Id do game: {IdGame}, Nome:{Nome}";
        }
    }
}
