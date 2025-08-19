 using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class EmployeeDAO : EmployeeContext
    {
        public static void AddEmployee(Employee employee)
        {
            try
            {
                db.Employees.InsertOnSubmit(employee);
                db.SubmitChanges();

            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        //public static object GetEmployees()
        //{
        //    throw new NotImplementedException();
        //}

        public static List<Employee> GetUsers(int userNumber)
        {
            return db.Employees.Where(x => x.UserNumber == userNumber).ToList();
        }

        public static List<EmployeeDetailDTO> GetEmployees()
        {
            List<EmployeeDetailDTO> employeeList = new List<EmployeeDetailDTO>();


            var list  = (from e in db.Employees
                         join d in  db.Departments on e.DepartmentID equals d.ID
                         join p in db.Positions on e.PositionID equals p.ID
                         select new
                         {
                             UserNumber = e.UserNumber,
                             Name = e.Name,
                             Surname =e.Surname,
                             EmployeeID = e.ID,
                             Password = e.Password,
                             DepartmentName = d.DepartmentName,
                             PositionName = p.PositionName,
                             DepartmentID = p.DepartmentID,
                             PositionID = e.PositionID,
                             isAmin = e.isAdmin,
                             Salary = e.Salary,
                             ImagePath = e.ImagePath,
                             Birthday = e.Birthday,
                             Address = e.Address,
                         }).OrderBy(x => x.UserNumber).ToList();


            foreach ( var item in list )
            {
                EmployeeDetailDTO dto = new EmployeeDetailDTO();
                dto.Name = item.Name;
                dto.userNumber = item.UserNumber;
                dto.Surname = item.Surname;
                dto.EmployeeID = item.EmployeeID;
                dto.Address = item.Address;
                dto.Password = item.Password;
                dto.DepartmentID = item.DepartmentID;
                dto.DepartmentName = item.DepartmentName;
                dto.PositionID = item.PositionID;
                dto.PositionName = item.PositionName;
                dto.isAdmin = item.isAmin;
                dto.Salary = item.Salary;
                dto.Birthday = item.Birthday; //work this out
                dto.ImagePath = item.ImagePath;

                employeeList.Add(dto);
            }

            return employeeList;
        }
    

        public static List<Employee> GetEmployees(int userNumber, string password)
        {
            try
            {
                List<Employee> list = db.Employees.Where(x =>x.UserNumber == userNumber && x.Password == password).ToList();
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //public static IEnumerable<Employee> GetEmployees2()
        //{
        //    var employees = db.Employees;
        //}

        public static int GetNextUniqueNumber()
        {
            //get the maxium user number currently in the database
            int maxUserNumber = db.Employees.Max(x => x.ID);
            int baseNumber = 1000;
            string userNumberString = baseNumber + maxUserNumber.ToString();
            int userNumber = Int32.Parse(userNumberString);
            return userNumber +1; 

        }

        public static int GetUniquePassword()
        {
            string maxUserPassword = db.Employees.Max(x => x.Password); // this is a string
            int basePassword = 1000;
            string userPasswordString = basePassword + maxUserPassword;
            int userPassword = Int32.Parse(userPasswordString);
            return userPassword + 1; //produces to many numbers


        }

        public static void AddNewEmployee (Employee newEmployee)
        {
            //generate a unique number for the new employee
            newEmployee.UserNumber = GetNextUniqueNumber();

            //add the new employee to the database
            db.Employees.InsertOnSubmit(newEmployee);

            //Commit the changes to the database

            db.SubmitChanges();
        }

        public static void UpdateEmployee(int employeeID, int amount)
        {
            try
            {
                Employee employee = db.Employees.First(x => x.ID == employeeID);
                employee.Salary = amount;
                db.SubmitChanges();

            }
            catch(Exception) 
            {
                throw;
            }
        }

        public static void UpdateEmployee(Employee employee)
        {
            try
            {
                Employee emp = db.Employees.First( x => x.ID == employee.ID);
                emp.UserNumber = employee.UserNumber;
                emp.Name = employee.Name;
                emp.Surname = employee.Surname;
                emp.Password = employee.Password;
                emp.isAdmin = employee.isAdmin;
                emp.Birthday = employee.Birthday;
                emp.Address = employee.Address;
                emp.DepartmentID = employee.DepartmentID;
                emp.PositionID = employee.PositionID;
                emp.Salary = employee.Salary;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateEmployee(Position position)
        {
            //selecting employees with position ID
            List<Employee> list = db.Employees.Where(x => x.PositionID == position.ID).ToList();
            foreach(var item in  list)
            {
                item.DepartmentID = position.DepartmentID;
            }
            db.SubmitChanges();
        }

        public static void DeleteEmployee(int employeeID)
        {
            try
            {
                //to delete each employee, each has task, salary and permission attached to it
                
                Employee employee = db.Employees.First(x => x.ID == employeeID);
                db.Employees.DeleteOnSubmit(employee);
                db.SubmitChanges();


                //DO NOT NEED BELOW BECAUSE TRIGGER WILL NOW DO THIS

                //List<Task> tasks = db.Tasks.Where(x => x.EmployeeID == employeeID).ToList();
                //db.Tasks.DeleteAllOnSubmit(tasks);
                //db.SubmitChanges();


                //List<Salary> salaries = db.Salaries.Where(x => x.EmployeeID == employeeID).ToList();
                //db.Salaries.DeleteAllOnSubmit(salaries);
                //db.SubmitChanges();

                //List<Permission> permissions = db.Permissions.Where(x => x.EmployeeID == employeeID).ToList();
                //db.Permissions.DeleteAllOnSubmit(permissions);
                //db.SubmitChanges();

            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
