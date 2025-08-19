using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class TaskDAO : EmployeeContext
    {
        public static void AddTask(Task task)
        {
            try
            {
                db.Tasks.InsertOnSubmit(task);
                db.SubmitChanges();
            }
            catch  (Exception ex) 
            {
                throw ex;           
            
            }


        }

        public static void ApproveTask(int taskID, bool isAdmin)
        {
            try
            {
                // control admin or not
                Task tsk = db.Tasks.First( x => x.ID == taskID );
                if(isAdmin)
                    tsk.TaskState = TaskStates.Approved;
                else
                    tsk.TaskState = TaskStates.Delivered;
                tsk.TaskDeliveryDate = DateTime.Today;
                db.SubmitChanges();

            }
            catch(Exception )
            {
                throw;
            }
        }

        public static void DeleteTask(int taskID)
        {
            try
            {
                Task ts = db.Tasks.First(x => x.ID == taskID);
                db.Tasks.DeleteOnSubmit(ts);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<TaskDetailDTO> GetTasks()
        {
            //this list will join 5 tables
            List<TaskDetailDTO> tasklist = new List<TaskDetailDTO>();

            var list =( from t in db.Tasks
                        join s in db.TaskStates on t.TaskState equals s.ID
                        join e in db.Employees on t.EmployeeID equals e.ID
                        join d in db.Departments on e.DepartmentID equals d.ID
                        join p in db.Positions on e.PositionID equals p.ID
                        select new
                        {
                            taskID = t.ID,
                            title = t.TaskTitle,
                            content =t.TaskContent,
                            startdate = t.TaskStarDate,
                            deliveryDate =t.TaskDeliveryDate,
                            taskStateName  = s.StateName, //s.StateName,
                            taskStateID =t.TaskState,
                            userNumber = e.UserNumber,
                            name = e.Name,
                            employeeID = t.EmployeeID, //capital
                            surname = e.Surname, //captial
                            positionName = p.PositionName,
                            departmentName = d.DepartmentName,
                            postionID = e.PositionID,
                            departmentID = e.DepartmentID,

                        }).OrderBy(x=>x.startdate).ToList();

            foreach ( var item in list)
            {
                TaskDetailDTO dto = new TaskDetailDTO();

                dto.TaskID = item.taskID;
                dto.Title = item.title;
                dto.Content = item.content;
                dto.TaskStartDate = item.startdate; //datetime
                dto.TaskDeliveryDate = item.deliveryDate; //datetime
                dto.TaskStateName = item.taskStateName;
                dto.TaskStateID = item.taskStateID;
                dto.userNumber = item.userNumber;
                dto.Name = item.name;
                dto.Surname = item.surname;
                dto.DepartmentName = item.departmentName;
                dto.PositionID = item.postionID;
                dto.PositionName = item.positionName;
                dto.EmployeeID = item.employeeID;

                tasklist.Add(dto);

            }
                

            return tasklist;
        }

        public static List<TaskState> GetTaskStates()
        {
            return db.TaskStates.ToList();
        }

        public static void UpdateTask(Task task)
        {
            try
            {
                Task ts = db.Tasks.First (x => x.ID == task.ID);
                ts.TaskTitle = task.TaskTitle;
                ts.TaskContent = task.TaskContent;
                ts.TaskState = task.TaskState;
                ts.EmployeeID = task.EmployeeID;
                db.SubmitChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
