using NHibernate.Cfg;
using NHibernate.Driver;
using NHibernate.Dialect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace SanPablo.CarBluMon.DataAccess.HibernateManager
{
    internal static class HibernateManager
    {
        private static readonly ISessionFactory _sessionFactory;
        private static readonly Configuration _configuration;
        static HibernateManager()
        {
            _configuration = getProperties();
            
            _sessionFactory = getProperties().BuildSessionFactory(); ;
        }
        private static Configuration getProperties() {
            Configuration cfg = new Configuration();
            cfg.AddProperties(new Dictionary<string, string>
                                {
                                    { NHibernate.Cfg.Environment.ConnectionDriver, typeof(Sql2008ClientDriver).FullName }
                                    , { NHibernate.Cfg.Environment.Dialect, typeof(MsSql2012Dialect).FullName }
                                    , { NHibernate.Cfg.Environment.ConnectionString, "" }
                                    //Only for Debug

                                }
                              );
            return cfg;
        }

        public static ISessionFactory SessionFactory {
            get { return _sessionFactory; } 
        }

    }
}
