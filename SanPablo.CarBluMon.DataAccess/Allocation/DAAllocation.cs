using NHibernate;
using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.DataAccess.Equipment;
using System;

namespace SanPablo.CarBluMon.DataAccess.Allocation
{
    public class DAAllocation: RepositoryManager.RepositoryManager<BEAllocation>
    {
        public bool Register(BEPatient patient, BEEquipment holter, BEEquipment mobile)
        {
            bool result;
            if (patient != null && holter != null && mobile != null)
            {
                BEAllocation entityHolter = new BEAllocation();
                BEAllocation entityMobile = new BEAllocation();

                int idHolter = holter.Id;
                int idMobile = mobile.Id;

                entityHolter.Equipment = holter;
                entityHolter.Patient = patient;
                entityHolter.State = true;

                entityMobile.Equipment = mobile;
                entityMobile.Patient = patient;
                entityMobile.State = true;

                ISession session = HibernateManager.HibernateManager.GetSession();
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(entityHolter);
                        session.Flush();

                        session.Save(entityMobile);
                        session.Flush();

                        holter = new DAEquipment().FindById(idHolter);
                        holter.Assign = true;
                        bool resultHolter = new DAEquipment().Modify(holter);

                        mobile = new DAEquipment().FindById(idMobile);
                        mobile.Assign = true;
                        bool resultMobile = new DAEquipment().Modify(mobile);

                        if (resultMobile == false || resultHolter == false)
                        {
                            throw new Exception("Error to assign equipment");
                        }
                        
                        transaction.Commit();
                        result = true;
                    }
                    catch (Exception e)
                    {
                        Console.Write(e.Message);
                        transaction.Rollback();
                        result = false;
                    }
                }
                
            }
            else
            {
                result = false;
            }
            return result;
        }
        
        public override bool Remove(BEAllocation entity)
        {
            try
            {
                ISession session = HibernateManager.HibernateManager.GetSession();
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        BEEquipment equipment = new DAEquipment().FindById(entity.Equipment.Id);
                        equipment.Assign = false;

                        bool result = new DAEquipment().Modify(equipment);

                        if (!result)
                        {
                            throw new Exception("Error to update equipment");
                        }

                        session.Delete(entity);
                        session.Flush();
                        
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception e)
                    {
                        Console.Write(e.Message);
                        transaction.Rollback();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException.Message);
                return false;
            }           
        }

        public bool Modify(BEAllocation entity, BEEquipment equipment)
        {
            try
            {
                ISession session = HibernateManager.HibernateManager.GetSession();
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        //Designando Equipo
                        BEAllocation oldAllocation = FindById(entity.Id);
                        BEEquipment oldEquipment = new DAEquipment().FindById(oldAllocation.Equipment.Id);
                        oldEquipment.Assign = false;
                        bool resultEquip = new DAEquipment().Modify(oldEquipment);
                        if (!resultEquip)
                        {
                            throw new Exception("Error to design old equipment");
                        }

                        //Guarda y Asigna nuevo registro.
                        BEEquipment currentEquipment = new DAEquipment().FindById(equipment.Id);
                        currentEquipment.Assign = true;
                        resultEquip = new DAEquipment().Modify(currentEquipment);

                        if (!resultEquip)
                        {
                            throw new Exception("Error to design old equipment");
                        }

                        entity.Equipment = currentEquipment;
                        
                        session.Update(entity);
                        session.Flush();

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception e)
                    {
                        Console.Write(e.Message);
                        transaction.Rollback();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException.Message);
                return false;
            }
        }
    }
}
