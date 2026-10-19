using System.Drawing;
using System.Windows.Forms;

namespace Vehicle_Rental_Management_System
{
    partial class Form1
    {
        // Halkan waxaa lagu qeexaa controls-ka iyo muuqaalka foomka.
        private System.ComponentModel.IContainer components = null;
        private Panel headerPanel;
        private Label headerTitleLabel;
        private GroupBox customerInfoGroupBox;
        private Label customerNameLabel;
        private Label customerAgeLabel;
        private Label rentalDaysLabel;
        private Label drivingExperienceLabel;
        private TextBox customerNameTextBox;
        private TextBox customerAgeTextBox;
        private TextBox rentalDaysTextBox;
        private TextBox drivingExperienceTextBox;
        private GroupBox vehicleTypeGroupBox;
        private Label economyIconLabel;
        private Label suvIconLabel;
        private Label luxuryIconLabel;
        private RadioButton economyRadioButton;
        private RadioButton suvRadioButton;
        private RadioButton luxuryRadioButton;
        private Label vehicleRateNoteLabel;
        private GroupBox insuranceGroupBox;
        private CheckBox insuranceCheckBox;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
        private GroupBox rentalResultsGroupBox;
        private TextBox rentalDetailsTextBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // InitializeComponent wuxuu abuuraa, cabbiraa, oo habeeyaa controls-ka form-ka.
        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerTitleLabel = new System.Windows.Forms.Label();
            this.customerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerAgeLabel = new System.Windows.Forms.Label();
            this.rentalDaysLabel = new System.Windows.Forms.Label();
            this.drivingExperienceLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerAgeTextBox = new System.Windows.Forms.TextBox();
            this.rentalDaysTextBox = new System.Windows.Forms.TextBox();
            this.drivingExperienceTextBox = new System.Windows.Forms.TextBox();
            this.vehicleTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.economyIconLabel = new System.Windows.Forms.Label();
            this.suvIconLabel = new System.Windows.Forms.Label();
            this.luxuryIconLabel = new System.Windows.Forms.Label();
            this.economyRadioButton = new System.Windows.Forms.RadioButton();
            this.suvRadioButton = new System.Windows.Forms.RadioButton();
            this.luxuryRadioButton = new System.Windows.Forms.RadioButton();
            this.vehicleRateNoteLabel = new System.Windows.Forms.Label();
            this.insuranceGroupBox = new System.Windows.Forms.GroupBox();
            this.insuranceCheckBox = new System.Windows.Forms.CheckBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.rentalResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.rentalDetailsTextBox = new System.Windows.Forms.TextBox();
            this.headerPanel.SuspendLayout();
            this.customerInfoGroupBox.SuspendLayout();
            this.vehicleTypeGroupBox.SuspendLayout();
            this.insuranceGroupBox.SuspendLayout();
            this.rentalResultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(103)))), ((int)(((byte)(201)))));
            this.headerPanel.Controls.Add(this.headerTitleLabel);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1594, 66);
            this.headerPanel.TabIndex = 0;
            // 
            // headerTitleLabel
            // 
            this.headerTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerTitleLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.headerTitleLabel.ForeColor = System.Drawing.Color.White;
            this.headerTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.headerTitleLabel.Name = "headerTitleLabel";
            this.headerTitleLabel.Size = new System.Drawing.Size(1594, 66);
            this.headerTitleLabel.TabIndex = 0;
            this.headerTitleLabel.Text = "Vehicle Rental Management System";
            this.headerTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerInfoGroupBox
            // 
            this.customerInfoGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(224)))), ((int)(((byte)(228)))));
            this.customerInfoGroupBox.Controls.Add(this.customerNameLabel);
            this.customerInfoGroupBox.Controls.Add(this.customerAgeLabel);
            this.customerInfoGroupBox.Controls.Add(this.rentalDaysLabel);
            this.customerInfoGroupBox.Controls.Add(this.drivingExperienceLabel);
            this.customerInfoGroupBox.Controls.Add(this.customerNameTextBox);
            this.customerInfoGroupBox.Controls.Add(this.customerAgeTextBox);
            this.customerInfoGroupBox.Controls.Add(this.rentalDaysTextBox);
            this.customerInfoGroupBox.Controls.Add(this.drivingExperienceTextBox);
            this.customerInfoGroupBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.customerInfoGroupBox.Location = new System.Drawing.Point(22, 88);
            this.customerInfoGroupBox.Name = "customerInfoGroupBox";
            this.customerInfoGroupBox.Size = new System.Drawing.Size(475, 220);
            this.customerInfoGroupBox.TabIndex = 0;
            this.customerInfoGroupBox.TabStop = false;
            this.customerInfoGroupBox.Text = "Customer Information";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.customerNameLabel.Location = new System.Drawing.Point(16, 36);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(190, 28);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Customer Name:";
            this.customerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customerAgeLabel
            // 
            this.customerAgeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.customerAgeLabel.Location = new System.Drawing.Point(16, 76);
            this.customerAgeLabel.Name = "customerAgeLabel";
            this.customerAgeLabel.Size = new System.Drawing.Size(190, 28);
            this.customerAgeLabel.TabIndex = 1;
            this.customerAgeLabel.Text = "Customer Age:";
            this.customerAgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rentalDaysLabel
            // 
            this.rentalDaysLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rentalDaysLabel.Location = new System.Drawing.Point(16, 116);
            this.rentalDaysLabel.Name = "rentalDaysLabel";
            this.rentalDaysLabel.Size = new System.Drawing.Size(190, 28);
            this.rentalDaysLabel.TabIndex = 2;
            this.rentalDaysLabel.Text = "Number of Rental Days:";
            this.rentalDaysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // drivingExperienceLabel
            // 
            this.drivingExperienceLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.drivingExperienceLabel.Location = new System.Drawing.Point(16, 156);
            this.drivingExperienceLabel.Name = "drivingExperienceLabel";
            this.drivingExperienceLabel.Size = new System.Drawing.Size(190, 28);
            this.drivingExperienceLabel.TabIndex = 3;
            this.drivingExperienceLabel.Text = "Driving Experience (years):";
            this.drivingExperienceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.customerNameTextBox.Location = new System.Drawing.Point(216, 36);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(238, 34);
            this.customerNameTextBox.TabIndex = 0;
            // 
            // customerAgeTextBox
            // 
            this.customerAgeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerAgeTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.customerAgeTextBox.Location = new System.Drawing.Point(216, 76);
            this.customerAgeTextBox.Name = "customerAgeTextBox";
            this.customerAgeTextBox.Size = new System.Drawing.Size(238, 34);
            this.customerAgeTextBox.TabIndex = 1;
            // 
            // rentalDaysTextBox
            // 
            this.rentalDaysTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rentalDaysTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rentalDaysTextBox.Location = new System.Drawing.Point(216, 116);
            this.rentalDaysTextBox.Name = "rentalDaysTextBox";
            this.rentalDaysTextBox.Size = new System.Drawing.Size(238, 34);
            this.rentalDaysTextBox.TabIndex = 2;
            // 
            // drivingExperienceTextBox
            // 
            this.drivingExperienceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drivingExperienceTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.drivingExperienceTextBox.Location = new System.Drawing.Point(216, 156);
            this.drivingExperienceTextBox.Name = "drivingExperienceTextBox";
            this.drivingExperienceTextBox.Size = new System.Drawing.Size(238, 34);
            this.drivingExperienceTextBox.TabIndex = 3;
            // 
            // vehicleTypeGroupBox
            // 
            this.vehicleTypeGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.vehicleTypeGroupBox.Controls.Add(this.economyIconLabel);
            this.vehicleTypeGroupBox.Controls.Add(this.suvIconLabel);
            this.vehicleTypeGroupBox.Controls.Add(this.luxuryIconLabel);
            this.vehicleTypeGroupBox.Controls.Add(this.economyRadioButton);
            this.vehicleTypeGroupBox.Controls.Add(this.suvRadioButton);
            this.vehicleTypeGroupBox.Controls.Add(this.luxuryRadioButton);
            this.vehicleTypeGroupBox.Controls.Add(this.vehicleRateNoteLabel);
            this.vehicleTypeGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.vehicleTypeGroupBox.Location = new System.Drawing.Point(22, 322);
            this.vehicleTypeGroupBox.Name = "vehicleTypeGroupBox";
            this.vehicleTypeGroupBox.Size = new System.Drawing.Size(475, 152);
            this.vehicleTypeGroupBox.TabIndex = 1;
            this.vehicleTypeGroupBox.TabStop = false;
            this.vehicleTypeGroupBox.Text = "Vehicle Type";
            // 
            // economyIconLabel
            // 
            this.economyIconLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.economyIconLabel.Location = new System.Drawing.Point(56, 30);
            this.economyIconLabel.Name = "economyIconLabel";
            this.economyIconLabel.Size = new System.Drawing.Size(70, 46);
            this.economyIconLabel.TabIndex = 0;
            this.economyIconLabel.Text = "🚗";
            this.economyIconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // suvIconLabel
            // 
            this.suvIconLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.suvIconLabel.Location = new System.Drawing.Point(198, 30);
            this.suvIconLabel.Name = "suvIconLabel";
            this.suvIconLabel.Size = new System.Drawing.Size(70, 46);
            this.suvIconLabel.TabIndex = 1;
            this.suvIconLabel.Text = "🚙";
            this.suvIconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // luxuryIconLabel
            // 
            this.luxuryIconLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.luxuryIconLabel.Location = new System.Drawing.Point(346, 30);
            this.luxuryIconLabel.Name = "luxuryIconLabel";
            this.luxuryIconLabel.Size = new System.Drawing.Size(70, 46);
            this.luxuryIconLabel.TabIndex = 2;
            this.luxuryIconLabel.Text = "🚘";
            this.luxuryIconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // economyRadioButton
            // 
            this.economyRadioButton.AutoSize = true;
            this.economyRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.economyRadioButton.Location = new System.Drawing.Point(42, 78);
            this.economyRadioButton.Name = "economyRadioButton";
            this.economyRadioButton.Size = new System.Drawing.Size(119, 29);
            this.economyRadioButton.TabIndex = 4;
            this.economyRadioButton.TabStop = true;
            this.economyRadioButton.Text = "Economy";
            this.economyRadioButton.UseVisualStyleBackColor = true;
            // 
            // suvRadioButton
            // 
            this.suvRadioButton.AutoSize = true;
            this.suvRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.suvRadioButton.Location = new System.Drawing.Point(216, 78);
            this.suvRadioButton.Name = "suvRadioButton";
            this.suvRadioButton.Size = new System.Drawing.Size(75, 29);
            this.suvRadioButton.TabIndex = 5;
            this.suvRadioButton.TabStop = true;
            this.suvRadioButton.Text = "SUV";
            this.suvRadioButton.UseVisualStyleBackColor = true;
            // 
            // luxuryRadioButton
            // 
            this.luxuryRadioButton.AutoSize = true;
            this.luxuryRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.luxuryRadioButton.Location = new System.Drawing.Point(346, 78);
            this.luxuryRadioButton.Name = "luxuryRadioButton";
            this.luxuryRadioButton.Size = new System.Drawing.Size(101, 29);
            this.luxuryRadioButton.TabIndex = 6;
            this.luxuryRadioButton.TabStop = true;
            this.luxuryRadioButton.Text = "Luxury";
            this.luxuryRadioButton.UseVisualStyleBackColor = true;
            // 
            // vehicleRateNoteLabel
            // 
            this.vehicleRateNoteLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vehicleRateNoteLabel.ForeColor = System.Drawing.Color.DimGray;
            this.vehicleRateNoteLabel.Location = new System.Drawing.Point(15, 112);
            this.vehicleRateNoteLabel.Name = "vehicleRateNoteLabel";
            this.vehicleRateNoteLabel.Size = new System.Drawing.Size(445, 22);
            this.vehicleRateNoteLabel.TabIndex = 7;
            this.vehicleRateNoteLabel.Text = "Daily rates: Economy $35  |  SUV $60  |  Luxury $100";
            this.vehicleRateNoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insuranceGroupBox
            // 
            this.insuranceGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(224)))), ((int)(((byte)(228)))));
            this.insuranceGroupBox.Controls.Add(this.insuranceCheckBox);
            this.insuranceGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.insuranceGroupBox.Location = new System.Drawing.Point(22, 488);
            this.insuranceGroupBox.Name = "insuranceGroupBox";
            this.insuranceGroupBox.Size = new System.Drawing.Size(475, 80);
            this.insuranceGroupBox.TabIndex = 2;
            this.insuranceGroupBox.TabStop = false;
            this.insuranceGroupBox.Text = "Insurance Option";
            // 
            // insuranceCheckBox
            // 
            this.insuranceCheckBox.AutoSize = true;
            this.insuranceCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.insuranceCheckBox.Location = new System.Drawing.Point(20, 34);
            this.insuranceCheckBox.Name = "insuranceCheckBox";
            this.insuranceCheckBox.Size = new System.Drawing.Size(306, 32);
            this.insuranceCheckBox.TabIndex = 7;
            this.insuranceCheckBox.Text = "Add insurance ($15 per day)";
            this.insuranceCheckBox.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.White;
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.calculateButton.Location = new System.Drawing.Point(42, 590);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(125, 42);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.White;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.clearButton.Location = new System.Drawing.Point(190, 590);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(125, 42);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.exitButton.Location = new System.Drawing.Point(338, 590);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 42);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // rentalResultsGroupBox
            // 
            this.rentalResultsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rentalResultsGroupBox.BackColor = System.Drawing.Color.White;
            this.rentalResultsGroupBox.Controls.Add(this.rentalDetailsTextBox);
            this.rentalResultsGroupBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.rentalResultsGroupBox.Location = new System.Drawing.Point(520, 88);
            this.rentalResultsGroupBox.Name = "rentalResultsGroupBox";
            this.rentalResultsGroupBox.Padding = new System.Windows.Forms.Padding(12, 10, 12, 12);
            this.rentalResultsGroupBox.Size = new System.Drawing.Size(1054, 544);
            this.rentalResultsGroupBox.TabIndex = 3;
            this.rentalResultsGroupBox.TabStop = false;
            this.rentalResultsGroupBox.Text = "Rental Information and Results";
            // 
            // rentalDetailsTextBox
            // 
            this.rentalDetailsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rentalDetailsTextBox.BackColor = System.Drawing.Color.White;
            this.rentalDetailsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rentalDetailsTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.rentalDetailsTextBox.Location = new System.Drawing.Point(12, 34);
            this.rentalDetailsTextBox.Multiline = true;
            this.rentalDetailsTextBox.Name = "rentalDetailsTextBox";
            this.rentalDetailsTextBox.ReadOnly = true;
            this.rentalDetailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rentalDetailsTextBox.Size = new System.Drawing.Size(1026, 495);
            this.rentalDetailsTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1594, 700);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.customerInfoGroupBox);
            this.Controls.Add(this.vehicleTypeGroupBox);
            this.Controls.Add(this.insuranceGroupBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.rentalResultsGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(960, 640);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Rental Management System";
            this.headerPanel.ResumeLayout(false);
            this.customerInfoGroupBox.ResumeLayout(false);
            this.customerInfoGroupBox.PerformLayout();
            this.vehicleTypeGroupBox.ResumeLayout(false);
            this.vehicleTypeGroupBox.PerformLayout();
            this.insuranceGroupBox.ResumeLayout(false);
            this.insuranceGroupBox.PerformLayout();
            this.rentalResultsGroupBox.ResumeLayout(false);
            this.rentalResultsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
