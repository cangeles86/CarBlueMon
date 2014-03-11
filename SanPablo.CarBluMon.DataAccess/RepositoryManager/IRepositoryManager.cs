using System.Collections.Generic;

namespace SanPablo.CarBluMon.DataAccess.RepositoryManager
{
    public interface IRepositoryManager<T>
    {
        bool Register(T entity);
        bool Modify(T entity);
        bool Remove(int code);
        T FindById(int code);
        List<T> Find(T entity);

    }
}
