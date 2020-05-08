using AppGames.Dados.Context;
using AppGames.Dados.Contracts;
using AppGames.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace AppGames.Dados.Persistence
{
    public class PlataformaRepository : BaseRepository<Plataforma>, IPlataformaRepository
    {
        public PlataformaRepository(ApplicationDbContext context)
            : base(context)
        {
            this.context = context;
        }
    }
}
