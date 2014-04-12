using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;

namespace SanPablo.CarBluMon.DataAccess.RepositoryManager
{
    public abstract class RepositoryManager<T>: IRepositoryManager<T> where T : class
    {
        public virtual bool Register(T entity)
        {
            try
            {
                ISession session = HibernateManager.HibernateManager.GetSession();
                
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

        public virtual bool Modify(T entity)
        {
            try
            {
                ISession session = HibernateManager.HibernateManager.GetSession();
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

        public virtual bool Remove(T entity)
        {
            try
            {
                ISession session = HibernateManager.HibernateManager.GetSession();
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

        public virtual T FindById(int code)
        {
            try
            {
                ISession session = HibernateManager.HibernateManager.GetSession();
                T entidad = (T)session.Get<T>(code);    
                return entidad;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return null;
            }          
        }

        public virtual List<T> Find(params string[][] criteriaListEq)
        {
            List<T> list;
            try
            {
                ISession session = HibernateManager.HibernateManager.GetSession();
                if (criteriaListEq == null)
                {
                    list = (List<T>)session.CreateCriteria(typeof(T)).List<T>();
                }
                else
                {
                    ICriteria criteria = session.CreateCriteria(typeof(T));
                    foreach (string[] item in criteriaListEq)
                    {
                        /*String Array: 
                         * Index 0: Compare Type
                         * Index 1: Data Fied
                         * Index 2: Value
                         * Index 3: Alias
                         */
                        if (item != null)
                        {
                            switch (item[0])
                            {
                                case "Eq":
                                    criteria.Add(Expression.Eq(item[1], item[2]));
                                    break;
                                case "Eq|Ns":
                                    criteria.CreateAlias(item[3], "ref");
                                    criteria.Add(Expression.Eq("ref." + item[1], item[2]));
                                    break;
                                case "Eq|NsIn":
                                    criteria.CreateAlias(item[3], "ref");
                                    criteria.Add(Expression.Eq("ref." + item[1], int.Parse(item[2])));
                                    break;
                                case "Lk":
                                    criteria.Add(Expression.Like(item[1], item[2] + "%"));
                                    break;
                                case "Activo":
                                    criteria.Add(Expression.Eq(item[1], true));
                                    break;
                                case "Inactivo":
                                    criteria.Add(Expression.Eq(item[1], false));
                                    break;                                    
                                default:
                                    break;
                            }
                        }                        
                    }
                    list = (List<T>)criteria.List<T>();
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
