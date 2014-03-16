using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using NHibernate.Tool.hbm2ddl;
using SanPablo.CarBluMon.BusinessEntities;
using System.Data;

namespace SanPablo.CarBluMon.DataAccess.HibernateManager
{
    internal static class HibernateManager
    {
        //@"Data Source=GYSLAP031\SQL1;Initial Catalog=CarBluMon;Integrated Security=True"

        private static Configuration ConfigureHibernate()
        {            
            var configure = new Configuration();
            configure.SessionFactoryName("BuildIt");
            configure.DataBaseIntegration(db =>
            {
                db.Dialect<MsSql2012Dialect>();
                db.Driver<SqlClientDriver>();
                db.KeywordsAutoImport = Hbm2DDLKeyWords.AutoQuote;
                db.IsolationLevel = IsolationLevel.ReadCommitted;
                db.ConnectionString = @"Data Source=GYSLAP031\SQL1;Initial Catalog=CarBluMon;Integrated Security=True";
                //db.ConnectionString = @"Data Source=354aa641-94f7-47c1-82e4-a2ea009c3d22.sqlserver.sequelizer.com;Initial Catalog=db354aa64194f747c182e4a2ea009c3d22;Persist Security Info=True;User ID=vhvuhydbjypfajaj;Password=PPjaaG3wjcAapHoenddvv8sTkYNbKA423RKeRVKswBLqEhWUREa6sNbPvyXi32UR";
                //db.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Local"].ToString();
                db.Timeout = 10;
                //debugging
                //db.LogFormattedSql = true;
                //db.LogSqlInConsole = true;
                //db.AutoCommentSql = true;
            });
            return configure;
        }

        private static HbmMapping GetMappings()
        {
            ModelMapper mapper = new ModelMapper();
            mapper.AddMapping<DALocationMap>();
            HbmMapping mapping = mapper.CompileMappingFor(new[] 
            {
                typeof(BELocation),
            });
            return mapping;
        }

        internal static ISessionFactory GetSession()
        {
            Configuration hbmConfig;
            ISessionFactory currentSession;
            hbmConfig = ConfigureHibernate();
            HbmMapping mappings = GetMappings();
            hbmConfig.AddDeserializedMapping(mappings, "SanPablo.CarBluMon.DataAccess");
            SchemaMetadataUpdater.QuoteTableAndColumns(hbmConfig);
            currentSession = hbmConfig.BuildSessionFactory();
            return currentSession;
        }

    }
}
