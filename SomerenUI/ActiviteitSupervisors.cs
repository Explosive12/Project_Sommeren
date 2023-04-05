using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace SomerenUI
{
    public partial class ActiviteitSupervisors : Form
    {
        SomerenService.ActivityService activityService = new SomerenService.ActivityService();
        SomerenService.LecturerService lectureService = new SomerenService.LecturerService();
        public ActiviteitSupervisors()
        {
            InitializeComponent();
        }
        private void ShowActivitySupervisorPanel()
        {
            // hide all other panels

           
           

            try
            {
                // get and display all students
                List<Lecturer> lecturer = GetActivitySupervisor();
                DisplayActivitySupervisor(lecturer);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the data: " + e.Message);
            }
        }
        private List<Lecturer> GetActivitySupervisor()
        {
           SomerenService.LecturerService lecturerService = new SomerenService.LecturerService();
            List<Lecturer> lecturer = lecturerService.GetLecturers();
            return lecturer;
        }

        private void DisplayActivitySupervisor(List<Lecturer> lecturers)
        {
           

            try
            {
                foreach (Lecturer lecturer in lecturers)
                {
                    ListViewItem li = new ListViewItem(lecturer.Name);
                    li.Tag = lecturer;   // link student object to listview item
                    SupervisorListView.Items.Add(li);

                    //li = new ListViewItem(student.Id.ToString());
                    //listViewStudents.Items.Add(li);
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the data: " + e.Message);
            }
        }

        // ==========================================================================================================

        private void ShowSupervisorPanel()
        {
            // hide all other panels

            // show students
          

            try
            {
                // get and display all activities
                List<Activity> acitvity = GetActivity();
                DisplayActivity(acitvity);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the data: " + e.Message);
            }
        }
        private List<Activity> GetActivity()
        {
            SomerenService.ActivityService activityService = new SomerenService.ActivityService();
            List<Activity> activity = activityService.GetActivity();
            return activity;
        }

        private void DisplayActivity(List<Activity> activities)
        {
            // clear the listview before filling it
            ActivityListView.Items.Clear();

            try
            {
                foreach (Activity activity in activities)
                {
                    ListViewItem li = new ListViewItem(activity.Omschrijving);
                    li.Tag = activity;   // link student object to listview item
                    ActivityListView.Items.Add(li);

                    //li = new ListViewItem(student.Id.ToString());
                    //listViewStudents.Items.Add(li);
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the data: " + e.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void ActiviteitSupervisors_Load(object sender, EventArgs e)
        {
            ShowActivitySupervisorPanel();
            ShowSupervisorPanel();


        }
        private Lecturer selectedSupervisor;
        private void pnlActivitySupervisor_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (SupervisorListView.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem selectedLecturer = SupervisorListView.SelectedItems[0];
            selectedSupervisor = (Lecturer)selectedLecturer.Tag;
        }
       

        
        private void removeSupervisor_Click(object sender, EventArgs e)
        {
            activityService.DeleteSupervisor(selectedActivity, selectedSupervisor);
        }
        private Activity selectedActivity;


        private void ActivityListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ActivityListView.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem selectedActivities = ActivityListView.SelectedItems[0];
            selectedActivity = (Activity)selectedActivities.Tag;

            DisplaySupervisorActvity(selectedActivity.ActiviteitId); 

            
        }

        private void addSupervisor_Click(object sender, EventArgs e)
        {
            activityService.AddSuperVisorActivity(selectedActivity, selectedSupervisor); 
        }

        private void SupervisorsInActivity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void DisplaySupervisorActvity(int activityId)
        {
            List<Lecturer> lecturers = activityService.GetAllSupervisorsActivity(activityId);

            SupervisorsInActivity.Items.Clear();

            try
            {
                foreach(Lecturer lecturer in lecturers)
                {
                    ListViewItem li = new ListViewItem(lecturer.Name);
                    li.Tag = lecturer;  
                    SupervisorsInActivity.Items.Add(li);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong while loading...");
            }
        }
    }
}
