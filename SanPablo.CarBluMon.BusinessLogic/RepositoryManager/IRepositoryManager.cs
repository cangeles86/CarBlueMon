using SanPablo.CarBluMon.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPablo.CarBluMon.BusinessLogic.RepositoryManager
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
