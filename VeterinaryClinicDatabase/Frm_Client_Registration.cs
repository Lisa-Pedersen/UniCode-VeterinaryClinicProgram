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
    public partial class Frm_Client_Registration : Form
    {
        private bool dobDateChanged;

        public Frm_Client_Registration()
        {
            InitializeComponent();
        }

        private void Frm_Client_Registration_Load(object sender, EventArgs e)
        {
            dobDateChanged = false;
        }

        private void btn_saveregistration_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newClientRow = singleClientDataSet.Tables["Client"].NewRow();
                
                newClientRow["first_name"] = CheckIfNull(first_nameTextBox.Text);
                newClientRow["last_name"] = CheckIfNull(last_nameTextBox.Text);
                newClientRow["contact_phone"] = CheckIfNull(contact_phoneTextBox.Text);
                newClientRow["email"] = CheckIfNull(emailTextBox.Text);
                newClientRow["street"] = CheckIfNull(streetTextBox.Text);
                newClientRow["suburb"] = CheckIfNull(suburbTextBox.Text);
                newClientRow["city"] = CheckIfNull(cityTextBox.Text);
                newClientRow["postcode"] = CheckIfNull(postcodeTextBox.Text);
                
                singleClientDataSet.Tables["Client"].Rows.Add(newClientRow);
                singleClientTableAdapter.Update(singleClientDataSet.Client);
                
                singleClientTableAdapter.FillByClientEmail(singleClientDataSet.Client, emailTextBox.Text);
                int clientid = Convert.ToInt32(singleClientDataSet.Tables["Client"].Rows[0].ItemArray[0].ToString());

                DataRow newAnimalRow = singleAnimalDataSet.Tables["Animal"].NewRow();

                newAnimalRow["animal_name"] = CheckIfNull(animal_nameTextBox.Text);
                newAnimalRow["breed"] = CheckIfNull(breedTextBox.Text);
                newAnimalRow["category"] = CheckIfNull(categoryTextBox.Text);
                newAnimalRow["sex"] = CheckIfNull(sexComboBox.Text);
                if (dobDateChanged) { newAnimalRow["dob"] = Convert.ToDateTime(dobDateTimePicker.Text); } else { newAnimalRow["dob"] = DBNull.Value; }
                newAnimalRow["animal_owner"] = clientid;

                singleAnimalDataSet.Tables["Animal"].Rows.Add(newAnimalRow);
                singleAnimalTableAdapter.Update(singleAnimalDataSet.Animal);

                string clientname = singleClientDataSet.Tables["Client"].Rows[0].ItemArray[1].ToString() + " "
                    + singleClientDataSet.Tables["Client"].Rows[0].ItemArray[2].ToString();

                animalTableAdapter.Fill(animalDataSet.Animal, clientid);
                string animalname = animalDataSet.Tables["Animal"].Rows[0].ItemArray[1].ToString();

                MessageBox.Show("Congratulations " + clientname + " and " + animalname + "! You are now registered.");

                this.Close();
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

        private void dobDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dobDateChanged = true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
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
