using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.Location;
using System.Collections.Generic;

namespace SanPablo.CarBluMon.Services.LocationManager
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SVLocationManager" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SVLocationManager.svc or SVLocationManager.svc.cs at the Solution Explorer and start debugging.
    public class SVLocationManager : ISVLocationManager
    {
        public bool RegisterLocation(BELocation entity)
        {
            BLLocation blEntity = new BLLocation();
            bool result = blEntity.Register(entity);
            return result;
        }
        
        public System.Collections.Generic.List<BELocation> GetLocations()
        {
            BLLocation blEntity = new BLLocation();
            List<BELocation> result = blEntity.Find(null);
            return result;
        }

        //public bool RegisterLocation(string latitude, string longitude)
        //{
        //    BELocation entity = new BELocation();
        //    entity.Latitude = double.Parse(latitude);
        //    entity.Longitude = double.Parse(longitude);
        //    BLLocation blEntity = new BLLocation();
        //    bool result = blEntity.Register(entity);
        //    return result;
        //}

    }
}


