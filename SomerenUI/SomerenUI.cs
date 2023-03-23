using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Data.SqlClient;

namespace SomerenUI
{

    public partial class SomerenUI : Form
    {
        const string DateFormat = "yyyy-MM-dd HH:mm";
        const string DateFormat2 = "yyyy-MM-dd";
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
            pnlDrinkSupplies.Hide();
            pnlCashRegister.Hide();

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
            pnlDrinkSupplies.Hide();
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
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the Students: " + e.Message);
            }
        }


        // Hier beginnen de activiteiten


        private void ShowDashBoardActivities()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlLecturer.Hide();
            pnlRooms.Hide();
            pnlDrinkSupplies.Hide();
            pnlCashRegister.Hide();

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
            pnlDrinkSupplies.Hide();
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
            pnlDrinkSupplies.Hide();

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
        private List<Drinks> GetDrinks()
        {
            DrinkService drinkService = new DrinkService();
            List<Drinks> allDrinks = drinkService.GetDrinks();
            return allDrinks;
        }

        private void ShowCashRegisterPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlActivities.Hide();
            pnlDrinkSupplies.Hide();
            pnlRooms.Hide();
            pnlLecturer.Hide();

            // show lecturer
            pnlCashRegister.Show();

            try
            {
                // get and display all lecturers
                List<Student> students = GetStudents();
                DisplayCashRegisterStudents(students);

                // get and display all drinks 
                List<Drinks> drinks = GetDrinks();
                DisplayCashRegisterDrinks(drinks);

            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students/drinks for cash register: " + e.Message);
            }
        }

        private void DisplayCashRegisterStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudentsCashRegister.Items.Clear();
            cashRegisterStudentComboBox.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.Id.ToString());
                li.Tag = student;   // link lecturer object to listview item
                li.SubItems.Add(student.Name.ToString());
                listViewStudentsCashRegister.Items.Add(li);
                cashRegisterStudentComboBox.Items.Add($"{student.Id}. {student.Name}");
            }
        }

        private void DisplayCashRegisterDrinks(List<Drinks> drinks)
        {
            // clear the listview before filling it
            listViewDrankCashRegister.Items.Clear();
            cashRegisterDrinksComboBox.Items.Clear();

            foreach (Drinks drink in drinks)
            {
                ListViewItem li = new ListViewItem(drink.Dranknr.ToString());
                li.Tag = drink;   // link lecturer object to listview item
                li.SubItems.Add(drink.Naam.ToString());
                li.SubItems.Add(drink.Prijs.ToString());
                li.SubItems.Add(drink.Voorraad.ToString());
                li.SubItems.Add(drink.Aantal_Verkocht.ToString());
                listViewDrankCashRegister.Items.Add(li);
                cashRegisterDrinksComboBox.Items.Add($"{drink.Dranknr}. {drink.Naam} - Prijs: {drink.Prijs} - Voorraad: {drink.Voorraad}");
            }
        }

        // button prompts beginnen hier
        /* Drankjes =========================================================================================== */

        private void ShowDashBoardDrinks()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlLecturer.Hide();
            pnlStudents.Hide();
            pnlActivities.Hide();
            pnlCashRegister.Hide();
            pnlRooms.Hide();

            // show activity
            pnlDrinkSupplies.Show();

            try
            {
                // get and display all activity
                List<Drinks> drinks = GetDrinks();
                DisplayDrinks(drinks);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the Drinks: " + e.Message);
            }
        }

        private void DisplayDrinks(List<Drinks> drinks)
        {
            // clear the listview before filling it
            listViewDrinkSupplies.Items.Clear();

            foreach (Drinks drink in drinks)
            {
                ListViewItem li = new ListViewItem(drink.Dranknr.ToString());
                li.Tag = drink;   // link student object to listview item
                li.SubItems.Add(drink.Naam);
                li.SubItems.Add(drink.Prijs.ToString());
                li.SubItems.Add(drink.Voorraad.ToString());
                li.SubItems.Add(drink.Aantal_Verkocht.ToString());
                listViewDrinkSupplies.Items.Add(li);
            }
        }

        private void listViewDrinkSupplies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDrinkSupplies.SelectedItems.Count == 0)
            {
                return;
            }
            /*listViewDrinkSupplies.FullRowSelect = true;*/
            ListViewItem selectedListViewItem = listViewDrinkSupplies.SelectedItems[0];
            Drinks selectedDrink = (Drinks)selectedListViewItem.Tag;

            DranknrDrinkSupplies.Text = selectedDrink.Dranknr.ToString();
            NaamDrinkSupplies.Text = selectedDrink.Naam;
            VoorraadDrinkSupplies.Text = selectedDrink.Voorraad.ToString();
        }

        private void UpdateDrinkSupplies_Click(object sender, EventArgs e)
        {

            ListViewItem selectedListViewItem = listViewDrinkSupplies.SelectedItems[0];
            Drinks selectedDrink = (Drinks)selectedListViewItem.Tag;

            try
            {
                DrinkService drinkService = new DrinkService();
                drinkService.Update(int.Parse(DranknrDrinkSupplies.Text), NaamDrinkSupplies.Text, int.Parse(VoorraadDrinkSupplies.Text));
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Something went wrong!" + ex.Message);

            }
            DisplayDrinks(GetDrinks());
        }

        //Revenue report begint hier

        private void ShowRevenuePanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlActivities.Hide();
            pnlRooms.Hide();
            pnlLecturer.Hide();

            // show Revenue
            pnlRevenueReport.Show();


        }
        bool start = false;
        DateTime startDate = new DateTime(1, 1, 1);
        DateTime endDate = new DateTime(2050, 12, 30);
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (monthCalendar1.SelectionStart > DateTime.Now)
            {
                MessageBox.Show("cant select past current time, silly :3");
                return;
            }
            if (start)
            {
                endDate = monthCalendar1.SelectionStart;
                if (endDate < startDate)
                {
                    startTimetxt.Text = $"Start date: {endDate.ToString(DateFormat2)}";
                    start = false;
                    return;
                }
                endTimetxt.Text = $"End date: {endDate.ToString(DateFormat2)}";
                start = false;
            }
            else
            {
                startDate = monthCalendar1.SelectionStart;
                if (startDate > endDate)
                {
                    endTimetxt.Text = $"End date: {startDate.ToString(DateFormat2)}";
                    start = true;
                    return;
                }
                startTimetxt.Text = $"Start date: {startDate.ToString(DateFormat2)}";
                start = true;
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

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDashBoardActivities();
        }


        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLecturerPanel();
        }



        private void drinkSuppliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDashBoardDrinks();
        }

        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCashRegisterPanel();
        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRevenuePanel();
        }
    }
}
