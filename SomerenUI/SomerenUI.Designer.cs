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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            listViewStudents = new System.Windows.Forms.ListView();
            IdHeader = new System.Windows.Forms.ColumnHeader();
            NameStudentHeader = new System.Windows.Forms.ColumnHeader();
            label1 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pnlRooms = new System.Windows.Forms.Panel();
            SomerenRoomsPicture = new System.Windows.Forms.PictureBox();
            listViewRooms = new System.Windows.Forms.ListView();
            KamerNummer = new System.Windows.Forms.ColumnHeader();
            Aantalbedden = new System.Windows.Forms.ColumnHeader();
            DocentORStudent = new System.Windows.Forms.ColumnHeader();
            RoomLabel = new System.Windows.Forms.Label();
            pnlLecturer = new System.Windows.Forms.Panel();
            listViewLecturers = new System.Windows.Forms.ListView();
            DocentIDHeader = new System.Windows.Forms.ColumnHeader();
            DocentNameHeader = new System.Windows.Forms.ColumnHeader();
            label2 = new System.Windows.Forms.Label();
            pnlActivities = new System.Windows.Forms.Panel();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            ActivityListView = new System.Windows.Forms.ListView();
            IdColumnHeader3 = new System.Windows.Forms.ColumnHeader();
            OmschrijvingcolumnHeader4 = new System.Windows.Forms.ColumnHeader();
            StartTijdcolumnHeader3 = new System.Windows.Forms.ColumnHeader();
            EindTijdcolumnHeader4 = new System.Windows.Forms.ColumnHeader();
            ActivityLabel = new System.Windows.Forms.Label();
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
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(962, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
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
            studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            activitiesToolStripMenuItem.Text = "Activities";
            activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(8, 22);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(943, 471);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(13, 13);
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
            pnlStudents.Location = new System.Drawing.Point(0, 27);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(953, 466);
            pnlStudents.TabIndex = 2;
            pnlStudents.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(826, 36);
            pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(127, 118);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { IdHeader, NameStudentHeader });
            listViewStudents.Location = new System.Drawing.Point(13, 38);
            listViewStudents.Margin = new System.Windows.Forms.Padding(2);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(809, 425);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = System.Windows.Forms.View.Details;
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
            label1.Location = new System.Drawing.Point(11, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 32);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(797, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(126, 121);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(SomerenRoomsPicture);
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Controls.Add(RoomLabel);
            pnlRooms.Location = new System.Drawing.Point(8, 22);
            pnlRooms.Margin = new System.Windows.Forms.Padding(2);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(943, 472);
            pnlRooms.TabIndex = 3;
            // 
            // SomerenRoomsPicture
            // 
            SomerenRoomsPicture.Image = (System.Drawing.Image)resources.GetObject("SomerenRoomsPicture.Image");
            SomerenRoomsPicture.Location = new System.Drawing.Point(801, 35);
            SomerenRoomsPicture.Margin = new System.Windows.Forms.Padding(2);
            SomerenRoomsPicture.Name = "SomerenRoomsPicture";
            SomerenRoomsPicture.Size = new System.Drawing.Size(127, 118);
            SomerenRoomsPicture.TabIndex = 2;
            SomerenRoomsPicture.TabStop = false;
            // 
            // listViewRooms
            // 
            listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { KamerNummer, Aantalbedden, DocentORStudent });
            listViewRooms.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1, listViewItem2 });
            listViewRooms.Location = new System.Drawing.Point(16, 36);
            listViewRooms.Margin = new System.Windows.Forms.Padding(2);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(781, 424);
            listViewRooms.TabIndex = 1;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            listViewRooms.View = System.Windows.Forms.View.Details;
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
            Aantalbedden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            RoomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            pnlLecturer.Location = new System.Drawing.Point(8, 24);
            pnlLecturer.Name = "pnlLecturer";
            pnlLecturer.Size = new System.Drawing.Size(942, 466);
            pnlLecturer.TabIndex = 3;
            // 
            // listViewLecturers
            // 
            listViewLecturers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { DocentIDHeader, DocentNameHeader });
            listViewLecturers.Location = new System.Drawing.Point(15, 42);
            listViewLecturers.Name = "listViewLecturers";
            listViewLecturers.Size = new System.Drawing.Size(766, 307);
            listViewLecturers.TabIndex = 1;
            listViewLecturers.UseCompatibleStateImageBehavior = false;
            listViewLecturers.View = System.Windows.Forms.View.Details;
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
            label2.Location = new System.Drawing.Point(13, 7);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(110, 32);
            label2.TabIndex = 0;
            label2.Text = "Lecturers";
            // 
            // pnlActivities
            // 
            pnlActivities.Controls.Add(pictureBox3);
            pnlActivities.Controls.Add(ActivityListView);
            pnlActivities.Controls.Add(ActivityLabel);
            pnlActivities.Location = new System.Drawing.Point(10, 19);
            pnlActivities.Margin = new System.Windows.Forms.Padding(2);
            pnlActivities.Name = "pnlActivities";
            pnlActivities.Size = new System.Drawing.Size(943, 466);
            pnlActivities.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(806, 39);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(126, 121);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // ActivityListView
            // 
            ActivityListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { IdColumnHeader3, OmschrijvingcolumnHeader4, StartTijdcolumnHeader3, EindTijdcolumnHeader4 });
            ActivityListView.Location = new System.Drawing.Point(13, 39);
            ActivityListView.Margin = new System.Windows.Forms.Padding(2);
            ActivityListView.Name = "ActivityListView";
            ActivityListView.Size = new System.Drawing.Size(758, 425);
            ActivityListView.TabIndex = 1;
            ActivityListView.UseCompatibleStateImageBehavior = false;
            ActivityListView.View = System.Windows.Forms.View.Details;
            // 
            // IdColumnHeader3
            // 
            IdColumnHeader3.Text = "ActiviteitId";
            IdColumnHeader3.Width = 80;
            // 
            // OmschrijvingcolumnHeader4
            // 
            OmschrijvingcolumnHeader4.Text = "Omschrijving";
            OmschrijvingcolumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            OmschrijvingcolumnHeader4.Width = 150;
            // 
            // StartTijdcolumnHeader3
            // 
            StartTijdcolumnHeader3.Text = "StartTijd";
            StartTijdcolumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            StartTijdcolumnHeader3.Width = 100;
            // 
            // EindTijdcolumnHeader4
            // 
            EindTijdcolumnHeader4.Text = "EindTijd";
            EindTijdcolumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            EindTijdcolumnHeader4.Width = 100;
            // 
            // ActivityLabel
            // 
            ActivityLabel.AutoSize = true;
            ActivityLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ActivityLabel.Location = new System.Drawing.Point(13, 4);
            ActivityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ActivityLabel.Name = "ActivityLabel";
            ActivityLabel.Size = new System.Drawing.Size(134, 32);
            ActivityLabel.TabIndex = 0;
            ActivityLabel.Text = "Activiteiten";
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(962, 505);
            Controls.Add(menuStrip1);
            Controls.Add(pnlStudents);
            Controls.Add(pnlActivities);
            Controls.Add(pnlRooms);
            Controls.Add(pnlLecturer);
            Controls.Add(pnlDashboard);
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
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.ListView listView1;
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
    }
}