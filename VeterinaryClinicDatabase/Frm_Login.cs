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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
           try 
           {
                string userlogin = txtbox_client_login.Text;

                if (userlogin.Equals("Staff"))
                {
                    frm_menu theMenuForm = new frm_menu(false);
                    theMenuForm.ShowDialog();
                }
                else if (userlogin.Equals("OfficeStaff"))
                {
                    frm_menu theMenuForm = new frm_menu(true);
                    theMenuForm.ShowDialog();
                }
                else
                {
                    System.Net.Mail.MailAddress userEmail = new System.Net.Mail.MailAddress(userlogin);
                    singleClientTableAdapter.FillByClientEmail(singleClientDataSet.Client, userEmail.Address);

                    if (singleClientDataSet.Tables["Client"].Rows.Count > 0)
                    {
                        int clientID = Convert.ToInt32(singleClientDataSet.Tables["Client"].Rows[0].ItemArray[0].ToString());
                        Frm_Client_Access theClientAccessForm = new Frm_Client_Access(clientID);
                        theClientAccessForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("There is no user registered in the system with that email address.");
                    }
                }
           }
            catch (Exception ex)
           {
                MessageBox.Show(ex.Message);
           }
        }

        private void btn_login_register_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Client_Registration theClientRegistrationForm = new Frm_Client_Registration();
                theClientRegistrationForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_login_exit_Click(object sender, EventArgs e)
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
