using AppGames.Dados.Context;
using AppGames.Dados.Contracts;
using AppGames.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppGames.Dados.Persistence
{
    public class GameRepository:BaseRepository<Game>, IGameRepository
    {
        public GameRepository(ApplicationDbContext context)
            : base(context)
        {
            this.context = context;
        }

        public override IList<Game> FindAll()
        {
            return context.Game
                          .Include(g=> g.Plataforma)
                          .OrderBy(g=> g.Nome)
                          .ToList();
        }
    }
}
