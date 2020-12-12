using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTOs;

namespace Services.CreateNewFormService
{
    public interface ICreatingNewFormService
    {
        void CreateFrom(FormDTO form);
    }
}
