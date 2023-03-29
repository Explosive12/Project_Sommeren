using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;
using SomerenService;

namespace SomerenUI
{
    public partial class ActivityStudentUI : Form
    {
        CultureInfo provider = new CultureInfo("nl-NL");
        const string DateFormat = "yyyy-MM-dd HH:mm";

        //Making the SomerenService object
        SomerenService.StudentService studentService = new SomerenService.StudentService();
        SomerenService.ActivityService activityService = new SomerenService.ActivityService();

        public ActivityStudentUI()
        {
            InitializeComponent();
        }

        //Displaying everything in the listviews
        private void DisplayActivity()
        {
            //Making the SomerenService object
            SomerenService.ActivityService activityService = new SomerenService.ActivityService();

            //Making a list with all the activities
            List<Activity> activities = activityService.GetActivity();

            // clear the listview before filling it
            ActivitylistView.Items.Clear();

            foreach (Activity activity in activities)
            {
                ListViewItem li = new ListViewItem(activity.Omschrijving);
                li.Tag = activity;   // link activity object to listview item
                li.SubItems.Add(activity.StartTijd.ToString(DateFormat));
                li.SubItems.Add(activity.EindTijd.ToString(DateFormat));
                ActivitylistView.Items.Add(li);
            }
        }

        private void DisplayStudents()
        {
            //Making a list with all the activities
            List<Student> students = studentService.GetStudents();

            // clear the listview before filling it
            StudentlistView.Items.Clear();

            try
            {
                foreach (Student student in students)
                {
                    ListViewItem li = new ListViewItem(student.Name);
                    li.Tag = student;   // link student object to listview item
                    StudentlistView.Items.Add(li);
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the Students: " + e.Message);
            }
        }

        private void ActivityStudentUI_Load(object sender, EventArgs e)
        {
            DisplayActivity();
            DisplayStudents();
        }

        //Selecting activities/students
        Activity selectedActivity;
        private void ActivitylistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ActivitylistView.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem selectedListViewItem = ActivitylistView.SelectedItems[0];
            selectedActivity = (Activity)selectedListViewItem.Tag;
        }

        Student selectedStudent;
        private void StudentlistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentlistView.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem selectedListViewItem = StudentlistView.SelectedItems[0];
            selectedStudent = (Student)selectedListViewItem.Tag;
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            activityService.AddStudentToActivity(selectedActivity, selectedStudent);
        }

        private void removeStudentButton_Click(object sender, EventArgs e)
        {
            activityService.RemoveStudentFromActivity(selectedActivity, selectedStudent);
        }
    }
}
