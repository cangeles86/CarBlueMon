﻿using SanPablo.CarBluMon.BusinessEntities;

namespace SanPablo.CarBluMon.DataAccess.Allocation
{
    public class DAAllocation: RepositoryManager.RepositoryManager<BEAllocation>
    {
        public bool ValidateAvailability(BEAllocation entity)
        {
            return false;
        }
    }
}
