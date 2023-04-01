using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class ActivityService
    {
        private ActivityDao activitydb;

        public ActivityService()
        {
            activitydb = new ActivityDao();
        }

        public List<Activity> GetActivity()
        {
            List<Activity> activities = activitydb.GetAllActivities();
            return activities;
        }

        public void AddActivity(Activity activity)
        {
            activitydb.AddActivity(activity);
        }

        public void UpdateActivity(Activity activity)
        {
            activitydb.UpdateActivity(activity);
        }

        public void DeleteActivity(Activity activity)
        {
            activitydb.DeleteActivity(activity);
        }

        public void AddStudentToActivity(Activity activity, Student student)
        {
            activitydb.AddStudentToActivity(activity, student);
        }

        public void RemoveStudentFromActivity(Activity activity, Student student)
        {
            activitydb.RemoveStudentFromActivity(activity, student);
        }

        public List<Student> GetAllStudentsFromActivity(int activityID)
        {
            List<Student> students = activitydb.GetAllStudentsFromActivity(activityID);
            return students;
        }
    }
}
