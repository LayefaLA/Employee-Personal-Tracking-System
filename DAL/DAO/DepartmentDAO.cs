using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.DAO
{
    public class DepartmentDAO : EmployeeContext
    {
        public static void AddDepartment(Department department)
        {
            //using try catch to prevent programme from crashing
            try
            {
                //this connection comes from employeeContext
                db.Departments.InsertOnSubmit(department); //class being the variable department
                db.SubmitChanges(); //saving the section

            }
            catch (Exception ex)
            {
                throw ex;  //VERSION ISSUE- how to fix it
            }
        }

        public static void DeleteDepartment(int iD)
        {
            try
            {
                Department department = db.Departments.First(x => x.ID == iD);  
                db.Departments.DeleteOnSubmit(department);
                db.SubmitChanges();

            }
            catch(Exception)
            {
                throw;
            }
        }

        public static List<Department> GetDepartments()
        {
            return db.Departments.ToList(); //supposed to return depart list from database to here.
        }

        public static void UpdateDepartment(Department department)
        {
            try
            {
                Department dpt = db.Departments.First(x => x.ID == department.ID);
                dpt.DepartmentName = department.DepartmentName;
                db.SubmitChanges();


            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
