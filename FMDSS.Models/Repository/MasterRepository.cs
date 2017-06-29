using System;
using System.Linq;
using FMDSS.Models.Providers;
using System.Dynamic;
namespace FMDSS.Models.Repository
{
    public class MasterRepository
    {
        private readonly dynamic _companyinfo;
        private readonly SqlProviders.ProviderSetting _providersSettings;
        public MasterRepository(dynamic settings)
        {
            if (settings != null)
            {
                _companyinfo = settings;
                _providersSettings = new SqlProviders.ProviderSetting(Convert.ToInt32(_companyinfo.CompanyID), _companyinfo.PrivateConnectionString);
                if (_companyinfo.CompanyID == 0 && _companyinfo.EnvironmentId == 0)
                    throw new Exception("Incorrect URL. Please verify the URL and try again");
            }
            else
            {
                //throw new MemberAccessException();
            }
        }

        #region GET GIS Master Data

        public dynamic GetFixedLandNocTypeList()
        {
            dynamic List = new ExpandoObject();
            try
            {
                using (db_FMDSS db = new db_FMDSS(_providersSettings.Privateconnectionstring))
                {
                    List = db.GIS_TblMstFixedLandNocTypes.Where(s => s.IsActive == true).Select(d => new { Key=d.NocTypeId, Value=d.NocTypeName }).ToList();
                }

            }
            catch (Exception ex)
            {

            }
            return List;
        }


        public dynamic GetFixedLandPermissionTypesList(int? EmitraServiceID)
        {
            dynamic List = new ExpandoObject();
            try
            {
                using (db_FMDSS db = new db_FMDSS(_providersSettings.Privateconnectionstring))
                {
                    if (EmitraServiceID != null && EmitraServiceID != 0)
                        List = db.GIS_TblMstFixedPermissionTypes.Where(s => s.Status == "Active" && s.EmitraServiceId == EmitraServiceID).Select(d => new { Key = d.PId, Value=d.Name }).ToList();
                    else
                        List = db.GIS_TblMstFixedPermissionTypes.Where(s => s.Status == "Active").Select(d => new { Key= d.PId, Value= d.Name }).ToList();

                }

            }
            catch (Exception ex)
            {

            }
            return List;
        }

        #endregion

        #region Get Plant List

        public dynamic GetPlantList()
        {
            dynamic List = new ExpandoObject();
            try
            {
                using (db_FMDSS db = new db_FMDSS(_providersSettings.Privateconnectionstring))
                {
                    List = db.GIS_TblMstFixedPermissionPlants.Where(s => s.IsActive == true).Select(d => new { Key = d.PlantName, Value = d.Id }).ToList();
                }

            }
            catch (Exception ex)
            {

            }
            return List;
        }
        #endregion
        public dynamic GetPlaceList()
        {
            dynamic List = null;
            try
            {
                using (db_FMDSS db = new db_FMDSS(_providersSettings.Privateconnectionstring))
                {
                    List = db.Master_TblMstPlaces.Select(d => new
                    {
                        d.PlaceId,
                        d.DistCode,
                        d.Master_TblMstDistrict.DistName,
                        d.PlaceName,
                        d.Category,
                        d.TicketAllocatedPerShift,
                        d.Isactive
                    }).ToList();
                }

            }
            catch (Exception ex)
            {

            }
            return List;
        }
    }
}
