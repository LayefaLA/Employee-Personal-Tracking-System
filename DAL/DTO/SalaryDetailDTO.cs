using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class SalaryDetailDTO
    {
        public int EmployeeID { get; set; }
        public int userNumber { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string DepartmentName { get; set; }
        public int DepartmentID { get; set; }
        public int PositionID { get; set; }
        public string MonthName { get; set; }  //monthName

        public int SalaryYear { get; set; }
        public int MonthID { get; set; }
        public int SalaryAmount { get; set; }   

        public int SalaryID { get; set; }
        public int OldSalary {  get; set; } //used for updating the salary 

    }
}
