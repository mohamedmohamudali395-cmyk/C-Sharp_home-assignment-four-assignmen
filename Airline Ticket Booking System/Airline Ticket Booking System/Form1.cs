using System;
using System.Globalization;
using System.Windows.Forms;

namespace Airline_Ticket_Booking_System
{
    // Form1 waa foomka airline-ka: wuxuu qaataa xogta rakaabka, hubiyaa shuruudaha, kadibna xisaabiyaa qiimaha.
    public partial class Form1 : Form
    {
        // Qiimayaashan waa tusaale maadaama sawirka shuruudaha aanu sheegin ticket fare-ka fasal kasta.
        // Waxaad ka beddeli kartaa qiimaha fasal kasta halkan.
        private const decimal NormalClassTicketPrice = 200m;
        private const decimal BusinessClassTicketPrice = 350m;
        private const decimal FirstClassTicketPrice = 500m;

        // Furaha foomka wuxuu diyaariyaa controls-ka muuqaalka.
        public Form1()
        {
            InitializeComponent();
        }

        // Calculate wuxuu hubiyaa xogta, xeerarka booking-ka, kadibna soo saaraa kharashka.
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Nadiifi natiijadii hore si booking cusub aanu u muujin xog duug ah.
            bookingDetailsTextBox.Clear();

            // Ka akhri sanduuqyada foomka oo ka saar meelaha bannaan ee magaca.
            string passengerName = passengerNameTextBox.Text.Trim();
            int passengerAge;
            int numberOfTickets;
            decimal baggageWeightKg;

            // Magaca rakaabku waa inuu jiraa.
            if (passengerName.Length == 0)
            {
                RejectBooking("Passenger name cannot be empty.", passengerNameTextBox);
                return;
            }

            // TryParse wuxuu hubiyaa in da'du tiro tahay oo u dhexeyso 1 iyo 100.
            if (!int.TryParse(passengerAgeTextBox.Text, out passengerAge)
                || passengerAge < 1 || passengerAge > 100)
            {
                RejectBooking("Passenger age must be a whole number from 1 to 100.", passengerAgeTextBox);
                return;
            }

            // TryParse wuxuu hubiyaa in tirada tikidhadu tahay 1 ilaa 5.
            if (!int.TryParse(numberOfTicketsTextBox.Text, out numberOfTickets)
                || numberOfTickets < 1 || numberOfTickets > 5)
            {
                RejectBooking("Number of tickets must be from 1 to 5.", numberOfTicketsTextBox);
                return;
            }

            // TryParse wuxuu hubiyaa in miisaanka boorsooyinku yahay tiro togan ama eber.
            if (!decimal.TryParse(
                    baggageWeightTextBox.Text,
                    NumberStyles.Number,
                    CultureInfo.CurrentCulture,
                    out baggageWeightKg)
                || baggageWeightKg < 0m)
            {
                RejectBooking("Baggage weight must be a valid number and cannot be negative.", baggageWeightTextBox);
                return;
            }

            // Miisaanka la geliyey waa wadarta boorsooyinka dhammaan tikidhada.
            // Qof kasta wuxuu qaadan karaa ugu badnaan 50 kg.
            decimal maximumBaggageKg = 50m * numberOfTickets;
            if (baggageWeightKg > maximumBaggageKg)
            {
                RejectBooking(
                    string.Format("Baggage cannot exceed {0:0.##} kg for {1} ticket(s).",
                        maximumBaggageKg, numberOfTickets),
                    baggageWeightTextBox);
                return;
            }

            // Ogaaw fasalka la doortay iyo qiimaha hal tikidh.
            string travelClass;
            decimal ticketPrice;
            if (normalClassRadioButton.Checked)
            {
                travelClass = "Normal Class";
                ticketPrice = NormalClassTicketPrice;
            }
            else if (businessClassRadioButton.Checked)
            {
                travelClass = "Business Class";
                ticketPrice = BusinessClassTicketPrice;
            }
            else if (firstClassRadioButton.Checked)
            {
                travelClass = "First Class";
                ticketPrice = FirstClassTicketPrice;
            }
            else
            {
                RejectBooking("Please select a travel class.", null);
                return;
            }

            // Bool-kan wuxuu go'aamiyaa in rakaabka ka yar 12 sano loo oggol yahay fasalka la doortay.
            bool bookingApproved = !(passengerAge < 12 && firstClassRadioButton.Checked);
            if (!bookingApproved)
            {
                RejectBooking("Passengers below 12 years cannot book First Class.", null);
                return;
            }

            // Qiimo-dhimista tirada tikidhada: 1-2 waa 0%, 3-4 waa 5%, 5 waa 10%.
            int ticketDiscountPercent;
            if (numberOfTickets == 5)
            {
                ticketDiscountPercent = 10;
            }
            else if (numberOfTickets >= 3)
            {
                ticketDiscountPercent = 5;
            }
            else
            {
                ticketDiscountPercent = 0;
            }

            // Qiimo-dhimista da'da: carruurta ka yar 12 sano 20%, dadka 60+ sano 10%.
            int ageDiscountPercent = passengerAge < 12 ? 20
                : passengerAge >= 60 ? 10
                : 0;

            // Qiimaha aasaasiga ahi waa fare-ka hal tikidh oo lagu dhuftay tirada tikidhada.
            decimal basicTicketCost = ticketPrice * numberOfTickets;

            // Labada qiimo-dhimis waxaa lagu xisaabiyaa qiimaha aasaasiga ah ee booking-ka.
            decimal ticketDiscount = basicTicketCost * ticketDiscountPercent / 100m;
            decimal ageDiscount = basicTicketCost * ageDiscountPercent / 100m;
            decimal totalDiscount = ticketDiscount + ageDiscount;

            // Caymiska safarku wuxuu ku darayaa $25 tikidh kasta haddii la doorto.
            decimal insuranceCost = travelInsuranceCheckBox.Checked
                ? 25m * numberOfTickets
                : 0m;

            // Ilaa 20 kg rakaabkiiba waa bilaash; xeerarku ma sheegin lacagta 20-50 kg dheeraadka ah.
            decimal freeBaggageAllowanceKg = 20m * numberOfTickets;
            string baggageRule;
            if (baggageWeightKg <= freeBaggageAllowanceKg)
            {
                baggageRule = "Within the free allowance (20 kg per passenger).";
            }
            else
            {
                baggageRule = "Above the free allowance; no extra-baggage fee was specified.";
            }

            // Wadarta guud waxay ka jartaa qiimo-dhimista, kuna dartaa caymiska.
            decimal totalCost = basicTicketCost - totalDiscount + insuranceCost;

            // Ku muuji faahfaahinta oo dhan marka booking-ku buuxiyo shuruudaha.
            bookingDetailsTextBox.Text =
                "AIRLINE BOOKING DETAILS" + Environment.NewLine
                + "Passenger Name: " + passengerName + Environment.NewLine
                + "Passenger Age: " + passengerAge + Environment.NewLine
                + "Travel Class: " + travelClass + Environment.NewLine
                + "Number of Tickets: " + numberOfTickets + Environment.NewLine
                + "Ticket Price: $" + ticketPrice.ToString("0.00") + Environment.NewLine
                + "Basic Ticket Cost: $" + basicTicketCost.ToString("0.00") + Environment.NewLine
                + "Ticket Discount (" + ticketDiscountPercent + "%): -$"
                    + ticketDiscount.ToString("0.00") + Environment.NewLine
                + "Age Discount (" + ageDiscountPercent + "%): -$"
                    + ageDiscount.ToString("0.00") + Environment.NewLine
                + "Travel Insurance: $" + insuranceCost.ToString("0.00") + Environment.NewLine
                + "Baggage Weight: " + baggageWeightKg.ToString("0.##") + " kg total" + Environment.NewLine
                + "Baggage Rule: " + baggageRule + Environment.NewLine
                + "TOTAL COST: $" + totalCost.ToString("0.00") + Environment.NewLine
                + "Booking Status: APPROVED";
        }

        // Booking la diiday wuxuu muujiyaa sababta, wuxuuna focus saaraa sanduuqa khaldan haddii uu jiro.
        private void RejectBooking(string reason, Control control)
        {
            bookingDetailsTextBox.Text =
                "Booking Status: REJECTED" + Environment.NewLine
                + "Reason: " + reason;

            MessageBox.Show(reason, "Booking rejected",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (control != null)
            {
                control.Focus();
            }
        }

        // Clear wuxuu tirtiraa xogta la geliyey, doorashooyinka, iyo natiijada booking-ka.
        private void clearButton_Click(object sender, EventArgs e)
        {
            passengerNameTextBox.Clear();
            passengerAgeTextBox.Clear();
            numberOfTicketsTextBox.Clear();
            baggageWeightTextBox.Clear();
            normalClassRadioButton.Checked = false;
            businessClassRadioButton.Checked = false;
            firstClassRadioButton.Checked = false;
            travelInsuranceCheckBox.Checked = false;
            bookingDetailsTextBox.Clear();
            passengerNameTextBox.Focus();
        }

        // Exit wuxuu xiraa foomka airline booking-ka.
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
