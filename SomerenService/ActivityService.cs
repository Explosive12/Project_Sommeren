using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
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

        public List<ActivitySupervisor> GetActivitySupervisors(List<ActivitySupervisor> activitySupervisors)
        {
            activitySupervisors = activitydb.GetActivitySupervisor();
            return activitySupervisors;
        }
    }
}
