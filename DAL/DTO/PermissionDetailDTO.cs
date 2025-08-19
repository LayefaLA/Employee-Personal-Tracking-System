using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class PermissionDetailDTO
    {
        public int EmployeeID { get; set; }
        public int userNumber { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int DepartmentID { get; set; }
        public int PositionID { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int PermissionDayAmount {  get; set; }
        public string StateName { get; set; }
        public int State {  get; set; }
        public string Explanation { get; set; }

        public int PermissionID { get; set; } //may cause error .13th column

    }
}
