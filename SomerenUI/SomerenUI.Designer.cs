using System.Windows.Forms;

namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            lecturersToolStripMenuItem = new ToolStripMenuItem();
            activitiesToolStripMenuItem = new ToolStripMenuItem();
            timeTableToolStripMenuItem = new ToolStripMenuItem();
            roomsToolStripMenuItem = new ToolStripMenuItem();
            DrinksButton = new ToolStripMenuItem();
            DrinkSuppliesButton = new ToolStripMenuItem();
            CashRegisterButton = new ToolStripMenuItem();
            RevenueReportButtonn = new ToolStripMenuItem();
            VATCalculationMenuItem = new ToolStripMenuItem();
            revenueToolStripMenuItem = new ToolStripMenuItem();
            listViewRevenueReport = new ListView();
            salesColumHeader = new ColumnHeader();
            TurnoverColumHeader = new ColumnHeader();
            nCustomerColumHeader = new ColumnHeader();
            pnlDashboard = new Panel();
            lblDashboard = new Label();
            pnlStudents = new Panel();
            pictureBox1 = new PictureBox();
            listViewStudents = new ListView();
            IdHeader = new ColumnHeader();
            NameStudentHeader = new ColumnHeader();
            label1 = new Label();
            monthCalendar = new MonthCalendar();
            pictureBox2 = new PictureBox();
            revenuebtn = new Button();
            pnlRooms = new Panel();
            SomerenRoomsPicture = new PictureBox();
            listViewRooms = new ListView();
            KamerNummer = new ColumnHeader();
            Aantalbedden = new ColumnHeader();
            DocentORStudent = new ColumnHeader();
            RoomLabel = new Label();
            pnlLecturer = new Panel();
            listViewLecturers = new ListView();
            DocentIDHeader = new ColumnHeader();
            DocentNameHeader = new ColumnHeader();
            label2 = new Label();
            pnlActivities = new Panel();
            activitySupervisor = new Button();
            activityStudentsButton = new Button();
            UpdateActivityButton = new Button();
            EindTijdActivityTextBox = new TextBox();
            StartTijdActivityTextBox = new TextBox();
            EindTijdActivityLabel = new Label();
            StartTijdActivityLabel = new Label();
            ActivityOmschrijvingLabel = new Label();
            OmschrijvingActivityTextBox = new TextBox();
            IdActivityLabel = new Label();
            ActivityIdTextBox = new TextBox();
            DeleteActivityButton = new Button();
            AddActivityButton = new Button();
            pictureBox3 = new PictureBox();
            ActivityListView = new ListView();
            IdColumnHeader3 = new ColumnHeader();
            OmschrijvingcolumnHeader4 = new ColumnHeader();
            StartTijdcolumnHeader3 = new ColumnHeader();
            EindTijdcolumnHeader4 = new ColumnHeader();
            ActivityLabel = new Label();
            pnlRevenueReport = new Panel();
            EindTijdLabel = new Label();
            BeginTijdLabel = new Label();
            pictureBox5 = new PictureBox();
            endTimetxt = new TextBox();
            startTimetxt = new TextBox();
            RevenuePictureBox = new PictureBox();
            RevenueLabel = new Label();
            pnlDrinkSupplies = new Panel();
            VoorraadDrinkLabel = new Label();
            DrankNaamLabel = new Label();
            labelDrankNummer = new Label();
            DranknrDrinkSupplies = new TextBox();
            UpdateDrinkSupplies = new Button();
            VoorraadDrinkSupplies = new TextBox();
            NaamDrinkSupplies = new TextBox();
            pictureBoxDrinkSupplies = new PictureBox();
            listViewDrinkSupplies = new ListView();
            columnHeader1Dranknr = new ColumnHeader();
            columnHeader2naam = new ColumnHeader();
            columnHeader3Prijs = new ColumnHeader();
            columnHeader4Voorraad = new ColumnHeader();
            columnHeader1Aantal_verkocht = new ColumnHeader();
            ImageListDrinkSupplies = new ImageList(components);
            Drink_Supplies = new Label();
            pnlCashRegister = new Panel();
            cashRegisterDrinksComboBox = new ComboBox();
            cashRegisterStudentComboBox = new ComboBox();
            cashRegisterSubmitOrderButton = new Button();
            listViewDrankCashRegister = new ListView();
            cashRegisterDrankColumnHeader1 = new ColumnHeader();
            cashRegisterDrankColumnHeader2 = new ColumnHeader();
            cashRegisterDrankColumnHeader3 = new ColumnHeader();
            cashRegisterDrankColumnHeader4 = new ColumnHeader();
            cashRegisterDrankColumnHeader5 = new ColumnHeader();
            pictureBox4 = new PictureBox();
            listViewStudentsCashRegister = new ListView();
            cashRegisterStudentColumnHeader1 = new ColumnHeader();
            cashRegisterStudentColumnHeader2 = new ColumnHeader();
            cashRegisterLabel = new Label();
            pnlTimeTable = new Panel();
            timeTableflowpnl = new FlowLayoutPanel();
            mondayTpnl = new Panel();
            monSuptxt = new TextBox();
            label4 = new Label();
            mondaylbl = new Label();
            monactivitytxt = new TextBox();
            label5 = new Label();
            tuesdayTpnl = new Panel();
            tueSuptxt = new TextBox();
            label3 = new Label();
            label6 = new Label();
            tueActivitytxt = new TextBox();
            label7 = new Label();
            wednesdayTpnl = new Panel();
            wedSuptxt = new TextBox();
            wednesdaylbl = new Label();
            label8 = new Label();
            wedActivitytxt = new TextBox();
            label9 = new Label();
            thursdayTpnl = new Panel();
            thuSuptxt = new TextBox();
            thursdaylbl = new Label();
            label10 = new Label();
            thuActivitytxt = new TextBox();
            label11 = new Label();
            fridayTpnl = new Panel();
            friSuptxt = new TextBox();
            fridaylbl = new Label();
            label12 = new Label();
            friActivitytxt = new TextBox();
            label13 = new Label();
            TimePicBox = new PictureBox();
            TimeTablelbl = new Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SomerenRoomsPicture).BeginInit();
            pnlLecturer.SuspendLayout();
            pnlActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlRevenueReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RevenuePictureBox).BeginInit();
            pnlDrinkSupplies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDrinkSupplies).BeginInit();
            pnlCashRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlTimeTable.SuspendLayout();
            timeTableflowpnl.SuspendLayout();
            mondayTpnl.SuspendLayout();
            tuesdayTpnl.SuspendLayout();
            wednesdayTpnl.SuspendLayout();
            thursdayTpnl.SuspendLayout();
            fridayTpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TimePicBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, DrinksButton });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(962, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(80, 19);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(67, 19);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { timeTableToolStripMenuItem });
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(67, 19);
            activitiesToolStripMenuItem.Text = "Activities";
            activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
            // 
            // timeTableToolStripMenuItem
            // 
            timeTableToolStripMenuItem.Name = "timeTableToolStripMenuItem";
            timeTableToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            timeTableToolStripMenuItem.Text = "TimeTable";
            timeTableToolStripMenuItem.Click += timeTableToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // DrinksButton
            // 
            DrinksButton.DropDownItems.AddRange(new ToolStripItem[] { DrinkSuppliesButton, CashRegisterButton, RevenueReportButtonn, VATCalculationMenuItem });
            DrinksButton.Name = "DrinksButton";
            DrinksButton.Size = new System.Drawing.Size(52, 19);
            DrinksButton.Text = "Drinks";
            // 
            // DrinkSuppliesButton
            // 
            DrinkSuppliesButton.Name = "DrinkSuppliesButton";
            DrinkSuppliesButton.Size = new System.Drawing.Size(157, 22);
            DrinkSuppliesButton.Text = "Drink Supplies";
            DrinkSuppliesButton.Click += DrinkSuppliesButton_Click;
            // 
            // CashRegisterButton
            // 
            CashRegisterButton.Name = "CashRegisterButton";
            CashRegisterButton.Size = new System.Drawing.Size(157, 22);
            CashRegisterButton.Text = "Cash Register";
            CashRegisterButton.Click += CashRegisterButton_Click;
            // 
            // RevenueReportButtonn
            // 
            RevenueReportButtonn.Name = "RevenueReportButtonn";
            RevenueReportButtonn.Size = new System.Drawing.Size(157, 22);
            RevenueReportButtonn.Text = "Revenue Report";
            RevenueReportButtonn.Click += RevenueReportButtonn_Click;
            // 
            // VATCalculationMenuItem
            // 
            VATCalculationMenuItem.Name = "VATCalculationMenuItem";
            VATCalculationMenuItem.Size = new System.Drawing.Size(157, 22);
            VATCalculationMenuItem.Text = "Calculate VAT";
            VATCalculationMenuItem.Click += VATCalculationMenuItem_Click;
            // 
            // revenueToolStripMenuItem
            // 
            revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            revenueToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            revenueToolStripMenuItem.Text = "Revenue report";
            // 
            // listViewRevenueReport
            // 
            listViewRevenueReport.Columns.AddRange(new ColumnHeader[] { salesColumHeader, TurnoverColumHeader, nCustomerColumHeader });
            listViewRevenueReport.Location = new System.Drawing.Point(20, 60);
            listViewRevenueReport.Margin = new Padding(1, 4, 1, 4);
            listViewRevenueReport.Name = "listViewRevenueReport";
            listViewRevenueReport.Size = new System.Drawing.Size(304, 258);
            listViewRevenueReport.TabIndex = 1;
            listViewRevenueReport.UseCompatibleStateImageBehavior = false;
            listViewRevenueReport.View = View.Details;
            // 
            // salesColumHeader
            // 
            salesColumHeader.Text = "Sales";
            salesColumHeader.Width = 50;
            // 
            // TurnoverColumHeader
            // 
            TurnoverColumHeader.Text = "Turnover";
            TurnoverColumHeader.Width = 100;
            // 
            // nCustomerColumHeader
            // 
            nCustomerColumHeader.Text = "nCustomer";
            nCustomerColumHeader.Width = 90;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(8, 22);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(944, 471);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(15, 17);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(208, 15);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(pictureBox1);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(label1);
            pnlStudents.Location = new System.Drawing.Point(8, 22);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(944, 471);
            pnlStudents.TabIndex = 2;
            pnlStudents.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(826, 36);
            pictureBox1.Margin = new Padding(1, 2, 1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(127, 118);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Columns.AddRange(new ColumnHeader[] { IdHeader, NameStudentHeader });
            listViewStudents.Location = new System.Drawing.Point(13, 38);
            listViewStudents.Margin = new Padding(1, 2, 1, 2);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(809, 425);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = View.Details;
            // 
            // IdHeader
            // 
            IdHeader.Text = "StudentId";
            // 
            // NameStudentHeader
            // 
            NameStudentHeader.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(13, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 32);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new System.Drawing.Point(357, 111);
            monthCalendar.Margin = new Padding(11);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 3;
            monthCalendar.DateChanged += monthCalendar_DateChanged_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(911, 56);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(144, 161);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // revenuebtn
            // 
            revenuebtn.Location = new System.Drawing.Point(42, 357);
            revenuebtn.Name = "revenuebtn";
            revenuebtn.Size = new System.Drawing.Size(225, 54);
            revenuebtn.TabIndex = 8;
            revenuebtn.Text = "Calculate revenue";
            revenuebtn.UseVisualStyleBackColor = true;
            revenuebtn.Click += revenuebtn_Click_1;
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(SomerenRoomsPicture);
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Controls.Add(RoomLabel);
            pnlRooms.Location = new System.Drawing.Point(8, 22);
            pnlRooms.Margin = new Padding(1, 2, 1, 2);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(944, 471);
            pnlRooms.TabIndex = 3;
            // 
            // SomerenRoomsPicture
            // 
            SomerenRoomsPicture.Image = (System.Drawing.Image)resources.GetObject("SomerenRoomsPicture.Image");
            SomerenRoomsPicture.Location = new System.Drawing.Point(801, 35);
            SomerenRoomsPicture.Margin = new Padding(1, 2, 1, 2);
            SomerenRoomsPicture.Name = "SomerenRoomsPicture";
            SomerenRoomsPicture.Size = new System.Drawing.Size(127, 118);
            SomerenRoomsPicture.TabIndex = 2;
            SomerenRoomsPicture.TabStop = false;
            // 
            // listViewRooms
            // 
            listViewRooms.Columns.AddRange(new ColumnHeader[] { KamerNummer, Aantalbedden, DocentORStudent });
            listViewRooms.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listViewRooms.Location = new System.Drawing.Point(15, 36);
            listViewRooms.Margin = new Padding(1, 2, 1, 2);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(781, 424);
            listViewRooms.TabIndex = 1;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            listViewRooms.View = View.Details;
            // 
            // KamerNummer
            // 
            KamerNummer.Tag = "";
            KamerNummer.Text = "KamerNummer";
            KamerNummer.Width = 100;
            // 
            // Aantalbedden
            // 
            Aantalbedden.Tag = "";
            Aantalbedden.Text = "Aantal Bedden";
            Aantalbedden.TextAlign = HorizontalAlignment.Center;
            Aantalbedden.Width = 120;
            // 
            // DocentORStudent
            // 
            DocentORStudent.Tag = "";
            DocentORStudent.Text = "Docent?";
            // 
            // RoomLabel
            // 
            RoomLabel.AutoSize = true;
            RoomLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RoomLabel.Location = new System.Drawing.Point(13, 4);
            RoomLabel.Margin = new Padding(1, 0, 1, 0);
            RoomLabel.Name = "RoomLabel";
            RoomLabel.Size = new System.Drawing.Size(86, 32);
            RoomLabel.TabIndex = 0;
            RoomLabel.Text = "Rooms";
            // 
            // pnlLecturer
            // 
            pnlLecturer.Controls.Add(pictureBox2);
            pnlLecturer.Controls.Add(listViewLecturers);
            pnlLecturer.Controls.Add(label2);
            pnlLecturer.Location = new System.Drawing.Point(8, 22);
            pnlLecturer.Name = "pnlLecturer";
            pnlLecturer.Size = new System.Drawing.Size(944, 711);
            pnlLecturer.TabIndex = 3;
            // 
            // listViewLecturers
            // 
            listViewLecturers.Columns.AddRange(new ColumnHeader[] { DocentIDHeader, DocentNameHeader });
            listViewLecturers.Location = new System.Drawing.Point(17, 56);
            listViewLecturers.Margin = new Padding(3, 4, 3, 4);
            listViewLecturers.Name = "listViewLecturers";
            listViewLecturers.Size = new System.Drawing.Size(875, 408);
            listViewLecturers.TabIndex = 1;
            listViewLecturers.UseCompatibleStateImageBehavior = false;
            listViewLecturers.View = View.Details;
            // 
            // DocentIDHeader
            // 
            DocentIDHeader.Text = "DocentID";
            DocentIDHeader.Width = 150;
            // 
            // DocentNameHeader
            // 
            DocentNameHeader.Text = "DocentName";
            DocentNameHeader.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(15, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(110, 32);
            label2.TabIndex = 0;
            label2.Text = "Lecturers";
            // 
            // pnlActivities
            // 
            pnlActivities.Controls.Add(activitySupervisor);
            pnlActivities.Controls.Add(activityStudentsButton);
            pnlActivities.Controls.Add(UpdateActivityButton);
            pnlActivities.Controls.Add(EindTijdActivityTextBox);
            pnlActivities.Controls.Add(StartTijdActivityTextBox);
            pnlActivities.Controls.Add(EindTijdActivityLabel);
            pnlActivities.Controls.Add(StartTijdActivityLabel);
            pnlActivities.Controls.Add(ActivityOmschrijvingLabel);
            pnlActivities.Controls.Add(OmschrijvingActivityTextBox);
            pnlActivities.Controls.Add(IdActivityLabel);
            pnlActivities.Controls.Add(ActivityIdTextBox);
            pnlActivities.Controls.Add(DeleteActivityButton);
            pnlActivities.Controls.Add(AddActivityButton);
            pnlActivities.Controls.Add(pictureBox3);
            pnlActivities.Controls.Add(ActivityListView);
            pnlActivities.Controls.Add(ActivityLabel);
            pnlActivities.Location = new System.Drawing.Point(8, 22);
            pnlActivities.Margin = new Padding(1, 2, 1, 2);
            pnlActivities.Name = "pnlActivities";
            pnlActivities.Size = new System.Drawing.Size(944, 471);
            pnlActivities.TabIndex = 4;
            // 
            // activitySupervisor
            // 
            activitySupervisor.Location = new System.Drawing.Point(755, 398);
            activitySupervisor.Name = "activitySupervisor";
            activitySupervisor.Size = new System.Drawing.Size(159, 43);
            activitySupervisor.TabIndex = 15;
            activitySupervisor.Text = "Activity Supervisor";
            activitySupervisor.UseVisualStyleBackColor = true;
            activitySupervisor.Click += activitySupervisor_Click;
            // 
            // activityStudentsButton
            // 
            activityStudentsButton.Location = new System.Drawing.Point(755, 346);
            activityStudentsButton.Name = "activityStudentsButton";
            activityStudentsButton.Size = new System.Drawing.Size(160, 38);
            activityStudentsButton.TabIndex = 15;
            activityStudentsButton.Text = "Activity Students";
            activityStudentsButton.UseVisualStyleBackColor = true;
            activityStudentsButton.Click += activityStudentsButton_Click;
            // 
            // UpdateActivityButton
            // 
            UpdateActivityButton.Location = new System.Drawing.Point(496, 134);
            UpdateActivityButton.Name = "UpdateActivityButton";
            UpdateActivityButton.Size = new System.Drawing.Size(168, 43);
            UpdateActivityButton.TabIndex = 14;
            UpdateActivityButton.Text = "&Update activity";
            UpdateActivityButton.UseVisualStyleBackColor = true;
            UpdateActivityButton.Click += UpdateActivityButton_Click;
            // 
            // EindTijdActivityTextBox
            // 
            EindTijdActivityTextBox.Location = new System.Drawing.Point(126, 428);
            EindTijdActivityTextBox.Margin = new Padding(3, 4, 3, 4);
            EindTijdActivityTextBox.Name = "EindTijdActivityTextBox";
            EindTijdActivityTextBox.Size = new System.Drawing.Size(161, 23);
            EindTijdActivityTextBox.TabIndex = 13;
            // 
            // StartTijdActivityTextBox
            // 
            StartTijdActivityTextBox.Location = new System.Drawing.Point(126, 393);
            StartTijdActivityTextBox.Margin = new Padding(3, 4, 3, 4);
            StartTijdActivityTextBox.Name = "StartTijdActivityTextBox";
            StartTijdActivityTextBox.Size = new System.Drawing.Size(161, 23);
            StartTijdActivityTextBox.TabIndex = 12;
            // 
            // EindTijdActivityLabel
            // 
            EindTijdActivityLabel.AutoSize = true;
            EindTijdActivityLabel.Location = new System.Drawing.Point(15, 433);
            EindTijdActivityLabel.Name = "EindTijdActivityLabel";
            EindTijdActivityLabel.Size = new System.Drawing.Size(52, 15);
            EindTijdActivityLabel.TabIndex = 11;
            EindTijdActivityLabel.Text = "EindTijd:";
            // 
            // StartTijdActivityLabel
            // 
            StartTijdActivityLabel.AutoSize = true;
            StartTijdActivityLabel.Location = new System.Drawing.Point(16, 396);
            StartTijdActivityLabel.Name = "StartTijdActivityLabel";
            StartTijdActivityLabel.Size = new System.Drawing.Size(53, 15);
            StartTijdActivityLabel.TabIndex = 10;
            StartTijdActivityLabel.Text = "StartTijd:";
            // 
            // ActivityOmschrijvingLabel
            // 
            ActivityOmschrijvingLabel.AutoSize = true;
            ActivityOmschrijvingLabel.Location = new System.Drawing.Point(17, 357);
            ActivityOmschrijvingLabel.Name = "ActivityOmschrijvingLabel";
            ActivityOmschrijvingLabel.Size = new System.Drawing.Size(81, 15);
            ActivityOmschrijvingLabel.TabIndex = 9;
            ActivityOmschrijvingLabel.Text = "Omschrijving:";
            // 
            // OmschrijvingActivityTextBox
            // 
            OmschrijvingActivityTextBox.Location = new System.Drawing.Point(126, 357);
            OmschrijvingActivityTextBox.Name = "OmschrijvingActivityTextBox";
            OmschrijvingActivityTextBox.Size = new System.Drawing.Size(166, 23);
            OmschrijvingActivityTextBox.TabIndex = 8;
            // 
            // IdActivityLabel
            // 
            IdActivityLabel.AutoSize = true;
            IdActivityLabel.Location = new System.Drawing.Point(18, 321);
            IdActivityLabel.Name = "IdActivityLabel";
            IdActivityLabel.Size = new System.Drawing.Size(21, 15);
            IdActivityLabel.TabIndex = 7;
            IdActivityLabel.Text = "ID:";
            // 
            // ActivityIdTextBox
            // 
            ActivityIdTextBox.Location = new System.Drawing.Point(68, 318);
            ActivityIdTextBox.Margin = new Padding(3, 4, 3, 4);
            ActivityIdTextBox.Name = "ActivityIdTextBox";
            ActivityIdTextBox.ReadOnly = true;
            ActivityIdTextBox.Size = new System.Drawing.Size(31, 23);
            ActivityIdTextBox.TabIndex = 6;
            // 
            // DeleteActivityButton
            // 
            DeleteActivityButton.Location = new System.Drawing.Point(496, 230);
            DeleteActivityButton.Name = "DeleteActivityButton";
            DeleteActivityButton.Size = new System.Drawing.Size(168, 43);
            DeleteActivityButton.TabIndex = 5;
            DeleteActivityButton.Text = "&Delete activity";
            DeleteActivityButton.UseVisualStyleBackColor = true;
            DeleteActivityButton.Click += DeleteActivityButton_Click;
            // 
            // AddActivityButton
            // 
            AddActivityButton.Location = new System.Drawing.Point(496, 39);
            AddActivityButton.Name = "AddActivityButton";
            AddActivityButton.Size = new System.Drawing.Size(168, 43);
            AddActivityButton.TabIndex = 4;
            AddActivityButton.Text = "&Add activity";
            AddActivityButton.UseVisualStyleBackColor = true;
            AddActivityButton.Click += AddActivityButton_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(785, 20);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(129, 121);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // ActivityListView
            // 
            ActivityListView.Columns.AddRange(new ColumnHeader[] { IdColumnHeader3, OmschrijvingcolumnHeader4, StartTijdcolumnHeader3, EindTijdcolumnHeader4 });
            ActivityListView.FullRowSelect = true;
            ActivityListView.Location = new System.Drawing.Point(13, 39);
            ActivityListView.Margin = new Padding(1, 2, 1, 2);
            ActivityListView.Name = "ActivityListView";
            ActivityListView.Size = new System.Drawing.Size(437, 234);
            ActivityListView.TabIndex = 1;
            ActivityListView.UseCompatibleStateImageBehavior = false;
            ActivityListView.View = View.Details;
            ActivityListView.SelectedIndexChanged += ActivityListView_SelectedIndexChanged;
            // 
            // IdColumnHeader3
            // 
            IdColumnHeader3.Text = "ActiviteitId";
            IdColumnHeader3.Width = 80;
            // 
            // OmschrijvingcolumnHeader4
            // 
            OmschrijvingcolumnHeader4.Text = "Omschrijving";
            OmschrijvingcolumnHeader4.TextAlign = HorizontalAlignment.Center;
            OmschrijvingcolumnHeader4.Width = 150;
            // 
            // StartTijdcolumnHeader3
            // 
            StartTijdcolumnHeader3.Text = "StartTijd";
            StartTijdcolumnHeader3.TextAlign = HorizontalAlignment.Center;
            StartTijdcolumnHeader3.Width = 100;
            // 
            // EindTijdcolumnHeader4
            // 
            EindTijdcolumnHeader4.Text = "EindTijd";
            EindTijdcolumnHeader4.TextAlign = HorizontalAlignment.Center;
            EindTijdcolumnHeader4.Width = 100;
            // 
            // ActivityLabel
            // 
            ActivityLabel.AutoSize = true;
            ActivityLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ActivityLabel.Location = new System.Drawing.Point(11, 3);
            ActivityLabel.Margin = new Padding(1, 0, 1, 0);
            ActivityLabel.Name = "ActivityLabel";
            ActivityLabel.Size = new System.Drawing.Size(134, 32);
            ActivityLabel.TabIndex = 0;
            ActivityLabel.Text = "Activiteiten";
            // 
            // pnlRevenueReport
            // 
            pnlRevenueReport.Controls.Add(EindTijdLabel);
            pnlRevenueReport.Controls.Add(BeginTijdLabel);
            pnlRevenueReport.Controls.Add(pictureBox5);
            pnlRevenueReport.Controls.Add(revenuebtn);
            pnlRevenueReport.Controls.Add(endTimetxt);
            pnlRevenueReport.Controls.Add(startTimetxt);
            pnlRevenueReport.Controls.Add(monthCalendar);
            pnlRevenueReport.Controls.Add(RevenuePictureBox);
            pnlRevenueReport.Controls.Add(listViewRevenueReport);
            pnlRevenueReport.Controls.Add(RevenueLabel);
            pnlRevenueReport.Location = new System.Drawing.Point(8, 22);
            pnlRevenueReport.Margin = new Padding(4, 5, 4, 5);
            pnlRevenueReport.Name = "pnlRevenueReport";
            pnlRevenueReport.Size = new System.Drawing.Size(944, 471);
            pnlRevenueReport.TabIndex = 5;
            pnlRevenueReport.Visible = false;
            // 
            // EindTijdLabel
            // 
            EindTijdLabel.AutoSize = true;
            EindTijdLabel.Location = new System.Drawing.Point(593, 252);
            EindTijdLabel.Name = "EindTijdLabel";
            EindTijdLabel.Size = new System.Drawing.Size(33, 15);
            EindTijdLabel.TabIndex = 9;
            EindTijdLabel.Text = "Eind:";
            // 
            // BeginTijdLabel
            // 
            BeginTijdLabel.AutoSize = true;
            BeginTijdLabel.Location = new System.Drawing.Point(598, 165);
            BeginTijdLabel.Name = "BeginTijdLabel";
            BeginTijdLabel.Size = new System.Drawing.Size(40, 15);
            BeginTijdLabel.TabIndex = 8;
            BeginTijdLabel.Text = "Begin:";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(787, 13);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(127, 121);
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // endTimetxt
            // 
            endTimetxt.Location = new System.Drawing.Point(638, 244);
            endTimetxt.Margin = new Padding(4);
            endTimetxt.Name = "endTimetxt";
            endTimetxt.ReadOnly = true;
            endTimetxt.Size = new System.Drawing.Size(124, 23);
            endTimetxt.TabIndex = 7;
            // 
            // startTimetxt
            // 
            startTimetxt.Location = new System.Drawing.Point(645, 162);
            startTimetxt.Margin = new Padding(4);
            startTimetxt.Name = "startTimetxt";
            startTimetxt.ReadOnly = true;
            startTimetxt.Size = new System.Drawing.Size(124, 23);
            startTimetxt.TabIndex = 6;
            // 
            // RevenuePictureBox
            // 
            RevenuePictureBox.Location = new System.Drawing.Point(1180, 60);
            RevenuePictureBox.Margin = new Padding(1, 4, 1, 4);
            RevenuePictureBox.Name = "RevenuePictureBox";
            RevenuePictureBox.Size = new System.Drawing.Size(181, 196);
            RevenuePictureBox.TabIndex = 2;
            RevenuePictureBox.TabStop = false;
            // 
            // RevenueLabel
            // 
            RevenueLabel.AutoSize = true;
            RevenueLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RevenueLabel.Location = new System.Drawing.Point(15, 6);
            RevenueLabel.Margin = new Padding(4, 0, 4, 0);
            RevenueLabel.Name = "RevenueLabel";
            RevenueLabel.Size = new System.Drawing.Size(178, 32);
            RevenueLabel.TabIndex = 0;
            RevenueLabel.Text = "Revenue report";
            // 
            // pnlDrinkSupplies
            // 
            pnlDrinkSupplies.Controls.Add(VoorraadDrinkLabel);
            pnlDrinkSupplies.Controls.Add(DrankNaamLabel);
            pnlDrinkSupplies.Controls.Add(labelDrankNummer);
            pnlDrinkSupplies.Controls.Add(DranknrDrinkSupplies);
            pnlDrinkSupplies.Controls.Add(UpdateDrinkSupplies);
            pnlDrinkSupplies.Controls.Add(VoorraadDrinkSupplies);
            pnlDrinkSupplies.Controls.Add(NaamDrinkSupplies);
            pnlDrinkSupplies.Controls.Add(pictureBoxDrinkSupplies);
            pnlDrinkSupplies.Controls.Add(listViewDrinkSupplies);
            pnlDrinkSupplies.Controls.Add(Drink_Supplies);
            pnlDrinkSupplies.Location = new System.Drawing.Point(8, 22);
            pnlDrinkSupplies.Margin = new Padding(4);
            pnlDrinkSupplies.Name = "pnlDrinkSupplies";
            pnlDrinkSupplies.Size = new System.Drawing.Size(944, 471);
            pnlDrinkSupplies.TabIndex = 5;
            pnlDrinkSupplies.Visible = false;
            // 
            // VoorraadDrinkLabel
            // 
            VoorraadDrinkLabel.AutoSize = true;
            VoorraadDrinkLabel.Location = new System.Drawing.Point(370, 395);
            VoorraadDrinkLabel.Margin = new Padding(4, 0, 4, 0);
            VoorraadDrinkLabel.Name = "VoorraadDrinkLabel";
            VoorraadDrinkLabel.Size = new System.Drawing.Size(60, 15);
            VoorraadDrinkLabel.TabIndex = 9;
            VoorraadDrinkLabel.Text = "Voorraad: ";
            // 
            // DrankNaamLabel
            // 
            DrankNaamLabel.AutoSize = true;
            DrankNaamLabel.Location = new System.Drawing.Point(232, 395);
            DrankNaamLabel.Margin = new Padding(4, 0, 4, 0);
            DrankNaamLabel.Name = "DrankNaamLabel";
            DrankNaamLabel.Size = new System.Drawing.Size(45, 15);
            DrankNaamLabel.TabIndex = 8;
            DrankNaamLabel.Text = "Naam: ";
            // 
            // labelDrankNummer
            // 
            labelDrankNummer.AutoSize = true;
            labelDrankNummer.Location = new System.Drawing.Point(48, 524);
            labelDrankNummer.Margin = new Padding(5, 0, 5, 0);
            labelDrankNummer.Name = "labelDrankNummer";
            labelDrankNummer.Size = new System.Drawing.Size(92, 15);
            labelDrankNummer.TabIndex = 7;
            labelDrankNummer.Text = "Drank Nummer:";
            // 
            // DranknrDrinkSupplies
            // 
            DranknrDrinkSupplies.Location = new System.Drawing.Point(42, 418);
            DranknrDrinkSupplies.Margin = new Padding(4);
            DranknrDrinkSupplies.Name = "DranknrDrinkSupplies";
            DranknrDrinkSupplies.ReadOnly = true;
            DranknrDrinkSupplies.Size = new System.Drawing.Size(124, 23);
            DranknrDrinkSupplies.TabIndex = 6;
            // 
            // UpdateDrinkSupplies
            // 
            UpdateDrinkSupplies.Location = new System.Drawing.Point(724, 393);
            UpdateDrinkSupplies.Margin = new Padding(4);
            UpdateDrinkSupplies.Name = "UpdateDrinkSupplies";
            UpdateDrinkSupplies.Size = new System.Drawing.Size(199, 70);
            UpdateDrinkSupplies.TabIndex = 5;
            UpdateDrinkSupplies.Text = "Update";
            UpdateDrinkSupplies.UseVisualStyleBackColor = true;
            UpdateDrinkSupplies.Click += UpdateDrinkSupplies_Click;
            // 
            // VoorraadDrinkSupplies
            // 
            VoorraadDrinkSupplies.Location = new System.Drawing.Point(344, 418);
            VoorraadDrinkSupplies.Margin = new Padding(4);
            VoorraadDrinkSupplies.Name = "VoorraadDrinkSupplies";
            VoorraadDrinkSupplies.Size = new System.Drawing.Size(124, 23);
            VoorraadDrinkSupplies.TabIndex = 4;
            // 
            // NaamDrinkSupplies
            // 
            NaamDrinkSupplies.Location = new System.Drawing.Point(197, 418);
            NaamDrinkSupplies.Margin = new Padding(4);
            NaamDrinkSupplies.Name = "NaamDrinkSupplies";
            NaamDrinkSupplies.Size = new System.Drawing.Size(124, 23);
            NaamDrinkSupplies.TabIndex = 3;
            // 
            // pictureBoxDrinkSupplies
            // 
            pictureBoxDrinkSupplies.Image = (System.Drawing.Image)resources.GetObject("pictureBoxDrinkSupplies.Image");
            pictureBoxDrinkSupplies.Location = new System.Drawing.Point(812, 13);
            pictureBoxDrinkSupplies.Margin = new Padding(1, 4, 1, 4);
            pictureBoxDrinkSupplies.Name = "pictureBoxDrinkSupplies";
            pictureBoxDrinkSupplies.Size = new System.Drawing.Size(127, 121);
            pictureBoxDrinkSupplies.TabIndex = 2;
            pictureBoxDrinkSupplies.TabStop = false;
            // 
            // listViewDrinkSupplies
            // 
            listViewDrinkSupplies.Columns.AddRange(new ColumnHeader[] { columnHeader1Dranknr, columnHeader2naam, columnHeader3Prijs, columnHeader4Voorraad, columnHeader1Aantal_verkocht });
            listViewDrinkSupplies.FullRowSelect = true;
            listViewDrinkSupplies.Location = new System.Drawing.Point(8, 54);
            listViewDrinkSupplies.Margin = new Padding(1, 2, 1, 2);
            listViewDrinkSupplies.Name = "listViewDrinkSupplies";
            listViewDrinkSupplies.Size = new System.Drawing.Size(514, 330);
            listViewDrinkSupplies.SmallImageList = ImageListDrinkSupplies;
            listViewDrinkSupplies.TabIndex = 1;
            listViewDrinkSupplies.UseCompatibleStateImageBehavior = false;
            listViewDrinkSupplies.View = View.Details;
            listViewDrinkSupplies.SelectedIndexChanged += listViewDrinkSupplies_SelectedIndexChanged_1;
            // 
            // columnHeader1Dranknr
            // 
            columnHeader1Dranknr.Text = "Dranknr";
            columnHeader1Dranknr.Width = 100;
            // 
            // columnHeader2naam
            // 
            columnHeader2naam.Text = "Naam";
            columnHeader2naam.TextAlign = HorizontalAlignment.Center;
            columnHeader2naam.Width = 100;
            // 
            // columnHeader3Prijs
            // 
            columnHeader3Prijs.Text = "Prijs";
            columnHeader3Prijs.TextAlign = HorizontalAlignment.Center;
            columnHeader3Prijs.Width = 100;
            // 
            // columnHeader4Voorraad
            // 
            columnHeader4Voorraad.Text = "Voorraad";
            columnHeader4Voorraad.TextAlign = HorizontalAlignment.Center;
            columnHeader4Voorraad.Width = 100;
            // 
            // columnHeader1Aantal_verkocht
            // 
            columnHeader1Aantal_verkocht.Text = "Aantal Verkocht";
            columnHeader1Aantal_verkocht.TextAlign = HorizontalAlignment.Center;
            columnHeader1Aantal_verkocht.Width = 100;
            // 
            // ImageListDrinkSupplies
            // 
            ImageListDrinkSupplies.ColorDepth = ColorDepth.Depth16Bit;
            ImageListDrinkSupplies.ImageStream = (ImageListStreamer)resources.GetObject("ImageListDrinkSupplies.ImageStream");
            ImageListDrinkSupplies.TransparentColor = System.Drawing.Color.Transparent;
            ImageListDrinkSupplies.Images.SetKeyName(0, "99c7f76ce843d3ad4b38330396851f17.ico");
            ImageListDrinkSupplies.Images.SetKeyName(1, "8ba9223dbe00db32810bf9103eabe034.ico");
            // 
            // Drink_Supplies
            // 
            Drink_Supplies.AutoSize = true;
            Drink_Supplies.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Drink_Supplies.Location = new System.Drawing.Point(16, 7);
            Drink_Supplies.Margin = new Padding(5, 0, 5, 0);
            Drink_Supplies.Name = "Drink_Supplies";
            Drink_Supplies.Size = new System.Drawing.Size(168, 32);
            Drink_Supplies.TabIndex = 0;
            Drink_Supplies.Text = "Drink Supplies";
            // 
            // pnlCashRegister
            // 
            pnlCashRegister.Controls.Add(cashRegisterDrinksComboBox);
            pnlCashRegister.Controls.Add(cashRegisterStudentComboBox);
            pnlCashRegister.Controls.Add(cashRegisterSubmitOrderButton);
            pnlCashRegister.Controls.Add(listViewDrankCashRegister);
            pnlCashRegister.Controls.Add(pictureBox4);
            pnlCashRegister.Controls.Add(listViewStudentsCashRegister);
            pnlCashRegister.Controls.Add(cashRegisterLabel);
            pnlCashRegister.Location = new System.Drawing.Point(8, 22);
            pnlCashRegister.Margin = new Padding(4, 5, 4, 5);
            pnlCashRegister.Name = "pnlCashRegister";
            pnlCashRegister.Size = new System.Drawing.Size(944, 471);
            pnlCashRegister.TabIndex = 5;
            pnlCashRegister.Visible = false;
            // 
            // cashRegisterDrinksComboBox
            // 
            cashRegisterDrinksComboBox.FormattingEnabled = true;
            cashRegisterDrinksComboBox.Location = new System.Drawing.Point(420, 433);
            cashRegisterDrinksComboBox.Margin = new Padding(3, 2, 3, 2);
            cashRegisterDrinksComboBox.Name = "cashRegisterDrinksComboBox";
            cashRegisterDrinksComboBox.Size = new System.Drawing.Size(385, 23);
            cashRegisterDrinksComboBox.TabIndex = 5;
            cashRegisterDrinksComboBox.Text = "Choose Drink";
            cashRegisterDrinksComboBox.SelectedIndexChanged += cashRegisterDrinksComboBox_SelectedIndexChanged;
            // 
            // cashRegisterStudentComboBox
            // 
            cashRegisterStudentComboBox.FormattingEnabled = true;
            cashRegisterStudentComboBox.Location = new System.Drawing.Point(20, 430);
            cashRegisterStudentComboBox.Margin = new Padding(3, 2, 3, 2);
            cashRegisterStudentComboBox.Name = "cashRegisterStudentComboBox";
            cashRegisterStudentComboBox.Size = new System.Drawing.Size(306, 23);
            cashRegisterStudentComboBox.TabIndex = 4;
            cashRegisterStudentComboBox.Text = "Choose Student";
            cashRegisterStudentComboBox.SelectedIndexChanged += cashRegisterStudentComboBox_SelectedIndexChanged;
            // 
            // cashRegisterSubmitOrderButton
            // 
            cashRegisterSubmitOrderButton.Location = new System.Drawing.Point(825, 416);
            cashRegisterSubmitOrderButton.Margin = new Padding(3, 2, 3, 2);
            cashRegisterSubmitOrderButton.Name = "cashRegisterSubmitOrderButton";
            cashRegisterSubmitOrderButton.Size = new System.Drawing.Size(116, 44);
            cashRegisterSubmitOrderButton.TabIndex = 6;
            cashRegisterSubmitOrderButton.Text = "Submit Order";
            cashRegisterSubmitOrderButton.UseVisualStyleBackColor = true;
            cashRegisterSubmitOrderButton.Click += cashRegisterSubmitOrderButton_Click_1;
            // 
            // listViewDrankCashRegister
            // 
            listViewDrankCashRegister.Columns.AddRange(new ColumnHeader[] { cashRegisterDrankColumnHeader1, cashRegisterDrankColumnHeader2, cashRegisterDrankColumnHeader3, cashRegisterDrankColumnHeader4, cashRegisterDrankColumnHeader5 });
            listViewDrankCashRegister.Location = new System.Drawing.Point(399, 64);
            listViewDrankCashRegister.Margin = new Padding(1, 4, 1, 4);
            listViewDrankCashRegister.Name = "listViewDrankCashRegister";
            listViewDrankCashRegister.Size = new System.Drawing.Size(516, 327);
            listViewDrankCashRegister.TabIndex = 3;
            listViewDrankCashRegister.UseCompatibleStateImageBehavior = false;
            listViewDrankCashRegister.View = View.Details;
            listViewDrankCashRegister.SelectedIndexChanged += listViewDrankCashRegister_SelectedIndexChanged_1;
            // 
            // cashRegisterDrankColumnHeader1
            // 
            cashRegisterDrankColumnHeader1.Text = "Dranknr";
            cashRegisterDrankColumnHeader1.Width = 80;
            // 
            // cashRegisterDrankColumnHeader2
            // 
            cashRegisterDrankColumnHeader2.Text = "Naam";
            cashRegisterDrankColumnHeader2.Width = 100;
            // 
            // cashRegisterDrankColumnHeader3
            // 
            cashRegisterDrankColumnHeader3.Text = "Prijs";
            // 
            // cashRegisterDrankColumnHeader4
            // 
            cashRegisterDrankColumnHeader4.Text = "Voorraad";
            cashRegisterDrankColumnHeader4.Width = 80;
            // 
            // cashRegisterDrankColumnHeader5
            // 
            cashRegisterDrankColumnHeader5.Text = "Aantal_Verkocht";
            cashRegisterDrankColumnHeader5.Width = 120;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(1180, 60);
            pictureBox4.Margin = new Padding(1, 4, 1, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(181, 196);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // listViewStudentsCashRegister
            // 
            listViewStudentsCashRegister.Columns.AddRange(new ColumnHeader[] { cashRegisterStudentColumnHeader1, cashRegisterStudentColumnHeader2 });
            listViewStudentsCashRegister.Location = new System.Drawing.Point(20, 64);
            listViewStudentsCashRegister.Margin = new Padding(1, 4, 1, 4);
            listViewStudentsCashRegister.Name = "listViewStudentsCashRegister";
            listViewStudentsCashRegister.Size = new System.Drawing.Size(309, 334);
            listViewStudentsCashRegister.TabIndex = 1;
            listViewStudentsCashRegister.UseCompatibleStateImageBehavior = false;
            listViewStudentsCashRegister.View = View.Details;
            listViewStudentsCashRegister.SelectedIndexChanged += listViewStudentsCashRegister_SelectedIndexChanged;
            // 
            // cashRegisterStudentColumnHeader1
            // 
            cashRegisterStudentColumnHeader1.Text = "StudentId";
            cashRegisterStudentColumnHeader1.Width = 80;
            // 
            // cashRegisterStudentColumnHeader2
            // 
            cashRegisterStudentColumnHeader2.Text = "Name";
            cashRegisterStudentColumnHeader2.Width = 100;
            // 
            // cashRegisterLabel
            // 
            cashRegisterLabel.AutoSize = true;
            cashRegisterLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cashRegisterLabel.Location = new System.Drawing.Point(15, 6);
            cashRegisterLabel.Margin = new Padding(4, 0, 4, 0);
            cashRegisterLabel.Name = "cashRegisterLabel";
            cashRegisterLabel.Size = new System.Drawing.Size(157, 32);
            cashRegisterLabel.TabIndex = 0;
            cashRegisterLabel.Text = "Cash Register";
            // 
            // pnlTimeTable
            // 
            pnlTimeTable.Controls.Add(timeTableflowpnl);
            pnlTimeTable.Controls.Add(TimePicBox);
            pnlTimeTable.Controls.Add(TimeTablelbl);
            pnlTimeTable.Location = new System.Drawing.Point(8, 25);
            pnlTimeTable.Name = "pnlTimeTable";
            pnlTimeTable.Size = new System.Drawing.Size(944, 463);
            pnlTimeTable.TabIndex = 6;
            pnlTimeTable.Visible = false;
            // 
            // timeTableflowpnl
            // 
            timeTableflowpnl.BorderStyle = BorderStyle.Fixed3D;
            timeTableflowpnl.Controls.Add(mondayTpnl);
            timeTableflowpnl.Controls.Add(tuesdayTpnl);
            timeTableflowpnl.Controls.Add(wednesdayTpnl);
            timeTableflowpnl.Controls.Add(thursdayTpnl);
            timeTableflowpnl.Controls.Add(fridayTpnl);
            timeTableflowpnl.Location = new System.Drawing.Point(18, 53);
            timeTableflowpnl.Margin = new Padding(3, 2, 3, 2);
            timeTableflowpnl.Name = "timeTableflowpnl";
            timeTableflowpnl.Size = new System.Drawing.Size(666, 263);
            timeTableflowpnl.TabIndex = 3;
            // 
            // mondayTpnl
            // 
            mondayTpnl.BorderStyle = BorderStyle.Fixed3D;
            mondayTpnl.Controls.Add(monSuptxt);
            mondayTpnl.Controls.Add(label4);
            mondayTpnl.Controls.Add(mondaylbl);
            mondayTpnl.Controls.Add(monactivitytxt);
            mondayTpnl.Controls.Add(label5);
            mondayTpnl.Location = new System.Drawing.Point(3, 2);
            mondayTpnl.Margin = new Padding(3, 2, 3, 2);
            mondayTpnl.Name = "mondayTpnl";
            mondayTpnl.Size = new System.Drawing.Size(124, 195);
            mondayTpnl.TabIndex = 0;
            // 
            // monSuptxt
            // 
            monSuptxt.Location = new System.Drawing.Point(8, 118);
            monSuptxt.Margin = new Padding(3, 2, 3, 2);
            monSuptxt.Name = "monSuptxt";
            monSuptxt.ReadOnly = true;
            monSuptxt.Size = new System.Drawing.Size(110, 23);
            monSuptxt.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(3, 37);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(81, 15);
            label4.TabIndex = 4;
            label4.Text = "activity name:";
            // 
            // mondaylbl
            // 
            mondaylbl.AutoSize = true;
            mondaylbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            mondaylbl.Location = new System.Drawing.Point(20, 5);
            mondaylbl.Name = "mondaylbl";
            mondaylbl.Size = new System.Drawing.Size(78, 25);
            mondaylbl.TabIndex = 3;
            mondaylbl.Text = "Monday";
            // 
            // monactivitytxt
            // 
            monactivitytxt.Location = new System.Drawing.Point(8, 60);
            monactivitytxt.Margin = new Padding(3, 2, 3, 2);
            monactivitytxt.Name = "monactivitytxt";
            monactivitytxt.ReadOnly = true;
            monactivitytxt.Size = new System.Drawing.Size(110, 23);
            monactivitytxt.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 95);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(77, 15);
            label5.TabIndex = 3;
            label5.Text = "supervisor(s):";
            // 
            // tuesdayTpnl
            // 
            tuesdayTpnl.BorderStyle = BorderStyle.Fixed3D;
            tuesdayTpnl.Controls.Add(tueSuptxt);
            tuesdayTpnl.Controls.Add(label3);
            tuesdayTpnl.Controls.Add(label6);
            tuesdayTpnl.Controls.Add(tueActivitytxt);
            tuesdayTpnl.Controls.Add(label7);
            tuesdayTpnl.Location = new System.Drawing.Point(133, 2);
            tuesdayTpnl.Margin = new Padding(3, 2, 3, 2);
            tuesdayTpnl.Name = "tuesdayTpnl";
            tuesdayTpnl.Size = new System.Drawing.Size(124, 195);
            tuesdayTpnl.TabIndex = 1;
            // 
            // tueSuptxt
            // 
            tueSuptxt.Location = new System.Drawing.Point(8, 118);
            tueSuptxt.Margin = new Padding(3, 2, 3, 2);
            tueSuptxt.Name = "tueSuptxt";
            tueSuptxt.ReadOnly = true;
            tueSuptxt.Size = new System.Drawing.Size(110, 23);
            tueSuptxt.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(20, 7);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 25);
            label3.TabIndex = 4;
            label3.Text = "Tuesday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(3, 37);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(81, 15);
            label6.TabIndex = 8;
            label6.Text = "activity name:";
            // 
            // tueActivitytxt
            // 
            tueActivitytxt.Location = new System.Drawing.Point(8, 60);
            tueActivitytxt.Margin = new Padding(3, 2, 3, 2);
            tueActivitytxt.Name = "tueActivitytxt";
            tueActivitytxt.ReadOnly = true;
            tueActivitytxt.Size = new System.Drawing.Size(110, 23);
            tueActivitytxt.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(3, 95);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(77, 15);
            label7.TabIndex = 7;
            label7.Text = "supervisor(s):";
            // 
            // wednesdayTpnl
            // 
            wednesdayTpnl.BorderStyle = BorderStyle.Fixed3D;
            wednesdayTpnl.Controls.Add(wedSuptxt);
            wednesdayTpnl.Controls.Add(wednesdaylbl);
            wednesdayTpnl.Controls.Add(label8);
            wednesdayTpnl.Controls.Add(wedActivitytxt);
            wednesdayTpnl.Controls.Add(label9);
            wednesdayTpnl.Location = new System.Drawing.Point(263, 2);
            wednesdayTpnl.Margin = new Padding(3, 2, 3, 2);
            wednesdayTpnl.Name = "wednesdayTpnl";
            wednesdayTpnl.Size = new System.Drawing.Size(124, 195);
            wednesdayTpnl.TabIndex = 2;
            // 
            // wedSuptxt
            // 
            wedSuptxt.Location = new System.Drawing.Point(11, 118);
            wedSuptxt.Margin = new Padding(3, 2, 3, 2);
            wedSuptxt.Name = "wedSuptxt";
            wedSuptxt.ReadOnly = true;
            wedSuptxt.Size = new System.Drawing.Size(110, 23);
            wedSuptxt.TabIndex = 13;
            // 
            // wednesdaylbl
            // 
            wednesdaylbl.AutoSize = true;
            wednesdaylbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            wednesdaylbl.Location = new System.Drawing.Point(6, 9);
            wednesdaylbl.Name = "wednesdaylbl";
            wednesdaylbl.Size = new System.Drawing.Size(104, 25);
            wednesdaylbl.TabIndex = 4;
            wednesdaylbl.Text = "Wednesday";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 37);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(81, 15);
            label8.TabIndex = 12;
            label8.Text = "activity name:";
            // 
            // wedActivitytxt
            // 
            wedActivitytxt.Location = new System.Drawing.Point(11, 60);
            wedActivitytxt.Margin = new Padding(3, 2, 3, 2);
            wedActivitytxt.Name = "wedActivitytxt";
            wedActivitytxt.ReadOnly = true;
            wedActivitytxt.Size = new System.Drawing.Size(110, 23);
            wedActivitytxt.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(6, 95);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(77, 15);
            label9.TabIndex = 11;
            label9.Text = "supervisor(s):";
            // 
            // thursdayTpnl
            // 
            thursdayTpnl.BorderStyle = BorderStyle.Fixed3D;
            thursdayTpnl.Controls.Add(thuSuptxt);
            thursdayTpnl.Controls.Add(thursdaylbl);
            thursdayTpnl.Controls.Add(label10);
            thursdayTpnl.Controls.Add(thuActivitytxt);
            thursdayTpnl.Controls.Add(label11);
            thursdayTpnl.Location = new System.Drawing.Point(393, 2);
            thursdayTpnl.Margin = new Padding(3, 2, 3, 2);
            thursdayTpnl.Name = "thursdayTpnl";
            thursdayTpnl.Size = new System.Drawing.Size(124, 195);
            thursdayTpnl.TabIndex = 1;
            // 
            // thuSuptxt
            // 
            thuSuptxt.Location = new System.Drawing.Point(16, 118);
            thuSuptxt.Margin = new Padding(3, 2, 3, 2);
            thuSuptxt.Name = "thuSuptxt";
            thuSuptxt.ReadOnly = true;
            thuSuptxt.Size = new System.Drawing.Size(110, 23);
            thuSuptxt.TabIndex = 17;
            // 
            // thursdaylbl
            // 
            thursdaylbl.AutoSize = true;
            thursdaylbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            thursdaylbl.Location = new System.Drawing.Point(20, 9);
            thursdaylbl.Name = "thursdaylbl";
            thursdaylbl.Size = new System.Drawing.Size(84, 25);
            thursdaylbl.TabIndex = 4;
            thursdaylbl.Text = "Thursday";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(11, 37);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(81, 15);
            label10.TabIndex = 16;
            label10.Text = "activity name:";
            // 
            // thuActivitytxt
            // 
            thuActivitytxt.Location = new System.Drawing.Point(16, 60);
            thuActivitytxt.Margin = new Padding(3, 2, 3, 2);
            thuActivitytxt.Name = "thuActivitytxt";
            thuActivitytxt.ReadOnly = true;
            thuActivitytxt.Size = new System.Drawing.Size(110, 23);
            thuActivitytxt.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(11, 95);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(77, 15);
            label11.TabIndex = 15;
            label11.Text = "supervisor(s):";
            // 
            // fridayTpnl
            // 
            fridayTpnl.BorderStyle = BorderStyle.Fixed3D;
            fridayTpnl.Controls.Add(friSuptxt);
            fridayTpnl.Controls.Add(fridaylbl);
            fridayTpnl.Controls.Add(label12);
            fridayTpnl.Controls.Add(friActivitytxt);
            fridayTpnl.Controls.Add(label13);
            fridayTpnl.Location = new System.Drawing.Point(523, 2);
            fridayTpnl.Margin = new Padding(3, 2, 3, 2);
            fridayTpnl.Name = "fridayTpnl";
            fridayTpnl.Size = new System.Drawing.Size(124, 195);
            fridayTpnl.TabIndex = 1;
            // 
            // friSuptxt
            // 
            friSuptxt.Location = new System.Drawing.Point(8, 118);
            friSuptxt.Margin = new Padding(3, 2, 3, 2);
            friSuptxt.Name = "friSuptxt";
            friSuptxt.ReadOnly = true;
            friSuptxt.Size = new System.Drawing.Size(110, 23);
            friSuptxt.TabIndex = 21;
            // 
            // fridaylbl
            // 
            fridaylbl.AutoSize = true;
            fridaylbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fridaylbl.Location = new System.Drawing.Point(29, 9);
            fridaylbl.Name = "fridaylbl";
            fridaylbl.Size = new System.Drawing.Size(60, 25);
            fridaylbl.TabIndex = 4;
            fridaylbl.Text = "Friday";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(4, 37);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(81, 15);
            label12.TabIndex = 20;
            label12.Text = "activity name:";
            // 
            // friActivitytxt
            // 
            friActivitytxt.Location = new System.Drawing.Point(8, 60);
            friActivitytxt.Margin = new Padding(3, 2, 3, 2);
            friActivitytxt.Name = "friActivitytxt";
            friActivitytxt.ReadOnly = true;
            friActivitytxt.Size = new System.Drawing.Size(110, 23);
            friActivitytxt.TabIndex = 18;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(4, 95);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(77, 15);
            label13.TabIndex = 19;
            label13.Text = "supervisor(s):";
            // 
            // TimePicBox
            // 
            TimePicBox.Image = (System.Drawing.Image)resources.GetObject("TimePicBox.Image");
            TimePicBox.Location = new System.Drawing.Point(798, 17);
            TimePicBox.Margin = new Padding(1, 2, 1, 2);
            TimePicBox.Name = "TimePicBox";
            TimePicBox.Size = new System.Drawing.Size(127, 118);
            TimePicBox.TabIndex = 2;
            TimePicBox.TabStop = false;
            // 
            // TimeTablelbl
            // 
            TimeTablelbl.AutoSize = true;
            TimeTablelbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TimeTablelbl.Location = new System.Drawing.Point(11, 4);
            TimeTablelbl.Name = "TimeTablelbl";
            TimeTablelbl.Size = new System.Drawing.Size(122, 32);
            TimeTablelbl.TabIndex = 0;
            TimeTablelbl.Text = "TimeTable";
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(962, 505);
            Controls.Add(menuStrip1);
            Controls.Add(pnlRevenueReport);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlTimeTable);
            Controls.Add(pnlActivities);
            Controls.Add(pnlRooms);
            Controls.Add(pnlLecturer);
            Controls.Add(pnlDrinkSupplies);
            Controls.Add(pnlCashRegister);
            Controls.Add(pnlStudents);
            MainMenuStrip = menuStrip1;
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlRooms.ResumeLayout(false);
            pnlRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SomerenRoomsPicture).EndInit();
            pnlLecturer.ResumeLayout(false);
            pnlLecturer.PerformLayout();
            pnlActivities.ResumeLayout(false);
            pnlActivities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlRevenueReport.ResumeLayout(false);
            pnlRevenueReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)RevenuePictureBox).EndInit();
            pnlDrinkSupplies.ResumeLayout(false);
            pnlDrinkSupplies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDrinkSupplies).EndInit();
            pnlCashRegister.ResumeLayout(false);
            pnlCashRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlTimeTable.ResumeLayout(false);
            pnlTimeTable.PerformLayout();
            timeTableflowpnl.ResumeLayout(false);
            mondayTpnl.ResumeLayout(false);
            mondayTpnl.PerformLayout();
            tuesdayTpnl.ResumeLayout(false);
            tuesdayTpnl.PerformLayout();
            wednesdayTpnl.ResumeLayout(false);
            wednesdayTpnl.PerformLayout();
            thursdayTpnl.ResumeLayout(false);
            thursdayTpnl.PerformLayout();
            fridayTpnl.ResumeLayout(false);
            fridayTpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TimePicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void UpdateActivityButton_Click1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void AddActivityButton_Click1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void UpdateDrinkSupplies_Click1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }


        private void DrinkSuppliesButton_Click1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.PictureBox SomerenRoomsPicture;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.ColumnHeader KamerNummer;
        private System.Windows.Forms.ColumnHeader Aantalbedden;
        private System.Windows.Forms.ColumnHeader DocentORStudent;
        private System.Windows.Forms.ListView listViewActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listViewDrankCashRegister;
        private System.Windows.Forms.ColumnHeader IdHeader;
        private System.Windows.Forms.ColumnHeader NameStudentHeader;
        private System.Windows.Forms.Panel pnlLecturer;
        private System.Windows.Forms.ListView listViewLecturers;
        private System.Windows.Forms.ColumnHeader DocentIDHeader;
        private System.Windows.Forms.ColumnHeader DocentNameHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader idColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.Panel pnlActivities;
        private System.Windows.Forms.ListView ActivityListView;
        private System.Windows.Forms.ColumnHeader IdColumnHeader3;
        private System.Windows.Forms.ColumnHeader OmschrijvingcolumnHeader4;
        private System.Windows.Forms.ColumnHeader StartTijdcolumnHeader3;
        private System.Windows.Forms.ColumnHeader EindTijdcolumnHeader4;
        private System.Windows.Forms.Label ActivityLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlDrinkSupplies;
        private System.Windows.Forms.PictureBox pictureBoxDrinkSupplies;
        private System.Windows.Forms.ListView listViewDrinkSupplies;
        private System.Windows.Forms.ColumnHeader columnHeader1Dranknr;
        private System.Windows.Forms.ColumnHeader columnHeader2naam;
        private System.Windows.Forms.ColumnHeader columnHeader3Prijs;
        private System.Windows.Forms.ColumnHeader columnHeader4Voorraad;
        private System.Windows.Forms.ColumnHeader columnHeader1Aantal_verkocht;
        private System.Windows.Forms.Label Drink_Supplies;
        private System.Windows.Forms.Button UpdateDrinkSupplies;
        private System.Windows.Forms.TextBox VoorraadDrinkSupplies;
        private System.Windows.Forms.TextBox NaamDrinkSupplies;
        private System.Windows.Forms.TextBox DranknrDrinkSupplies;
        private System.Windows.Forms.Label labelDrankNummer;
        private System.Windows.Forms.Label VoorraadDrinkLabel;
        private System.Windows.Forms.Label DrankNaamLabel;
        private System.Windows.Forms.Panel pnlCashRegister;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListView listViewStudentsCashRegister;
        private System.Windows.Forms.ColumnHeader cashRegisterStudentColumnHeader1;
        private System.Windows.Forms.ColumnHeader cashRegisterStudentColumnHeader2;
        private System.Windows.Forms.Label cashRegisterLabel;
        private System.Windows.Forms.ColumnHeader cashRegisterDrankColumnHeader1;
        private System.Windows.Forms.ColumnHeader cashRegisterDrankColumnHeader2;
        private System.Windows.Forms.ColumnHeader cashRegisterDrankColumnHeader3;
        private System.Windows.Forms.ColumnHeader cashRegisterDrankColumnHeader4;
        private System.Windows.Forms.ColumnHeader cashRegisterDrankColumnHeader5;
        private System.Windows.Forms.Button cashRegisterSubmitOrderButton;
        private System.Windows.Forms.ComboBox cashRegisterDrinksComboBox;
        private System.Windows.Forms.ComboBox cashRegisterStudentComboBox;
        private System.Windows.Forms.ToolStripMenuItem revenueToolStripMenuItem;
        private System.Windows.Forms.Panel pnlRevenueReport;
        private System.Windows.Forms.PictureBox RevenuePictureBox;
        private System.Windows.Forms.ColumnHeader salesColumHeader;
        private System.Windows.Forms.ColumnHeader TurnoverColumHeader;
        private System.Windows.Forms.Label RevenueLabel;
        private System.Windows.Forms.TextBox endTimetxt;
        private System.Windows.Forms.TextBox startTimetxt;
        private System.Windows.Forms.ColumnHeader nCustomerColumHeader;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ToolStripMenuItem DrinksButton;
        private System.Windows.Forms.ToolStripMenuItem DrinkSuppliesButton;
        private System.Windows.Forms.ToolStripMenuItem CashRegisterButton;
        private System.Windows.Forms.ToolStripMenuItem RevenueReportButtonn;
        private System.Windows.Forms.Label EindTijdLabel;
        private System.Windows.Forms.Label BeginTijdLabel;
        private System.Windows.Forms.ImageList ImageListDrinkSupplies;
        private System.Windows.Forms.ToolStripMenuItem VATCalculationMenuItem;
        private System.Windows.Forms.ListView listViewRevenueReport;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ToolStripMenuItem revenueReportToolStripMenuItem;
        private System.Windows.Forms.Button revenuebtn;
        private System.Windows.Forms.Button DeleteActivityButton;
        private System.Windows.Forms.Button AddActivityButton;
        private System.Windows.Forms.TextBox EindTijdActivityTextBox;
        private System.Windows.Forms.TextBox StartTijdActivityTextBox;
        private System.Windows.Forms.Label EindTijdActivityLabel;
        private System.Windows.Forms.Label StartTijdActivityLabel;
        private System.Windows.Forms.Label ActivityOmschrijvingLabel;
        private System.Windows.Forms.TextBox OmschrijvingActivityTextBox;
        private System.Windows.Forms.Label IdActivityLabel;
        private System.Windows.Forms.TextBox ActivityIdTextBox;
        private System.Windows.Forms.Button UpdateActivityButton;
        private System.Windows.Forms.ToolStripMenuItem timeTableToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTimeTable;
        private System.Windows.Forms.PictureBox TimePicBox;
        private System.Windows.Forms.Label TimeTablelbl;
        private System.Windows.Forms.FlowLayoutPanel timeTableflowpnl;
        private System.Windows.Forms.Panel mondayTpnl;
        private System.Windows.Forms.Panel tuesdayTpnl;
        private System.Windows.Forms.Panel wednesdayTpnl;
        private System.Windows.Forms.Panel thursdayTpnl;
        private System.Windows.Forms.Panel fridayTpnl;
        private System.Windows.Forms.Label mondaylbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label wednesdaylbl;
        private System.Windows.Forms.Label thursdaylbl;
        private System.Windows.Forms.Label fridaylbl;
        private System.Windows.Forms.TextBox monSuptxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox monactivitytxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tueSuptxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tueActivitytxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox wedSuptxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox wedActivitytxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox thuSuptxt;
        private System.Windows.Forms.Button activitySupervisor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox thuActivitytxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox friSuptxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox friActivitytxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button activityStudentsButton;

    }
}