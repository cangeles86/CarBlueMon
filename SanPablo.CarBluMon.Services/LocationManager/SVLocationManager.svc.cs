using SanPablo.CarBluMon.BusinessEntities;
using SanPablo.CarBluMon.BusinessLogic.Location;

namespace SanPablo.CarBluMon.Services.LocationManager
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SVLocationManager" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SVLocationManager.svc or SVLocationManager.svc.cs at the Solution Explorer and start debugging.
    public class SVLocationManager : ISVLocationManager
    {

        public bool RegisterLocation(double Latitude, double Longitud)
        {
            BELocation entity = new BELocation();
            BLLocation blEntity = new BLLocation();
            entity.Latitude = Latitude;
            entity.Longitude = Longitud;
            bool result = blEntity.Register(entity);
            return result;
        }
    }
}
