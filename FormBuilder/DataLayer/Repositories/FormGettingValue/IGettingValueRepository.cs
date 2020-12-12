using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTOs;

namespace DataLayer.Repositories.FormGettingValue
{
    public interface IGettingValueRepository:IRepository<Form>
    {
        FormDTOCollection GetFormsInfo();
    }
}
