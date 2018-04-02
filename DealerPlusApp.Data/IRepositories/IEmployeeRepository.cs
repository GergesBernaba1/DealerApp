using DealerPlusApp.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerPlusApp.Data.IRepositories
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Employee GetByID(long Id);
        IEnumerable<Employee> GetAll();
        bool DeleteEmp(Employee emp);
        bool UpdateEmp(Employee emp);

    }
}
