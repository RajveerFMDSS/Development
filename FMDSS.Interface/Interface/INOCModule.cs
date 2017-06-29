using FMDSS.CustomModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMDSS.Interface.Interface
{
   public  interface INOCModule
    {
        StringResponse SaveNOCbyCitizen(NOCModel model);
    }

}
