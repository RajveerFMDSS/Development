using System;
using FMDSS.Models.Providers;
using System.Dynamic;

namespace FMDSS.Models.Repository
{
    public class NOCRepository
    {
        private readonly dynamic _companyinfo;
        private readonly SqlProviders.ProviderSetting _providersSettings;
        public NOCRepository(dynamic settings)
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

        #region Save NOC by Citizen

        public dynamic SaveNOCbyCitizen()
        {
            dynamic List = new ExpandoObject();
            try
            {
                //using (db_FMDSS db = new db_FMDSS(_providersSettings.Privateconnectionstring))
                //{
                //    List = db.GIS_TblMstFixedPermissionPlants.Where(s => s.IsActive == true).Select(d => new { Key = d.PlantName, Value = d.Id }).ToList();
                //}

            }
            catch (Exception ex)
            {

            }
            return List;
        }

        #endregion

    }
}
