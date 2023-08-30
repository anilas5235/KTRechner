using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KTRechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static readonly int AXAConstDaysPerMonths = 30, NachleistungspflichtMonate =3;
        private double KTperDay, Rent, RentPerDay, DifferncePerDay,TotalRecovery,OverPaidDaysRecovery,RequiredDaysRecovery;
        private int TotalTimeFrame,DaysUntilKTends,DaysKTOverPaid;
        private DateTime KTPaidUntil, RentStart;        

        private void Form1_Load(object sender, EventArgs e)
        {
            TbxKTPerDayInput_TextChanged(sender, e);
            TbxRentPerMonthInput_TextChanged(sender, e);

            dtpKTended.Enabled = false;

            UpadteOutputFields();
        }

        private void TbxKTPerDayInput_TextChanged(object sender, EventArgs e)
        {
            KTperDay = ValidateDoubleInputField(tbxKTPerDayInput, KTperDay);
        }

        private void DtpKTGezahltBis_ValueChanged(object sender, EventArgs e)
        {
            KTPaidUntil = dtpKTPaidUntilInput.Value;
        }        

        private void DtpRentenEintritt_ValueChanged(object sender, EventArgs e)
        {
            RentStart = dtpRentStartDateInput.Value;
        }
        

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            CalculateRecoverySumme();
        }

        private void TbxRentPerMonthInput_TextChanged(object sender, EventArgs e)
        {
            Rent = ValidateDoubleInputField(tbxRentPerMonthInput, Rent);
        }

        private void CalculateRecoverySumme()
        {
            DaysUntilKTends = 0;
            DaysKTOverPaid = 0;

            RentPerDay = Rent / AXAConstDaysPerMonths;
            DifferncePerDay = KTperDay - RentPerDay;
            TotalTimeFrame = (int)Math.Ceiling((KTPaidUntil - RentStart).TotalDays)+1;          

            //Cacualte the end Date 3 Months after the rent payments started
            DateTime KTended = new DateTime(RentStart.Year, RentStart.Month + NachleistungspflichtMonate, RentStart.Day, RentStart.Hour, RentStart.Minute, RentStart.Second);
            if (KTended.Day == 1)
            {
                if (KTended.Month == 1) KTended = new DateTime(KTended.Year - 1, 12, DateTime.DaysInMonth(KTended.Year - 1, 12));
                else KTended = new DateTime(KTended.Year, KTended.Month - 1, DateTime.DaysInMonth(KTended.Year, KTended.Month - 1));
            }
            else KTended = new DateTime(KTended.Year, KTended.Month, KTended.Day - 1);

            DateTime DisplayKTended = KTended;

            if ((KTPaidUntil - KTended).TotalDays < 0) KTended = KTPaidUntil;
            DaysUntilKTends = (int)Math.Ceiling((KTended - RentStart).TotalDays) + 1;
            DaysKTOverPaid = (int)Math.Ceiling((KTPaidUntil - KTended).TotalDays) - 1;
            if (DaysKTOverPaid < 1) DaysKTOverPaid = 0;

            RequiredDaysRecovery = DaysUntilKTends * (DifferncePerDay <= 0 ? KTperDay : RentPerDay);
            OverPaidDaysRecovery = DaysKTOverPaid * KTperDay;

            TotalRecovery = RequiredDaysRecovery + OverPaidDaysRecovery;


            dtpKTended.Value = DisplayKTended;
            dtpKTended.Refresh();

            UpadteOutputFields();
        }

        private void UpadteOutputFields()
        {
            tbxDifferncePerDayOutput.Text = DifferncePerDay.ToString("0.00");
            tbxRecoverySumeOutput.Text = TotalRecovery.ToString("0.00");
            tbxKTPerDayOutput.Text = KTperDay.ToString("0.00");
            tbxRentPerDayOutput.Text = RentPerDay.ToString("0.00");
            tbxRequireddDaysOutput.Text = DaysUntilKTends.ToString();
            tbxOverPaidDaysOutput.Text = DaysKTOverPaid.ToString();
            tbxRecoveryOverPaidOutput.Text = OverPaidDaysRecovery.ToString("0.00");
            tbxRequiredDaysRecoveryOutput.Text = RequiredDaysRecovery.ToString("0.00");            
        }

        private double ValidateDoubleInputField(System.Windows.Forms.TextBox InputBox, double currentValue)
        {
            bool valied = true;
            foreach (var item in InputBox.Text)if (item == '+' || item == '-') valied = false;
            
            if (valied && Double.TryParse(InputBox.Text, out double inputValue))return inputValue;               
                        
            InputBox.Text = currentValue.ToString("0.00");
            return currentValue;            
        }      
    }
}
