using System.Drawing;
using System.Windows.Forms;

namespace Airline_Ticket_Booking_System
{
    partial class Form1
    {
        // Controls-ka foomka iyo qaybaha muuqaalka waxaa lagu qeexaa halkan.
        private System.ComponentModel.IContainer components = null;
        private Panel headerPanel;
        private Label headerTitleLabel;
        private TableLayoutPanel mainLayout;
        private TableLayoutPanel leftColumnLayout;
        private GroupBox personalInfoGroupBox;
        private TableLayoutPanel personalInfoFields;
        private Label passengerNameLabel;
        private Label passengerAgeLabel;
        private Label numberOfTicketsLabel;
        private Label baggageWeightLabel;
        private TextBox passengerNameTextBox;
        private TextBox passengerAgeTextBox;
        private TextBox numberOfTicketsTextBox;
        private TextBox baggageWeightTextBox;
        private GroupBox travelClassGroupBox;
        private FlowLayoutPanel travelClassOptions;
        private RadioButton firstClassRadioButton;
        private RadioButton normalClassRadioButton;
        private RadioButton businessClassRadioButton;
        private Label fareNoteLabel;
        private GroupBox additionalOptionsGroupBox;
        private CheckBox travelInsuranceCheckBox;
        private FlowLayoutPanel actionButtons;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
        private GroupBox airlineBookingDetailsGroupBox;
        private TextBox bookingDetailsTextBox;
        private ToolTip baggageToolTip;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // InitializeComponent wuxuu abuuraa controls-ka, cabbirkooda, midabbadooda, iyo isku-xirkooda.
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerTitleLabel = new System.Windows.Forms.Label();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.leftColumnLayout = new System.Windows.Forms.TableLayoutPanel();
            this.personalInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.personalInfoFields = new System.Windows.Forms.TableLayoutPanel();
            this.passengerNameLabel = new System.Windows.Forms.Label();
            this.passengerAgeLabel = new System.Windows.Forms.Label();
            this.numberOfTicketsLabel = new System.Windows.Forms.Label();
            this.baggageWeightLabel = new System.Windows.Forms.Label();
            this.passengerNameTextBox = new System.Windows.Forms.TextBox();
            this.passengerAgeTextBox = new System.Windows.Forms.TextBox();
            this.numberOfTicketsTextBox = new System.Windows.Forms.TextBox();
            this.baggageWeightTextBox = new System.Windows.Forms.TextBox();
            this.travelClassGroupBox = new System.Windows.Forms.GroupBox();
            this.travelClassOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.firstClassRadioButton = new System.Windows.Forms.RadioButton();
            this.normalClassRadioButton = new System.Windows.Forms.RadioButton();
            this.businessClassRadioButton = new System.Windows.Forms.RadioButton();
            this.fareNoteLabel = new System.Windows.Forms.Label();
            this.additionalOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.travelInsuranceCheckBox = new System.Windows.Forms.CheckBox();
            this.actionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.airlineBookingDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.bookingDetailsTextBox = new System.Windows.Forms.TextBox();
            this.baggageToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.headerPanel.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.leftColumnLayout.SuspendLayout();
            this.personalInfoGroupBox.SuspendLayout();
            this.personalInfoFields.SuspendLayout();
            this.travelClassGroupBox.SuspendLayout();
            this.travelClassOptions.SuspendLayout();
            this.additionalOptionsGroupBox.SuspendLayout();
            this.actionButtons.SuspendLayout();
            this.airlineBookingDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(103)))), ((int)(((byte)(201)))));
            this.headerPanel.Controls.Add(this.headerTitleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1293, 64);
            this.headerPanel.TabIndex = 0;
            // 
            // headerTitleLabel
            // 
            this.headerTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerTitleLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.headerTitleLabel.ForeColor = System.Drawing.Color.White;
            this.headerTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.headerTitleLabel.Name = "headerTitleLabel";
            this.headerTitleLabel.Size = new System.Drawing.Size(1293, 64);
            this.headerTitleLabel.TabIndex = 0;
            this.headerTitleLabel.Text = "Airline Ticket Booking System";
            this.headerTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainLayout
            // 
            this.mainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.mainLayout.Controls.Add(this.leftColumnLayout, 0, 0);
            this.mainLayout.Controls.Add(this.airlineBookingDetailsGroupBox, 1, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 64);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Padding = new System.Windows.Forms.Padding(16, 14, 16, 16);
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(1293, 606);
            this.mainLayout.TabIndex = 1;
            // 
            // leftColumnLayout
            // 
            this.leftColumnLayout.ColumnCount = 1;
            this.leftColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftColumnLayout.Controls.Add(this.personalInfoGroupBox, 0, 0);
            this.leftColumnLayout.Controls.Add(this.travelClassGroupBox, 0, 1);
            this.leftColumnLayout.Controls.Add(this.additionalOptionsGroupBox, 0, 2);
            this.leftColumnLayout.Controls.Add(this.actionButtons, 0, 3);
            this.leftColumnLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftColumnLayout.Location = new System.Drawing.Point(19, 17);
            this.leftColumnLayout.Name = "leftColumnLayout";
            this.leftColumnLayout.RowCount = 4;
            this.leftColumnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.leftColumnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.leftColumnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.leftColumnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.leftColumnLayout.Size = new System.Drawing.Size(599, 570);
            this.leftColumnLayout.TabIndex = 0;
            // 
            // personalInfoGroupBox
            // 
            this.personalInfoGroupBox.Controls.Add(this.personalInfoFields);
            this.personalInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personalInfoGroupBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.personalInfoGroupBox.Location = new System.Drawing.Point(3, 3);
            this.personalInfoGroupBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.personalInfoGroupBox.Name = "personalInfoGroupBox";
            this.personalInfoGroupBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.personalInfoGroupBox.Size = new System.Drawing.Size(593, 252);
            this.personalInfoGroupBox.TabIndex = 0;
            this.personalInfoGroupBox.TabStop = false;
            this.personalInfoGroupBox.Text = "Personal Information";
            // 
            // personalInfoFields
            // 
            this.personalInfoFields.ColumnCount = 2;
            this.personalInfoFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.personalInfoFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.personalInfoFields.Controls.Add(this.passengerNameLabel, 0, 0);
            this.personalInfoFields.Controls.Add(this.passengerAgeLabel, 0, 1);
            this.personalInfoFields.Controls.Add(this.numberOfTicketsLabel, 0, 2);
            this.personalInfoFields.Controls.Add(this.baggageWeightLabel, 0, 3);
            this.personalInfoFields.Controls.Add(this.passengerNameTextBox, 1, 0);
            this.personalInfoFields.Controls.Add(this.passengerAgeTextBox, 1, 1);
            this.personalInfoFields.Controls.Add(this.numberOfTicketsTextBox, 1, 2);
            this.personalInfoFields.Controls.Add(this.baggageWeightTextBox, 1, 3);
            this.personalInfoFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personalInfoFields.Location = new System.Drawing.Point(10, 38);
            this.personalInfoFields.Name = "personalInfoFields";
            this.personalInfoFields.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personalInfoFields.RowCount = 4;
            this.personalInfoFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.personalInfoFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.personalInfoFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.personalInfoFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.personalInfoFields.Size = new System.Drawing.Size(573, 204);
            this.personalInfoFields.TabIndex = 0;
            // 
            // passengerNameLabel
            // 
            this.passengerNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passengerNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.passengerNameLabel.Location = new System.Drawing.Point(6, 2);
            this.passengerNameLabel.Margin = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.passengerNameLabel.Name = "passengerNameLabel";
            this.passengerNameLabel.Size = new System.Drawing.Size(232, 50);
            this.passengerNameLabel.TabIndex = 0;
            this.passengerNameLabel.Text = "Passenger Name:";
            this.passengerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passengerAgeLabel
            // 
            this.passengerAgeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passengerAgeLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.passengerAgeLabel.Location = new System.Drawing.Point(6, 52);
            this.passengerAgeLabel.Margin = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.passengerAgeLabel.Name = "passengerAgeLabel";
            this.passengerAgeLabel.Size = new System.Drawing.Size(232, 50);
            this.passengerAgeLabel.TabIndex = 1;
            this.passengerAgeLabel.Text = "Passenger Age:";
            this.passengerAgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numberOfTicketsLabel
            // 
            this.numberOfTicketsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfTicketsLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.numberOfTicketsLabel.Location = new System.Drawing.Point(6, 102);
            this.numberOfTicketsLabel.Margin = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.numberOfTicketsLabel.Name = "numberOfTicketsLabel";
            this.numberOfTicketsLabel.Size = new System.Drawing.Size(232, 50);
            this.numberOfTicketsLabel.TabIndex = 2;
            this.numberOfTicketsLabel.Text = "Number of Tickets:";
            this.numberOfTicketsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // baggageWeightLabel
            // 
            this.baggageWeightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baggageWeightLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.baggageWeightLabel.Location = new System.Drawing.Point(6, 152);
            this.baggageWeightLabel.Margin = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.baggageWeightLabel.Name = "baggageWeightLabel";
            this.baggageWeightLabel.Size = new System.Drawing.Size(232, 50);
            this.baggageWeightLabel.TabIndex = 3;
            this.baggageWeightLabel.Text = "Baggage weight (kg):";
            this.baggageWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passengerNameTextBox
            // 
            this.passengerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passengerNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passengerNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.passengerNameTextBox.Location = new System.Drawing.Point(249, 7);
            this.passengerNameTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 12, 5);
            this.passengerNameTextBox.Name = "passengerNameTextBox";
            this.passengerNameTextBox.Size = new System.Drawing.Size(309, 34);
            this.passengerNameTextBox.TabIndex = 0;
            // 
            // passengerAgeTextBox
            // 
            this.passengerAgeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passengerAgeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passengerAgeTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.passengerAgeTextBox.Location = new System.Drawing.Point(249, 57);
            this.passengerAgeTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 12, 5);
            this.passengerAgeTextBox.Name = "passengerAgeTextBox";
            this.passengerAgeTextBox.Size = new System.Drawing.Size(309, 34);
            this.passengerAgeTextBox.TabIndex = 1;
            // 
            // numberOfTicketsTextBox
            // 
            this.numberOfTicketsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfTicketsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfTicketsTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numberOfTicketsTextBox.Location = new System.Drawing.Point(249, 107);
            this.numberOfTicketsTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 12, 5);
            this.numberOfTicketsTextBox.Name = "numberOfTicketsTextBox";
            this.numberOfTicketsTextBox.Size = new System.Drawing.Size(309, 34);
            this.numberOfTicketsTextBox.TabIndex = 2;
            // 
            // baggageWeightTextBox
            // 
            this.baggageWeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baggageWeightTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baggageWeightTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.baggageWeightTextBox.Location = new System.Drawing.Point(249, 157);
            this.baggageWeightTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 12, 5);
            this.baggageWeightTextBox.Name = "baggageWeightTextBox";
            this.baggageWeightTextBox.Size = new System.Drawing.Size(309, 34);
            this.baggageWeightTextBox.TabIndex = 3;
            this.baggageToolTip.SetToolTip(this.baggageWeightTextBox, "Enter the combined baggage weight for all tickets; maximum is 50 kg per passenger" +
        ".");
            // 
            // travelClassGroupBox
            // 
            this.travelClassGroupBox.Controls.Add(this.travelClassOptions);
            this.travelClassGroupBox.Controls.Add(this.fareNoteLabel);
            this.travelClassGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.travelClassGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.travelClassGroupBox.Location = new System.Drawing.Point(3, 267);
            this.travelClassGroupBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.travelClassGroupBox.Name = "travelClassGroupBox";
            this.travelClassGroupBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.travelClassGroupBox.Size = new System.Drawing.Size(593, 121);
            this.travelClassGroupBox.TabIndex = 1;
            this.travelClassGroupBox.TabStop = false;
            this.travelClassGroupBox.Text = "Travel Class";
            // 
            // travelClassOptions
            // 
            this.travelClassOptions.Controls.Add(this.firstClassRadioButton);
            this.travelClassOptions.Controls.Add(this.normalClassRadioButton);
            this.travelClassOptions.Controls.Add(this.businessClassRadioButton);
            this.travelClassOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.travelClassOptions.Location = new System.Drawing.Point(10, 36);
            this.travelClassOptions.Name = "travelClassOptions";
            this.travelClassOptions.Size = new System.Drawing.Size(573, 42);
            this.travelClassOptions.TabIndex = 0;
            this.travelClassOptions.WrapContents = false;
            // 
            // firstClassRadioButton
            // 
            this.firstClassRadioButton.AutoSize = true;
            this.firstClassRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.firstClassRadioButton.Location = new System.Drawing.Point(8, 10);
            this.firstClassRadioButton.Margin = new System.Windows.Forms.Padding(8, 10, 6, 3);
            this.firstClassRadioButton.Name = "firstClassRadioButton";
            this.firstClassRadioButton.Size = new System.Drawing.Size(123, 29);
            this.firstClassRadioButton.TabIndex = 4;
            this.firstClassRadioButton.TabStop = true;
            this.firstClassRadioButton.Text = "First Class";
            this.firstClassRadioButton.UseVisualStyleBackColor = true;
            // 
            // normalClassRadioButton
            // 
            this.normalClassRadioButton.AutoSize = true;
            this.normalClassRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.normalClassRadioButton.Location = new System.Drawing.Point(143, 10);
            this.normalClassRadioButton.Margin = new System.Windows.Forms.Padding(6, 10, 6, 3);
            this.normalClassRadioButton.Name = "normalClassRadioButton";
            this.normalClassRadioButton.Size = new System.Drawing.Size(152, 29);
            this.normalClassRadioButton.TabIndex = 5;
            this.normalClassRadioButton.TabStop = true;
            this.normalClassRadioButton.Text = "Normal Class";
            this.normalClassRadioButton.UseVisualStyleBackColor = true;
            // 
            // businessClassRadioButton
            // 
            this.businessClassRadioButton.AutoSize = true;
            this.businessClassRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.businessClassRadioButton.Location = new System.Drawing.Point(307, 10);
            this.businessClassRadioButton.Margin = new System.Windows.Forms.Padding(6, 10, 6, 3);
            this.businessClassRadioButton.Name = "businessClassRadioButton";
            this.businessClassRadioButton.Size = new System.Drawing.Size(160, 29);
            this.businessClassRadioButton.TabIndex = 6;
            this.businessClassRadioButton.TabStop = true;
            this.businessClassRadioButton.Text = "Business Class";
            this.businessClassRadioButton.UseVisualStyleBackColor = true;
            // 
            // fareNoteLabel
            // 
            this.fareNoteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fareNoteLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.fareNoteLabel.ForeColor = System.Drawing.Color.DimGray;
            this.fareNoteLabel.Location = new System.Drawing.Point(14, 78);
            this.fareNoteLabel.Name = "fareNoteLabel";
            this.fareNoteLabel.Size = new System.Drawing.Size(565, 22);
            this.fareNoteLabel.TabIndex = 1;
            this.fareNoteLabel.Text = "Sample fares: Normal $200 | Business $350 | First $500";
            this.fareNoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // additionalOptionsGroupBox
            // 
            this.additionalOptionsGroupBox.Controls.Add(this.travelInsuranceCheckBox);
            this.additionalOptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.additionalOptionsGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.additionalOptionsGroupBox.Location = new System.Drawing.Point(3, 398);
            this.additionalOptionsGroupBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.additionalOptionsGroupBox.Name = "additionalOptionsGroupBox";
            this.additionalOptionsGroupBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.additionalOptionsGroupBox.Size = new System.Drawing.Size(593, 86);
            this.additionalOptionsGroupBox.TabIndex = 2;
            this.additionalOptionsGroupBox.TabStop = false;
            this.additionalOptionsGroupBox.Text = "Additional Options";
            // 
            // travelInsuranceCheckBox
            // 
            this.travelInsuranceCheckBox.AutoSize = true;
            this.travelInsuranceCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.travelInsuranceCheckBox.Location = new System.Drawing.Point(18, 36);
            this.travelInsuranceCheckBox.Name = "travelInsuranceCheckBox";
            this.travelInsuranceCheckBox.Size = new System.Drawing.Size(362, 29);
            this.travelInsuranceCheckBox.TabIndex = 7;
            this.travelInsuranceCheckBox.Text = "Add travel insurance ($25 per ticket)";
            this.travelInsuranceCheckBox.UseVisualStyleBackColor = true;
            // 
            // actionButtons
            // 
            this.actionButtons.Controls.Add(this.calculateButton);
            this.actionButtons.Controls.Add(this.clearButton);
            this.actionButtons.Controls.Add(this.exitButton);
            this.actionButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionButtons.Location = new System.Drawing.Point(3, 497);
            this.actionButtons.Name = "actionButtons";
            this.actionButtons.Padding = new System.Windows.Forms.Padding(3, 14, 3, 3);
            this.actionButtons.Size = new System.Drawing.Size(593, 70);
            this.actionButtons.TabIndex = 3;
            this.actionButtons.WrapContents = false;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.White;
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.calculateButton.Location = new System.Drawing.Point(9, 17);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(6, 3, 10, 3);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(112, 40);
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
            this.clearButton.Location = new System.Drawing.Point(131, 17);
            this.clearButton.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 40);
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
            this.exitButton.Location = new System.Drawing.Point(253, 17);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 40);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // airlineBookingDetailsGroupBox
            // 
            this.airlineBookingDetailsGroupBox.Controls.Add(this.bookingDetailsTextBox);
            this.airlineBookingDetailsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airlineBookingDetailsGroupBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.airlineBookingDetailsGroupBox.Location = new System.Drawing.Point(624, 17);
            this.airlineBookingDetailsGroupBox.Name = "airlineBookingDetailsGroupBox";
            this.airlineBookingDetailsGroupBox.Padding = new System.Windows.Forms.Padding(12, 10, 12, 12);
            this.airlineBookingDetailsGroupBox.Size = new System.Drawing.Size(650, 570);
            this.airlineBookingDetailsGroupBox.TabIndex = 1;
            this.airlineBookingDetailsGroupBox.TabStop = false;
            this.airlineBookingDetailsGroupBox.Text = "Airline Booking Details";
            // 
            // bookingDetailsTextBox
            // 
            this.bookingDetailsTextBox.BackColor = System.Drawing.Color.White;
            this.bookingDetailsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookingDetailsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingDetailsTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.bookingDetailsTextBox.Location = new System.Drawing.Point(12, 40);
            this.bookingDetailsTextBox.Multiline = true;
            this.bookingDetailsTextBox.Name = "bookingDetailsTextBox";
            this.bookingDetailsTextBox.ReadOnly = true;
            this.bookingDetailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bookingDetailsTextBox.Size = new System.Drawing.Size(626, 518);
            this.bookingDetailsTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1293, 670);
            this.Controls.Add(this.mainLayout);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(940, 620);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline Ticket Booking System";
            this.headerPanel.ResumeLayout(false);
            this.mainLayout.ResumeLayout(false);
            this.leftColumnLayout.ResumeLayout(false);
            this.personalInfoGroupBox.ResumeLayout(false);
            this.personalInfoFields.ResumeLayout(false);
            this.personalInfoFields.PerformLayout();
            this.travelClassGroupBox.ResumeLayout(false);
            this.travelClassOptions.ResumeLayout(false);
            this.travelClassOptions.PerformLayout();
            this.additionalOptionsGroupBox.ResumeLayout(false);
            this.additionalOptionsGroupBox.PerformLayout();
            this.actionButtons.ResumeLayout(false);
            this.airlineBookingDetailsGroupBox.ResumeLayout(false);
            this.airlineBookingDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
