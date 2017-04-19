namespace VeterinaryClinicDatabase
{
    partial class Frm_Invoices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label inv_amountLabel;
            System.Windows.Forms.Label paid_dateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Invoices));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.listbox_unpaid_invoices = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbx_invoices_details = new System.Windows.Forms.GroupBox();
            this.btn_invoices_save = new System.Windows.Forms.Button();
            this.paid_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.singleInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleInvoiceDataSet = new VeterinaryClinicDatabase.SingleInvoiceDataSet();
            this.lbl_invoices_apptmt_date_time = new System.Windows.Forms.Label();
            this.lbl_invoices_client_name = new System.Windows.Forms.Label();
            this.inv_amountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_invoices_close = new System.Windows.Forms.Button();
            this.singleClientDataSet = new VeterinaryClinicDatabase.SingleClientDataSet();
            this.singleClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleClientTableAdapter = new VeterinaryClinicDatabase.SingleClientDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager1 = new VeterinaryClinicDatabase.SingleClientDataSetTableAdapters.TableAdapterManager();
            this.appointmentDataSet = new VeterinaryClinicDatabase.AppointmentDataSet();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTableAdapter = new VeterinaryClinicDatabase.AppointmentDataSetTableAdapters.AppointmentTableAdapter();
            this.tableAdapterManager2 = new VeterinaryClinicDatabase.AppointmentDataSetTableAdapters.TableAdapterManager();
            this.singleAnimalDataSet = new VeterinaryClinicDatabase.SingleAnimalDataSet();
            this.singleAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleAnimalTableAdapter = new VeterinaryClinicDatabase.SingleAnimalDataSetTableAdapters.AnimalTableAdapter();
            this.tableAdapterManager3 = new VeterinaryClinicDatabase.SingleAnimalDataSetTableAdapters.TableAdapterManager();
            this.singleInvoiceTableAdapter = new VeterinaryClinicDatabase.SingleInvoiceDataSetTableAdapters.InvoiceTableAdapter();
            this.tableAdapterManager4 = new VeterinaryClinicDatabase.SingleInvoiceDataSetTableAdapters.TableAdapterManager();
            this.singleScheduleSlotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleScheduleSlotDataSet = new VeterinaryClinicDatabase.SingleScheduleSlotDataSet();
            this.singleScheduleSlotTableAdapter = new VeterinaryClinicDatabase.SingleScheduleSlotDataSetTableAdapters.ScheduleSlotTableAdapter();
            this.invoiceDataSet = new VeterinaryClinicDatabase.InvoiceDataSet();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new VeterinaryClinicDatabase.InvoiceDataSetTableAdapters.InvoiceTableAdapter();
            this.tableAdapterManager = new VeterinaryClinicDatabase.InvoiceDataSetTableAdapters.TableAdapterManager();
            inv_amountLabel = new System.Windows.Forms.Label();
            paid_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpbx_invoices_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleInvoiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleAnimalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleScheduleSlotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleScheduleSlotDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inv_amountLabel
            // 
            inv_amountLabel.AutoSize = true;
            inv_amountLabel.Location = new System.Drawing.Point(6, 34);
            inv_amountLabel.Name = "inv_amountLabel";
            inv_amountLabel.Size = new System.Drawing.Size(88, 16);
            inv_amountLabel.TabIndex = 12;
            inv_amountLabel.Text = "Invoice Total:";
            // 
            // paid_dateLabel
            // 
            paid_dateLabel.AutoSize = true;
            paid_dateLabel.Location = new System.Drawing.Point(6, 64);
            paid_dateLabel.Name = "paid_dateLabel";
            paid_dateLabel.Size = new System.Drawing.Size(71, 16);
            paid_dateLabel.TabIndex = 14;
            paid_dateLabel.Text = "Date Paid:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_menu
            // 
            this.lbl_menu.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.Location = new System.Drawing.Point(73, 12);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(266, 50);
            this.lbl_menu.TabIndex = 6;
            this.lbl_menu.Text = "Invoices";
            this.lbl_menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listbox_unpaid_invoices
            // 
            this.listbox_unpaid_invoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_unpaid_invoices.FormattingEnabled = true;
            this.listbox_unpaid_invoices.ItemHeight = 16;
            this.listbox_unpaid_invoices.Location = new System.Drawing.Point(12, 90);
            this.listbox_unpaid_invoices.Name = "listbox_unpaid_invoices";
            this.listbox_unpaid_invoices.Size = new System.Drawing.Size(287, 276);
            this.listbox_unpaid_invoices.TabIndex = 8;
            this.listbox_unpaid_invoices.SelectedValueChanged += new System.EventHandler(this.listbox_unpaid_invoices_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Unpaid Invoices:";
            // 
            // grpbx_invoices_details
            // 
            this.grpbx_invoices_details.Controls.Add(this.btn_invoices_save);
            this.grpbx_invoices_details.Controls.Add(this.paid_dateDateTimePicker);
            this.grpbx_invoices_details.Controls.Add(this.lbl_invoices_apptmt_date_time);
            this.grpbx_invoices_details.Controls.Add(this.lbl_invoices_client_name);
            this.grpbx_invoices_details.Controls.Add(this.inv_amountTextBox);
            this.grpbx_invoices_details.Controls.Add(this.label3);
            this.grpbx_invoices_details.Controls.Add(this.label2);
            this.grpbx_invoices_details.Controls.Add(inv_amountLabel);
            this.grpbx_invoices_details.Controls.Add(paid_dateLabel);
            this.grpbx_invoices_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbx_invoices_details.Location = new System.Drawing.Point(305, 90);
            this.grpbx_invoices_details.Name = "grpbx_invoices_details";
            this.grpbx_invoices_details.Size = new System.Drawing.Size(315, 194);
            this.grpbx_invoices_details.TabIndex = 16;
            this.grpbx_invoices_details.TabStop = false;
            this.grpbx_invoices_details.Text = "Invoice Details";
            // 
            // btn_invoices_save
            // 
            this.btn_invoices_save.Location = new System.Drawing.Point(223, 158);
            this.btn_invoices_save.Name = "btn_invoices_save";
            this.btn_invoices_save.Size = new System.Drawing.Size(86, 30);
            this.btn_invoices_save.TabIndex = 22;
            this.btn_invoices_save.Text = "Save";
            this.btn_invoices_save.UseVisualStyleBackColor = true;
            this.btn_invoices_save.Click += new System.EventHandler(this.btn_invoices_save_Click);
            // 
            // paid_dateDateTimePicker
            // 
            this.paid_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.singleInvoiceBindingSource, "paid_date", true));
            this.paid_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.paid_dateDateTimePicker.Location = new System.Drawing.Point(114, 60);
            this.paid_dateDateTimePicker.Name = "paid_dateDateTimePicker";
            this.paid_dateDateTimePicker.Size = new System.Drawing.Size(116, 22);
            this.paid_dateDateTimePicker.TabIndex = 19;
            this.paid_dateDateTimePicker.DropDown += new System.EventHandler(this.paid_dateDateTimePicker_ValueChanged);
            // 
            // singleInvoiceBindingSource
            // 
            this.singleInvoiceBindingSource.DataMember = "Invoice";
            this.singleInvoiceBindingSource.DataSource = this.singleInvoiceDataSet;
            // 
            // singleInvoiceDataSet
            // 
            this.singleInvoiceDataSet.DataSetName = "SingleInvoiceDataSet";
            this.singleInvoiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_invoices_apptmt_date_time
            // 
            this.lbl_invoices_apptmt_date_time.AutoSize = true;
            this.lbl_invoices_apptmt_date_time.Location = new System.Drawing.Point(111, 121);
            this.lbl_invoices_apptmt_date_time.Name = "lbl_invoices_apptmt_date_time";
            this.lbl_invoices_apptmt_date_time.Size = new System.Drawing.Size(11, 16);
            this.lbl_invoices_apptmt_date_time.TabIndex = 21;
            this.lbl_invoices_apptmt_date_time.Text = " ";
            // 
            // lbl_invoices_client_name
            // 
            this.lbl_invoices_client_name.AutoSize = true;
            this.lbl_invoices_client_name.Location = new System.Drawing.Point(111, 96);
            this.lbl_invoices_client_name.Name = "lbl_invoices_client_name";
            this.lbl_invoices_client_name.Size = new System.Drawing.Size(11, 16);
            this.lbl_invoices_client_name.TabIndex = 20;
            this.lbl_invoices_client_name.Text = " ";
            // 
            // inv_amountTextBox
            // 
            this.inv_amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleInvoiceBindingSource, "inv_amount", true));
            this.inv_amountTextBox.Location = new System.Drawing.Point(114, 31);
            this.inv_amountTextBox.Name = "inv_amountTextBox";
            this.inv_amountTextBox.ReadOnly = true;
            this.inv_amountTextBox.Size = new System.Drawing.Size(116, 22);
            this.inv_amountTextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Appointment:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Client:";
            // 
            // btn_invoices_close
            // 
            this.btn_invoices_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invoices_close.Location = new System.Drawing.Point(528, 336);
            this.btn_invoices_close.Name = "btn_invoices_close";
            this.btn_invoices_close.Size = new System.Drawing.Size(86, 30);
            this.btn_invoices_close.TabIndex = 17;
            this.btn_invoices_close.Text = "Close";
            this.btn_invoices_close.UseVisualStyleBackColor = true;
            this.btn_invoices_close.Click += new System.EventHandler(this.btn_invoices_close_Click);
            // 
            // singleClientDataSet
            // 
            this.singleClientDataSet.DataSetName = "SingleClientDataSet";
            this.singleClientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // singleClientBindingSource
            // 
            this.singleClientBindingSource.DataMember = "Client";
            this.singleClientBindingSource.DataSource = this.singleClientDataSet;
            // 
            // singleClientTableAdapter
            // 
            this.singleClientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClientTableAdapter = this.singleClientTableAdapter;
            this.tableAdapterManager1.UpdateOrder = VeterinaryClinicDatabase.SingleClientDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // appointmentDataSet
            // 
            this.appointmentDataSet.DataSetName = "AppointmentDataSet";
            this.appointmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "Appointment";
            this.appointmentBindingSource.DataSource = this.appointmentDataSet;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.AppointmentTableAdapter = this.appointmentTableAdapter;
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.UpdateOrder = VeterinaryClinicDatabase.AppointmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // singleAnimalDataSet
            // 
            this.singleAnimalDataSet.DataSetName = "SingleAnimalDataSet";
            this.singleAnimalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // singleAnimalBindingSource
            // 
            this.singleAnimalBindingSource.DataMember = "Animal";
            this.singleAnimalBindingSource.DataSource = this.singleAnimalDataSet;
            // 
            // singleAnimalTableAdapter
            // 
            this.singleAnimalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.AnimalTableAdapter = this.singleAnimalTableAdapter;
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.UpdateOrder = VeterinaryClinicDatabase.SingleAnimalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // singleInvoiceTableAdapter
            // 
            this.singleInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager4
            // 
            this.tableAdapterManager4.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager4.InvoiceTableAdapter = this.singleInvoiceTableAdapter;
            this.tableAdapterManager4.UpdateOrder = VeterinaryClinicDatabase.SingleInvoiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // singleScheduleSlotBindingSource
            // 
            this.singleScheduleSlotBindingSource.DataMember = "ScheduleSlot";
            this.singleScheduleSlotBindingSource.DataSource = this.singleScheduleSlotDataSet;
            // 
            // singleScheduleSlotDataSet
            // 
            this.singleScheduleSlotDataSet.DataSetName = "SingleScheduleSlotDataSet";
            this.singleScheduleSlotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // singleScheduleSlotTableAdapter
            // 
            this.singleScheduleSlotTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceDataSet
            // 
            this.invoiceDataSet.DataSetName = "InvoiceDataSet";
            this.invoiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.invoiceDataSet;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InvoiceTableAdapter = this.invoiceTableAdapter;
            this.tableAdapterManager.UpdateOrder = VeterinaryClinicDatabase.InvoiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Frm_Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 381);
            this.Controls.Add(this.btn_invoices_close);
            this.Controls.Add(this.grpbx_invoices_details);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox_unpaid_invoices);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_menu);
            this.Name = "Frm_Invoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Invoices";
            this.Load += new System.EventHandler(this.Frm_Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpbx_invoices_details.ResumeLayout(false);
            this.grpbx_invoices_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleInvoiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleAnimalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleScheduleSlotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleScheduleSlotDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.ListBox listbox_unpaid_invoices;
        private System.Windows.Forms.Label label1;
        private InvoiceDataSet invoiceDataSet;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private InvoiceDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private InvoiceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox grpbx_invoices_details;
        private System.Windows.Forms.Button btn_invoices_save;
        private System.Windows.Forms.Label lbl_invoices_apptmt_date_time;
        private System.Windows.Forms.Label lbl_invoices_client_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_invoices_close;
        private SingleClientDataSet singleClientDataSet;
        private System.Windows.Forms.BindingSource singleClientBindingSource;
        private SingleClientDataSetTableAdapters.ClientTableAdapter singleClientTableAdapter;
        private SingleClientDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private AppointmentDataSet appointmentDataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private AppointmentDataSetTableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private AppointmentDataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private SingleAnimalDataSet singleAnimalDataSet;
        private System.Windows.Forms.BindingSource singleAnimalBindingSource;
        private SingleAnimalDataSetTableAdapters.AnimalTableAdapter singleAnimalTableAdapter;
        private SingleAnimalDataSetTableAdapters.TableAdapterManager tableAdapterManager3;
        private SingleInvoiceDataSet singleInvoiceDataSet;
        private System.Windows.Forms.BindingSource singleInvoiceBindingSource;
        private SingleInvoiceDataSetTableAdapters.InvoiceTableAdapter singleInvoiceTableAdapter;
        private SingleInvoiceDataSetTableAdapters.TableAdapterManager tableAdapterManager4;
        private System.Windows.Forms.DateTimePicker paid_dateDateTimePicker;
        private System.Windows.Forms.TextBox inv_amountTextBox;
        private SingleScheduleSlotDataSet singleScheduleSlotDataSet;
        private System.Windows.Forms.BindingSource singleScheduleSlotBindingSource;
        private SingleScheduleSlotDataSetTableAdapters.ScheduleSlotTableAdapter singleScheduleSlotTableAdapter;
        private SingleScheduleSlotDataSetTableAdapters.TableAdapterManager tableAdapterManager5;
    }
}