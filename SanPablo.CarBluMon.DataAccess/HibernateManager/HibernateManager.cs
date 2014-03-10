using NHibernate.Cfg;
using NHibernate.Driver;
using NHibernate.Dialect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Mapping.ByCode;
using SanPablo.CarBluMon.DataAccess.Location;
using SanPablo.CarBluMon.BusinessEntities;

namespace SanPablo.CarBluMon.DataAccess.HibernateManager
{
    internal static class HibernateManager
    {
        private static readonly ISessionFactory _sessionFactory;
        private static readonly Configuration _configuration;
        static HibernateManager()
        {
            _configuration = GetConfiguration();
            HbmMapping mappings = GetMappings();
            _configuration.AddDeserializedMapping(mappings, "SanPablo.CarBluMon.DataAccess");
            _sessionFactory = GetConfiguration().BuildSessionFactory();
        }
        private static Configuration GetConfiguration() {
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

        private static HbmMapping GetMappings() {
            ModelMapper mapper = new ModelMapper();
            mapper.AddMapping<DALocationMap>();
            HbmMapping mapping = 
                mapper.CompileMappingFor(new[] 
                                            {
                                                typeof(BELocation) 
                                            }
                                         );

            return mapping;
        }
        public static ISessionFactory SessionFactory {
            get { return _sessionFactory; } 
        }

    }
}
