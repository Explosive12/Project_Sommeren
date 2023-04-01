namespace SomerenUI
{
    partial class ActivityStudentUI
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
            this.ActivitylistView = new System.Windows.Forms.ListView();
            this.omschrijvingcolumnHeader = new System.Windows.Forms.ColumnHeader();
            this.starttijdcolumnHeader = new System.Windows.Forms.ColumnHeader();
            this.eindtijdcolumnHeader = new System.Windows.Forms.ColumnHeader();
            this.StudentlistView = new System.Windows.Forms.ListView();
            this.naamcolumnHeader = new System.Windows.Forms.ColumnHeader();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.removeStudentButton = new System.Windows.Forms.Button();
            this.StudentsinActivitylistView = new System.Windows.Forms.ListView();
            this.studentNameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.studentInActivityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ActivitylistView
            // 
            this.ActivitylistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.omschrijvingcolumnHeader,
            this.starttijdcolumnHeader,
            this.eindtijdcolumnHeader});
            this.ActivitylistView.FullRowSelect = true;
            this.ActivitylistView.Location = new System.Drawing.Point(12, 59);
            this.ActivitylistView.Name = "ActivitylistView";
            this.ActivitylistView.Size = new System.Drawing.Size(404, 156);
            this.ActivitylistView.TabIndex = 0;
            this.ActivitylistView.UseCompatibleStateImageBehavior = false;
            this.ActivitylistView.View = System.Windows.Forms.View.Details;
            this.ActivitylistView.SelectedIndexChanged += new System.EventHandler(this.ActivitylistView_SelectedIndexChanged);
            // 
            // omschrijvingcolumnHeader
            // 
            this.omschrijvingcolumnHeader.Text = "Omschrijving";
            this.omschrijvingcolumnHeader.Width = 100;
            // 
            // starttijdcolumnHeader
            // 
            this.starttijdcolumnHeader.Text = "StartTijd";
            this.starttijdcolumnHeader.Width = 150;
            // 
            // eindtijdcolumnHeader
            // 
            this.eindtijdcolumnHeader.Text = "EindTijd";
            this.eindtijdcolumnHeader.Width = 150;
            // 
            // StudentlistView
            // 
            this.StudentlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.naamcolumnHeader});
            this.StudentlistView.FullRowSelect = true;
            this.StudentlistView.Location = new System.Drawing.Point(472, 59);
            this.StudentlistView.Name = "StudentlistView";
            this.StudentlistView.Size = new System.Drawing.Size(299, 156);
            this.StudentlistView.TabIndex = 1;
            this.StudentlistView.UseCompatibleStateImageBehavior = false;
            this.StudentlistView.View = System.Windows.Forms.View.Details;
            this.StudentlistView.SelectedIndexChanged += new System.EventHandler(this.StudentlistView_SelectedIndexChanged);
            // 
            // naamcolumnHeader
            // 
            this.naamcolumnHeader.Text = "Naam";
            this.naamcolumnHeader.Width = 100;
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(166, 252);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(250, 50);
            this.addStudentButton.TabIndex = 2;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // removeStudentButton
            // 
            this.removeStudentButton.Location = new System.Drawing.Point(166, 324);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(250, 50);
            this.removeStudentButton.TabIndex = 3;
            this.removeStudentButton.Text = "Remove Student";
            this.removeStudentButton.UseVisualStyleBackColor = true;
            this.removeStudentButton.Click += new System.EventHandler(this.removeStudentButton_Click);
            // 
            // StudentsinActivitylistView
            // 
            this.StudentsinActivitylistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentNameColumnHeader});
            this.StudentsinActivitylistView.Location = new System.Drawing.Point(472, 253);
            this.StudentsinActivitylistView.Name = "StudentsinActivitylistView";
            this.StudentsinActivitylistView.Size = new System.Drawing.Size(299, 185);
            this.StudentsinActivitylistView.TabIndex = 4;
            this.StudentsinActivitylistView.UseCompatibleStateImageBehavior = false;
            this.StudentsinActivitylistView.View = System.Windows.Forms.View.Details;
            // 
            // studentNameColumnHeader
            // 
            this.studentNameColumnHeader.Text = "Naam";
            this.studentNameColumnHeader.Width = 100;
            // 
            // studentInActivityLabel
            // 
            this.studentInActivityLabel.AutoSize = true;
            this.studentInActivityLabel.Location = new System.Drawing.Point(472, 230);
            this.studentInActivityLabel.Name = "studentInActivityLabel";
            this.studentInActivityLabel.Size = new System.Drawing.Size(136, 20);
            this.studentInActivityLabel.TabIndex = 5;
            this.studentInActivityLabel.Text = "Student in Activity: ";
            // 
            // ActivityStudentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentInActivityLabel);
            this.Controls.Add(this.StudentsinActivitylistView);
            this.Controls.Add(this.removeStudentButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.StudentlistView);
            this.Controls.Add(this.ActivitylistView);
            this.Name = "ActivityStudentUI";
            this.Text = "ActivityStudentUI";
            this.Load += new System.EventHandler(this.ActivityStudentUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ActivitylistView;
        private System.Windows.Forms.ColumnHeader omschrijvingcolumnHeader;
        private System.Windows.Forms.ColumnHeader starttijdcolumnHeader;
        private System.Windows.Forms.ColumnHeader eindtijdcolumnHeader;
        private System.Windows.Forms.ListView StudentlistView;
        private System.Windows.Forms.ColumnHeader naamcolumnHeader;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button removeStudentButton;
        private System.Windows.Forms.ListView StudentsinActivitylistView;
        private System.Windows.Forms.ColumnHeader studentNameColumnHeader;
        private System.Windows.Forms.Label studentInActivityLabel;
    }
}