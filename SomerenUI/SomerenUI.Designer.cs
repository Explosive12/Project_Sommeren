﻿namespace SomerenUI
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
            idcolumnHeader = new System.Windows.Forms.ColumnHeader();
            NamecolumnHeader = new System.Windows.Forms.ColumnHeader();
            StudentLabel = new System.Windows.Forms.Label();
            pnlRooms = new System.Windows.Forms.Panel();
            SomerenRoomsPicture = new System.Windows.Forms.PictureBox();
            listViewRooms = new System.Windows.Forms.ListView();
            KamerNummer = new System.Windows.Forms.ColumnHeader();
            Aantalbedden = new System.Windows.Forms.ColumnHeader();
            DocentORStudent = new System.Windows.Forms.ColumnHeader();
            RoomLabel = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SomerenRoomsPicture).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
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
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            activitiesToolStripMenuItem.Text = "Activities";
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
            pnlDashboard.Location = new System.Drawing.Point(12, 27);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(938, 466);
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
            pnlStudents.Controls.Add(StudentLabel);
            pnlStudents.Location = new System.Drawing.Point(12, 27);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(938, 466);
            pnlStudents.TabIndex = 2;
            pnlStudents.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(805, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(130, 123);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { idcolumnHeader, NamecolumnHeader });
            listViewStudents.Location = new System.Drawing.Point(16, 42);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(766, 307);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // idcolumnHeader
            // 
            idcolumnHeader.Text = "ID";
            // 
            // NamecolumnHeader
            // 
            NamecolumnHeader.Text = "Name";
            NamecolumnHeader.Width = 300;
            // 
            // StudentLabel
            // 
            StudentLabel.AutoSize = true;
            StudentLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            StudentLabel.Location = new System.Drawing.Point(13, 7);
            StudentLabel.Name = "StudentLabel";
            StudentLabel.Size = new System.Drawing.Size(107, 32);
            StudentLabel.TabIndex = 0;
            StudentLabel.Text = "Students";
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(SomerenRoomsPicture);
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Controls.Add(RoomLabel);
            pnlRooms.Location = new System.Drawing.Point(12, 27);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(938, 466);
            pnlRooms.TabIndex = 3;
            // 
            // SomerenRoomsPicture
            // 
            SomerenRoomsPicture.Image = (System.Drawing.Image)resources.GetObject("SomerenRoomsPicture.Image");
            SomerenRoomsPicture.Location = new System.Drawing.Point(805, 0);
            SomerenRoomsPicture.Name = "SomerenRoomsPicture";
            SomerenRoomsPicture.Size = new System.Drawing.Size(130, 123);
            SomerenRoomsPicture.TabIndex = 2;
            SomerenRoomsPicture.TabStop = false;
            // 
            // listViewRooms
            // 
            listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { KamerNummer, Aantalbedden, DocentORStudent });
            listViewRooms.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1, listViewItem2 });
            listViewRooms.Location = new System.Drawing.Point(16, 42);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(766, 307);
            listViewRooms.TabIndex = 1;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            listViewRooms.View = System.Windows.Forms.View.Details;
            listViewRooms.SelectedIndexChanged += listViewRooms_SelectedIndexChanged;
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
            RoomLabel.Location = new System.Drawing.Point(19, 7);
            RoomLabel.Name = "RoomLabel";
            RoomLabel.Size = new System.Drawing.Size(86, 32);
            RoomLabel.TabIndex = 0;
            RoomLabel.Text = "Rooms";
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(962, 505);
            Controls.Add(menuStrip1);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlStudents);
            Controls.Add(pnlRooms);
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
            pnlRooms.ResumeLayout(false);
            pnlRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SomerenRoomsPicture).EndInit();
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
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.PictureBox SomerenRoomsPicture;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.ColumnHeader KamerNummer;
        private System.Windows.Forms.ColumnHeader Aantalbedden;
        private System.Windows.Forms.ColumnHeader DocentORStudent;
        private System.Windows.Forms.ColumnHeader idcolumnHeader;
        private System.Windows.Forms.ColumnHeader NamecolumnHeader;
    }
}