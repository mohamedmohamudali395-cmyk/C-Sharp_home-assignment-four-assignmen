using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Registration_Fee_System
{
    // Foomka weyn ee ardaygu ku xareynayo koorsooyinka, kuna arkayo kharashka.
    public partial class Form1 : Form
    {
        // Constructor-ku wuxuu dhisaa naqshadda, wuxuuna diyaariyaa natiijooyinka bilowga.
        public Form1()
        {
            InitializeComponent();
            ResetResults();
        }

        // Calculate: hubi xogta ardayga iyo koorsooyinka, kadibna xisaabi kharashka.
        private void calculateButton_Click(object sender, EventArgs e)
        {
            ResetResults();

            // Magaca iyo aqoonsiga ardaygu waa xog khasab ah.
            string studentName = studentNameTextBox.Text.Trim();
            string studentId = studentIdTextBox.Text.Trim();

            if (studentName.Length == 0)
            {
                RejectRegistration("Student name cannot be empty.", studentNameTextBox);
                return;
            }

            if (studentId.Length == 0)
            {
                RejectRegistration("Student ID cannot be empty.", studentIdTextBox);
                return;
            }

            // TryParse wuxuu xaqiijiyaa in tirada koorsooyinku tiro tahay oo u dhexeyso 1 iyo 8.
            int courseCount;
            if (!int.TryParse(courseCountTextBox.Text.Trim(), out courseCount)
                || courseCount < 1 || courseCount > 8)
            {
                RejectRegistration("Number of courses must be a number between 1 and 8.",
                    courseCountTextBox);
                return;
            }

            // Hubi in ardaygu doortay sanad waxbarasho.
            if (studyLevelComboBox.SelectedIndex < 0)
            {
                RejectRegistration("Please select a study level.", studyLevelComboBox);
                return;
            }

            // Switch-ku wuxuu dejinayaa lacagta koorso kasta ee Year 1 ilaa Year 4.
            decimal feePerCourse;
            switch (studyLevelComboBox.SelectedIndex)
            {
                case 0:
                    feePerCourse = 40m;
                    break;
                case 1:
                    feePerCourse = 45m;
                    break;
                case 2:
                    feePerCourse = 50m;
                    break;
                case 3:
                    feePerCourse = 55m;
                    break;
                default:
                    RejectRegistration("The selected study level is not valid.", studyLevelComboBox);
                    return;
            }

            // Tuition-ka aasaasiga ahi waa qiimaha koorso kasta lagu dhuftay tirada koorsooyinka.
            decimal tuitionFee = feePerCourse * courseCount;

            // Adeegyada waa lacag go'an: hoygu waa $120, gaadiidkuna waa $80.
            decimal accommodationFee = accommodationCheckBox.Checked ? 120m : 0m;
            decimal transportFee = transportCheckBox.Checked ? 80m : 0m;

            // 6 koorso ama ka badan waxay helayaan 10% discount oo tuition-ka laga xisaabiyo.
            decimal courseDiscount = courseCount >= 6
                ? tuitionFee * 0.10m
                : 0m;

            // Hoyga iyo gaadiidka oo wada jira, iyo 5+ koorso, waxay keenaan 5% discount dheeraad ah.
            decimal serviceDiscount = accommodationCheckBox.Checked
                && transportCheckBox.Checked
                && courseCount >= 5
                    ? tuitionFee * 0.05m
                    : 0m;

            // Discount-yada waxaa laga jarayaa tuition-ka; kharashka adeegyada waa lagu darayaa.
            decimal totalDiscount = courseDiscount + serviceDiscount;
            decimal finalFee = tuitionFee + accommodationFee + transportFee - totalDiscount;

            // Natiijooyinka oo dhan waxaa loo diraa sanduuqa Registration Summary.
            registrationResultsTextBox.Text =
                "REGISTRATION SUMMARY" + Environment.NewLine
                + "Student Name: " + studentName + Environment.NewLine
                + "Student ID: " + studentId + Environment.NewLine
                + "Study Level: " + studyLevelComboBox.SelectedItem + Environment.NewLine
                + "Number of Courses: " + courseCount + Environment.NewLine
                + Environment.NewLine
                + "Tuition Fee: " + FormatMoney(tuitionFee) + Environment.NewLine
                + "Accommodation Fee: " + FormatMoney(accommodationFee) + Environment.NewLine
                + "Transport Fee: " + FormatMoney(transportFee) + Environment.NewLine
                + "Discount Amount: -" + FormatMoney(totalDiscount) + Environment.NewLine
                + "  Course discount (10% when eligible): -" + FormatMoney(courseDiscount) + Environment.NewLine
                + "  Service discount (5% when eligible): -" + FormatMoney(serviceDiscount) + Environment.NewLine
                + Environment.NewLine
                + "FINAL REGISTRATION FEE: " + FormatMoney(finalFee) + Environment.NewLine
                + "Registration Status: CALCULATED";
        }

        // Haddii gelintu khaldan tahay, sababta muuji oo focus saar sanduuqa u baahan sixid.
        private void RejectRegistration(string reason, Control invalidControl)
        {
            registrationResultsTextBox.Text =
                "REGISTRATION NOT CALCULATED" + Environment.NewLine
                + "Reason: " + reason;

            MessageBox.Show(this, reason, "Registration input error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (invalidControl != null)
            {
                invalidControl.Focus();
            }
        }

        // Lacagta u qaabee dollar laba meelood oo jajab ah.
        private static string FormatMoney(decimal amount)
        {
            return amount.ToString("C2", CultureInfo.GetCultureInfo("en-US"));
        }

        // Dib ugu celi sanduuqa natiijada xaaladdiisii bilowga.
        private void ResetResults()
        {
            registrationResultsTextBox.Text =
                "Registration details will appear here after you click Calculate.";
        }

        // Clear wuxuu nadiifiyaa dhammaan gelinta, adeegyada iyo natiijooyinka.
        private void clearButton_Click(object sender, EventArgs e)
        {
            studentNameTextBox.Clear();
            studentIdTextBox.Clear();
            courseCountTextBox.Clear();
            studyLevelComboBox.SelectedIndex = -1;
            accommodationCheckBox.Checked = false;
            transportCheckBox.Checked = false;
            ResetResults();
            studentNameTextBox.Focus();
        }

        // Exit wuxuu xiraa foomka.
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}