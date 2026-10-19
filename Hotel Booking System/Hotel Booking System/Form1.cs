using System;
using System.Windows.Forms;

namespace Hotel_Booking_System
{
    // Foomka ugu weyn ee qaata xogta martida, xisaabiya qiimaha, soona bandhiga natiijada.
    public partial class Form1 : Form
    {
        // Marka foomku furmo, controls-ka Designer-ka ayaa la diyaariyaa, natiijooyinkana waa la nadiifiyaa.
        public Form1()
        {
            InitializeComponent();
            ClearBookingResults();
        }

        // Qaybtani waxay shaqaysaa marka badhanka Calculate la riixo.
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Ka saar natiijadii hore si aan xog duug ahi ugu harin xisaab cusub.
            ClearBookingResults();

            // Ka akhri xogta martida iyo tirooyinka sanduuqyada foomka.
            string guestName = guestNameTextBox.Text.Trim();
            int guestAge;
            int nights;
            int guests;

            // Hubi in magaca martidu aanu bannaanayn.
            if (guestName.Length == 0)
            {
                RejectBooking("Guest name cannot be empty.", guestNameTextBox);
                return;
            }

            // TryParse wuxuu hubiyaa in da'du tiro tahay oo u dhexeyso 18 iyo 90.
            if (!int.TryParse(guestAgeTextBox.Text, out guestAge) || guestAge < 18 || guestAge > 90)
            {
                RejectBooking("Guest age must be between 18 and 90.", guestAgeTextBox);
                return;
            }

            // Hubi in habeenadu tiro yihiin oo u dhexeeyaan 1 iyo 30.
            if (!int.TryParse(numberOfNightsTextBox.Text, out nights) || nights < 1 || nights > 30)
            {
                RejectBooking("Number of nights must be between 1 and 30.", numberOfNightsTextBox);
                return;
            }

            // Hubi in tirada martidu tiro tahay oo u dhexeyso 1 iyo 6.
            if (!int.TryParse(numberOfGuestsTextBox.Text, out guests) || guests < 1 || guests > 6)
            {
                RejectBooking("Number of guests must be between 1 and 6.", numberOfGuestsTextBox);
                return;
            }

            // Ogaaw nooca qolka uu isticmaaluhu doortay.
            string roomType;
            if (standardRadioButton.Checked)
            {
                roomType = "Standard";
            }
            else if (normalRadioButton.Checked)
            {
                roomType = "Normal";
            }
            else if (highRadioButton.Checked)
            {
                roomType = "High";
            }
            else
            {
                RejectBooking("Please choose a room type.", null);
                return;
            }

            // Switch-ku wuxuu dejinayaa qiimaha habeenkii iyo martida ugu badan ee qolku qaadi karo.
            decimal ratePerNight;
            int roomCapacity;

            // UI-ga: Normal wuxuu u dhigmaa Deluxe, High-na Suite.
            switch (roomType)
            {
                case "Standard":
                    ratePerNight = 50m;
                    roomCapacity = 2;
                    break;
                case "Normal":
                    ratePerNight = 80m;
                    roomCapacity = 4;
                    break;
                case "High":
                    ratePerNight = 130m;
                    roomCapacity = 6;
                    break;
                default:
                    RejectBooking("Please choose a valid room type.", null);
                    return;
            }

            // Bool-kan wuxuu go'aamiyaa in tirada martidu ku habboon tahay awoodda qolka.
            bool bookingApproved = guests <= roomCapacity;
            if (!bookingApproved)
            {
                RejectBooking(
                    string.Format("{0} rooms allow a maximum of {1} guests.", roomType, roomCapacity),
                    null);
                return;
            }

            // Xisaabi qiimo-dhimista joogitaanka: 1-4 habeen 0%, 5-9 habeen 5%, 10+ habeen 12%.
            int stayDiscountPercent;
            if (nights >= 10)
            {
                stayDiscountPercent = 12;
            }
            else if (nights >= 5)
            {
                stayDiscountPercent = 5;
            }
            else
            {
                stayDiscountPercent = 0;
            }

            // Martida da'doodu tahay 60 ama ka badan waxay helayaan 5% qiimo-dhimis dheeraad ah.
            int seniorDiscountPercent = guestAge >= 60 ? 5 : 0;
            int totalDiscountPercent = stayDiscountPercent + seniorDiscountPercent;

            // Xisaabi qiimaha qolka, qiimo-dhimista, quraacda, adeegga, iyo wadarta ugu dambaysa.
            decimal basicCost = ratePerNight * nights;
            decimal discount = basicCost * totalDiscountPercent / 100m;
            decimal breakfastCost = breakfastCheckBox.Checked ? 10m * guests * nights : 0m;
            decimal serviceCharge = guests > 4 ? basicCost * 0.05m : 0m;
            decimal totalCost = basicCost - discount + breakfastCost + serviceCharge;

            // Ku qor natiijooyinka booking-ka labels-ka ku jira qaybta Booking details.
            lblResultName.Text = "Guest Name: " + guestName;
            lblResultRoom.Text = "Room Type: " + roomType;
            lblBasicCost.Text = "Basic Cost: $" + basicCost.ToString("0.00");
            lblDiscount.Text = "Discount: $" + discount.ToString("0.00")
                + " (" + totalDiscountPercent + "%)";
            lblBreakfastCost.Text = "Breakfast Cost: $" + breakfastCost.ToString("0.00");
            lblServiceCharge.Text = "Service Charge: $" + serviceCharge.ToString("0.00");
            lblTotalCost.Text = "Total Cost: $" + totalCost.ToString("0.00");
            lblBookingStatus.Text = "Booking Status: Approved";
        }

        // Qaybtani booking-ka way diiddaa, fariin bay soo bandhigtaa, sanduuqa khaldan ayayna focus saartaa.
        private void RejectBooking(string message, Control control)
        {
            lblBookingStatus.Text = "Booking Status: Rejected";
            MessageBox.Show(message, "Booking rejected",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (control != null)
            {
                control.Focus();
            }
        }

        // Nadiifi qoraalka labels-ka si aan waxba uga muuqan ka hor Calculate ama ka dib Clear.
        private void ClearBookingResults()
        {
            lblResultName.Text = "";
            lblResultRoom.Text = "";
            lblBasicCost.Text = "";
            lblDiscount.Text = "";
            lblBreakfastCost.Text = "";
            lblServiceCharge.Text = "";
            lblTotalCost.Text = "";
            lblBookingStatus.Text = "";
        }

        // Badhanka Clear wuxuu tirtiraa xogta la geliyey iyo natiijada xisaabta.
        private void clearButton_Click(object sender, EventArgs e)
        {
            guestNameTextBox.Clear();
            guestAgeTextBox.Clear();
            numberOfNightsTextBox.Clear();
            numberOfGuestsTextBox.Clear();
            standardRadioButton.Checked = false;
            normalRadioButton.Checked = false;
            highRadioButton.Checked = false;
            breakfastCheckBox.Checked = false;

            ClearBookingResults();
            guestNameTextBox.Focus();
        }

        // Badhanka Exit wuxuu xiraa foomka.
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
