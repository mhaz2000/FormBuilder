using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Repositories;
using DataLayer.Repositories.FormGettingValue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataUnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private Repository<Form> _formRepo;
        private FromDataBase _dbContext;

        public UnitOfWork(FromDataBase context)
        {
            _dbContext = context;
            GettingValueRepository = new GettingValueRepository(_dbContext);
        }
        public IRepository<Form> Forms
        {
            get
            {
                return _formRepo ??
                    (_formRepo = new Repository<Form>(_dbContext));
            }
        }

        public IGettingValueRepository GettingValueRepository { get; }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
