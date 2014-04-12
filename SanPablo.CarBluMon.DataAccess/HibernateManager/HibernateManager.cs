using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using NHibernate.Tool.hbm2ddl;
using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.DataAccess.Allocation;
using SanPablo.CarBluMon.DataAccess.Doctor;
using SanPablo.CarBluMon.DataAccess.DocumentType;
using SanPablo.CarBluMon.DataAccess.ECGHistory;
using SanPablo.CarBluMon.DataAccess.Equipment;
using SanPablo.CarBluMon.DataAccess.EquipmentType;
using SanPablo.CarBluMon.DataAccess.HelpRequests;
using SanPablo.CarBluMon.DataAccess.Medicine;
using SanPablo.CarBluMon.DataAccess.Patient;
using SanPablo.CarBluMon.DataAccess.PhoneDirectory;
using SanPablo.CarBluMon.DataAccess.StatePatient;
using SanPablo.CarBluMon.DataAccess.Users;
using System.Data;

namespace SanPablo.CarBluMon.DataAccess.HibernateManager
{
    internal static class HibernateManager
    {
        private static ISession _currentSession;
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
                //db.ConnectionString = @"Data Source=GYSLAP031\SQL1;Initial Catalog=CarBluMon;Integrated Security=True";
                db.ConnectionString = @"Data Source=354aa641-94f7-47c1-82e4-a2ea009c3d22.sqlserver.sequelizer.com
                    ;Initial Catalog=db354aa64194f747c182e4a2ea009c3d22
                    ;Persist Security Info=True
                    ;User ID=vhvuhydbjypfajaj
                    ;Password=oFDRSUcntF2vKnQKyrAUUPDztNQn2VeaJ4c75ZVUtEHQjf2NdsEmc6NGbdxedXuE";  
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
            mapper.AddMapping<DAAllocationMap>();
            mapper.AddMapping<DADoctorMap>();
            mapper.AddMapping<DADocumentTypeMap>();
            mapper.AddMapping<DAECGHistoryMap>();
            mapper.AddMapping<DAEquipmentMap>();
            mapper.AddMapping<DAEquipmentTypeMap>();
            mapper.AddMapping<DAHelpRequestMap>();
            mapper.AddMapping<DAMedicineMap>();
            mapper.AddMapping<DAPatientMap>();
            mapper.AddMapping<DAPhoneDirectoryMap>();
            mapper.AddMapping<DAStatePatientMap>();
            mapper.AddMapping<DAUserMap>();
            HbmMapping mapping = mapper.CompileMappingFor(new[] 
            {
                typeof(BEAllocation),
                typeof(BEDoctor),
                typeof(BEDocumentType),
                typeof(BEECGHistory),
                typeof(BEEquipment),
                typeof(BEEquipmentType),
                typeof(BEHelpRequest),
                typeof(BEMedicine),
                typeof(BEPatient),
                typeof(BEPhoneDirectory),
                typeof(BEStatePatient),                
                typeof(BEUser)                
            });
            return mapping;
        }

        internal static ISession GetSession()
        {
            if (_currentSession == null)
            {
                Configuration hbmConfig;
                hbmConfig = ConfigureHibernate();
                HbmMapping mappings = GetMappings();
                hbmConfig.AddDeserializedMapping(mappings, "SanPablo.CarBluMon.DataAccess");
                SchemaMetadataUpdater.QuoteTableAndColumns(hbmConfig);
                _currentSession = hbmConfig.BuildSessionFactory().OpenSession();
            }            
            return _currentSession;
        }

    }
}
