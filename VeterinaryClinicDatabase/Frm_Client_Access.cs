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
    public partial class Frm_Client_Access : Form
    {
        private int clientID;
        private bool addAnimal;
        private int staffID;
        private bool dobDateChanged;

        public Frm_Client_Access(int clientID)
        {
            InitializeComponent();
            this.clientID = clientID;
            addAnimal = true;
        }

        private void Frm_Client_Access_Load(object sender, EventArgs e)
        {
            try
            {
                dobDateChanged = false;
                singleClientTableAdapter.Fill(singleClientDataSet.Client, clientID);
                string clientname = singleClientDataSet.Tables["Client"].Rows[0].ItemArray[1].ToString() +
                    " " + singleClientDataSet.Tables["Client"].Rows[0].ItemArray[2].ToString();

                lbl_Client_name.Text = "Hello " + clientname;

                animalTableAdapter.Fill(animalDataSet.Animal, clientID);
                Load_Animal_Listbox();
                staffTableAdapter.FillOnlyVeterinarians(staffDataSet.Staff);
                Load_AllVeterinarians_ComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Load_Animal_Listbox()
        {
            listbox_singleclient_animals.Items.Clear();
            string animaldetails = "";

            for (int i = 0; i < animalDataSet.Tables["Animal"].Rows.Count; i++)
            {
                animaldetails = animalDataSet.Tables["Animal"].Rows[i].ItemArray[1].ToString() + '\t'
                    + animalDataSet.Tables["Animal"].Rows[i].ItemArray[2].ToString() + '\t'
                    + animalDataSet.Tables["Animal"].Rows[i].ItemArray[4].ToString();
                listbox_singleclient_animals.Items.Add(animaldetails);
            }
        }

        private void Load_AllVeterinarians_ComboBox()
        {
            comboBox_appointment_staff.Items.Clear();
            string staffname = "";
            for (int i = 0; i < staffDataSet.Tables["Staff"].Rows.Count; i++)
            {
                staffname = staffDataSet.Tables["Staff"].Rows[i].ItemArray[1].ToString() + " " +
                    staffDataSet.Tables["Staff"].Rows[i].ItemArray[2].ToString();
                comboBox_appointment_staff.Items.Add(staffname);
            }
        }

        private void listbox_singleclient_animals_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int index = listbox_singleclient_animals.SelectedIndex;
                int animalID = Convert.ToInt32(animalDataSet.Tables["Animal"].Rows[index].ItemArray[0].ToString());

                singleAnimalTableAdapter.Fill(singleAnimalDataSet.Animal, animalID);

                btn_singleclient_saveanimal.Text = "Save Changes";
                addAnimal = false;

                groupBox_appointment_details.Enabled = true;
                string animalname = singleAnimalDataSet.Tables["Animal"].Rows[0].ItemArray[1].ToString();
                groupBox_appointment_details.Text = "Add Appointment For " + animalname;
                lbl_upcoming_appointments.Text = "Upcoming Appointments For " + animalname;

                listBox_upcoming_appointments.Items.Clear();

                scheduleSlotTableAdapter.FillByAnimalDate(scheduleSlotDataSet.ScheduleSlot, animalID);
                Load_upcoming_appointments_listbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Load_upcoming_appointments_listbox()
        {
            try
            {
                string apptmtsRecord = "";
                int apptmtsStaffID = 0;
                string staffname = "";
                DateTime apptmtDate;
                DateTime apptmt_start_time;
                DateTime apptmt_end_time;
                listBox_upcoming_appointments.Items.Clear();

                for (int i = 0; i < scheduleSlotDataSet.Tables["ScheduleSlot"].Rows.Count; i++)
                {
                    apptmtsStaffID = Convert.ToInt32(scheduleSlotDataSet.Tables["ScheduleSlot"].Rows[i].ItemArray[5].ToString());
                    singleStaffTableAdapter.Fill(singleStaffDataSet.Staff, apptmtsStaffID);
                    staffname = singleStaffDataSet.Tables["Staff"].Rows[0].ItemArray[1].ToString() + " "
                        + singleStaffDataSet.Tables["Staff"].Rows[0].ItemArray[2].ToString();

                    apptmtDate = DateTime.Parse(scheduleSlotDataSet.Tables["ScheduleSlot"].Rows[i].ItemArray[1].ToString());
                    apptmt_start_time = DateTime.Parse(scheduleSlotDataSet.Tables["ScheduleSlot"].Rows[i].ItemArray[2].ToString());
                    apptmt_end_time = DateTime.Parse(scheduleSlotDataSet.Tables["ScheduleSlot"].Rows[i].ItemArray[3].ToString());

                    apptmtsRecord = apptmtDate.ToLongDateString().PadRight(50 - apptmtDate.ToLongDateString().Length) + "\t"
                        + apptmt_start_time.ToShortTimeString() + "\t To "
                        + apptmt_end_time.ToShortTimeString() + "\t With "
                        + staffname;
                    listBox_upcoming_appointments.Items.Add(apptmtsRecord);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_singleclient_save_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                singleClientBindingSource.EndEdit();
                singleClientTableAdapter.Update(singleClientDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_singleclient_clearanimal_details_Click(object sender, EventArgs e)
        {
            try
            {
                Clear_Animal_Details();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear_Animal_Details()
        {
            foreach (Control c in this.grpbox_singleclient_animals.Controls)
            {
                if(c is TextBox)
                {
                    (c as TextBox).Clear();
                }
                else if (c is ComboBox)
                {
                    (c as ComboBox).SelectedIndex = -1;
                }
            }

            btn_singleclient_saveanimal.Text = "Add Animal";
            addAnimal = true;
            dobDateChanged = false;
            groupBox_appointment_details.Enabled = false;
            listBox_upcoming_appointments.Items.Clear();
        }

        private void btn_singleclient_saveanimal_Click(object sender, EventArgs e)
        {
            if (addAnimal)
            {
                DataRow newAnimalRow = singleAnimalDataSet.Tables["Animal"].NewRow();

                newAnimalRow["animal_name"] = CheckIfNull(animal_nameTextBox.Text);
                newAnimalRow["breed"] = CheckIfNull(breedTextBox.Text);
                newAnimalRow["category"] = CheckIfNull(categoryTextBox.Text);
                newAnimalRow["sex"] = CheckIfNull(sexComboBox.Text);
                if (dobDateChanged) { newAnimalRow["dob"] = Convert.ToDateTime(dobDateTimePicker.Text); } else { newAnimalRow["dob"] = DBNull.Value; }
                newAnimalRow["animal_owner"] = clientID;

                singleAnimalDataSet.Tables["Animal"].Rows.Add(newAnimalRow);
                singleAnimalTableAdapter.Update(singleAnimalDataSet.Animal);
            }
            else
            {
                this.Validate();
                singleAnimalBindingSource.EndEdit();
                singleAnimalTableAdapter.Update(singleAnimalDataSet);
            }

            animalTableAdapter.Fill(animalDataSet.Animal, clientID);
            Load_Animal_Listbox();
            Clear_Animal_Details();
        }

        private Object CheckIfNull(string text)
        {
            if (String.IsNullOrEmpty(text)) return DBNull.Value; else return text;
        }

        private void comboBox_appointment_staff_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                listbox_appointment_staffSpecialties.Items.Clear();
                specialty_descriptionTextBox.Clear();
                int index = comboBox_appointment_staff.SelectedIndex;
                staffID = Convert.ToInt32(staffDataSet.Tables["Staff"].Rows[index].ItemArray[0].ToString());

                string specialty;

                singleStaffSpecialtyTableAdapter.Fill(singleStaffSpecialtyDataSet.Specialty, staffID);
                for (int i = 0; i < singleStaffSpecialtyDataSet.Tables["Specialty"].Rows.Count; i++)
                {
                    specialty = singleStaffSpecialtyDataSet.Tables["Specialty"].Rows[i].ItemArray[1].ToString();
                    listbox_appointment_staffSpecialties.Items.Add(specialty);
                }

                Load_appointment_times_listbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listbox_appointment_staffSpecialties_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = listbox_appointment_staffSpecialties.SelectedIndex;
            string specialty_code = singleStaffSpecialtyDataSet.Tables["Specialty"].Rows[index].ItemArray[0].ToString();

            singleSpecialtyTableAdapter.Fill(singleSpecialtyDataSet.Specialty, specialty_code);
        }


        private void dtp_appointment_date_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Load_appointment_times_listbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Load_appointment_times_listbox()
        {
            listbox_appointment_scheduleslots.Items.Clear();
            DateTime appointmentDate = dtp_appointment_date.Value;
            scheduleSlotTableAdapter.FillByDate(scheduleSlotDataSet.ScheduleSlot, appointmentDate.ToShortDateString(), staffID);
            
            DateTime apptmtStartTime;
            DateTime apptmtEndTime;
            string appointmentEntry;
            listbox_appointment_scheduleslots.Items.Clear();

            for (int i = 0; i < scheduleSlotDataSet.Tables["ScheduleSlot"].Rows.Count; i++)
            {
                apptmtStartTime = DateTime.Parse(scheduleSlotDataSet.Tables["ScheduleSlot"].Rows[i].ItemArray[2].ToString());
                apptmtEndTime = DateTime.Parse(scheduleSlotDataSet.Tables["ScheduleSlot"].Rows[i].ItemArray[3].ToString());

                appointmentEntry = apptmtStartTime.ToShortTimeString() + "\t To  " + apptmtEndTime.ToShortTimeString();

                listbox_appointment_scheduleslots.Items.Add(appointmentEntry);
            }
        }

        private void btn_add_appointment_Click(object sender, EventArgs e)
        {
            try
            {
                int apptmtAnimalID = Convert.ToInt32(singleAnimalDataSet.Tables["Animal"].Rows[0].ItemArray[0].ToString());
                int? apptmtID =  null;
                appointmentTableAdapter.Insert(apptmtAnimalID, ref apptmtID);

                int index = listbox_appointment_scheduleslots.SelectedIndex;
                scheduleSlotDataSet.Tables["ScheduleSlot"].Rows[index]["apptmt_booked"] = apptmtID;
                scheduleSlotTableAdapter.Update(scheduleSlotDataSet.ScheduleSlot);

                scheduleSlotTableAdapter.FillByAnimalDate(scheduleSlotDataSet.ScheduleSlot,apptmtAnimalID);
                Load_upcoming_appointments_listbox();
                
                Clear_Appointment_Details();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear_Appointment_Details()
        {
            comboBox_appointment_staff.SelectedIndex = 0;
            listbox_appointment_staffSpecialties.Items.Clear();
            specialty_descriptionTextBox.Clear();
            listbox_appointment_scheduleslots.Items.Clear();
            groupBox_appointment_details.Enabled = false;
        }

        private void dobDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dobDateChanged = true;
        }

        private void btn_client_access_logout_Click(object sender, EventArgs e)
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
