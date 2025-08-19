using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class SalaryDAO : EmployeeContext
    {
        public static void AddSalary(Salary salary)
        {
            try
            {
                db.Salaries.InsertOnSubmit(salary);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
                //new exception cannot add an entity that already exists
            }
        }

        public static void DeleteSalary(int salaryID)
        {
            try
            {
                Salary salary = db.Salaries.First(x => x.ID == salaryID);
            }
            catch (Exception)
            {
                throw; //sequence contains no element?? how to fix?
            }
        }

        public static List<Month> GetMonths()
        {
            return db.Months.ToList();
        }

        public static List<SalaryDetailDTO> GetSalaries()
        {
            // creating a joint table on salary employee and months
            List<SalaryDetailDTO> salaryList = new List<SalaryDetailDTO>(); 
            var list = (from s in db.Salaries
                        join e in db.Employees on s.EmployeeID equals e.ID
                        join m in db.Months on s.MonthID equals m.ID
                        select new
                        {
                            userNumber = e.UserNumber,
                            name = e.Name,
                            surname = e.Surname,
                            EmployeeID = s.EmployeeID,
                            amount = s.Amount,
                            year = s.Year,
                            monthName = m.MonthName,
                            monthID = s.MonthID,
                            salaryID = s.ID,
                            departmentID = e.DepartmentID,
                            positionID = e.PositionID
                        }).OrderBy(x => x.year).ToList();
            foreach ( var item in list )
            {
                SalaryDetailDTO dto = new SalaryDetailDTO();
                dto.userNumber = item.userNumber;
                dto.Name = item.name;
                dto.Surname = item.surname;
                dto.EmployeeID = item.EmployeeID;
                dto.SalaryAmount =item.amount;
                dto.SalaryYear = item.year;
                dto.MonthName = item.monthName;
                dto.MonthID = item.monthID;
                dto.SalaryID = item.salaryID;
                dto.DepartmentID = item.departmentID;
                dto.PositionID = item.positionID;
                dto.OldSalary = item.amount;

                salaryList.Add(dto);
                
            }
            return salaryList;
        }

        public static void UpdateSalary(Salary salary)
        {
            try
            {
                Salary sl = db.Salaries.First (x => x.ID == salary.ID);
                sl.Amount = salary.Amount;
                sl.Year = salary.Year;
                sl.MonthID = salary.MonthID;
                db.SubmitChanges();

            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
