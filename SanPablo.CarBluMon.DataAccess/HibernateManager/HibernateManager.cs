﻿using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using NHibernate.Tool.hbm2ddl;
using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.DataAccess.Location;
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
                db.Timeout = 10;
                //debugging
                db.LogFormattedSql = true;
                db.LogSqlInConsole = true;
                db.AutoCommentSql = true;
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
            hbmConfig.AddDeserializedMapping(mappings, "SGC.DL");
            SchemaMetadataUpdater.QuoteTableAndColumns(hbmConfig);
            currentSession = hbmConfig.BuildSessionFactory();
            return currentSession;
        }

    }
}
