using System.Drawing;
using System.Windows.Forms;

namespace Registration_Fee_System
{
    partial class Form1
    {
        // Controls-kan ayaa laga isticmaalaa naqshadda iyo code-ka xisaabinta.
        private System.ComponentModel.IContainer components = null;
        private Panel headerPanel;
        private Label headerTitleLabel;
        private GroupBox studentInfoGroupBox;
        private Label studentNameLabel;
        private Label studentIdLabel;
        private Label courseCountLabel;
        private Label studyLevelLabel;
        private TextBox studentNameTextBox;
        private TextBox studentIdTextBox;
        private TextBox courseCountTextBox;
        private ComboBox studyLevelComboBox;
        private GroupBox servicesGroupBox;
        private CheckBox accommodationCheckBox;
        private CheckBox transportCheckBox;
        private GroupBox courseRatesGroupBox;
        private Label courseRatesLabel;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
        private GroupBox registrationSummaryGroupBox;
        private TextBox registrationResultsTextBox;

        // Si habboon u nadiifi resources-ka marka form-ka la xiro.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // InitializeComponent wuxuu abuuraa oo habeeyaa dhammaan controls-ka form-ka.
        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerTitleLabel = new System.Windows.Forms.Label();
            this.studentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.courseCountLabel = new System.Windows.Forms.Label();
            this.studyLevelLabel = new System.Windows.Forms.Label();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.courseCountTextBox = new System.Windows.Forms.TextBox();
            this.studyLevelComboBox = new System.Windows.Forms.ComboBox();
            this.servicesGroupBox = new System.Windows.Forms.GroupBox();
            this.accommodationCheckBox = new System.Windows.Forms.CheckBox();
            this.transportCheckBox = new System.Windows.Forms.CheckBox();
            this.courseRatesGroupBox = new System.Windows.Forms.GroupBox();
            this.courseRatesLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.registrationSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.registrationResultsTextBox = new System.Windows.Forms.TextBox();
            this.headerPanel.SuspendLayout();
            this.studentInfoGroupBox.SuspendLayout();
            this.servicesGroupBox.SuspendLayout();
            this.courseRatesGroupBox.SuspendLayout();
            this.registrationSummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.headerPanel.Controls.Add(this.headerTitleLabel);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1080, 72);
            this.headerPanel.TabIndex = 0;
            // 
            // headerTitleLabel
            // 
            this.headerTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerTitleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.headerTitleLabel.ForeColor = System.Drawing.Color.White;
            this.headerTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.headerTitleLabel.Name = "headerTitleLabel";
            this.headerTitleLabel.Size = new System.Drawing.Size(1080, 72);
            this.headerTitleLabel.TabIndex = 0;
            this.headerTitleLabel.Text = "Course Registration Fee System";
            this.headerTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentInfoGroupBox
            // 
            this.studentInfoGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.studentInfoGroupBox.Controls.Add(this.studentNameLabel);
            this.studentInfoGroupBox.Controls.Add(this.studentIdLabel);
            this.studentInfoGroupBox.Controls.Add(this.courseCountLabel);
            this.studentInfoGroupBox.Controls.Add(this.studyLevelLabel);
            this.studentInfoGroupBox.Controls.Add(this.studentNameTextBox);
            this.studentInfoGroupBox.Controls.Add(this.studentIdTextBox);
            this.studentInfoGroupBox.Controls.Add(this.courseCountTextBox);
            this.studentInfoGroupBox.Controls.Add(this.studyLevelComboBox);
            this.studentInfoGroupBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.studentInfoGroupBox.Location = new System.Drawing.Point(22, 94);
            this.studentInfoGroupBox.Name = "studentInfoGroupBox";
            this.studentInfoGroupBox.Size = new System.Drawing.Size(470, 226);
            this.studentInfoGroupBox.TabIndex = 0;
            this.studentInfoGroupBox.TabStop = false;
            this.studentInfoGroupBox.Text = "Student Information";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.studentNameLabel.Location = new System.Drawing.Point(18, 38);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(180, 28);
            this.studentNameLabel.TabIndex = 0;
            this.studentNameLabel.Text = "Student Name:";
            this.studentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.studentIdLabel.Location = new System.Drawing.Point(18, 79);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(180, 28);
            this.studentIdLabel.TabIndex = 1;
            this.studentIdLabel.Text = "Student ID:";
            this.studentIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // courseCountLabel
            // 
            this.courseCountLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.courseCountLabel.Location = new System.Drawing.Point(18, 120);
            this.courseCountLabel.Name = "courseCountLabel";
            this.courseCountLabel.Size = new System.Drawing.Size(180, 28);
            this.courseCountLabel.TabIndex = 2;
            this.courseCountLabel.Text = "Number of Courses:";
            this.courseCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // studyLevelLabel
            // 
            this.studyLevelLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.studyLevelLabel.Location = new System.Drawing.Point(18, 161);
            this.studyLevelLabel.Name = "studyLevelLabel";
            this.studyLevelLabel.Size = new System.Drawing.Size(180, 28);
            this.studyLevelLabel.TabIndex = 3;
            this.studyLevelLabel.Text = "Study Level:";
            this.studyLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.studentNameTextBox.Location = new System.Drawing.Point(208, 38);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(240, 33);
            this.studentNameTextBox.TabIndex = 0;
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentIdTextBox.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.studentIdTextBox.Location = new System.Drawing.Point(208, 79);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(240, 33);
            this.studentIdTextBox.TabIndex = 1;
            // 
            // courseCountTextBox
            // 
            this.courseCountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.courseCountTextBox.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.courseCountTextBox.Location = new System.Drawing.Point(208, 120);
            this.courseCountTextBox.Name = "courseCountTextBox";
            this.courseCountTextBox.Size = new System.Drawing.Size(240, 33);
            this.courseCountTextBox.TabIndex = 2;
            // 
            // studyLevelComboBox
            // 
            this.studyLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studyLevelComboBox.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.studyLevelComboBox.FormattingEnabled = true;
            this.studyLevelComboBox.Items.AddRange(new object[] {
            "Year 1",
            "Year 2",
            "Year 3",
            "Year 4"});
            this.studyLevelComboBox.Location = new System.Drawing.Point(208, 161);
            this.studyLevelComboBox.Name = "studyLevelComboBox";
            this.studyLevelComboBox.Size = new System.Drawing.Size(240, 33);
            this.studyLevelComboBox.TabIndex = 3;
            // 
            // servicesGroupBox
            // 
            this.servicesGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.servicesGroupBox.Controls.Add(this.accommodationCheckBox);
            this.servicesGroupBox.Controls.Add(this.transportCheckBox);
            this.servicesGroupBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.servicesGroupBox.Location = new System.Drawing.Point(22, 338);
            this.servicesGroupBox.Name = "servicesGroupBox";
            this.servicesGroupBox.Size = new System.Drawing.Size(470, 112);
            this.servicesGroupBox.TabIndex = 1;
            this.servicesGroupBox.TabStop = false;
            this.servicesGroupBox.Text = "Optional Services";
            // 
            // accommodationCheckBox
            // 
            this.accommodationCheckBox.AutoSize = true;
            this.accommodationCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.accommodationCheckBox.Location = new System.Drawing.Point(24, 36);
            this.accommodationCheckBox.Name = "accommodationCheckBox";
            this.accommodationCheckBox.Size = new System.Drawing.Size(248, 29);
            this.accommodationCheckBox.TabIndex = 4;
            this.accommodationCheckBox.Text = "Accommodation ($120)";
            this.accommodationCheckBox.UseVisualStyleBackColor = true;
            // 
            // transportCheckBox
            // 
            this.transportCheckBox.AutoSize = true;
            this.transportCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.transportCheckBox.Location = new System.Drawing.Point(24, 70);
            this.transportCheckBox.Name = "transportCheckBox";
            this.transportCheckBox.Size = new System.Drawing.Size(178, 29);
            this.transportCheckBox.TabIndex = 5;
            this.transportCheckBox.Text = "Transport ($80)";
            this.transportCheckBox.UseVisualStyleBackColor = true;
            // 
            // courseRatesGroupBox
            // 
            this.courseRatesGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.courseRatesGroupBox.Controls.Add(this.courseRatesLabel);
            this.courseRatesGroupBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.courseRatesGroupBox.Location = new System.Drawing.Point(22, 468);
            this.courseRatesGroupBox.Name = "courseRatesGroupBox";
            this.courseRatesGroupBox.Size = new System.Drawing.Size(470, 150);
            this.courseRatesGroupBox.TabIndex = 2;
            this.courseRatesGroupBox.TabStop = false;
            this.courseRatesGroupBox.Text = "Course Rates";
            // 
            // courseRatesLabel
            // 
            this.courseRatesLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.courseRatesLabel.Location = new System.Drawing.Point(22, 32);
            this.courseRatesLabel.Name = "courseRatesLabel";
            this.courseRatesLabel.Size = new System.Drawing.Size(420, 105);
            this.courseRatesLabel.TabIndex = 0;
            this.courseRatesLabel.Text = "Year 1:  $40 per course\r\nYear 2:  $45 per course\r\nYear 3:  $50 per course\r\nYear 4" +
    ":  $55 per course";
            this.courseRatesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.calculateButton.FlatAppearance.BorderSize = 0;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(28, 626);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(140, 46);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.White;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.clearButton.Location = new System.Drawing.Point(187, 626);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(140, 46);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(346, 626);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 46);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // registrationSummaryGroupBox
            // 
            this.registrationSummaryGroupBox.BackColor = System.Drawing.Color.White;
            this.registrationSummaryGroupBox.Controls.Add(this.registrationResultsTextBox);
            this.registrationSummaryGroupBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.registrationSummaryGroupBox.Location = new System.Drawing.Point(512, 94);
            this.registrationSummaryGroupBox.Name = "registrationSummaryGroupBox";
            this.registrationSummaryGroupBox.Size = new System.Drawing.Size(546, 524);
            this.registrationSummaryGroupBox.TabIndex = 3;
            this.registrationSummaryGroupBox.TabStop = false;
            this.registrationSummaryGroupBox.Text = "Registration Summary";
            // 
            // registrationResultsTextBox
            // 
            this.registrationResultsTextBox.BackColor = System.Drawing.Color.White;
            this.registrationResultsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registrationResultsTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.registrationResultsTextBox.Location = new System.Drawing.Point(18, 34);
            this.registrationResultsTextBox.Multiline = true;
            this.registrationResultsTextBox.Name = "registrationResultsTextBox";
            this.registrationResultsTextBox.ReadOnly = true;
            this.registrationResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.registrationResultsTextBox.Size = new System.Drawing.Size(510, 472);
            this.registrationResultsTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1080, 713);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.studentInfoGroupBox);
            this.Controls.Add(this.servicesGroupBox);
            this.Controls.Add(this.courseRatesGroupBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.registrationSummaryGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Registration Fee System";
            this.headerPanel.ResumeLayout(false);
            this.studentInfoGroupBox.ResumeLayout(false);
            this.studentInfoGroupBox.PerformLayout();
            this.servicesGroupBox.ResumeLayout(false);
            this.servicesGroupBox.PerformLayout();
            this.courseRatesGroupBox.ResumeLayout(false);
            this.registrationSummaryGroupBox.ResumeLayout(false);
            this.registrationSummaryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}