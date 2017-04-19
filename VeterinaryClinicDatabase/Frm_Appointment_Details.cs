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
    public partial class Frm_Appointment_Details : Form
    {
        private List<string> appointment_details;
        private int apptmtIDParam;

        public Frm_Appointment_Details( List<string> appointment_details)
        {
            try
            {
                InitializeComponent();
                this.appointment_details = appointment_details;
                apptmtIDParam = Convert.ToInt32(appointment_details.ElementAt(2).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_Appointment_Details_Load(object sender, EventArgs e)
        {
            try
            {
                this.observedTableAdapter.Fill(observedDataSet.Observed, apptmtIDParam);
                this.conditionTableAdapter.Fill(this.conditionDataSet.Condition);
                this.medicationTableAdapter.Fill(this.medicationDataSet.Medication);
                lbl_appointment_detals_animal_client.Text += '\t' + appointment_details.ElementAt(4).ToString() + " and "
                    + appointment_details.ElementAt(5).ToString();
                lbl_appointmentdetails_time.Text += '\t' + appointment_details.ElementAt(0).ToString();

                Load_Medication_and_Condition_Listboxes();
                Load_Appointment_specific_Medication_and_Condition_Listboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Load_Medication_and_Condition_Listboxes()
        {
            for (int i = 0; i < conditionDataSet.Tables["Condition"].Rows.Count; i++)
            {
                listbox_all_conditions.Items.Add(conditionDataSet.Tables["Condition"].Rows[i].ItemArray[1].ToString());
            }
            for (int i = 0; i < medicationDataSet.Tables["Medication"].Rows.Count; i++)
            {
                listbox_all_medications.Items.Add(medicationDataSet.Tables["Medication"].Rows[i].ItemArray[1].ToString());
            }
        }

        private void Load_Appointment_specific_Medication_and_Condition_Listboxes()
        {
            listbox_apptmt__conds_and_meds.Items.Clear();
            int prescribed_amt = 0;
            string condition = null;
            string medication = null;
            for (int i = 0; i < observedDataSet.Tables["Observed"].Rows.Count; i++)
            {
                singleConditionTableAdapter.Fill(singleConditionDataSet.Condition,
                    Convert.ToInt32(observedDataSet.Tables["Observed"].Rows[i].ItemArray[1].ToString()));
                singleMedicationTableAdapter.Fill(singleMedicationDataSet.Medication, 
                    Convert.ToInt32(observedDataSet.Tables["Observed"].Rows[i].ItemArray[2].ToString()) );
                prescribed_amt = Convert.ToInt32(observedDataSet.Tables["Observed"].Rows[i].ItemArray[3].ToString());
                condition = singleConditionDataSet.Tables["Condition"].Rows[0].ItemArray[1].ToString();
                medication = singleMedicationDataSet.Tables["Medication"].Rows[0].ItemArray[1].ToString();

                listbox_apptmt__conds_and_meds.Items.Add( condition.PadRight(32 - condition.Length) 
                    + '\t' + medication.PadRight(32 - condition.Length)
                    + '\t' + prescribed_amt);
            }
        }

        private void listbox_all_conditions_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int index = listbox_all_conditions.SelectedIndex;
                int condIDParam = Convert.ToInt32(conditionDataSet.Tables["Condition"].Rows[index].ItemArray[0].ToString());
                singleConditionTableAdapter.Fill(singleConditionDataSet.Condition, condIDParam);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listbox_all_medications_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int index = listbox_all_medications.SelectedIndex;
                int medIDParam = Convert.ToInt32(medicationDataSet.Tables["Medication"].Rows[index].ItemArray[0].ToString());
                singleMedicationTableAdapter.Fill(singleMedicationDataSet.Medication, medIDParam);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_condition_and_medication_Click(object sender, EventArgs e)
        {
            try
            {
                if (listbox_all_conditions.SelectedIndex == -1 | listbox_all_medications.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a condition and a medication to add.");
                }
                else
                {
                    int condIDParam = Convert.ToInt32(singleConditionDataSet.Tables["Condition"].Rows[0].ItemArray[0].ToString());
                    int medIDParam = Convert.ToInt32(singleMedicationDataSet.Tables["Medication"].Rows[0].ItemArray[0].ToString());
                    int prescribedamt = Convert.ToInt32(txtbx_prescribed_amt.Text);

                    DataRow newObservedRow = observedDataSet.Tables["Observed"].NewRow();
                    
                    newObservedRow["apptmt"] = CheckIfZero(apptmtIDParam);
                    newObservedRow["condition"] = CheckIfZero(condIDParam);
                    newObservedRow["medication"] = CheckIfZero(medIDParam);
                    newObservedRow["amt_given"] = CheckIfZero(prescribedamt);

                    observedDataSet.Tables["Observed"].Rows.Add(newObservedRow);
                    observedTableAdapter.Update(observedDataSet.Observed);

                    singleMedicationTableAdapter.Fill(singleMedicationDataSet.Medication, medIDParam);
                    int existingunits = Convert.ToInt32( singleMedicationDataSet.Tables["Medication"].Rows[0].ItemArray[2].ToString() );
                    singleMedicationDataSet.Tables["Medication"].Rows[0]["units"] = existingunits - prescribedamt;
                    singleMedicationTableAdapter.Update(singleMedicationDataSet.Medication);

                    ClearTextboxes();
                    listbox_all_conditions.ClearSelected();
                    listbox_all_medications.ClearSelected();

                    observedTableAdapter.Fill(observedDataSet.Observed, apptmtIDParam);
                    Load_Appointment_specific_Medication_and_Condition_Listboxes();
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private object CheckIfZero(int idParam)
        {
            if ( idParam == 0 ) return DBNull.Value; else return idParam;
        }

        private void ClearTextboxes()
        {
            foreach (Control c in this.grpbx_conditions.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Clear();
                }
            }
            foreach (Control c in this.grpbx_medications.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Clear();
                }
            }
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

        private void btn_save_appointment_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult userAction = MessageBox.Show(
                    null, 
                    "Do you want to generate an invoice for this appointment?\nIf you choose no the Invoice Amount will not be saved.", 
                    "Important", 
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation 
                    );

                switch (userAction)
                {
                    case DialogResult.Yes:
                        SaveAppointment();
                        NewInvoice();
                        this.Close();
                        break;
                    case DialogResult.No:
                        SaveAppointment();
                        this.Close();
                        break;
                    case DialogResult.Cancel:
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveAppointment()
        {
            this.Validate();
            appointmentBindingSource.EndEdit();
            appointmentTableAdapter.Update(appointmentDataSet);
        }

        private void NewInvoice()
        {
            DataRow newInvoiceRow = invoiceDataSet.Tables["Invoice"].NewRow();

            newInvoiceRow["inv_amount"] = Convert.ToDecimal(CheckIfNull(txtbx_invoice_amt.Text));
            if (checkbox_paid_now.Checked) { newInvoiceRow["paid_date"] = DateTime.Today.ToShortDateString(); }
                else { newInvoiceRow["paid_date"] = DBNull.Value; } 
            newInvoiceRow["for_apptmt"] = apptmtIDParam;

            invoiceDataSet.Tables["Invoice"].Rows.Add(newInvoiceRow);
            invoiceTableAdapter.Update(invoiceDataSet.Invoice);
        }

        private object CheckIfNull(string text)
        {
            if (String.IsNullOrEmpty(text)) return DBNull.Value; else return text;
        }

    } // END OF: Class: Frm_Appointment_Details
} //END OF: Namespace: VeterinaryClinicDatabase
