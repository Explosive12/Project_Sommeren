using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using static System.Windows.Forms.LinkLabel;
using System.Globalization;

namespace SomerenUI
{

    public partial class SomerenUI : Form
    {
        CultureInfo provider = new CultureInfo("nl-NL");
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
            pnlRevenueReport.Hide();


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
            pnlRevenueReport.Hide();


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

            try
            {
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
            pnlRevenueReport.Hide();


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


        //
        // Activity buttons here
        //

        private void DeleteActivity()
        {

            if (ActivityListView.SelectedItems.Count == 0)
                return;
            else if (ActivityListView.SelectedItems.Count > 1)
            {
                MessageBox.Show("Please select only 1 activity to delete");
                return;
            }
            // have a yes no option, continue if yes is selected
            DialogResult ActivityDeleteResult = MessageBox.Show("Are you sure you want to delete this activity?", "Delete activity", MessageBoxButtons.YesNo);
            if (ActivityDeleteResult == DialogResult.No)
                return;

            // get the selected activity
            ListViewItem selectedListViewItem = ActivityListView.SelectedItems[0];
            Activity selectedActivity = (Activity)selectedListViewItem.Tag;

            // delete the activity
            ActivityService activityService = new();
            activityService.DeleteActivity(selectedActivity);

            MessageBox.Show($"Successfully deleted the activity {selectedActivity.Omschrijving}!");

            // refresh the listview
            DisplayActivity(GetActivities());

        }

        private void UpdateActivity()
        {
            if (ActivityListView.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select only 1 activity to update");
                return;
            }
            // fill in activity
            try
            {
                Activity editActivity = new()
                {
                    ActiviteitId = int.Parse(ActivityIdTextBox.Text),
                    Omschrijving = OmschrijvingActivityTextBox.Text,
                    StartTijd = DateTime.ParseExact(StartTijdActivityTextBox.Text, DateFormat, provider),
                    EindTijd = DateTime.ParseExact(EindTijdActivityTextBox.Text, DateFormat, provider)
                };

                // update the activity
                ActivityService activityService = new();
                activityService.UpdateActivity(editActivity);
                MessageBox.Show($"the Editing of the activity {editActivity.Omschrijving} went well!");
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Oh no! :( \n Something went wrong: {exp.Message}");
            }
            //Refresh activity list
            DisplayActivity(GetActivities());
            
        }

        // Load the activity info
        private void LoadActivity()
        {
            if (ActivityListView.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem selectedListViewItem = ActivityListView.SelectedItems[0];
            Activity selectedActivity = (Activity)selectedListViewItem.Tag;

            ActivityIdTextBox.Text = selectedActivity.ActiviteitId.ToString();
            OmschrijvingActivityTextBox.Text = selectedActivity.Omschrijving;
            StartTijdActivityTextBox.Text = selectedActivity.StartTijd.ToString(DateFormat);
            EindTijdActivityTextBox.Text = selectedActivity.EindTijd.ToString(DateFormat);

        }



        private void AddActivity()
        {
            // Check if everything is filled in
            if (OmschrijvingActivityTextBox.Text == "" || StartTijdActivityTextBox.Text == "" || EindTijdActivityTextBox.Text == "")
            {
                MessageBox.Show("Please fill in all the boxes! <3");
                return;
            }

            try
            {
                // Fill in the Activity (would work faster with constructor but okay)
                Activity newActivity = new()
                {
                    Omschrijving = OmschrijvingActivityTextBox.Text,
                    StartTijd = DateTime.ParseExact(StartTijdActivityTextBox.Text, DateFormat, provider),
                    EindTijd = DateTime.ParseExact(EindTijdActivityTextBox.Text, DateFormat, provider)
                };

                // Add the activiity
                ActivityService activityService = new();
                activityService.AddActivity(newActivity);
                MessageBox.Show("The activity has been added!");
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Oh no! :( \n Something went wrong: {exp.Message}");
            }
            // refresh activity list
            DisplayActivity(GetActivities());

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
            pnlRevenueReport.Hide();


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
            pnlRevenueReport.Hide();


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
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlActivities.Hide();
            pnlDrinkSupplies.Hide();
            pnlRooms.Hide();
            pnlLecturer.Hide();
            pnlRevenueReport.Hide();


            // show Cash Register
            pnlCashRegister.Show();

            try
            {
                // get and display all cash registers
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

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.Id.ToString());
                li.Tag = student;   // link lecturer object to listview item
                li.SubItems.Add(student.Name.ToString());
                listViewStudentsCashRegister.Items.Add(li);
                cashRegisterStudentComboBox.DisplayMember = "DisplayMember";
                cashRegisterStudentComboBox.Items.Add(student);
            }
        }

        private void DisplayCashRegisterDrinks(List<Drinks> drinks)
        {
            // clear the listview before filling it
            listViewDrankCashRegister.Items.Clear();

            foreach (Drinks drink in drinks)
            {
                ListViewItem li = new ListViewItem(drink.Dranknr.ToString());
                li.Tag = drink;   // link lecturer object to listview item
                li.SubItems.Add(drink.Naam.ToString());
                li.SubItems.Add(drink.Prijs.ToString());
                li.SubItems.Add(drink.Voorraad.ToString());
                li.SubItems.Add(drink.Aantal_Verkocht.ToString());
                listViewDrankCashRegister.Items.Add(li);
                cashRegisterDrinksComboBox.DisplayMember = "DisplayMember";
                cashRegisterDrinksComboBox.Items.Add(drink);

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
            pnlRevenueReport.Hide();


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
            foreach (ListViewItem voorraadIcoon in listViewDrinkSupplies.Items)
            {
                int voorraad = 0;
                if (int.TryParse(voorraadIcoon.SubItems[3].Text, out voorraad) && voorraad < 10)
                {
                    voorraadIcoon.ImageIndex = 1;
                }
                else
                {
                    voorraadIcoon.ImageIndex = 0;
                }
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

        //Revenue report begint hier

        private void ShowRevenuePanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlActivities.Hide();
            pnlRooms.Hide();
            pnlLecturer.Hide();
            pnlCashRegister.Hide();
            pnlDrinkSupplies.Hide();

            // show Revenue
            pnlRevenueReport.Show();
        }

        bool start = false;
        DateTime startDate = new DateTime(1, 1, 1);
        DateTime endDate = new DateTime(2050, 12, 30);
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (monthCalendar.SelectionStart > DateTime.Now)
            {
                MessageBox.Show("cant select past current time, silly :3");
                return;
            }
            if (start)
            {
                endDate = monthCalendar.SelectionStart;
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
                startDate = monthCalendar.SelectionStart;
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

        private void revenuebtn_Click(object sender, EventArgs e)
        {
            try
            {
                RevenueService revenueService = new RevenueService();
                Revenue revenue = new Revenue();
                revenue = revenueService.Select(startDate, endDate, revenue);

                // add revenue data to listview

                ListViewItem li = new ListViewItem(revenue.Sales.ToString());
                li.Tag = revenue;   // link revenue object to listview items
                li.SubItems.Add(revenue.Turnover.ToString());
                li.SubItems.Add(revenue.NumberOfStudents.ToString());
                listViewRevenueReport.Items.Add(li);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Something went wrong!" + ex.Message);
            }
        }

        // button prompts beginnen hier

        private void UpdateDrinkSupplies_Click(object sender, EventArgs e)
        {

            ListViewItem selectedListViewItem = listViewDrinkSupplies.SelectedItems[0];
            selectedDrink = (Drinks)selectedListViewItem.Tag;

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
        // Cash Register begint here

        public Student selectedStudent;
        private void listViewStudentsCashRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStudentsCashRegister.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem selectedListViewStudent = listViewStudentsCashRegister.SelectedItems[0];
            selectedStudent = (Student)selectedListViewStudent.Tag;
        }


        public Drinks selectedDrink;
        private void listViewDrankCashRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDrankCashRegister.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem selectedListViewDrank = listViewDrankCashRegister.SelectedItems[0];
            selectedDrink = (Drinks)selectedListViewDrank.Tag;
        }


        private void cashRegisterSubmitOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                OrderService orderService = new OrderService();

                orderService.Insert(selectedStudent.Id, selectedDrink.Dranknr, selectedDrink.Prijs, DateTime.Now);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Something went wrong!" + ex.Message);
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


        private void DrinkSuppliesButton_Click(object sender, EventArgs e)
        {
            ShowDashBoardDrinks();
        }

        private void CashRegisterButton_Click(object sender, EventArgs e)
        {
            ShowCashRegisterPanel();
        }

        private void RevenueReportButtonn_Click(object sender, EventArgs e)
        {
            ShowRevenuePanel();
        }

        private void cashRegisterStudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStudent = (Student)cashRegisterStudentComboBox.SelectedItem;
        }

        private void cashRegisterDrinksComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDrink = (Drinks)cashRegisterDrinksComboBox.SelectedItem;

        }


        // Make the VatCalculation form show up
        private void VATCalculationMenuItem_Click(object sender, EventArgs e)
        {
            VATCalculationUI form = new();
            form.ShowDialog();
        }

        private void AddActivityButton_Click(object sender, EventArgs e)
        {
            AddActivity();
        }

        private void DeleteActivityButton_Click(object sender, EventArgs e)
        {
            DeleteActivity();
        }

        private void UpdateActivityButton_Click(object sender, EventArgs e)
        {
            UpdateActivity();
        }

        private void ActivityListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadActivity();
        }

        private void activityStudentsButton_Click(object sender, EventArgs e)
        {
            ActivityStudentUI activityStudent = new ActivityStudentUI();
            activityStudent.ShowDialog();

        }
    }
}
