
/* @class:          Frm_Menu
 * @description:    A Windows Form class that handles the menu for the program.  
 *                  The menu gives the user access to the Client and Staff areas 
 *                  of the program.  This is the main form of the program.
 *                  Also can automatically generate ScheduleSlots for the database.
 * @author:         Lisa Pedersen
 * @version:        1.0
 * @date            April 2016
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
    public partial class frm_menu : Form
    {
        bool isOfficeStaff;
        
        /* @method:         frm_menu
         * @description:    Method that initialises the Frm_Menu form window when created.   
         * @param:          none
         */
        public frm_menu(bool isOfficeStaff)
        {
            InitializeComponent();
            this.isOfficeStaff = isOfficeStaff;
        }


        private void frm_menu_Load(object sender, EventArgs e)
        {
            if(!isOfficeStaff)
            {
                btn_menu_schedule.Visible = false;
            }
        }


        /* @method:         btn_menu_clients_click
         * @description:    Button click method for the Clients menu button 
         *                  that creates and shows the Frm_Clients Windows Form window.   
         * @param:          object      sender      automated parameter that is 
         *                                          the object that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                          about the click event.
         */
        private void btn_menu_clients_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Clients theClientsForm = new Frm_Clients();
                theClientsForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* @method:         btn_menu_staff_Click
         * @description:    Button click method for the Staff menu button
         *                  that creates and shows the Frm_Staff Windows Form window.
         * @param:          object      sender      automated parameter that is 
         *                                          the object that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                          about the click event.
         */
        private void btn_menu_staff_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Staff theStaffForm = new Frm_Staff();
                theStaffForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* @method:         btn_menu_Exit_Cick
         * @description:    Button click method for the Exit menu button
         *                  that closes this Frm_Menu Windows Form window.
         * @param:          object      sender      automated parameter that is 
         *                                          the object that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                          about the click event.
         */
        private void btn_menu_Exit_Click(object sender, EventArgs e)
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
        

        private void btn_menu_schedule_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Schedule theStaffScheduleForm = new Frm_Schedule();
                theStaffScheduleForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_menu_appointments_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Appointments theAppointmentsForm = new Frm_Appointments();
                theAppointmentsForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_menu_invoices_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Invoices theInvoicesForm = new Frm_Invoices();
                theInvoicesForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    } // END: Partial Class: Frm_Menu
} // END: Namespace VeterinaryClinicDatabase
