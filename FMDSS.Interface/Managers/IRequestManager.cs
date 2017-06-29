using FMDSS.Interface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMDSS.Interface
{
  public  interface IRequestManager
    {
        ICompany Company { get; }
        IMaster Master { get; }

        INOCModule NOCModule { get; }

    }
}
