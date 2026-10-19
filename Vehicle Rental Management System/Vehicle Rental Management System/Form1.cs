using System;
using System.Windows.Forms;

namespace Vehicle_Rental_Management_System
{
    // Foomka ugu weyn ee maamulka kirada gaadiidka.
    public partial class Form1 : Form
    {
        // Dhisidda foomka: InitializeComponent ayaa soo muuqsiinaya controls-ka naqshadda.
        public Form1()
        {
            InitializeComponent();
        }
        // Calculate wuxuu hubiyaa shuruudaha kirada, kadibna qiimaha ayuu xisaabiyaa.
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Tirtir natiijadii hore si aan xogtii booking-kii hore u harin.
            rentalDetailsTextBox.Clear();

            // Ka akhri magaca iyo tirooyinka lagu qoray foomka.
            string customerName = customerNameTextBox.Text.Trim();
            int customerAge;
            int rentalDays;
            int drivingYears;

            // Magaca macmiilku ma bannaanaan karo.
            if (customerName.Length == 0)
            {
                RejectRental("Customer name cannot be empty.", customerNameTextBox);
                return;
            }

            // TryParse wuxuu xaqiijiyaa in da'du tiro tahay oo u dhexeyso 18 iyo 80.
            if (!int.TryParse(customerAgeTextBox.Text, out customerAge)
                || customerAge < 18 || customerAge > 80)
            {
                RejectRental("Customer age must be between 18 and 80.", customerAgeTextBox);
                return;
            }

            // TryParse wuxuu xaqiijiyaa in maalmaha kiradu yihiin tiro u dhexeysa 1 iyo 30.
            if (!int.TryParse(rentalDaysTextBox.Text, out rentalDays)
                || rentalDays < 1 || rentalDays > 30)
            {
                RejectRental("Rental days must be between 1 and 30.", rentalDaysTextBox);
                return;
            }

            // TryParse wuxuu xaqiijiyaa in sannadaha khibraddu tiro yihiin oo aanay taban ahayn.
            if (!int.TryParse(drivingExperienceTextBox.Text, out drivingYears)
                || drivingYears < 0)
            {
                RejectRental("Driving experience must be a number and cannot be negative.",
                    drivingExperienceTextBox);
                return;
            }

            // Soo hel nooca gaadhiga iyo qiimaha kirada maalintii.
            string vehicleType;
            decimal dailyRate;
            if (economyRadioButton.Checked)
            {
                vehicleType = "Economy";
                dailyRate = 35m;
            }
            else if (suvRadioButton.Checked)
            {
                vehicleType = "SUV";
                dailyRate = 60m;
            }
            else if (luxuryRadioButton.Checked)
            {
                vehicleType = "Luxury";
                dailyRate = 100m;
            }
            else
            {
                RejectRental("Please select a vehicle type.", null);
                return;
            }

            // Bool-kan iyo sababtan waxay go'aamiyaan in macmiilku buuxiyey shuruudaha u-qalmitaanka.
            bool rentalApproved = true;
            string rejectionReason = "";

            // Da'da 18-20 waa la aqbalaa qaab ahaan, laakiin kirada looma oggola qof ka yar 21.
            if (customerAge < 21)
            {
                rentalApproved = false;
                rejectionReason = "Customers below 21 years are not eligible to rent a vehicle.";
            }
            // Macmiil kasta waa inuu leeyahay ugu yaraan hal sano oo khibrad wadis ah.
            else if (drivingYears < 1)
            {
                rentalApproved = false;
                rejectionReason = "Customers must have at least 1 year of driving experience.";
            }
            // Gaadhiga Luxury wuxuu u baahan yahay da' ugu yaraan 25 sano.
            else if (luxuryRadioButton.Checked && customerAge < 25)
            {
                rentalApproved = false;
                rejectionReason = "Luxury vehicles require customers to be at least 25 years old.";
            }
            // Gaadhiga Luxury wuxuu sidoo kale u baahan yahay ugu yaraan 3 sano oo khibrad wadis ah.
            else if (luxuryRadioButton.Checked && drivingYears < 3)
            {
                rentalApproved = false;
                rejectionReason = "Luxury vehicles require at least 3 years of driving experience.";
            }

            // Haddii shuruud ka mid ahi fashilanto, muuji sababta oo jooji xisaabinta.
            if (!rentalApproved)
            {
                RejectRental(rejectionReason, null);
                return;
            }

            // Qiimaha aasaasiga ah waa qiimaha maalintii lagu dhuftay tirada maalmaha.
            decimal basicRentalCost = dailyRate * rentalDays;

            // Hesho boqolkiiba qiimo-dhimista ku xiran muddada kirada.
            int discountPercent;
            if (rentalDays >= 14)
            {
                discountPercent = 10;
            }
            else if (rentalDays >= 7)
            {
                discountPercent = 5;
            }
            else
            {
                discountPercent = 0;
            }

            // Xisaabi qiimo-dhimista lacag ahaan.
            decimal discount = basicRentalCost * discountPercent / 100m;

            // Caymisku waa $15 maalin kasta haddii macmiilku doorto insurance-ka.
            decimal insuranceCost = insuranceCheckBox.Checked
                ? 15m * rentalDays
                : 0m;

            // Da'da 21 ilaa 24 waxaa lagu daraa 10% surcharge oo laga xisaabiyo qiimaha aasaasiga ah.
            decimal youngDriverSurcharge = customerAge >= 21 && customerAge <= 24
                ? basicRentalCost * 0.10m
                : 0m;

            // Wadarta kama dambaysta ahi waxay ka jartaa discount-ka, kuna dartaa insurance iyo surcharge.
            decimal finalRentalCost =
                basicRentalCost - discount + insuranceCost + youngDriverSurcharge;

            // Ku qor natiijada oo dhan sanduuqa Rental Information and Results.
            rentalDetailsTextBox.Text =
                "RENTAL INFORMATION AND RESULTS" + Environment.NewLine
                + "Customer Name: " + customerName + Environment.NewLine
                + "Customer Age: " + customerAge + Environment.NewLine
                + "Driving Experience: " + drivingYears + " year(s)" + Environment.NewLine
                + "Rental Days: " + rentalDays + Environment.NewLine
                + "Vehicle Type: " + vehicleType + Environment.NewLine
                + "Basic Rental Cost: $" + basicRentalCost.ToString("0.00") + Environment.NewLine
                + "Discount (" + discountPercent + "%): -$" + discount.ToString("0.00")
                    + Environment.NewLine
                + "Insurance Cost: $" + insuranceCost.ToString("0.00") + Environment.NewLine
                + "Young Driver Surcharge: $" + youngDriverSurcharge.ToString("0.00")
                    + Environment.NewLine
                + "Final Rental Cost: $" + finalRentalCost.ToString("0.00") + Environment.NewLine
                + "Rental Status: APPROVED";
        }

        // Habkani wuxuu diidaa kirada, soo bandhigaa sababta, wuxuuna focus saaraa sanduuqa khaldan.
        private void RejectRental(string reason, Control control)
        {
            rentalDetailsTextBox.Text =
                "Rental Status: NOT ELIGIBLE" + Environment.NewLine
                + "Reason: " + reason;

            MessageBox.Show(reason, "Rental not approved",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (control != null)
            {
                control.Focus();
            }
        }

        // Clear wuxuu faaruqiyaa gelinta, ka-noqdaa doorashooyinka, oo tirtiraa natiijada.
        private void clearButton_Click(object sender, EventArgs e)
        {
            customerNameTextBox.Clear();
            customerAgeTextBox.Clear();
            rentalDaysTextBox.Clear();
            drivingExperienceTextBox.Clear();
            economyRadioButton.Checked = false;
            suvRadioButton.Checked = false;
            luxuryRadioButton.Checked = false;
            insuranceCheckBox.Checked = false;
            rentalDetailsTextBox.Clear();
            customerNameTextBox.Focus();
        }

        // Exit wuxuu xiraa foomka.
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
