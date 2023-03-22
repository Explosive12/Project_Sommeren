using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace SomerenUI
{

    public partial class SomerenUI : Form
    {
        const string DateFormat = "yyyy-MM-dd HH:mm";
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            pnlActivities.Hide();
            pnlRooms.Hide();
            pnlLecturer.Hide();

            // show dashboard
            pnlDashboard.Show();
        }
        
        // students beginnen hier

        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlLecturer.Hide();
            pnlActivities.Hide();
            pnlRooms.Hide();
            pnlCashRegister.Hide();

            // show students
            pnlStudents.Show();

            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.Id.ToString());
                li.Tag = student;   // link student object to listview item
                li.SubItems.Add(student.Name);
                listViewStudents.Items.Add(li);

                //li = new ListViewItem(student.Id.ToString());
                //listViewStudents.Items.Add(li);
            }
        }


        // Hier beginnen de activiteiten


        private void ShowDashBoardActivities()
        {
            // hide all other panels
            pnlDashboard.Hide();

            // show activity
            pnlActivities.Show();

            try
            {
                // get and display all activity
                List<Activity> activities = GetActivities();
                DisplayActivity(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }
        }

        private List<Activity> GetActivities()
        {
            ActivityService acitivtyService = new ActivityService();
            List<Activity> activities = acitivtyService.GetActivity();
            return activities;
        }


        // Rooms Section
        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoomsPannel();
        }

        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> allRooms = roomService.GetRooms();
            return allRooms;
        }

        private void ShowRoomsPannel()
        {
            //Hide all other pannels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlLecturer.Hide();
            pnlActivities.Hide();
            pnlCashRegister.Hide();

            // Hide all other Listviews?


            //Show rooms
            pnlRooms.Show();

            try
            {
                // get and display all rooms
                List<Room> rooms = GetRooms();
                DisplayRooms(rooms);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message);
            }
        }

        private void DisplayRooms(List<Room> rooms)
        {
            // clear the listview before filling it
            listViewRooms.Items.Clear();

            foreach (Room room in rooms)
            {
                ListViewItem listItem = new(room.RoomNumber.ToString());
                listItem.SubItems.Add(room.Capacity.ToString());

                if (room.Type == false)
                {
                    listItem.SubItems.Add("Yes");
                }
                else
                {
                    listItem.SubItems.Add("No");

                }
                listViewRooms.Items.Add(listItem);
            }
        }
        
        //nog een activity

        private void DisplayActivity(List<Activity> activities)
        {
            // clear the listview before filling it
            ActivityListView.Items.Clear();

            foreach (Activity activity in activities)
            {
                ListViewItem li = new ListViewItem(activity.ActiviteitId.ToString());
                li.Tag = activity;   // link student object to listview item
                li.SubItems.Add(activity.Omschrijving);
                li.SubItems.Add(activity.StartTijd.ToString(DateFormat));
                li.SubItems.Add(activity.EindTijd.ToString(DateFormat));
                ActivityListView.Items.Add(li);
            }
        }
        
        // Lecturers beginnen hier
        
        private List<Lecturer> GetLecturers()
        {
            LecturerService lecturerService = new LecturerService();
            List<Lecturer> lecturers = lecturerService.GetLecturers();
            return lecturers;
        }
        private void ShowLecturerPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlActivities.Hide();
            pnlRooms.Hide();
            pnlCashRegister.Hide();

            // show lecturer
            pnlLecturer.Show();

            try
            {
                // get and display all lecturers
                List<Lecturer> lecturers = GetLecturers();
                DisplayLecturers(lecturers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the lecturers: " + e.Message);
            }
        }
        private void DisplayLecturers(List<Lecturer> lecturers)
        {
            // clear the listview before filling it
            listViewLecturers.Items.Clear();

            foreach (Lecturer lectuer in lecturers)
            {
                ListViewItem li = new ListViewItem(lectuer.Id.ToString());
                li.Tag = lectuer;   // link lecturer object to listview item
                li.SubItems.Add(lectuer.Name.ToString());
                listViewLecturers.Items.Add(li);
            }
        }

        //Cash Register
        private void ShowCashRegisterPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlActivities.Hide();
            pnlRooms.Hide();
            pnlLecturer.Hide();

            // show lecturer
            pnlCashRegister.Show();

            try
            {
                // get and display all lecturers
                List<Student> students = GetStudents();
                DisplayCashRegisterStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students for cash register: " + e.Message);
            }
        }

        private void DisplayCashRegisterStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudentsCashRegister.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.Id.ToString());
                li.Tag = student;   // link lecturer object to listview item
                li.SubItems.Add(student.Name.ToString());
                listViewStudentsCashRegister.Items.Add(li);
            }
        }

        // button prompts beginnen hier

        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDashBoardActivities();
        }


        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLecturerPanel();
        }

        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCashRegisterPanel();
        }
    }
}
