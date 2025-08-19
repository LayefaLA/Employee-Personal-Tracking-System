using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class PositionDAO : EmployeeContext  //derive from here to access database
    {
        public static void AddPosition(Position position)
        {
            try
            {
                db.Positions.InsertOnSubmit(position);
                db.SubmitChanges();

            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public static void DeletePosition(int iD)
        {
            try
            {
                Position position = db.Positions.First(x => x.ID == iD);
                db.Positions.DeleteOnSubmit(position);
                db.SubmitChanges();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<PositionDTO> GetPositions()
        {
            try
            {
                var list = ( from p in  db.Positions
                             join d in db.Departments on p.DepartmentID equals d.ID
                             select new
                             {
                                 positionID=p.ID,
                                 positionName= p.PositionName,
                                 departmentName = d.DepartmentName,
                                 departmentID = p.DepartmentID
                                
                             }).OrderBy(x => x.positionID).ToList();

                //add these values into another list in Position DTO
                List<PositionDTO> positionList = new List<PositionDTO>();
                foreach (var item in list)
                {
                    PositionDTO dto = new PositionDTO();
                    dto.ID = item.positionID;
                    dto.PositionName = item.positionName;
                    dto.DepartmentName = item.departmentName;
                    dto.DepartmentID = item.departmentID;
                    
                    positionList.Add(dto);

                }
                return positionList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdatePosition(Position position)
        {
            try 
            {
                Position pst = db.Positions.First(x => x.ID == position.ID);
                pst.PositionName = position.PositionName;
                pst.DepartmentID = position.DepartmentID;
                db.SubmitChanges();

            }
            catch(Exception) 
            {
                throw;
            }
                
        }
    }
}
