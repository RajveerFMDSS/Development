using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMDSS.CustomModels.Models
{
    public class RequestModel
    {
    }


    public class PlantDetails
    {
        public int ID { get; set; }
        public string PlantName { get; set; }
        public int PlantNumber { get; set; }
    }
    public class RequestBaseModel
    {
        public int Status { get; set; } = 1;
        public string CreatedDate { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
    }

    public class NOCModel : RequestBaseModel
    {
        public NOCModel()
        {
            GISInfo = new GISInformation();
            GISInfo.GISList = new List<GISInformationList>();
            PlantDetail = new List<PlantDetails>();
        }

        [Required(ErrorMessage ="Please Select Applicant Type")]
        public string ApplicantType { get; set; }
        [Required]
        public string PerposedAreaInHacture { get; set; }
        [Required]
        public string NoOfTreePerposedArea { get; set; }
        [Required]
        public int IsTehsildar { get; set; }
        [Required]
        public string ProjectDescription { get; set; }
    
        public string RevenueRecordFile { get; set; }
   
        public string RevenueMapFile { get; set; }

        public string DetailedProjectReportFile { get; set; }

        public GISInformation GISInfo { get; set; }
        public List<PlantDetails> PlantDetail { get; set; }
    }


    public class GISInformation
    {
        public string ID { get; set; }
        public string kioskuserid { get; set; }

        [Required]
        public int NOCPurpose { get; set; }
        [Required]
        public int NOCType { get; set; }
        [Required]
        public string AreaInHecture { get; set; }

        public string GISID { get; set; }
        public string SSOID { get; set; }

        public string FileName { get; set; }
        public string FileNameOrignal { get; set; }
        [Required]
        public string Lat { get; set; }
        [Required]
        public string Long { get; set; }

        public string WaterSource { get; set; }
        public string NearestWaterSource { get; set; }

        public string NearestForestSource { get; set; }
        public string WidelifyZone { get; set; }

        public string ForestInHactare { get; set; }
        public string FeesAmount { get; set; }

        public int ISAravaliHills { get; set; }
        public int ISForestLand { get; set; }
        public int ISPlantationArea { get; set; }

        public List <GISInformationList> GISList { get; set; }
    }
    public class GISInformationList: GISMainValueCollection
    {
        public string Div_NM { get; set; }
        public string Dist_NM { get; set; }
        public string Block_NM { get; set; }
        public string Gp_NM { get; set; }
        public string Village_NM { get; set; }
        public string Tehsil_NM { get; set; }
       
    }

    public class GISMainValueCollection
    {
        public string Div_Cd { get; set; }
        public string Dist_Cd { get; set; }
        public string Tehsil_Cd { get; set; }
        public string Blk_Cd { get; set; }
        public string Gp_Cd { get; set; }
        public string Vlg_Cd { get; set; }
        public string FOREST_DIVCODE { get; set; }
        public string FOREST_RANGECODE { get; set; }
        public string KhasraNo { get; set; }
        public string areaName { get; set; }
    }
}
