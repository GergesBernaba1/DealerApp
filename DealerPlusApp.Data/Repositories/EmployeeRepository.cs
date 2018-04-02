using DealerPlusApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerPlusApp.Data.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext context)
            : base(context)
        {

        }

        public override IEnumerable<Employee> GetAll()
        {
            return _entities.Set<Employee>().AsEnumerable();
        }

        public Employee GetByID(long Id)
        {
            return _dbset.Where(x => x.ID == Id).FirstOrDefault();
        }


        public bool DeleteEmp(Employee emp)
        {
            try
            {
                _dbset.Remove(emp);
                _entities.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateEmp(Employee emp)
        {
            try
            {
                _entities.Entry<Employee>(emp).State = EntityState.Modified;
                _entities.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
