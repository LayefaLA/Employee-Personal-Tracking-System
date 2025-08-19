using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;
using DAL;



namespace BLL
{
    public class EmployeeBLL
    {
        public static void AddEmployee(Employee employee)
        {
            EmployeeDAO.AddEmployee(employee);
        }

        public static void DeleteEmployee(int employeeID)
        {
            EmployeeDAO.DeleteEmployee(employeeID);
        }

        public static EmployeeDTO GetAll()
        {
            

            //Merging departments and positions
            EmployeeDTO dto = new EmployeeDTO();
            dto.Departments = DepartmentDAO.GetDepartments();
            
            dto.Positions = PositionDAO.GetPositions(); //cannot implicitly convert type?
            dto.Employees = EmployeeDAO.GetEmployees();
            return dto;

        }

        public static List<Employee> GetEmployees(int userNumber, string password)
        {
            return EmployeeDAO.GetEmployees(userNumber, password);
        }

        public static bool IsUnique(int userNumber)
        {
            List<Employee> list = EmployeeDAO.GetUsers(userNumber);
            if(list.Count > 0)
            {
                return false;
            }
            else { return true; }
            
        }

        public static void AddNewEmployee(Employee newEmployee)
        {
            EmployeeDAO.AddNewEmployee(newEmployee);
        }
        public static void UpdateEmployee(Employee employee)
        {
            EmployeeDAO.UpdateEmployee(employee);
            
        }
    }
}
