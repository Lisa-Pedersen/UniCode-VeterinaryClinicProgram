
/* @class:          Frm_Staff
 * @description:    A Windows Form class that handles the Staff area of the program.  
 *                  This Windows Form window shows a list of Staff in a listbox that 
 *                  when clicked on shows the details of a specific staff member in a group of textboxes.
 *                  The user can add a new staff member, edit a staff member and delete a staff member in this window.
 *                  The user can also add specialities to a staff member by clicking a specialty in the Avaliable specialties
 *                  listbox then clicking the 'Add Specialty' button.  Similarly the user can remove a specialty from the 
 *                  staff member's specialty list by selecting a currently listed specialty from the staff specialties list
 *                  and clicking the 'Remove Specialty' button.
 *                  If a staff member is not a Veterinarian the area of the form related to specialties is disabled.
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
    public partial class Frm_Staff : Form
    {
        // a class variable that is set to false when editing a staff member.
        private bool newStaff = true;
        
        /* @method:         Frm_Staff
         * @description:    Method that initialises the Frm_Clients form window when created.   
         * @param:          none
         */
        public Frm_Staff()
        {
            InitializeComponent();
        }

        /* @method:         Frm_Staff_Load
         * 
         * @description:    Method that is called when the Frm_Staff window is shown.
         *                  When the Frm_Staff window is loaded we fill the Staff DataGridView
         *                  with a list of staff from the database.
         * 
         * @param:          object      sender      automated parameter that is 
         *                                              the object that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void Frm_Staff_Load(object sender, EventArgs e)
        {
            try
            {
                this.staffTableAdapter.Fill(this.staffDataSet.Staff);
                Load_AllStaff_Listbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* @method:         Load_AllStaff_Listbox
         * 
         * @description:    Method used to load the listbox_AllStaff with 
         *                  the staff that are in the dataset.
         * 
         * @param:          none
         */
        private void Load_AllStaff_Listbox()
        {
            String staffDetails = "";
            listbox_AllStaff.Items.Clear();

            for (int i = 0; i < staffDataSet.Tables["Staff"].Rows.Count; i++)
            {
                string name = staffDataSet.Tables["Staff"].Rows[i].ItemArray[1].ToString() + " " +
                    staffDataSet.Tables["Staff"].Rows[i].ItemArray[2].ToString();
                string role = staffDataSet.Tables["Staff"].Rows[i].ItemArray[3].ToString();
                staffDetails = name.PadRight(50 - name.Length) + '\t' + role;
                listbox_AllStaff.Items.Add(staffDetails);
            }
        }
        
        /* @method:         btn_find_staff_Click
         * 
         * @description:    Click method for the btn_find_staff 'Find' button.
         *                  Fills the staff table adapter with the appropriate records that match the
         *                  text in the searchbox then reload the listbox with the records.
         *                  The btn_reset_staff_listbox button is then enabled to allow the user the ability
         *                  to reset the listbox.
         * 
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void btn_find_staff_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_staff_name_searchbox.TextLength > 0) 
                {
                    staffTableAdapter.FillByStaffName(staffDataSet.Staff, txt_staff_name_searchbox.Text);
                    Load_AllStaff_Listbox();
                    txt_staff_name_searchbox.Clear();
                    btn_reset_staff_listbox.Enabled = true;
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        /* @method:         btn_reset_staff_listbox_Click
         * 
         * @description:    Click method for the btn_reset_staff_listbox 'Reset' button.
         * 
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void btn_reset_staff_listbox_Click(object sender, EventArgs e)
        {
            try
            {
                staffTableAdapter.Fill(staffDataSet.Staff);
                Load_AllStaff_Listbox();
                txt_staff_name_searchbox.Clear();
                btn_reset_staff_listbox.Enabled = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        /* @method:        lisbox_AllStaff_Click
         * 
         * @description:    A listbox SelectedValueChanged method for when the Staff listbox is clicked.
         *                  Gets the staff id of the specific staff member that is clicked in the listbox
         *                  then fills the textboxes with the appropriate staff's data from the database.
         *                  Also fills the staff's specialty listbox with the client's specialties.
         *                  Now that there is a specific staff member displayed, the SaveStaff, ClearDetails and
         *                  DeleteStaff buttons are enabled.  Also sets the newStaff variable to false incase
         *                  the user wants to save any changes to the staff's information.
         *                  Also if the staff member is a Veterinarian, we enable the Staff Specialties area of the form
         *                  otherwise Staff Specialties are redundant so we disable them.
         * 
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void listbox_AllStaff_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listbox_AllStaff.SelectedIndex;
                int staffID = Convert.ToInt32(staffDataSet.Tables["Staff"].Rows[index].ItemArray[0].ToString());
                singleStaffTableAdapter.Fill(singleStaffDataSet.Staff, staffID);

                btn_staff_clear.Enabled = true;
                btn_staff_delete.Enabled = true;
                newStaff = false;
                singleSpecialtyTableAdapter.Fill(singleSpecialtyDataSet.Specialty, "");

                string role = singleStaffDataSet.Tables["Staff"].Rows[0].ItemArray[3].ToString();
                if (role.Equals("Veterinarian"))
                {
                    singleStaffSpecialtyTableAdapter.Fill(singleStaffSpecialtyDataSet.Specialty, staffID);
                    Load_StaffSpecialties_Listbox();

                    specialtyTableAdapter.Fill(specialtyDataSet.Specialty, staffID);
                    Load_Specialty_Listbox();

                    groupbox_Specialties.Enabled = true;
                    listbox_singleStaff_specialties.Enabled = true;
                }
                else
                {
                    listbox_singleStaff_specialties.Items.Clear();
                    listbox_avaliable_specialties.Items.Clear();
                    groupbox_Specialties.Enabled = false;
                    listbox_singleStaff_specialties.Enabled = false;
                    btn_specialty_remove.Enabled = false;
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        /* @method:         Load_StaffSpecialties_Listbox
         * 
         * @description:    Method used to load the listbox_singleStaff_specialties with 
         *                  the staff specialties that are in the dataset.
         * 
         * @param:          none
         */
        private void Load_StaffSpecialties_Listbox()
        {
            string name = "";
            listbox_singleStaff_specialties.Items.Clear();

            for (int i = 0; i < singleStaffSpecialtyDataSet.Tables["Specialty"].Rows.Count; i++)
            {
                name = singleStaffSpecialtyDataSet.Tables["Specialty"].Rows[i].ItemArray[1].ToString();
                listbox_singleStaff_specialties.Items.Add(name);
            }
        }

        /* @method:         Load_StaffSpecialties_Listbox
         * 
         * @description:    Method used to load the listbox_singleStaff_specialties with 
         *                  the staff specialties that are in the dataset.
         * 
         * @param:          none
         */
        private void Load_Specialty_Listbox()
        {
            string specialty = "";
            listbox_avaliable_specialties.Items.Clear();

            for (int i = 0; i < specialtyDataSet.Tables["Specialty"].Rows.Count; i++)
            {
                specialty = specialtyDataSet.Tables["Specialty"].Rows[i].ItemArray[1].ToString();
                listbox_avaliable_specialties.Items.Add(specialty);
            }
        }

        /* @method:        btn_staff_save_Click
         * 
         * @description:    A Click method for when the btn_staff_save 'Save Staff' button is clicked.
         *                  First we check if the user is saving a new client or saving changes to an 
         *                  existing client.
         *                  If user is adding a new staff member create a new row, adding data then update
         *                  the database, if editing an existing staff member update the database.
         *                  Then refresh the Staff DataGridView and clear the textboxes.
         * 
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void btn_staff_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (newStaff)
                {
                    // Create new row for the Staff member's dataset
                    DataRow newStaffRow = singleStaffDataSet.Tables["Staff"].NewRow();

                    // Get values from input controls and put into the new row
                    newStaffRow["first_name"] = CheckIfNull(txt_staff_first_name.Text);
                    newStaffRow["last_name"] = CheckIfNull(txt_staff_last_name.Text);
                    newStaffRow["staff_role"] = CheckIfNull(comboBox_staff_role.Text);

                    // Add the row to the dataset and then update the database with the new information
                    singleStaffDataSet.Tables["Staff"].Rows.Add(newStaffRow);
                    singleStaffTableAdapter.Update(singleStaffDataSet);
                }
                else
                {
                    // Else when editing a staff member we need to update the database when the save button is clicked
                    this.Validate();
                    singleStaffBindingSource.EndEdit();
                    singleStaffTableAdapter.Update(singleStaffDataSet);
                }

                // Retrieve a refreshed copy of data from database then call the ClearStaffInformation method.
                staffTableAdapter.Fill(staffDataSet.Staff);
                Load_AllStaff_Listbox();
                ClearStaffInformation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Object CheckIfNull(string text)
        {
            if (String.IsNullOrEmpty(text)) return DBNull.Value; else return text;
        }

        /* @method:         ClearStaffInformation
         * 
         * @description:    Loops through all controls, if the control is a textbox
         *                  it is cleared of text.
         *                  Because Staff information is cleared we disable the addSpecialty,
         *                  clearDetails, and DeleteStaff buttons and enable the SaveStaff
         *                  button.  
         *                  Then the Specialty DataGridView is cleared and the newStaff
         *                  variable is set to true in case we save a new staff's data.
         * 
         * @param:          none
         */
        private void ClearStaffInformation()
        {
            foreach (Control c in this.groupBox_staff_details.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Clear();
                }
                else if (c is ComboBox)
                {
                    (c as ComboBox).SelectedIndex = -1;
                }
            }

            btn_staff_clear.Enabled = false;
            btn_staff_delete.Enabled = false;
            btn_staff_save.Enabled = true;
            listbox_singleStaff_specialties.Items.Clear();
            listbox_avaliable_specialties.Items.Clear();
            btn_specialty_add.Enabled = false;
            btn_specialty_remove.Enabled = false;
            singleSpecialtyTableAdapter.Fill(singleSpecialtyDataSet.Specialty, "");

            newStaff = true;
        }

        /* @method:         btn_staff_clear_Click
         * 
         * @description:    Click method for the btn_staff_clear 'Clear Details' button.
         *                  Calls on the ClearStaffInformation method.
         * 
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void btn_staff_clear_Click(object sender, EventArgs e)
        {
            try
            {
                ClearStaffInformation();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        /* @method:         btn_staff_delete_Click
         * 
         * @description:    Click method for the btn_staff_delete 'Delete Staff' button.
         *                  When deleting a staff member, the specialties that are connected to the 
         *                  staff member are first deleted from the database in the StaffSpecialty table,
         *                  then the staff member itself is deleted from the database.
         *                  Then the Staff's DataGridView is reset to show the change.
         *                  Then the textboxes and buttons are cleared.
         *                  
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void btn_staff_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int staffIDParam = Convert.ToInt32(singleStaffDataSet.Tables["Staff"].Rows[0].ItemArray[0].ToString());
                staffSpecialtyTableAdapter.DeleteByStaffID(staffIDParam);
                singleStaffTableAdapter.DeleteQuery(staffIDParam);
                
                staffTableAdapter.Fill(staffDataSet.Staff);
                Load_AllStaff_Listbox();
                ClearStaffInformation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* @method:         Specialties_Listboxes_Click
         * 
         * @description:    Click method for the specialties listboxes, both the 
         *                  listbox_singleStaff_specialties and the listbox_avaliable_specialties.
         *                  The Specialty details textboxes are filled out with the appropriate
         *                  data from either table. 
         *                  In addition depending on which listbox is clicked, will depend on which button
         *                  is enabled.  IE: the 'Add Specialty' button or 'Remove Specialty' button.
         *                  
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void Specialties_Listboxes_Click(object sender, EventArgs e)
        {
            try
            {
                int index = 0;
                string specialty_code = ""; 
                if (sender.Equals(listbox_singleStaff_specialties))
                {
                    index = listbox_singleStaff_specialties.SelectedIndex;
                    specialty_code = singleStaffSpecialtyDataSet.Tables["Specialty"].Rows[index].ItemArray[0].ToString();

                    btn_specialty_remove.Enabled = true;
                    btn_specialty_add.Enabled = false;
                }
                else if (sender.Equals(listbox_avaliable_specialties))
                {
                    index = listbox_avaliable_specialties.SelectedIndex;
                    specialty_code = specialtyDataSet.Tables["Specialty"].Rows[index].ItemArray[0].ToString();

                    btn_specialty_add.Enabled = true;
                    btn_specialty_remove.Enabled = false;
                }

                singleSpecialtyTableAdapter.Fill(singleSpecialtyDataSet.Specialty, specialty_code);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* @method:         btn_specialty_add_Click
         * 
         * @description:    Click method for the btn_specialty_add 'Add Specialty' button.
         *                  When clicked it will get the staff member that we are adding the 
         *                  specialty to then adds the specialty to that staff member
         *                  
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void btn_specialty_add_Click(object sender, EventArgs e)
        {
            try
            {
                int staffIDParam = Convert.ToInt32(singleStaffDataSet.Tables["Staff"].Rows[0].ItemArray[0].ToString());
                staffSpecialtyTableAdapter.Fill(staffSpecialtyDataSet.StaffSpecialty, staffIDParam);

                int index = listbox_avaliable_specialties.SelectedIndex;
                string specialtyCode = specialtyDataSet.Tables["Specialty"].Rows[index].ItemArray[0].ToString();
                
                DataRow newStaffSpecialtyRow = staffSpecialtyDataSet.Tables["StaffSpecialty"].NewRow();
                newStaffSpecialtyRow["staff_id"] = staffIDParam;
                newStaffSpecialtyRow["specialty_code"] = specialtyCode;
                staffSpecialtyDataSet.Tables["StaffSpecialty"].Rows.Add(newStaffSpecialtyRow);
                staffSpecialtyTableAdapter.Update(staffSpecialtyDataSet);

                singleStaffSpecialtyTableAdapter.Fill(singleStaffSpecialtyDataSet.Specialty, staffIDParam);
                Load_StaffSpecialties_Listbox();
                specialtyTableAdapter.Fill(specialtyDataSet.Specialty, staffIDParam);
                Load_Specialty_Listbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* @method:         btn_specialty_remove_Click
         * 
         * @description:    Click method for the btn_specialty_remove 'Remove Specialty' button.
         *                  When clicked it will get the staff member that we are removing the 
         *                  specialty from then removes the specialty from that staff members records.
         *                  
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void btn_specialty_remove_Click(object sender, EventArgs e)
        {
            int staffIDParam = Convert.ToInt32(singleStaffDataSet.Tables["Staff"].Rows[0].ItemArray[0].ToString());
            
            int index = listbox_singleStaff_specialties.SelectedIndex;
            string specialtyCode = singleStaffSpecialtyDataSet.Tables["Specialty"].Rows[index].ItemArray[0].ToString();

            staffSpecialtyTableAdapter.DeleteUniqueEntry(staffIDParam, specialtyCode);

            singleStaffSpecialtyTableAdapter.Fill(singleStaffSpecialtyDataSet.Specialty, staffIDParam);
            Load_StaffSpecialties_Listbox();
            specialtyTableAdapter.Fill(specialtyDataSet.Specialty, staffIDParam);
            Load_Specialty_Listbox();

        }

        /* @method:         btn_staff_close_Click
         * 
         * @description:    Click method for the btn_staff_close 'Close' button.
         *                  Closes the Staff Windows Form window, which takes the user back to the
         *                  Frm_Menu window.
         *                  
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void btn_staff_close_Click(object sender, EventArgs e)
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

        /* @method:         Staff_Details_TextChanged
         * 
         * @description:    Method for if the text is changed in the Staff Details textboxes.
         *                  If Staff Details is amended then the 'Clear Details' button is 
         *                  Enabled.
         *                  
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void Staff_Details_TextChanged(object sender, EventArgs e)
        {
            if (!btn_staff_clear.Enabled)
            {
                btn_staff_clear.Enabled = true;
            }
            
        }

    } // END: Partial Class: Frm_Staff
} // END: Namespace VeterinaryClinicDatabase