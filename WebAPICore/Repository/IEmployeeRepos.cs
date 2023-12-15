using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.Models;

namespace WebAPICore.Repository
{
    public interface IEmployeeRepos
    {
        IEnumerable<Employee> GetAll();
        Employee GetEmployee(int id);
        Employee AddEmployee(Employee emp);


    }
}
