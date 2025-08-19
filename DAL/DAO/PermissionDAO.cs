using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class PermissionDAO : EmployeeContext
    {
        public static void AddPermission(Permission permission)
        {
            try
            {
                //inserting onto database
                db.Permissions.InsertOnSubmit(permission);
                db.SubmitChanges();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public static void DeletePermission(int permissionID)
        {
            try
            {
                Permission pr = db.Permissions.First(x => x.ID == permissionID);
                db.Permissions.DeleteOnSubmit(pr);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<PermissionDetailDTO> GetPermissions()
        {
            List<PermissionDetailDTO> permissions = new List<PermissionDetailDTO>();

            //joining 3 table together permission, permission state and Employee
            var list =( from p in db.Permissions
                        join s in db.PermissionStates on p.PermissionState equals s.ID
                        join e in db. Employees on p.EmployeeID equals e.ID
                        select new
                        {
                            UserNumber = e.UserNumber,
                            name = e.Name,
                            Surname = e.Surname,
                            StateName =s.StateName,
                            stateID = p.PermissionState,
                            startDate = p.PermissionStartDate,
                            endDate = p.PermissionEndDate,
                            employeeID = p.EmployeeID,
                            explanation = p.PermissionExplanation,
                            dayAmount = p.PermissionDay,
                            departmentID = e.DepartmentID,
                            positionID = e.PositionID,
                            permissionID = p.ID

                            // sorting the collection of elements by startDate
                            //arrange them from ascending order
                        }).OrderBy( x=> x.startDate ).ToList(); 

            // assign the list to a permission detail list?
            foreach (var item in list)
            {
                PermissionDetailDTO dto = new PermissionDetailDTO();

                dto.userNumber = item.UserNumber;
                dto.Name = item.name;
                dto.Surname = item.Surname;
                dto.EmployeeID = item.employeeID;
                dto.PermissionDayAmount = item.dayAmount;
                dto.StartDate = item.startDate;
                dto.EndDate = item.endDate;
                dto.DepartmentID = item.departmentID;
                dto.PositionID = item.positionID;
                dto.State = item.stateID;
                dto.StateName = item.StateName;
                dto.Explanation = item.explanation;
                dto.PermissionID = item.permissionID;

                permissions.Add(dto);
            }


            return permissions;
        }

        public static List<PermissionState> GetStates()
        {
            return db.PermissionStates.ToList(); //pulls from the database
        }

        public static void UpdatePermission(Permission permission)
        {
            try
            {
                //select data from the table
                Permission pr = db.Permissions.First(x => x.ID == permission.ID);

                //setting vales to a new class
                pr.PermissionStartDate = permission.PermissionStartDate;
                pr.PermissionEndDate = permission.PermissionEndDate;
                pr.PermissionExplanation = permission.PermissionExplanation;
                pr.PermissionDay = permission.PermissionDay;

                db.SubmitChanges();

            }
            catch (Exception ex)
            {

            }
        }

        public static void UpdatePermission(int permissionID, int approved)
        {
            try
            {
                Permission pr = db.Permissions.First(x => x.ID == permissionID);
                pr.PermissionState = approved;
                db.SubmitChanges();
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
