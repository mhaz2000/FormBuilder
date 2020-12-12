using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using Common.DTOs;

namespace DataLayer.Repositories.FormCreating
{
    public interface IFormCreatingRepository: IRepository<Form>
    {
        void AddNewForm(FormDTO form);
    }
}
