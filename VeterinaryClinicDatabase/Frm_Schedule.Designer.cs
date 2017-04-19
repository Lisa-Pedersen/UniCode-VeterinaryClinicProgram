namespace VeterinaryClinicDatabase
{
    partial class Frm_Schedule
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
            System.Windows.Forms.Label slot_dateLabel;
            System.Windows.Forms.Label roomLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Schedule));
            this.listbox_schedule_slots = new System.Windows.Forms.ListBox();
            this.lbl_scheduling_avaliable_schedule_slots = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.btn_save_scheduleslot = new System.Windows.Forms.Button();
            this.btn_schedule_close = new System.Windows.Forms.Button();
            this.staffDataSet = new VeterinaryClinicDatabase.StaffDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new VeterinaryClinicDatabase.StaffDataSetTableAdapters.StaffTableAdapter();
            this.tableAdapterManager = new VeterinaryClinicDatabase.StaffDataSetTableAdapters.TableAdapterManager();
            this.btn_load_schedule_slots = new System.Windows.Forms.Button();
            this.slot_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.singleScheduleSlotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleScheduleSlotDataSet = new VeterinaryClinicDatabase.SingleScheduleSlotDataSet();
            this.roomComboBox = new System.Windows.Forms.ComboBox();
            this.grpbx_scheduleslot_details = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_schedule_clear_details = new System.Windows.Forms.Button();
            this.groupBox_consult_times = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_consult_end_time = new System.Windows.Forms.DateTimePicker();
            this.dtp_consult_start_time = new System.Windows.Forms.DateTimePicker();
            this.combobx_staff_on_duty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.singleScheduleSlotTableAdapter = new VeterinaryClinicDatabase.SingleScheduleSlotDataSetTableAdapters.ScheduleSlotTableAdapter();
            this.tableAdapterManager1 = new VeterinaryClinicDatabase.SingleScheduleSlotDataSetTableAdapters.TableAdapterManager();
            this.singleStaffDataSet = new VeterinaryClinicDatabase.SingleStaffDataSet();
            this.singleStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleStaffTableAdapter = new VeterinaryClinicDatabase.SingleStaffDataSetTableAdapters.StaffTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_schedule_avaliable_month = new System.Windows.Forms.DateTimePicker();
            this.listbox_schedule_daysleft = new System.Windows.Forms.ListBox();
            this.lbl_schedule_daysleft = new System.Windows.Forms.Label();
            this.scheduleSlotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleSlotDataSet = new VeterinaryClinicDatabase.ScheduleSlotDataSet();
            this.scheduleSlotTableAdapter = new VeterinaryClinicDatabase.ScheduleSlotDataSetTableAdapters.ScheduleSlotTableAdapter();
            slot_dateLabel = new System.Windows.Forms.Label();
            roomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleScheduleSlotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleScheduleSlotDataSet)).BeginInit();
            this.grpbx_scheduleslot_details.SuspendLayout();
            this.groupBox_consult_times.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleSlotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleSlotDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // slot_dateLabel
            // 
            slot_dateLabel.AutoSize = true;
            slot_dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            slot_dateLabel.Location = new System.Drawing.Point(18, 26);
            slot_dateLabel.Name = "slot_dateLabel";
            slot_dateLabel.Size = new System.Drawing.Size(40, 16);
            slot_dateLabel.TabIndex = 31;
            slot_dateLabel.Text = "Date:";
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            roomLabel.Location = new System.Drawing.Point(18, 80);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new System.Drawing.Size(88, 16);
            roomLabel.TabIndex = 37;
            roomLabel.Text = "Assigned To:";
            // 
            // listbox_schedule_slots
            // 
            this.listbox_schedule_slots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_schedule_slots.FormattingEnabled = true;
            this.listbox_schedule_slots.ItemHeight = 16;
            this.listbox_schedule_slots.Location = new System.Drawing.Point(12, 139);
            this.listbox_schedule_slots.Name = "listbox_schedule_slots";
            this.listbox_schedule_slots.Size = new System.Drawing.Size(361, 452);
            this.listbox_schedule_slots.TabIndex = 17;
            this.listbox_schedule_slots.SelectedValueChanged += new System.EventHandler(this.listbox_schedule_slots_SelectedValueChanged);
            // 
            // lbl_scheduling_avaliable_schedule_slots
            // 
            this.lbl_scheduling_avaliable_schedule_slots.AutoSize = true;
            this.lbl_scheduling_avaliable_schedule_slots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scheduling_avaliable_schedule_slots.Location = new System.Drawing.Point(9, 86);
            this.lbl_scheduling_avaliable_schedule_slots.Name = "lbl_scheduling_avaliable_schedule_slots";
            this.lbl_scheduling_avaliable_schedule_slots.Size = new System.Drawing.Size(124, 16);
            this.lbl_scheduling_avaliable_schedule_slots.TabIndex = 18;
            this.lbl_scheduling_avaliable_schedule_slots.Text = "Schedule Slots For:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_menu
            // 
            this.lbl_menu.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.Location = new System.Drawing.Point(73, 12);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(379, 50);
            this.lbl_menu.TabIndex = 19;
            this.lbl_menu.Text = "Clinic Scheduling";
            // 
            // btn_save_scheduleslot
            // 
            this.btn_save_scheduleslot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_scheduleslot.Location = new System.Drawing.Point(294, 207);
            this.btn_save_scheduleslot.Name = "btn_save_scheduleslot";
            this.btn_save_scheduleslot.Size = new System.Drawing.Size(109, 29);
            this.btn_save_scheduleslot.TabIndex = 26;
            this.btn_save_scheduleslot.Text = "Save";
            this.btn_save_scheduleslot.UseVisualStyleBackColor = true;
            this.btn_save_scheduleslot.Click += new System.EventHandler(this.btn_save_scheduleslot_Click);
            // 
            // btn_schedule_close
            // 
            this.btn_schedule_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_schedule_close.Location = new System.Drawing.Point(730, 562);
            this.btn_schedule_close.Name = "btn_schedule_close";
            this.btn_schedule_close.Size = new System.Drawing.Size(86, 29);
            this.btn_schedule_close.TabIndex = 27;
            this.btn_schedule_close.Text = "Close";
            this.btn_schedule_close.UseVisualStyleBackColor = true;
            this.btn_schedule_close.Click += new System.EventHandler(this.btn_schedule_close_Click);
            // 
            // staffDataSet
            // 
            this.staffDataSet.DataSetName = "StaffDataSet";
            this.staffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.staffDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StaffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.UpdateOrder = VeterinaryClinicDatabase.StaffDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btn_load_schedule_slots
            // 
            this.btn_load_schedule_slots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load_schedule_slots.Location = new System.Drawing.Point(285, 104);
            this.btn_load_schedule_slots.Name = "btn_load_schedule_slots";
            this.btn_load_schedule_slots.Size = new System.Drawing.Size(88, 29);
            this.btn_load_schedule_slots.TabIndex = 29;
            this.btn_load_schedule_slots.Text = "Load";
            this.btn_load_schedule_slots.UseVisualStyleBackColor = true;
            this.btn_load_schedule_slots.Click += new System.EventHandler(this.btn_load_schedule_slots_Click);
            // 
            // slot_dateDateTimePicker
            // 
            this.slot_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.singleScheduleSlotBindingSource, "slot_date", true));
            this.slot_dateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slot_dateDateTimePicker.Location = new System.Drawing.Point(174, 21);
            this.slot_dateDateTimePicker.Name = "slot_dateDateTimePicker";
            this.slot_dateDateTimePicker.Size = new System.Drawing.Size(229, 22);
            this.slot_dateDateTimePicker.TabIndex = 32;
            this.slot_dateDateTimePicker.ValueChanged += new System.EventHandler(this.slot_dateDateTimePicker_ValueChanged);
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
            // roomComboBox
            // 
            this.roomComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleScheduleSlotBindingSource, "room", true));
            this.roomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomComboBox.FormattingEnabled = true;
            this.roomComboBox.Location = new System.Drawing.Point(174, 79);
            this.roomComboBox.Name = "roomComboBox";
            this.roomComboBox.Size = new System.Drawing.Size(229, 24);
            this.roomComboBox.TabIndex = 38;
            this.roomComboBox.SelectedValueChanged += new System.EventHandler(this.roomComboBox_SelectedValueChanged);
            // 
            // grpbx_scheduleslot_details
            // 
            this.grpbx_scheduleslot_details.Controls.Add(this.label6);
            this.grpbx_scheduleslot_details.Controls.Add(this.label5);
            this.grpbx_scheduleslot_details.Controls.Add(this.btn_schedule_clear_details);
            this.grpbx_scheduleslot_details.Controls.Add(this.groupBox_consult_times);
            this.grpbx_scheduleslot_details.Controls.Add(this.combobx_staff_on_duty);
            this.grpbx_scheduleslot_details.Controls.Add(this.label1);
            this.grpbx_scheduleslot_details.Controls.Add(slot_dateLabel);
            this.grpbx_scheduleslot_details.Controls.Add(this.slot_dateDateTimePicker);
            this.grpbx_scheduleslot_details.Controls.Add(this.btn_save_scheduleslot);
            this.grpbx_scheduleslot_details.Controls.Add(roomLabel);
            this.grpbx_scheduleslot_details.Controls.Add(this.roomComboBox);
            this.grpbx_scheduleslot_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbx_scheduleslot_details.Location = new System.Drawing.Point(394, 131);
            this.grpbx_scheduleslot_details.Name = "grpbx_scheduleslot_details";
            this.grpbx_scheduleslot_details.Size = new System.Drawing.Size(422, 250);
            this.grpbx_scheduleslot_details.TabIndex = 41;
            this.grpbx_scheduleslot_details.TabStop = false;
            this.grpbx_scheduleslot_details.Text = "Schedule Slot Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(404, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(405, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "*";
            // 
            // btn_schedule_clear_details
            // 
            this.btn_schedule_clear_details.Location = new System.Drawing.Point(179, 207);
            this.btn_schedule_clear_details.Name = "btn_schedule_clear_details";
            this.btn_schedule_clear_details.Size = new System.Drawing.Size(109, 29);
            this.btn_schedule_clear_details.TabIndex = 43;
            this.btn_schedule_clear_details.Text = "Clear Details";
            this.btn_schedule_clear_details.UseVisualStyleBackColor = true;
            this.btn_schedule_clear_details.Click += new System.EventHandler(this.btn_schedule_clear_details_Click);
            // 
            // groupBox_consult_times
            // 
            this.groupBox_consult_times.Controls.Add(this.label3);
            this.groupBox_consult_times.Controls.Add(this.label2);
            this.groupBox_consult_times.Controls.Add(this.dtp_consult_end_time);
            this.groupBox_consult_times.Controls.Add(this.dtp_consult_start_time);
            this.groupBox_consult_times.Enabled = false;
            this.groupBox_consult_times.Location = new System.Drawing.Point(168, 109);
            this.groupBox_consult_times.Name = "groupBox_consult_times";
            this.groupBox_consult_times.Size = new System.Drawing.Size(235, 92);
            this.groupBox_consult_times.TabIndex = 42;
            this.groupBox_consult_times.TabStop = false;
            this.groupBox_consult_times.Text = "Consult Times:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Time:";
            // 
            // dtp_consult_end_time
            // 
            this.dtp_consult_end_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_consult_end_time.Location = new System.Drawing.Point(95, 53);
            this.dtp_consult_end_time.Name = "dtp_consult_end_time";
            this.dtp_consult_end_time.ShowUpDown = true;
            this.dtp_consult_end_time.Size = new System.Drawing.Size(134, 22);
            this.dtp_consult_end_time.TabIndex = 1;
            this.dtp_consult_end_time.Value = new System.DateTime(1753, 1, 1, 8, 30, 0, 0);
            // 
            // dtp_consult_start_time
            // 
            this.dtp_consult_start_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_consult_start_time.Location = new System.Drawing.Point(95, 25);
            this.dtp_consult_start_time.Name = "dtp_consult_start_time";
            this.dtp_consult_start_time.ShowUpDown = true;
            this.dtp_consult_start_time.Size = new System.Drawing.Size(134, 22);
            this.dtp_consult_start_time.TabIndex = 0;
            this.dtp_consult_start_time.Value = new System.DateTime(1753, 1, 1, 8, 0, 0, 0);
            // 
            // combobx_staff_on_duty
            // 
            this.combobx_staff_on_duty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobx_staff_on_duty.FormattingEnabled = true;
            this.combobx_staff_on_duty.Location = new System.Drawing.Point(174, 49);
            this.combobx_staff_on_duty.Name = "combobx_staff_on_duty";
            this.combobx_staff_on_duty.Size = new System.Drawing.Size(229, 24);
            this.combobx_staff_on_duty.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Staff Member on Duty:";
            // 
            // singleScheduleSlotTableAdapter
            // 
            this.singleScheduleSlotTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ScheduleSlotTableAdapter = this.singleScheduleSlotTableAdapter;
            this.tableAdapterManager1.UpdateOrder = VeterinaryClinicDatabase.SingleScheduleSlotDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(704, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "* Required Information";
            // 
            // dtp_schedule_avaliable_month
            // 
            this.dtp_schedule_avaliable_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_schedule_avaliable_month.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_schedule_avaliable_month.Location = new System.Drawing.Point(29, 105);
            this.dtp_schedule_avaliable_month.Name = "dtp_schedule_avaliable_month";
            this.dtp_schedule_avaliable_month.ShowUpDown = true;
            this.dtp_schedule_avaliable_month.Size = new System.Drawing.Size(200, 22);
            this.dtp_schedule_avaliable_month.TabIndex = 44;
            // 
            // listbox_schedule_daysleft
            // 
            this.listbox_schedule_daysleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_schedule_daysleft.FormattingEnabled = true;
            this.listbox_schedule_daysleft.ItemHeight = 16;
            this.listbox_schedule_daysleft.Location = new System.Drawing.Point(397, 407);
            this.listbox_schedule_daysleft.Name = "listbox_schedule_daysleft";
            this.listbox_schedule_daysleft.Size = new System.Drawing.Size(312, 180);
            this.listbox_schedule_daysleft.TabIndex = 45;
            this.listbox_schedule_daysleft.SelectedValueChanged += new System.EventHandler(this.listbox_schedule_daysleft_SelectedValueChanged);
            // 
            // lbl_schedule_daysleft
            // 
            this.lbl_schedule_daysleft.AutoSize = true;
            this.lbl_schedule_daysleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_schedule_daysleft.ForeColor = System.Drawing.Color.Black;
            this.lbl_schedule_daysleft.Location = new System.Drawing.Point(394, 388);
            this.lbl_schedule_daysleft.Name = "lbl_schedule_daysleft";
            this.lbl_schedule_daysleft.Size = new System.Drawing.Size(334, 16);
            this.lbl_schedule_daysleft.TabIndex = 46;
            this.lbl_schedule_daysleft.Text = "Days that dont meet minimum scheduling requirements:";
            // 
            // scheduleSlotBindingSource
            // 
            this.scheduleSlotBindingSource.DataMember = "ScheduleSlot";
            this.scheduleSlotBindingSource.DataSource = this.scheduleSlotDataSet;
            // 
            // scheduleSlotDataSet
            // 
            this.scheduleSlotDataSet.DataSetName = "ScheduleSlotDataSet";
            this.scheduleSlotDataSet.EnforceConstraints = false;
            this.scheduleSlotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scheduleSlotTableAdapter
            // 
            this.scheduleSlotTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 611);
            this.Controls.Add(this.lbl_schedule_daysleft);
            this.Controls.Add(this.listbox_schedule_daysleft);
            this.Controls.Add(this.dtp_schedule_avaliable_month);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpbx_scheduleslot_details);
            this.Controls.Add(this.btn_load_schedule_slots);
            this.Controls.Add(this.btn_schedule_close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_menu);
            this.Controls.Add(this.lbl_scheduling_avaliable_schedule_slots);
            this.Controls.Add(this.listbox_schedule_slots);
            this.Name = "Frm_Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Veterinary Clinic Application";
            this.Load += new System.EventHandler(this.Frm_Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleScheduleSlotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleScheduleSlotDataSet)).EndInit();
            this.grpbx_scheduleslot_details.ResumeLayout(false);
            this.grpbx_scheduleslot_details.PerformLayout();
            this.groupBox_consult_times.ResumeLayout(false);
            this.groupBox_consult_times.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleSlotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleSlotDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_schedule_slots;
        private System.Windows.Forms.Label lbl_scheduling_avaliable_schedule_slots;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.Button btn_save_scheduleslot;
        private System.Windows.Forms.Button btn_schedule_close;
        private StaffDataSet staffDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private StaffDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private StaffDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btn_load_schedule_slots;
        private ScheduleSlotDataSet scheduleSlotDataSet;
        private System.Windows.Forms.BindingSource scheduleSlotBindingSource;
        private ScheduleSlotDataSetTableAdapters.ScheduleSlotTableAdapter scheduleSlotTableAdapter;
        private SingleStaffDataSet singleStaffDataSet;
        private System.Windows.Forms.BindingSource singleStaffBindingSource;
        private SingleStaffDataSetTableAdapters.StaffTableAdapter singleStaffTableAdapter;
        private SingleScheduleSlotDataSet singleScheduleSlotDataSet;
        private System.Windows.Forms.BindingSource singleScheduleSlotBindingSource;
        private SingleScheduleSlotDataSetTableAdapters.ScheduleSlotTableAdapter singleScheduleSlotTableAdapter;
        private System.Windows.Forms.DateTimePicker slot_dateDateTimePicker;
        private System.Windows.Forms.ComboBox roomComboBox;
        private System.Windows.Forms.GroupBox grpbx_scheduleslot_details;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combobx_staff_on_duty;
        private SingleScheduleSlotDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.GroupBox groupBox_consult_times;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_consult_end_time;
        private System.Windows.Forms.DateTimePicker dtp_consult_start_time;
        private System.Windows.Forms.Button btn_schedule_clear_details;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_schedule_avaliable_month;
        private System.Windows.Forms.ListBox listbox_schedule_daysleft;
        private System.Windows.Forms.Label lbl_schedule_daysleft;
    }
}