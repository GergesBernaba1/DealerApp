using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealerPlusApp.Data;

namespace DealerPlusApp.Service.IService
{

    public interface IEmployeeService : IEntityService<Employee>
    {
        Employee GetById(int Id);
    }
}
