using DealerPlusApp.Data;
using DealerPlusApp.Data.IRepositories;
using DealerPlusApp.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerPlusApp.Service.Service
{
    public class EmployeeService : EntityService<Employee>, IEmployeeService
    {
        IUnitOfWork _unitOfWork;
        IEmployeeRepository _employeeRepository;

        public EmployeeService(IUnitOfWork unitOfWork, IEmployeeRepository employeeRepository)
            : base(unitOfWork, employeeRepository)
        {
            _unitOfWork = unitOfWork;
            _employeeRepository = employeeRepository;
        }


        public Employee GetById(int Id)
        {
            return _employeeRepository.GetByID(Id);
        }
    }
}
