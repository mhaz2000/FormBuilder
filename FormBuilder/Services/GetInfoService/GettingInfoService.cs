using Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DataUnitOfWork;

namespace Services.GetInfoService
{
    public class GettingInfoService : IGettingInfoService
    {
        private IUnitOfWork _unitOfWork;
        public GettingInfoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public FormDTOCollection GetAllFormInfo()
        {
            return _unitOfWork.GettingValueRepository.GetFormsInfo();
        }
    }
}
