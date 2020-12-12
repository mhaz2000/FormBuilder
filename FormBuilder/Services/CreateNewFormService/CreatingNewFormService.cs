using Common.DTOs;
using DataLayer.DataUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CreateNewFormService
{
    public class CreatingNewFormService : ICreatingNewFormService
    {
        private IUnitOfWork _unitOfWork;
        public CreatingNewFormService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //create new from and send it to repository.
        public void CreateFrom(FormDTO form)
        {
            _unitOfWork.FormCreatingRepository.AddNewForm(form);
        }
    }
}
