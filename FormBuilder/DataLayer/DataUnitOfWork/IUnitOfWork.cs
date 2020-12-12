using DataLayer.Models;
using DataLayer.Repositories;
using DataLayer.Repositories.FormCreating;
using DataLayer.Repositories.FormGettingValue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataUnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<Form> Forms { get; }
        IGettingValueRepository GettingValueRepository { get; }
        IFormCreatingRepository FormCreatingRepository { get; }

        void Save();
    }
}
