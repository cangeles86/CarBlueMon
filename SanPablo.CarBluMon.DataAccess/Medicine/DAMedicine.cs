using NHibernate;
using NHibernate.Criterion;
using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.DataAccess.RepositoryManager;
using System;

namespace SanPablo.CarBluMon.DataAccess.Medicine
{
    public class DAMedicine: RepositoryManager<BEMedicine>
    {
        public BEMedicine GetMedicineByUser(int code)
        {
            BEMedicine result = new BEMedicine();
            try
            {
                ISession session = HibernateManager.HibernateManager.GetSession();
                result = (BEMedicine)session.CreateCriteria(typeof(BEMedicine)).Add(Expression.Eq("User.Id", code)).List<BEMedicine>()[0];
                return result;
                
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return null;
            }
            
            
            
        }
    }
}
