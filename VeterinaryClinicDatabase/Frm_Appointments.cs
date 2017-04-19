using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VeterinaryClinicDatabase
{
    public partial class Frm_Appointments : Form
    {

        int apptmtIDParam = 0;
        int animalIDParam = 0;
        bool apptmt_confirmed_bool = false;
        string apptmt_confirmed = null;
        int clientIDParam = 0;
        int staffIDParam = 0;

        public Frm_Appointments()
        {
            InitializeComponent();
        }

        private void Frm_Appointments_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime apptmts_day = DateTime.Parse(dtp_apptmts_fill_listbox.Text);
                this.scheduleSlotTableAdapter.FillByDateForApptmts(this.scheduleSlotDataSet.ScheduleSlot, apptmts_day.ToShortDateString());
                Fill_Appointments_Listbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Fill_Appointments_Listbox()
        {
            listbox_upcoming_appointments.Items.Clear();
            for (int i = 0; i < scheduleSlotDataSet.Tables["ScheduleSlot"].Rows.Count; i++)
            {
                List<string> appointmentDetails = GetAppointmentDetails(i);
                listbox_upcoming_appointments.Items.Add(
                    appointmentDetails.ElementAt(0).ToString().PadRight(25 - appointmentDetails.ElementAt(0).ToString().Length) + "  "
                    + appointmentDetails.ElementAt(3).ToString() + "\tFor "
                    + appointmentDetails.ElementAt(4).ToString() + " and "
                    + appointmentDetails.ElementAt(5).ToString() + "\t" + "With "
                    + appointmentDetails.ElementAt(1).ToString());
            }
        }

        private List<string> GetAppointmentDetails(int index)
        {
            List<string> appointment_details = new List<string>();

            DateTime dateTime_apptmt_start_time = DateTime.Parse(scheduleSlotDataSet.Tables["ScheduleSlot"].Rows[index].ItemArray[2].ToString());
            appointment_details.Add(dateTime_apptmt_start_time.ToShortTimeString());

            staffIDParam = Convert.ToInt32(scheduleSlotDataSet.Tables["ScheduleSlot"].Rows[index].ItemArray[5].ToString());
            singleStaffTableAdapter.Fill(singleStaffDataSet.Staff, staffIDParam);
            appointment_details.Add(singleStaffDataSet.Tables["Staff"].Rows[0].ItemArray[1].ToString() + " "
                + singleStaffDataSet.Tables["Staff"].Rows[0].ItemArray[2].ToString());

            apptmtIDParam = Convert.ToInt32(scheduleSlotDataSet.Tables["ScheduleSlot"].Rows[index].ItemArray[6].ToString());
            appointment_details.Add(apptmtIDParam.ToString());
            this.appointmentTableAdapter.FillByApptmtID(appointmentDataSet.Appointment, apptmtIDParam);

            apptmt_confirmed_bool = Convert.ToBoolean(appointmentDataSet.Tables["Appointment"].Rows[0].ItemArray[2]);
            if (apptmt_confirmed_bool) { apptmt_confirmed = "Confirmed"; } else { apptmt_confirmed = "Unconfirmed"; }
            appointment_details.Add(apptmt_confirmed);

            animalIDParam = Convert.ToInt32(appointmentDataSet.Tables["Appointment"].Rows[0].ItemArray[3].ToString());
            this.singleAnimalTableAdapter.Fill(singleAnimalDataSet.Animal, animalIDParam);
            appointment_details.Add(singleAnimalDataSet.Tables["Animal"].Rows[0].ItemArray[1].ToString());

            clientIDParam = Convert.ToInt32(singleAnimalDataSet.Tables["Animal"].Rows[0].ItemArray[6].ToString());
            this.singleClientTableAdapter.Fill(singleClientDataSet.Client, clientIDParam);
            appointment_details.Add(singleClientDataSet.Tables["Client"].Rows[0].ItemArray[1].ToString() + " "
                + singleClientDataSet.Tables["Client"].Rows[0].ItemArray[2].ToString());

            return appointment_details;
        }

        private void dtp_apptmts_fill_listbox_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(DateTime.Compare(dtp_apptmts_fill_listbox.Value.Date, DateTime.Today) >= 0)
                {
                    DateTime apptmts_day = DateTime.Parse(dtp_apptmts_fill_listbox.Text);
                    this.scheduleSlotTableAdapter.FillByDateForApptmts(this.scheduleSlotDataSet.ScheduleSlot, apptmts_day.ToShortDateString());
                    Fill_Appointments_Listbox();
                }
                else
                {
                    MessageBox.Show("You must pick a date later than today's date");
                    dtp_apptmts_fill_listbox.Value = DateTime.Today;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_open_appointment_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listbox_upcoming_appointments.SelectedIndex;
                Frm_Appointment_Details theAppointmentDetailsForm = new Frm_Appointment_Details(GetAppointmentDetails(index));
                theAppointmentDetailsForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_appointments_close_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
