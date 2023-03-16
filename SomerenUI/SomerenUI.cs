using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            pnlRooms.Hide();


            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            PnlLecturer.Hide();

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
            listViewRooms.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.Name);
                li.Tag = student;   // link student object to listview item
                li.SubItems.Add(student.Name);
                listViewStudents.Items.Add(li);
            }
        }
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

            // show lecturer
            PnlLecturer.Show();

            try
            {
                // get and display all students
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
            listViewLecturers.Clear();

            foreach (Lecturer lectuer in lecturers)
            {
                ListViewItem li = new ListViewItem(lectuer.Id.ToString());
                li.Tag = lectuer;   // link lecturer object to listview item
                li.SubItems.Add(lectuer.Name.ToString());
                listViewLecturers.Items.Add(li);
            }
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
                if (room.Type == true)
                    listItem.SubItems.Add("Ja");
                else
                    listItem.SubItems.Add("Nee");
                listViewRooms.Items.Add(listItem);
            }
        }

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

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLecturerPanel();
        private void listViewRooms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}