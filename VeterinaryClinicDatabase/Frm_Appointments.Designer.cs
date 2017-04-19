namespace VeterinaryClinicDatabase
{
    partial class Frm_Appointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Appointments));
            this.listbox_upcoming_appointments = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.dtp_apptmts_fill_listbox = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_apptmts_email_confirm = new System.Windows.Forms.Button();
            this.scheduleSlotDataSet = new VeterinaryClinicDatabase.ScheduleSlotDataSet();
            this.scheduleSlotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleSlotTableAdapter = new VeterinaryClinicDatabase.ScheduleSlotDataSetTableAdapters.ScheduleSlotTableAdapter();
            this.singleAnimalDataSet = new VeterinaryClinicDatabase.SingleAnimalDataSet();
            this.singleAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleAnimalTableAdapter = new VeterinaryClinicDatabase.SingleAnimalDataSetTableAdapters.AnimalTableAdapter();
            this.appointmentDataSet = new VeterinaryClinicDatabase.AppointmentDataSet();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTableAdapter = new VeterinaryClinicDatabase.AppointmentDataSetTableAdapters.AppointmentTableAdapter();
            this.singleClientDataSet = new VeterinaryClinicDatabase.SingleClientDataSet();
            this.singleClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleClientTableAdapter = new VeterinaryClinicDatabase.SingleClientDataSetTableAdapters.ClientTableAdapter();
            this.singleStaffDataSet = new VeterinaryClinicDatabase.SingleStaffDataSet();
            this.singleStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleStaffTableAdapter = new VeterinaryClinicDatabase.SingleStaffDataSetTableAdapters.StaffTableAdapter();
            this.tableAdapterManager1 = new VeterinaryClinicDatabase.SingleStaffDataSetTableAdapters.TableAdapterManager();
            this.btn_open_appointment = new System.Windows.Forms.Button();
            this.btn_appointments_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleSlotDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleSlotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleAnimalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listbox_upcoming_appointments
            // 
            this.listbox_upcoming_appointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_upcoming_appointments.FormattingEnabled = true;
            this.listbox_upcoming_appointments.ItemHeight = 16;
            this.listbox_upcoming_appointments.Location = new System.Drawing.Point(12, 100);
            this.listbox_upcoming_appointments.Name = "listbox_upcoming_appointments";
            this.listbox_upcoming_appointments.Size = new System.Drawing.Size(541, 324);
            this.listbox_upcoming_appointments.TabIndex = 1;
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
            this.lbl_menu.Size = new System.Drawing.Size(308, 50);
            this.lbl_menu.TabIndex = 6;
            this.lbl_menu.Text = "Appointments";
            // 
            // dtp_apptmts_fill_listbox
            // 
            this.dtp_apptmts_fill_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_apptmts_fill_listbox.Location = new System.Drawing.Point(58, 71);
            this.dtp_apptmts_fill_listbox.Name = "dtp_apptmts_fill_listbox";
            this.dtp_apptmts_fill_listbox.Size = new System.Drawing.Size(257, 22);
            this.dtp_apptmts_fill_listbox.TabIndex = 8;
            this.dtp_apptmts_fill_listbox.ValueChanged += new System.EventHandler(this.dtp_apptmts_fill_listbox_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "For:";
            // 
            // btn_apptmts_email_confirm
            // 
            this.btn_apptmts_email_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apptmts_email_confirm.Location = new System.Drawing.Point(12, 430);
            this.btn_apptmts_email_confirm.Name = "btn_apptmts_email_confirm";
            this.btn_apptmts_email_confirm.Size = new System.Drawing.Size(143, 34);
            this.btn_apptmts_email_confirm.TabIndex = 22;
            this.btn_apptmts_email_confirm.Text = "Send Email";
            this.btn_apptmts_email_confirm.UseVisualStyleBackColor = true;
            // 
            // scheduleSlotDataSet
            // 
            this.scheduleSlotDataSet.DataSetName = "ScheduleSlotDataSet";
            this.scheduleSlotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scheduleSlotBindingSource
            // 
            this.scheduleSlotBindingSource.DataMember = "ScheduleSlot";
            this.scheduleSlotBindingSource.DataSource = this.scheduleSlotDataSet;
            // 
            // scheduleSlotTableAdapter
            // 
            this.scheduleSlotTableAdapter.ClearBeforeFill = true;
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
            // singleStaffDataSet
            // 
            this.singleStaffDataSet.DataSetName = "SingleStaffDataSet";
            this.singleStaffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // singleStaffBindingSource
            // 
            this.singleStaffBindingSource.DataMember = "Staff";
            this.singleStaffBindingSource.DataSource = this.singleStaffDataSet;
            // 
            // singleStaffTableAdapter
            // 
            this.singleStaffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.StaffTableAdapter = this.singleStaffTableAdapter;
            this.tableAdapterManager1.UpdateOrder = VeterinaryClinicDatabase.SingleStaffDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btn_open_appointment
            // 
            this.btn_open_appointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open_appointment.Location = new System.Drawing.Point(161, 430);
            this.btn_open_appointment.Name = "btn_open_appointment";
            this.btn_open_appointment.Size = new System.Drawing.Size(143, 34);
            this.btn_open_appointment.TabIndex = 23;
            this.btn_open_appointment.Text = "Open Appointment";
            this.btn_open_appointment.UseVisualStyleBackColor = true;
            this.btn_open_appointment.Click += new System.EventHandler(this.btn_open_appointment_Click);
            // 
            // btn_appointments_close
            // 
            this.btn_appointments_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_appointments_close.Location = new System.Drawing.Point(449, 430);
            this.btn_appointments_close.Name = "btn_appointments_close";
            this.btn_appointments_close.Size = new System.Drawing.Size(104, 34);
            this.btn_appointments_close.TabIndex = 24;
            this.btn_appointments_close.Text = "Close";
            this.btn_appointments_close.UseVisualStyleBackColor = true;
            this.btn_appointments_close.Click += new System.EventHandler(this.btn_appointments_close_Click);
            // 
            // Frm_Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 476);
            this.Controls.Add(this.btn_appointments_close);
            this.Controls.Add(this.btn_open_appointment);
            this.Controls.Add(this.btn_apptmts_email_confirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_apptmts_fill_listbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_menu);
            this.Controls.Add(this.listbox_upcoming_appointments);
            this.Name = "Frm_Appointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Veterinary Clinic Application";
            this.Load += new System.EventHandler(this.Frm_Appointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleSlotDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleSlotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleAnimalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_upcoming_appointments;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.DateTimePicker dtp_apptmts_fill_listbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_apptmts_email_confirm;

        private ScheduleSlotDataSet scheduleSlotDataSet;
        private System.Windows.Forms.BindingSource scheduleSlotBindingSource;
        private ScheduleSlotDataSetTableAdapters.ScheduleSlotTableAdapter scheduleSlotTableAdapter;

        private SingleAnimalDataSet singleAnimalDataSet;
        private System.Windows.Forms.BindingSource singleAnimalBindingSource;
        private SingleAnimalDataSetTableAdapters.AnimalTableAdapter singleAnimalTableAdapter;

        private AppointmentDataSet appointmentDataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private AppointmentDataSetTableAdapters.AppointmentTableAdapter appointmentTableAdapter;

        private SingleClientDataSet singleClientDataSet;
        private System.Windows.Forms.BindingSource singleClientBindingSource;
        private SingleClientDataSetTableAdapters.ClientTableAdapter singleClientTableAdapter;
        private SingleClientDataSetTableAdapters.TableAdapterManager tableAdapterManager;

        private SingleStaffDataSet singleStaffDataSet;
        private System.Windows.Forms.BindingSource singleStaffBindingSource;
        private SingleStaffDataSetTableAdapters.StaffTableAdapter singleStaffTableAdapter;
        private SingleStaffDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button btn_open_appointment;
        private System.Windows.Forms.Button btn_appointments_close;
    }
}