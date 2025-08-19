using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL; //make sure to add this library

namespace DAL.DTO
{
    public class EmployeeDTO
    {
        public List<Department> Departments { get; set; }
        public List<PositionDTO> Positions { get; set; }

        public List<EmployeeDetailDTO> Employees { get; set; }
    }
}
