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
    public partial class Frm_Invoices : Form
    {
        public Frm_Invoices()
        {
            InitializeComponent();
        }
        
        private void Frm_Invoices_Load(object sender, EventArgs e)
        {
            try
            {
                this.invoiceTableAdapter.FillByUnpaidInvoices(this.invoiceDataSet.Invoice);
                Load_all_invoices_listbox();
                paid_dateDateTimePicker.CustomFormat = " ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Load_all_invoices_listbox()
        {
            listbox_unpaid_invoices.Items.Clear();
            int apptmtID = 0;
            int animalID = 0;
            int clientID = 0;
            DateTime apptmtDate;
            string clientName = null;
            double invAmt = 0.0;

            for (int i = 0; i < invoiceDataSet.Tables["Invoice"].Rows.Count; i++)
            {
                apptmtID = Convert.ToInt32(invoiceDataSet.Tables["Invoice"].Rows[i].ItemArray[3].ToString());
                appointmentTableAdapter.FillByApptmtID(appointmentDataSet.Appointment, apptmtID);
                singleScheduleSlotTableAdapter.FillByApptmtID(singleScheduleSlotDataSet.ScheduleSlot, apptmtID);
                animalID = Convert.ToInt32(appointmentDataSet.Tables["Appointment"].Rows[0].ItemArray[3].ToString());
                singleAnimalTableAdapter.Fill(singleAnimalDataSet.Animal, animalID);
                clientID = Convert.ToInt32(singleAnimalDataSet.Tables["Animal"].Rows[0].ItemArray[6].ToString());
                singleClientTableAdapter.Fill(singleClientDataSet.Client, clientID);


                apptmtDate = DateTime.Parse(singleScheduleSlotDataSet.Tables["ScheduleSlot"].Rows[0].ItemArray[1].ToString());
                clientName = singleClientDataSet.Tables["Client"].Rows[0].ItemArray[1].ToString() + " "
                    + singleClientDataSet.Tables["Client"].Rows[0].ItemArray[2].ToString();
                invAmt = Convert.ToDouble(invoiceDataSet.Tables["Invoice"].Rows[i].ItemArray[1].ToString());

                listbox_unpaid_invoices.Items.Add(apptmtDate.ToShortDateString() + '\t' + invAmt.ToString() + '\t' + clientName);
            }
        }

        private void listbox_unpaid_invoices_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int index = listbox_unpaid_invoices.SelectedIndex;
                int invID = Convert.ToInt32(invoiceDataSet.Tables["Invoice"].Rows[index].ItemArray[0].ToString());

                singleInvoiceTableAdapter.Fill(singleInvoiceDataSet.Invoice, invID);

                int apptmtID = 0;
                int animalID = 0;
                int clientID = 0;
                DateTime apptmtDate;
                string clientName = null;

                apptmtID = Convert.ToInt32(invoiceDataSet.Tables["Invoice"].Rows[index].ItemArray[3].ToString());
                appointmentTableAdapter.FillByApptmtID(appointmentDataSet.Appointment, apptmtID);
                singleScheduleSlotTableAdapter.FillByApptmtID(singleScheduleSlotDataSet.ScheduleSlot, apptmtID);
                animalID = Convert.ToInt32(appointmentDataSet.Tables["Appointment"].Rows[0].ItemArray[3].ToString());
                singleAnimalTableAdapter.Fill(singleAnimalDataSet.Animal, animalID);
                clientID = Convert.ToInt32(singleAnimalDataSet.Tables["Animal"].Rows[0].ItemArray[6].ToString());
                singleClientTableAdapter.Fill(singleClientDataSet.Client, clientID);

                apptmtDate = DateTime.Parse(singleScheduleSlotDataSet.Tables["ScheduleSlot"].Rows[0].ItemArray[1].ToString());
                clientName = singleClientDataSet.Tables["Client"].Rows[0].ItemArray[1].ToString() + " "
                    + singleClientDataSet.Tables["Client"].Rows[0].ItemArray[2].ToString();

                lbl_invoices_client_name.Text = clientName;
                lbl_invoices_apptmt_date_time.Text = apptmtDate.ToLongDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_invoices_close_Click(object sender, EventArgs e)
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

        private void paid_dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                paid_dateDateTimePicker.Format = DateTimePickerFormat.Short;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_invoices_save_Click(object sender, EventArgs e)
        {

            try
            {
                this.Validate();
                singleInvoiceBindingSource.EndEdit();
                singleInvoiceTableAdapter.Update(singleInvoiceDataSet);

                ClearInvoiceDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearInvoiceDetails()
        {
            singleInvoiceTableAdapter.Fill(singleInvoiceDataSet.Invoice, 0);
            lbl_invoices_client_name.Text = " ";
            lbl_invoices_apptmt_date_time.Text = " ";
            paid_dateDateTimePicker.CustomFormat = " ";
            invoiceTableAdapter.FillByUnpaidInvoices(invoiceDataSet.Invoice);
            Load_all_invoices_listbox();
        }
    } //ENDOF: Frm_Invoices
} // ENDOF: namespace VeterinaryClinicDatabase
