namespace SomerenUI
{
    partial class ActiviteitSupervisors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addSupervisor = new System.Windows.Forms.Button();
            this.removeSupervisor = new System.Windows.Forms.Button();
            this.SupervisorListView = new System.Windows.Forms.ListView();
            this.columnHeaderSuperVisor = new System.Windows.Forms.ColumnHeader();
            this.ActivityListView = new System.Windows.Forms.ListView();
            this.columnHeader1Activity = new System.Windows.Forms.ColumnHeader();
            this.SupervisorsInActivity = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // addSupervisor
            // 
            this.addSupervisor.Location = new System.Drawing.Point(33, 289);
            this.addSupervisor.Name = "addSupervisor";
            this.addSupervisor.Size = new System.Drawing.Size(166, 46);
            this.addSupervisor.TabIndex = 0;
            this.addSupervisor.Text = "Add Supervisor";
            this.addSupervisor.UseVisualStyleBackColor = true;
            this.addSupervisor.Click += new System.EventHandler(this.addSupervisor_Click);
            // 
            // removeSupervisor
            // 
            this.removeSupervisor.Location = new System.Drawing.Point(483, 289);
            this.removeSupervisor.Name = "removeSupervisor";
            this.removeSupervisor.Size = new System.Drawing.Size(166, 46);
            this.removeSupervisor.TabIndex = 1;
            this.removeSupervisor.Text = "Remove Supervisor";
            this.removeSupervisor.UseVisualStyleBackColor = true;
            this.removeSupervisor.Click += new System.EventHandler(this.removeSupervisor_Click);
            // 
            // SupervisorListView
            // 
            this.SupervisorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSuperVisor});
            this.SupervisorListView.FullRowSelect = true;
            this.SupervisorListView.Location = new System.Drawing.Point(226, 25);
            this.SupervisorListView.Name = "SupervisorListView";
            this.SupervisorListView.Size = new System.Drawing.Size(125, 208);
            this.SupervisorListView.TabIndex = 2;
            this.SupervisorListView.UseCompatibleStateImageBehavior = false;
            this.SupervisorListView.View = System.Windows.Forms.View.Details;
            this.SupervisorListView.SelectedIndexChanged += new System.EventHandler(this.pnlActivitySupervisor_SelectedIndexChanged);
            // 
            // columnHeaderSuperVisor
            // 
            this.columnHeaderSuperVisor.Text = "Supervisor Name";
            this.columnHeaderSuperVisor.Width = 120;
            // 
            // ActivityListView
            // 
            this.ActivityListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1Activity});
            this.ActivityListView.FullRowSelect = true;
            this.ActivityListView.Location = new System.Drawing.Point(33, 25);
            this.ActivityListView.Name = "ActivityListView";
            this.ActivityListView.Size = new System.Drawing.Size(127, 208);
            this.ActivityListView.TabIndex = 5;
            this.ActivityListView.UseCompatibleStateImageBehavior = false;
            this.ActivityListView.View = System.Windows.Forms.View.Details;
            this.ActivityListView.SelectedIndexChanged += new System.EventHandler(this.ActivityListView_SelectedIndexChanged_1);
            // 
            // columnHeader1Activity
            // 
            this.columnHeader1Activity.Text = "Activity Name";
            this.columnHeader1Activity.Width = 120;
            // 
            // SupervisorsInActivity
            // 
            this.SupervisorsInActivity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.SupervisorsInActivity.Location = new System.Drawing.Point(461, 25);
            this.SupervisorsInActivity.Name = "SupervisorsInActivity";
            this.SupervisorsInActivity.Size = new System.Drawing.Size(220, 208);
            this.SupervisorsInActivity.TabIndex = 6;
            this.SupervisorsInActivity.UseCompatibleStateImageBehavior = false;
            this.SupervisorsInActivity.View = System.Windows.Forms.View.Details;
            this.SupervisorsInActivity.SelectedIndexChanged += new System.EventHandler(this.SupervisorsInActivity_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Supervisor Activity Name";
            this.columnHeader1.Width = 160;
            // 
            // ActiviteitSupervisors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SupervisorsInActivity);
            this.Controls.Add(this.ActivityListView);
            this.Controls.Add(this.SupervisorListView);
            this.Controls.Add(this.removeSupervisor);
            this.Controls.Add(this.addSupervisor);
            this.Name = "ActiviteitSupervisors";
            this.Text = "ActiviteitSupervisors";
            this.Load += new System.EventHandler(this.ActiviteitSupervisors_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addSupervisor;
        private System.Windows.Forms.Button removeSupervisor;
        private System.Windows.Forms.ListView pnlActivitySupervisor;
        private System.Windows.Forms.ColumnHeader columnHeaderSuperVisor;
        private System.Windows.Forms.ListView ActivityListViewv2;
        private System.Windows.Forms.ColumnHeader columnHeader1Activity;
        private System.Windows.Forms.ListView SupervisorListView;
        private System.Windows.Forms.ListView ActivityListView;
        private System.Windows.Forms.ListView SupervisorsInActivity;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}