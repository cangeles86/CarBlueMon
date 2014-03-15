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
            try
            {
                ISession session = HibernateManager.HibernateManager.GetSession().OpenSession();
                T entidad = (T)session.Get<T>(code);
                return entidad;
            }
            catch (Exception)
            {
                return null;
            }          
        }

        public List<T> Find(T entity)
        {
            List<T> list;
            try
            {
                ISession session = HibernateManager.HibernateManager.GetSession().OpenSession();
                list = (List<T>)session.CreateCriteria(typeof(T)).List<T>();
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
