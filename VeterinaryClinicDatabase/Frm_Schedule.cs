
/* @class:          Frm_Schedule
 * @description:    A Windows Form class that handles the StaffScheduling area of the program.  
 *                  
 *                  By clicking close the Window will close bringing the user back to the Menu window.
 * 
 * @author:         Lisa Pedersen
 * @version:        1.1
 * @date            May 2016
 */

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
    public partial class Frm_Schedule : Form
    {
        public Frm_Schedule()
        {
            InitializeComponent();
        }

        private void Frm_Schedule_Load(object sender, EventArgs e)
        {
            try
            {
                // Display the date in the datetimepicker as "February 2001".
                dtp_schedule_avaliable_month.CustomFormat = "MMMM yyyy";
                // set the datetimepicker to be todays month initially
                dtp_schedule_avaliable_month.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 01);
                
                dtp_consult_start_time.CustomFormat = "h':'mm tt";
                dtp_consult_end_time.CustomFormat = "h':'mm tt";

                scheduleSlotTableAdapter.FillByMonthYear(scheduleSlotDataSet.ScheduleSlot, DateTime.Today.Month, DateTime.Today.Year);
                Load_listbox_schedule_slots();
                
                // Get all veterinarians from the database and fill the combobx_staff_on_duty
                staffTableAdapter.FillOnlyVeterinarians(staffDataSet.Staff);
                Load_AllVeterinarians_ComboBox();
                // Load the room combobox with the relevant entries, based on the date.
                loadRoomComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       /* @method:         Load_AllVeterinarians_DropDown
        * 
        * @description:    Method used to load the combobx_scheduling_veterinarians with 
        *                  the staff members that are in the dataset.
        * 
        * @param:          none
        */
        private void Load_AllVeterinarians_ComboBox()
        {
            combobx_staff_on_duty.Items.Clear();
            string staffname = "";
            for (int i = 0; i < staffDataSet.Tables["Staff"].Rows.Count; i++)
            {
                staffname = staffDataSet.Tables["Staff"].Rows[i].ItemArray[1].ToString() + " " +
                    staffDataSet.Tables["Staff"].Rows[i].ItemArray[2].ToString();
                combobx_staff_on_duty.Items.Add(staffname);
            }
        }

       /* @method:         btn_load_schedule_slots_Click
        * 
        * @description:    Click method used to load the listbox_avaliable_schedule_slots with 
        *                  the schedule slots not in the database when the 'Load' button is clicked.  
        * 
        * @param:          object      sender      automated parameter that is 
        *                                              the object that calls on this method.
        *                 EventArgs   e           automated parameter that holds information
        *                                              about the click event.
        */
        private void btn_load_schedule_slots_Click(object sender, EventArgs e)
        {
            try
            {
                int month = dtp_schedule_avaliable_month.Value.Month;
                int year = dtp_schedule_avaliable_month.Value.Year;

                scheduleSlotTableAdapter.FillByMonthYear(scheduleSlotDataSet.ScheduleSlot, month, year);
                Load_listbox_schedule_slots();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       /* @method:         Load_listbox_schedule_slots
        * 
        * @description:    Method that, when called, will load the relevant scheduleslots for the
        *                  month.  The scheduleSlotTableAdapter.FillByMonthYear needs to be 
        *                  called first.  
        * 
        * @param:          object      sender      automated parameter that is 
        *                                              the object that calls on this method.
        *                 EventArgs   e           automated parameter that holds information
        *                                              about the click event.
        */
        private void Load_listbox_schedule_slots()
        {
            
            string scheduleSlot_listbox_entry = "";
            listbox_schedule_slots.Items.Clear();

            string scheduleSlotDate = "";
            string scheduleSlotRoom = "";
            string staffOnDutyName = "";
            
            for (int i = 0; i < scheduleSlotDataSet.Tables["ScheduleSlot"].Rows.Count; i++)
            {
                DateTime scheduleSlotDateTime = 
                    DateTime.Parse(scheduleSlotDataSet.Tables["ScheduleSlot"].Rows[i].ItemArray[1].ToString());
                scheduleSlotDate = scheduleSlotDateTime.ToLongDateString();

                scheduleSlotRoom = scheduleSlotDataSet.Tables["ScheduleSlot"].Rows[i].ItemArray[4].ToString();
                
                singleStaffTableAdapter.Fill(singleStaffDataSet.Staff, 
                    Convert.ToInt32(scheduleSlotDataSet.Tables["ScheduleSlot"].Rows[i].ItemArray[5]));
                staffOnDutyName = singleStaffDataSet.Tables["Staff"].Rows[0].ItemArray[1].ToString() + " " +
                    singleStaffDataSet.Tables["Staff"].Rows[0].ItemArray[2].ToString();

                scheduleSlot_listbox_entry = scheduleSlotDate.PadRight(50 - scheduleSlotDate.Length) 
                    + '\t' + scheduleSlotRoom + '\t' + staffOnDutyName;
                listbox_schedule_slots.Items.Add(scheduleSlot_listbox_entry);
            }
            Load_listbox_schedule_daysleft();
        }

        private void Load_listbox_schedule_daysleft()
        {
            listbox_schedule_daysleft.Items.Clear();
            
            int month = dtp_schedule_avaliable_month.Value.Month;
            int year = dtp_schedule_avaliable_month.Value.Year;

            scheduleSlotTableAdapter.FillByNumOfStaffAssignedinMonth(scheduleSlotDataSet.ScheduleSlot,month, year);

            int numOfDays = DateTime.DaysInMonth(year, month);
            DateTime loopDate = new DateTime(year, month, 01);
            DateTime scheduleDate;
            int numberOfEntries;
            int index = 0;

            for (int i = 0; i < numOfDays; i++)
            {
                if (index < scheduleSlotDataSet.Tables["ScheduleSlot"].Rows.Count)
                {
                    scheduleDate = DateTime.Parse(scheduleSlotDataSet.Tables["ScheduleSlot"].Rows[index].ItemArray[1].ToString());
                    numberOfEntries = Convert.ToInt32(scheduleSlotDataSet.Tables["ScheduleSlot"].Rows[index]["num_staff_assigned"].ToString());
                    
                    if (loopDate.Day == scheduleDate.Day)
                    {
                        if (scheduleDate.DayOfWeek != DayOfWeek.Sunday && numberOfEntries < 2)
                        {
                            listbox_schedule_daysleft.Items.Add(scheduleDate.ToLongDateString());
                        }
                        else if (scheduleDate.DayOfWeek == DayOfWeek.Sunday && numberOfEntries < 1)
                        {
                            listbox_schedule_daysleft.Items.Add(scheduleDate.ToLongDateString());
                        }
                        
                        index++;
                    }
                    else
                    {
                        listbox_schedule_daysleft.Items.Add(loopDate.ToLongDateString());
                    }
                }
                else
                {
                    listbox_schedule_daysleft.Items.Add(loopDate.ToLongDateString());
                }
                loopDate = loopDate.AddDays(1);
            }
            scheduleSlotTableAdapter.FillByMonthYear(scheduleSlotDataSet.ScheduleSlot, month, year);
        }

       /* @method:         listbox_schedule_slots_SelectedValueChanged
        * 
        * @description:    Selected Value Changed method for the Schedule Slots listbox.
        *                  When the user selects a different entry in the listbox
        *                  the entry details are loaded into the Schedule Slots details area.
        * 
        * @param:          object      sender      automated parameter that is 
        *                                              the object that calls on this method.
        *                  EventArgs   e           automated parameter that holds information
        *                                              about the click event.
        */
        private void listbox_schedule_slots_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int index = listbox_schedule_slots.SelectedIndex;
                // Couldn't use Slot_id as the ScheduleSlotDataSet cannot retrieve it because of the GroupBy clause.
                string slot_date = scheduleSlotDataSet.Tables["ScheduleSlot"].Rows[index].ItemArray[1].ToString();
                string slot_room = scheduleSlotDataSet.Tables["ScheduleSlot"].Rows[index].ItemArray[4].ToString();
                singleScheduleSlotTableAdapter.Fill(singleScheduleSlotDataSet.ScheduleSlot, slot_date, slot_room);

                int staffID = Convert.ToInt32(singleScheduleSlotDataSet.Tables["ScheduleSlot"].Rows[0].ItemArray[5].ToString());
                singleStaffTableAdapter.Fill(singleStaffDataSet.Staff, staffID);

                string staffname = singleStaffDataSet.Tables["Staff"].Rows[0].ItemArray[1].ToString() + " " +
                    singleStaffDataSet.Tables["Staff"].Rows[0].ItemArray[2].ToString();
                combobx_staff_on_duty.Text = staffname;

                if(slot_room.Equals("consult"))
                {
                    dtp_consult_start_time.Value = DateTime.Parse(singleScheduleSlotDataSet.Tables["ScheduleSlot"].Rows[0].ItemArray[2].ToString());
                    dtp_consult_end_time.Value = DateTime.Parse(singleScheduleSlotDataSet.Tables["ScheduleSlot"].Rows[0].ItemArray[3].ToString());
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       /* @method:         btn_save_scheduleslot_Click
        * 
        * @description:    The click method for the btn_save_scheduleslot 'Save' button.
        *                  If the ScheduleSlot is being edited replace the record else
        *                  if it is a new scheduleslot add a new row with the correct
        *                  data to the database.
        * 
        * @param:          object      sender      automated parameter that is 
        *                                              the object that calls on this method.
        *                  EventArgs   e           automated parameter that holds information
        *                                              about the click event.
        */
        private void btn_save_scheduleslot_Click(object sender, EventArgs e)
        {
            try
            {
                string slot_date = slot_dateDateTimePicker.Value.ToShortDateString();
                string slot_room = roomComboBox.SelectedItem.ToString();

                int index = combobx_staff_on_duty.SelectedIndex;
                int staff_on_duty_id = Convert.ToInt32(staffDataSet.Tables["Staff"].Rows[index].ItemArray[0].ToString());

                singleScheduleSlotTableAdapter.Fill(singleScheduleSlotDataSet.ScheduleSlot, slot_date, slot_room);

                if (singleScheduleSlotDataSet.Tables["ScheduleSlot"].Rows.Count <= 0)
                {
                    DateTime startTime = new DateTime(1900, 1, 1, 8, 00, 00);
                    DateTime endTime = new DateTime(1900, 1, 1, 8, 30, 00);
                    DateTime closingTime = new DateTime(1900, 1, 1, 18, 00, 00);

                    if (slot_room.Equals("on-call"))
                    {
                        // Create new row for the ScheduleSlot dataset
                        DataRow newScheduleSlotRow = singleScheduleSlotDataSet.Tables["ScheduleSlot"].NewRow();

                        // Get values from input controls and put into the new row
                        newScheduleSlotRow["slot_date"] = slot_date;
                        newScheduleSlotRow["start_time"] = startTime.TimeOfDay;
                        newScheduleSlotRow["end_time"] = closingTime.TimeOfDay;
                        newScheduleSlotRow["room"] = slot_room;
                        newScheduleSlotRow["staff_on_duty"] = staff_on_duty_id;
                        newScheduleSlotRow["apptmt_booked"] = DBNull.Value;

                        // Add the row to the dataset
                        singleScheduleSlotDataSet.Tables["ScheduleSlot"].Rows.Add(newScheduleSlotRow);
                    }
                    else if (slot_room.Equals("consult"))
                    {
                        // Create new row for the ScheduleSlot dataset
                        DataRow newScheduleSlotRow = singleScheduleSlotDataSet.Tables["ScheduleSlot"].NewRow();

                        // Get values from input controls and put into the new row
                        newScheduleSlotRow["slot_date"] = slot_date;
                        newScheduleSlotRow["start_time"] = dtp_consult_start_time.Value.TimeOfDay;
                        newScheduleSlotRow["end_time"] = dtp_consult_end_time.Value.TimeOfDay;
                        newScheduleSlotRow["room"] = slot_room;
                        newScheduleSlotRow["staff_on_duty"] = staff_on_duty_id;
                        newScheduleSlotRow["apptmt_booked"] = DBNull.Value;

                        // Add the row to the dataset
                        singleScheduleSlotDataSet.Tables["ScheduleSlot"].Rows.Add(newScheduleSlotRow);
                    }
                    else
                    {
                        while (startTime < closingTime)
                        {
                            // Create new row for the ScheduleSlot dataset
                            DataRow newScheduleSlotRow = singleScheduleSlotDataSet.Tables["ScheduleSlot"].NewRow();

                            // Get values from input controls and put into the new row
                            newScheduleSlotRow["slot_date"] = slot_date;
                            newScheduleSlotRow["start_time"] = startTime.TimeOfDay;
                            newScheduleSlotRow["end_time"] = endTime.TimeOfDay;
                            newScheduleSlotRow["room"] = slot_room;
                            newScheduleSlotRow["staff_on_duty"] = staff_on_duty_id;
                            newScheduleSlotRow["apptmt_booked"] = DBNull.Value;

                            // Add the row to the dataset and then update the database with the new information
                            singleScheduleSlotDataSet.Tables["ScheduleSlot"].Rows.Add(newScheduleSlotRow);

                            // Shift startTime & endTime forward 30 mins each for next ScheduleSlot entry
                            startTime = startTime.Add(new TimeSpan(0, 30, 0));
                            endTime = endTime.Add(new TimeSpan(0, 30, 0));
                        }
                    }

                    singleScheduleSlotTableAdapter.Update(singleScheduleSlotDataSet.ScheduleSlot);
                }
                else
                {
                    string question = "There is already an assigned Slot for this room on this date. Are you sure you want to change the entry?";
                    string message = "IMPORTANT";

                    switch (MessageBox.Show(question, message, MessageBoxButtons.YesNo))
                    {
                        case DialogResult.Yes:
                            {
                                for (int i = 0; i < singleScheduleSlotDataSet.Tables["ScheduleSlot"].Rows.Count; i++)
                                {
                                    singleScheduleSlotDataSet.Tables["ScheduleSlot"].Rows[i]["staff_on_duty"] = staff_on_duty_id;
                                }
                                
                                singleScheduleSlotTableAdapter.Update(singleScheduleSlotDataSet.ScheduleSlot);
                                break;
                            }
                        case DialogResult.No:
                            {
                                break;
                            }
                    }
                }

                int month = dtp_schedule_avaliable_month.Value.Month;
                int year = dtp_schedule_avaliable_month.Value.Year;

                scheduleSlotTableAdapter.FillByMonthYear(scheduleSlotDataSet.ScheduleSlot, month, year);
                Load_listbox_schedule_slots();
                clear_inputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* @method:         clear_inputs
        * 
        * @description:    Method used to clear all the Schedule Slot 
        *                  Details.
        * 
        * @param:          none
        */
        private void clear_inputs()
        {
            foreach (Control c in this.grpbx_scheduleslot_details.Controls)
            {
                if (c is ComboBox)
                {
                    (c as ComboBox).SelectedIndex = -1;
                }
            }
            DateTime resetValue = new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day,8,0,0);
            dtp_consult_start_time.Value = resetValue;
            dtp_consult_end_time.Value = resetValue.AddMinutes(30);
            groupBox_consult_times.Enabled = false;
        }

        /* @method:         btn_schedule_close_Click
        * 
        * @description:    The click method for the btn_schedule_close 'Close' button.
        *                  Once the user is finished with the form and clicks close
         *                  the form will close showing the menu.
        * 
        * @param:          object      sender      automated parameter that is 
        *                                              the object that calls on this method.
        *                  EventArgs   e           automated parameter that holds information
        *                                              about the click event.
        */
        private void btn_schedule_close_Click(object sender, EventArgs e)
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

        /* @method:         roomComboBox_SelectedValueChanged
        * 
        * @description:    The SelectedValueChanged method for the roomComboBox.
        *                  If the roomComboBox is changed to 'consult' then the
        *                  consult groupbox with avaliable times is enabled.
        * 
        * @param:          object      sender      automated parameter that is 
        *                                              the object that calls on this method.
        *                  EventArgs   e           automated parameter that holds information
        *                                              about the click event.
        */
        private void roomComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (roomComboBox.Text.Equals("consult")) 
                { 
                    groupBox_consult_times.Enabled = true; 
                }
                else
                {
                    groupBox_consult_times.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       /* @method:         slot_dateDateTimePicker_ValueChanged
        * 
        * @description:    The ValueChanged method for the slot_dateTimePicker.
        *                  If the date is changed the date is checked to see if it is a Sunday.
        *                  If it isnt a Sunday all rooms and the consult options are available
        *                  in the roomcombobox dropdown list, otherwise if it is a Sunday
        *                  only on-call and consult are available.
        * 
        * @param:          object      sender      automated parameter that is 
        *                                              the object that calls on this method.
        *                  EventArgs   e           automated parameter that holds information
        *                                              about the click event.
        */
        private void slot_dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                loadRoomComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadRoomComboBox()
        {
            roomComboBox.Items.Clear();

            if (slot_dateDateTimePicker.Value.DayOfWeek != DayOfWeek.Sunday)
            {
                roomComboBox.Items.Add("1");
                roomComboBox.Items.Add("2");
                roomComboBox.Items.Add("3");
                roomComboBox.Items.Add("4");
                roomComboBox.Items.Add("consult");
            }
            else
            {
                roomComboBox.Items.Add("on-call");
                roomComboBox.Items.Add("consult");
            }
        }

        /* @method:         btn_schedule_clear_details_Click
         * 
         * @description:    Click method used to clear all the Schedule Slot 
         *                  Details.  Uses the Clear_Inputs method.
         * 
         * @param:          object      sender      automated parameter that is 
         *                                              the object that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void btn_schedule_clear_details_Click(object sender, EventArgs e)
        {
            try
            {
                clear_inputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listbox_schedule_daysleft_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                slot_dateDateTimePicker.Value = DateTime.Parse(listbox_schedule_daysleft.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    } // END: Partial Class: Frm_Schedule
} // END: Namespace VeterinaryClinicDatabase
