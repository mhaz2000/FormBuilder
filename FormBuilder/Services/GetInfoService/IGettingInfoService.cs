using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTOs;

namespace Services.GetInfoService
{
    public interface IGettingInfoService
    {
        FormDTOCollection GetAllFormInfo();
    }
}
