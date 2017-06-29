using FMDSS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMDSS.CustomModels.Models
{


    public class DropDownValue
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class Master_TblMstPlaceModel
    {
        public long PlaceId { get; set; }
        public string DistCode { get; set; }

        public string DistName { get; set; }
        public string PlaceName { get; set; }
        public string Category { get; set; }
        public int TicketAllocatedPerShift { get; set; }
        public bool Isactive { get; set; }

    }

}
