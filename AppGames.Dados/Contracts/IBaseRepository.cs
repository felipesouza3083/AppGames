using System;
using System.Collections.Generic;
using System.Text;

namespace AppGames.Dados.Contracts
{
    public interface IBaseRepository<T>
        where T : class
    {
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
        IList<T> FindAll();
        T FindById(int id);
    }
}
