using NHibernate;
using System;
using System.Collections.Generic;

namespace SanPablo.CarBluMon.DataAccess.RepositoryManager
{
    public abstract class RepositoryManager<T>: IRepositoryManager<T> where T : class
    {
        public bool Register(T entity)
        {
            try
            {
                ISession session = HibernateManager.HibernateManager.GetSession().OpenSession();
                session.Save(entity);
                session.Flush();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException.Message);
                return false;
            }

        }

        public bool Modify(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int code)
        {
            throw new NotImplementedException();
        }

        public T FindById(int code)
        {
            throw new NotImplementedException();
        }

        public List<T> Find(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
