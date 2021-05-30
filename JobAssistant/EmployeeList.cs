using System.Collections.Generic;

namespace JobAssistant
{
    public class EmployeeList
    {
        private static EmployeeList _EmployeeList;
        private static List<Employee> list = new List<Employee>();

        protected EmployeeList()
        {
        }

        public static EmployeeList CreateSingle()
        {
            if (_EmployeeList == null)
                _EmployeeList = new EmployeeList();
            return _EmployeeList;
        }

        public void AddToEmployeeList(Employee user)
        {
            list.Add(user);
        }

        public void DeleteFromEmployeeList(Employee employee)
        {
            list.Remove(employee);
        }

        public List<Employee> GetList()
        {
            return list;
        }

        public Employee GetEmployee(string username)
        {
            foreach (var item in list)
            {
                if (item.username == username)
                {
                    return item;
                }
            }
            return new Employee();
        }

        public bool isValid(Employee employee)
        {
            foreach (var item in list)
            {
                if (employee.password == item.password && employee.username == item.username)
                {
                    return true;
                }
            }
            return false;
        }
    }
}