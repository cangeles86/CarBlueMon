﻿using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.RepositoryManager;
using SanPablo.CarBluMon.DataAccess.PhoneDirectory;
using System.Collections.Generic;

namespace SanPablo.CarBluMon.BusinessLogic.PhoneDirectory
{
    public class BLPhoneDirectory : IRepositoryManager<BEPhoneDirectory>
    {
        public bool Register(BEPhoneDirectory entity)
        {
            return new DAPhoneDirectory().Register(entity);
        }

        public bool Modify(BEPhoneDirectory entity)
        {
            return new DAPhoneDirectory().Modify(entity);
        }

        public bool Remove(BEPhoneDirectory entity)
        {
            return new DAPhoneDirectory().Remove(entity);
        }

        public BEPhoneDirectory FindById(int code)
        {
            return new DAPhoneDirectory().FindById(code);
        }

        public List<BEPhoneDirectory> Find(params string[][] criteriaListEq)
        {
            return new DAPhoneDirectory().Find(criteriaListEq);
        }
    }
}
