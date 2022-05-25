using ClassLibrary_Core.Entities;
using ClassLibrary_Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary_Mock.Repositories
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees = new List<Employee>()
        {
            new Employee
            {
                Id = "1",
                EmployeeCode ="EMP0001",
                FirstName ="ale",
                LastName ="lio"
            },
            new Employee
            {
                Id = "2",
                EmployeeCode ="EMP0002",
                FirstName ="alessandra",
                LastName ="rossi"
            },
            new Employee
            {
                Id = "3",
                EmployeeCode ="EMP0003",
                FirstName ="paola",
                LastName ="verdi"
            },
            new Employee
            {
                Id = "4",
                EmployeeCode ="EMP0004",
                FirstName ="giorgio",
                LastName ="bianchi"
            },



        };
       
        public bool Add(Employee newItem)
        {
            var exists = _employees.Exists(e=>e.EmployeeCode== newItem.EmployeeCode);
            if (exists)
                throw new Exception($"Employee with code {newItem.EmployeeCode} alredy exist");
            _employees.Add(newItem);
            return true;
        }

        public bool DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> Fetch(Func<Employee, bool> filter = null)
        {
            if(filter == null)
                return _employees;
            return _employees.Where(filter);
        }

        public Employee GetByCode(string code)
        {
            throw new NotImplementedException();
        }

        public Employee GetById(string id)
        {
            if(id == null)
                return null;
            return _employees.FirstOrDefault(e => e.Id == id);
        }

        public bool Update(Employee updateItem)
        {
            throw new NotImplementedException();
        }
    }
}
