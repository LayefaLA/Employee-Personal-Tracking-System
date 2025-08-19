using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class PositionDTO : Position //drive class from class position
    {
        public string DepartmentName { get; set; }
        public int OldDepartmentID { get; set; }
    }

    //public static Position FromDTO(PositionDTO dto)
    //{
    //    return new Position
    //    {
    //        PositionName = dto.PositionName
    //    };
    //}
}
