using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.Models;

namespace WebAPICore.Repository
{
    public class EmployeeRepos: IEmployeeRepos
    {
        private  readonly List<Employee> repos;

        public EmployeeRepos()
        {
            repos = new List<Employee>()
            {
                new Employee(){Id=12,Name="Rohit",Gender="Male",Department="IT" },
                new Employee(){Id=13,Name="Sagar",Gender="Male",Department="IT"},
                new Employee(){Id=14,Name="Deepika",Gender="Female",Department="Non-IT"},
                new Employee(){Id=15,Name="Usha",Gender="Female",Department="IT"}
            };
        }

        public IEnumerable<Employee> GetAll()
        {
            return repos;
        }

        public Employee GetEmployee(int id)
        {
            return repos.FirstOrDefault(x => x.Id == id);
        }

        public Employee AddEmployee(Employee emp)
        {

            return emp;
        }
    }
}
