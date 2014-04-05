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
            try
            {
                ISession session = HibernateManager.HibernateManager.GetSession().OpenSession();
                session.Update(entity);
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

        public bool Remove(T entity)
        {
            try
            {
                ISession session = HibernateManager.HibernateManager.GetSession().OpenSession();
                session.Delete(entity);
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

        public T FindById(int code)
        {
            try
            {
                ISession session = HibernateManager.HibernateManager.GetSession().OpenSession();
                T entidad = (T)session.Get<T>(code);    
                return entidad;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return null;
            }          
        }

        public List<T> Find(T entity)
        {
            List<T> list;
            try
            {
                ISession session = HibernateManager.HibernateManager.GetSession().OpenSession();
                if (entity == null)
                {
                    list = (List<T>)session.CreateCriteria(typeof(T)).List<T>();
                }
                else
                {
                    list = null;
                }
                
                return list;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return null;
            }
        }
    }
}
