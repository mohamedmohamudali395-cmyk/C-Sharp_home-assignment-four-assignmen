using System.Drawing;
using System.Windows.Forms;

namespace Hotel_Booking_System
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Panel headerPanel;
        private Label headerTitleLabel;
        private TableLayoutPanel mainLayout;
        private TableLayoutPanel leftColumnLayout;
        private GroupBox personalInfoGroupBox;
        private TableLayoutPanel personalInfoFields;
        private Label guestNameLabel;
        private Label guestAgeLabel;
        private Label numberOfNightsLabel;
        private Label numberOfGuestsLabel;
        private TextBox guestNameTextBox;
        private TextBox guestAgeTextBox;
        private TextBox numberOfNightsTextBox;
        private TextBox numberOfGuestsTextBox;
        private GroupBox roomTypeGroupBox;
        private FlowLayoutPanel roomTypeOptions;
        private RadioButton standardRadioButton;
        private RadioButton normalRadioButton;
        private RadioButton highRadioButton;
        private GroupBox additionalOptionsGroupBox;
        private FlowLayoutPanel additionalOptions;
        private CheckBox breakfastCheckBox;
        private FlowLayoutPanel actionButtons;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
        private GroupBox bookingDetailsGroupBox;
        private TableLayoutPanel bookingDetailsLayout;
        private Label lblResultName;
        private Label lblResultRoom;
        private Label lblBasicCost;
        private Label lblDiscount;
        private Label lblBreakfastCost;
        private Label lblServiceCharge;
        private Label lblTotalCost;
        private Label lblBookingStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerTitleLabel = new System.Windows.Forms.Label();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.leftColumnLayout = new System.Windows.Forms.TableLayoutPanel();
            this.personalInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.personalInfoFields = new System.Windows.Forms.TableLayoutPanel();
            this.guestNameLabel = new System.Windows.Forms.Label();
            this.guestAgeLabel = new System.Windows.Forms.Label();
            this.numberOfNightsLabel = new System.Windows.Forms.Label();
            this.numberOfGuestsLabel = new System.Windows.Forms.Label();
            this.guestNameTextBox = new System.Windows.Forms.TextBox();
            this.guestAgeTextBox = new System.Windows.Forms.TextBox();
            this.numberOfNightsTextBox = new System.Windows.Forms.TextBox();
            this.numberOfGuestsTextBox = new System.Windows.Forms.TextBox();
            this.roomTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.roomTypeOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.standardRadioButton = new System.Windows.Forms.RadioButton();
            this.normalRadioButton = new System.Windows.Forms.RadioButton();
            this.highRadioButton = new System.Windows.Forms.RadioButton();
            this.additionalOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.additionalOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.breakfastCheckBox = new System.Windows.Forms.CheckBox();
            this.actionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.bookingDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.bookingDetailsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblResultName = new System.Windows.Forms.Label();
            this.lblResultRoom = new System.Windows.Forms.Label();
            this.lblBasicCost = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblBreakfastCost = new System.Windows.Forms.Label();
            this.lblServiceCharge = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblBookingStatus = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.leftColumnLayout.SuspendLayout();
            this.personalInfoGroupBox.SuspendLayout();
            this.personalInfoFields.SuspendLayout();
            this.roomTypeGroupBox.SuspendLayout();
            this.roomTypeOptions.SuspendLayout();
            this.additionalOptionsGroupBox.SuspendLayout();
            this.additionalOptions.SuspendLayout();
            this.actionButtons.SuspendLayout();
            this.bookingDetailsGroupBox.SuspendLayout();
            this.bookingDetailsLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(103)))), ((int)(((byte)(201)))));
            this.headerPanel.Controls.Add(this.headerTitleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1446, 72);
            this.headerPanel.TabIndex = 0;
            // 
            // headerTitleLabel
            // 
            this.headerTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerTitleLabel.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.headerTitleLabel.ForeColor = System.Drawing.Color.White;
            this.headerTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.headerTitleLabel.Name = "headerTitleLabel";
            this.headerTitleLabel.Size = new System.Drawing.Size(1446, 72);
            this.headerTitleLabel.TabIndex = 0;
            this.headerTitleLabel.Text = "Hotel Room Booking System";
            this.headerTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainLayout
            // 
            this.mainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(224)))), ((int)(((byte)(228)))));
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.mainLayout.Controls.Add(this.leftColumnLayout, 0, 0);
            this.mainLayout.Controls.Add(this.bookingDetailsGroupBox, 1, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 72);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Padding = new System.Windows.Forms.Padding(18, 16, 18, 14);
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(1446, 633);
            this.mainLayout.TabIndex = 1;
            // 
            // leftColumnLayout
            // 
            this.leftColumnLayout.ColumnCount = 1;
            this.leftColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftColumnLayout.Controls.Add(this.personalInfoGroupBox, 0, 0);
            this.leftColumnLayout.Controls.Add(this.roomTypeGroupBox, 0, 1);
            this.leftColumnLayout.Controls.Add(this.additionalOptionsGroupBox, 0, 2);
            this.leftColumnLayout.Controls.Add(this.actionButtons, 0, 3);
            this.leftColumnLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftColumnLayout.Location = new System.Drawing.Point(21, 19);
            this.leftColumnLayout.Name = "leftColumnLayout";
            this.leftColumnLayout.RowCount = 4;
            this.leftColumnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.leftColumnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.leftColumnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.leftColumnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.leftColumnLayout.Size = new System.Drawing.Size(670, 597);
            this.leftColumnLayout.TabIndex = 0;
            // 
            // personalInfoGroupBox
            // 
            this.personalInfoGroupBox.Controls.Add(this.personalInfoFields);
            this.personalInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personalInfoGroupBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.personalInfoGroupBox.Location = new System.Drawing.Point(3, 3);
            this.personalInfoGroupBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.personalInfoGroupBox.Name = "personalInfoGroupBox";
            this.personalInfoGroupBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.personalInfoGroupBox.Size = new System.Drawing.Size(664, 271);
            this.personalInfoGroupBox.TabIndex = 0;
            this.personalInfoGroupBox.TabStop = false;
            this.personalInfoGroupBox.Text = "Personal Information";
            // 
            // personalInfoFields
            // 
            this.personalInfoFields.ColumnCount = 2;
            this.personalInfoFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.personalInfoFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.personalInfoFields.Controls.Add(this.guestNameLabel, 0, 0);
            this.personalInfoFields.Controls.Add(this.guestAgeLabel, 0, 1);
            this.personalInfoFields.Controls.Add(this.numberOfNightsLabel, 0, 2);
            this.personalInfoFields.Controls.Add(this.numberOfGuestsLabel, 0, 3);
            this.personalInfoFields.Controls.Add(this.guestNameTextBox, 1, 0);
            this.personalInfoFields.Controls.Add(this.guestAgeTextBox, 1, 1);
            this.personalInfoFields.Controls.Add(this.numberOfNightsTextBox, 1, 2);
            this.personalInfoFields.Controls.Add(this.numberOfGuestsTextBox, 1, 3);
            this.personalInfoFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personalInfoFields.Location = new System.Drawing.Point(10, 48);
            this.personalInfoFields.Name = "personalInfoFields";
            this.personalInfoFields.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.personalInfoFields.RowCount = 4;
            this.personalInfoFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.personalInfoFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.personalInfoFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.personalInfoFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.personalInfoFields.Size = new System.Drawing.Size(644, 213);
            this.personalInfoFields.TabIndex = 0;
            // 
            // guestNameLabel
            // 
            this.guestNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guestNameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.guestNameLabel.Location = new System.Drawing.Point(7, 2);
            this.guestNameLabel.Margin = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.guestNameLabel.Name = "guestNameLabel";
            this.guestNameLabel.Size = new System.Drawing.Size(268, 52);
            this.guestNameLabel.TabIndex = 0;
            this.guestNameLabel.Text = "Guest Name:";
            this.guestNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guestAgeLabel
            // 
            this.guestAgeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guestAgeLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.guestAgeLabel.Location = new System.Drawing.Point(7, 54);
            this.guestAgeLabel.Margin = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.guestAgeLabel.Name = "guestAgeLabel";
            this.guestAgeLabel.Size = new System.Drawing.Size(268, 52);
            this.guestAgeLabel.TabIndex = 1;
            this.guestAgeLabel.Text = "Guest Age:";
            this.guestAgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numberOfNightsLabel
            // 
            this.numberOfNightsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfNightsLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.numberOfNightsLabel.Location = new System.Drawing.Point(7, 106);
            this.numberOfNightsLabel.Margin = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.numberOfNightsLabel.Name = "numberOfNightsLabel";
            this.numberOfNightsLabel.Size = new System.Drawing.Size(268, 52);
            this.numberOfNightsLabel.TabIndex = 2;
            this.numberOfNightsLabel.Text = "Number of Nights:";
            this.numberOfNightsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numberOfGuestsLabel
            // 
            this.numberOfGuestsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfGuestsLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.numberOfGuestsLabel.Location = new System.Drawing.Point(7, 158);
            this.numberOfGuestsLabel.Margin = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.numberOfGuestsLabel.Name = "numberOfGuestsLabel";
            this.numberOfGuestsLabel.Size = new System.Drawing.Size(268, 53);
            this.numberOfGuestsLabel.TabIndex = 3;
            this.numberOfGuestsLabel.Text = "Number of Guests:";
            this.numberOfGuestsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guestNameTextBox
            // 
            this.guestNameTextBox.BackColor = System.Drawing.Color.White;
            this.guestNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guestNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guestNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guestNameTextBox.Location = new System.Drawing.Point(286, 7);
            this.guestNameTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 10, 5);
            this.guestNameTextBox.Name = "guestNameTextBox";
            this.guestNameTextBox.Size = new System.Drawing.Size(344, 39);
            this.guestNameTextBox.TabIndex = 0;
            // 
            // guestAgeTextBox
            // 
            this.guestAgeTextBox.BackColor = System.Drawing.Color.White;
            this.guestAgeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guestAgeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guestAgeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guestAgeTextBox.Location = new System.Drawing.Point(286, 59);
            this.guestAgeTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 10, 5);
            this.guestAgeTextBox.Name = "guestAgeTextBox";
            this.guestAgeTextBox.Size = new System.Drawing.Size(344, 39);
            this.guestAgeTextBox.TabIndex = 1;
            // 
            // numberOfNightsTextBox
            // 
            this.numberOfNightsTextBox.BackColor = System.Drawing.Color.White;
            this.numberOfNightsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfNightsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfNightsTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numberOfNightsTextBox.Location = new System.Drawing.Point(286, 111);
            this.numberOfNightsTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 10, 5);
            this.numberOfNightsTextBox.Name = "numberOfNightsTextBox";
            this.numberOfNightsTextBox.Size = new System.Drawing.Size(344, 39);
            this.numberOfNightsTextBox.TabIndex = 2;
            // 
            // numberOfGuestsTextBox
            // 
            this.numberOfGuestsTextBox.BackColor = System.Drawing.Color.White;
            this.numberOfGuestsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfGuestsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfGuestsTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numberOfGuestsTextBox.Location = new System.Drawing.Point(286, 163);
            this.numberOfGuestsTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 10, 5);
            this.numberOfGuestsTextBox.Name = "numberOfGuestsTextBox";
            this.numberOfGuestsTextBox.Size = new System.Drawing.Size(344, 39);
            this.numberOfGuestsTextBox.TabIndex = 3;
            // 
            // roomTypeGroupBox
            // 
            this.roomTypeGroupBox.Controls.Add(this.roomTypeOptions);
            this.roomTypeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomTypeGroupBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.roomTypeGroupBox.Location = new System.Drawing.Point(3, 286);
            this.roomTypeGroupBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.roomTypeGroupBox.Name = "roomTypeGroupBox";
            this.roomTypeGroupBox.Padding = new System.Windows.Forms.Padding(10, 6, 10, 8);
            this.roomTypeGroupBox.Size = new System.Drawing.Size(664, 97);
            this.roomTypeGroupBox.TabIndex = 1;
            this.roomTypeGroupBox.TabStop = false;
            this.roomTypeGroupBox.Text = "Room Type";
            // 
            // roomTypeOptions
            // 
            this.roomTypeOptions.Controls.Add(this.standardRadioButton);
            this.roomTypeOptions.Controls.Add(this.normalRadioButton);
            this.roomTypeOptions.Controls.Add(this.highRadioButton);
            this.roomTypeOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomTypeOptions.Location = new System.Drawing.Point(10, 46);
            this.roomTypeOptions.Name = "roomTypeOptions";
            this.roomTypeOptions.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomTypeOptions.Size = new System.Drawing.Size(644, 43);
            this.roomTypeOptions.TabIndex = 0;
            this.roomTypeOptions.WrapContents = false;
            // 
            // standardRadioButton
            // 
            this.standardRadioButton.AutoSize = true;
            this.standardRadioButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.standardRadioButton.Location = new System.Drawing.Point(12, 8);
            this.standardRadioButton.Margin = new System.Windows.Forms.Padding(8, 8, 34, 4);
            this.standardRadioButton.Name = "standardRadioButton";
            this.standardRadioButton.Size = new System.Drawing.Size(150, 40);
            this.standardRadioButton.TabIndex = 0;
            this.standardRadioButton.TabStop = true;
            this.standardRadioButton.Text = "Standard";
            this.standardRadioButton.UseVisualStyleBackColor = true;
            // 
            // normalRadioButton
            // 
            this.normalRadioButton.AutoSize = true;
            this.normalRadioButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.normalRadioButton.Location = new System.Drawing.Point(204, 8);
            this.normalRadioButton.Margin = new System.Windows.Forms.Padding(8, 8, 34, 4);
            this.normalRadioButton.Name = "normalRadioButton";
            this.normalRadioButton.Size = new System.Drawing.Size(132, 40);
            this.normalRadioButton.TabIndex = 1;
            this.normalRadioButton.TabStop = true;
            this.normalRadioButton.Text = "Normal";
            this.normalRadioButton.UseVisualStyleBackColor = true;
            // 
            // highRadioButton
            // 
            this.highRadioButton.AutoSize = true;
            this.highRadioButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.highRadioButton.Location = new System.Drawing.Point(378, 8);
            this.highRadioButton.Margin = new System.Windows.Forms.Padding(8, 8, 20, 4);
            this.highRadioButton.Name = "highRadioButton";
            this.highRadioButton.Size = new System.Drawing.Size(99, 40);
            this.highRadioButton.TabIndex = 2;
            this.highRadioButton.TabStop = true;
            this.highRadioButton.Text = "High";
            this.highRadioButton.UseVisualStyleBackColor = true;
            // 
            // additionalOptionsGroupBox
            // 
            this.additionalOptionsGroupBox.Controls.Add(this.additionalOptions);
            this.additionalOptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.additionalOptionsGroupBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.additionalOptionsGroupBox.Location = new System.Drawing.Point(3, 393);
            this.additionalOptionsGroupBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.additionalOptionsGroupBox.Name = "additionalOptionsGroupBox";
            this.additionalOptionsGroupBox.Padding = new System.Windows.Forms.Padding(10, 6, 10, 8);
            this.additionalOptionsGroupBox.Size = new System.Drawing.Size(664, 85);
            this.additionalOptionsGroupBox.TabIndex = 2;
            this.additionalOptionsGroupBox.TabStop = false;
            this.additionalOptionsGroupBox.Text = "Additional Options";
            // 
            // additionalOptions
            // 
            this.additionalOptions.Controls.Add(this.breakfastCheckBox);
            this.additionalOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.additionalOptions.Location = new System.Drawing.Point(10, 46);
            this.additionalOptions.Name = "additionalOptions";
            this.additionalOptions.Padding = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.additionalOptions.Size = new System.Drawing.Size(644, 31);
            this.additionalOptions.TabIndex = 0;
            this.additionalOptions.WrapContents = false;
            // 
            // breakfastCheckBox
            // 
            this.breakfastCheckBox.AutoSize = true;
            this.breakfastCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.breakfastCheckBox.Location = new System.Drawing.Point(14, 5);
            this.breakfastCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 3);
            this.breakfastCheckBox.Name = "breakfastCheckBox";
            this.breakfastCheckBox.Size = new System.Drawing.Size(426, 36);
            this.breakfastCheckBox.TabIndex = 0;
            this.breakfastCheckBox.Text = "Breakfast (10 per guest per night)";
            this.breakfastCheckBox.UseVisualStyleBackColor = true;
            // 
            // actionButtons
            // 
            this.actionButtons.Controls.Add(this.calculateButton);
            this.actionButtons.Controls.Add(this.clearButton);
            this.actionButtons.Controls.Add(this.exitButton);
            this.actionButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionButtons.Location = new System.Drawing.Point(3, 491);
            this.actionButtons.Name = "actionButtons";
            this.actionButtons.Padding = new System.Windows.Forms.Padding(2, 20, 2, 0);
            this.actionButtons.Size = new System.Drawing.Size(664, 103);
            this.actionButtons.TabIndex = 3;
            this.actionButtons.WrapContents = false;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.White;
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.calculateButton.Location = new System.Drawing.Point(14, 23);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(160, 46);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.White;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.clearButton.Location = new System.Drawing.Point(198, 23);
            this.clearButton.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(160, 46);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.exitButton.Location = new System.Drawing.Point(382, 23);
            this.exitButton.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(160, 46);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // bookingDetailsGroupBox
            // 
            this.bookingDetailsGroupBox.Controls.Add(this.bookingDetailsLayout);
            this.bookingDetailsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingDetailsGroupBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.bookingDetailsGroupBox.Location = new System.Drawing.Point(697, 19);
            this.bookingDetailsGroupBox.Name = "bookingDetailsGroupBox";
            this.bookingDetailsGroupBox.Padding = new System.Windows.Forms.Padding(12, 10, 12, 12);
            this.bookingDetailsGroupBox.Size = new System.Drawing.Size(728, 597);
            this.bookingDetailsGroupBox.TabIndex = 1;
            this.bookingDetailsGroupBox.TabStop = false;
            this.bookingDetailsGroupBox.Text = "Booking details";
            // 
            // bookingDetailsLayout
            // 
            this.bookingDetailsLayout.BackColor = System.Drawing.Color.White;
            this.bookingDetailsLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookingDetailsLayout.ColumnCount = 1;
            this.bookingDetailsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bookingDetailsLayout.Controls.Add(this.lblResultName, 0, 0);
            this.bookingDetailsLayout.Controls.Add(this.lblResultRoom, 0, 1);
            this.bookingDetailsLayout.Controls.Add(this.lblBasicCost, 0, 2);
            this.bookingDetailsLayout.Controls.Add(this.lblDiscount, 0, 3);
            this.bookingDetailsLayout.Controls.Add(this.lblBreakfastCost, 0, 4);
            this.bookingDetailsLayout.Controls.Add(this.lblServiceCharge, 0, 5);
            this.bookingDetailsLayout.Controls.Add(this.lblTotalCost, 0, 6);
            this.bookingDetailsLayout.Controls.Add(this.lblBookingStatus, 0, 7);
            this.bookingDetailsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingDetailsLayout.Location = new System.Drawing.Point(12, 48);
            this.bookingDetailsLayout.Name = "bookingDetailsLayout";
            this.bookingDetailsLayout.Padding = new System.Windows.Forms.Padding(14, 8, 14, 8);
            this.bookingDetailsLayout.RowCount = 8;
            this.bookingDetailsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.bookingDetailsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.bookingDetailsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.bookingDetailsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.bookingDetailsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.bookingDetailsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.bookingDetailsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.bookingDetailsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.bookingDetailsLayout.Size = new System.Drawing.Size(704, 537);
            this.bookingDetailsLayout.TabIndex = 0;
            // 
            // lblResultName
            // 
            this.lblResultName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblResultName.Location = new System.Drawing.Point(17, 8);
            this.lblResultName.Name = "lblResultName";
            this.lblResultName.Size = new System.Drawing.Size(668, 64);
            this.lblResultName.TabIndex = 0;
            this.lblResultName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResultRoom
            // 
            this.lblResultRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblResultRoom.Location = new System.Drawing.Point(17, 72);
            this.lblResultRoom.Name = "lblResultRoom";
            this.lblResultRoom.Size = new System.Drawing.Size(668, 64);
            this.lblResultRoom.TabIndex = 1;
            this.lblResultRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBasicCost
            // 
            this.lblBasicCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBasicCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBasicCost.Location = new System.Drawing.Point(17, 136);
            this.lblBasicCost.Name = "lblBasicCost";
            this.lblBasicCost.Size = new System.Drawing.Size(668, 64);
            this.lblBasicCost.TabIndex = 2;
            this.lblBasicCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDiscount.Location = new System.Drawing.Point(17, 200);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(668, 64);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBreakfastCost
            // 
            this.lblBreakfastCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBreakfastCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBreakfastCost.Location = new System.Drawing.Point(17, 264);
            this.lblBreakfastCost.Name = "lblBreakfastCost";
            this.lblBreakfastCost.Size = new System.Drawing.Size(668, 64);
            this.lblBreakfastCost.TabIndex = 4;
            this.lblBreakfastCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblServiceCharge
            // 
            this.lblServiceCharge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServiceCharge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblServiceCharge.Location = new System.Drawing.Point(17, 328);
            this.lblServiceCharge.Name = "lblServiceCharge";
            this.lblServiceCharge.Size = new System.Drawing.Size(668, 64);
            this.lblServiceCharge.TabIndex = 5;
            this.lblServiceCharge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalCost.Location = new System.Drawing.Point(17, 392);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(668, 64);
            this.lblTotalCost.TabIndex = 6;
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBookingStatus
            // 
            this.lblBookingStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBookingStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBookingStatus.Location = new System.Drawing.Point(17, 456);
            this.lblBookingStatus.Name = "lblBookingStatus";
            this.lblBookingStatus.Size = new System.Drawing.Size(668, 71);
            this.lblBookingStatus.TabIndex = 7;
            this.lblBookingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(224)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1446, 705);
            this.Controls.Add(this.mainLayout);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Room Booking System";
            this.headerPanel.ResumeLayout(false);
            this.mainLayout.ResumeLayout(false);
            this.leftColumnLayout.ResumeLayout(false);
            this.personalInfoGroupBox.ResumeLayout(false);
            this.personalInfoFields.ResumeLayout(false);
            this.personalInfoFields.PerformLayout();
            this.roomTypeGroupBox.ResumeLayout(false);
            this.roomTypeOptions.ResumeLayout(false);
            this.roomTypeOptions.PerformLayout();
            this.additionalOptionsGroupBox.ResumeLayout(false);
            this.additionalOptions.ResumeLayout(false);
            this.additionalOptions.PerformLayout();
            this.actionButtons.ResumeLayout(false);
            this.bookingDetailsGroupBox.ResumeLayout(false);
            this.bookingDetailsLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}




