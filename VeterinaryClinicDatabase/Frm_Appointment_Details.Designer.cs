namespace VeterinaryClinicDatabase
{
    partial class Frm_Appointment_Details
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
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label animal_weightLabel;
            System.Windows.Forms.Label cond_titleLabel;
            System.Windows.Forms.Label cond_descriptionLabel;
            System.Windows.Forms.Label med_nameLabel;
            System.Windows.Forms.Label unitsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Appointment_Details));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.txtbx_apptmt_notes = new System.Windows.Forms.TextBox();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentDataSet = new VeterinaryClinicDatabase.AppointmentDataSet();
            this.txtbx_animal_weight = new System.Windows.Forms.TextBox();
            this.conditionDataSet = new VeterinaryClinicDatabase.ConditionDataSet();
            this.conditionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conditionTableAdapter = new VeterinaryClinicDatabase.ConditionDataSetTableAdapters.ConditionTableAdapter();
            this.tableAdapterManager1 = new VeterinaryClinicDatabase.ConditionDataSetTableAdapters.TableAdapterManager();
            this.listbox_all_conditions = new System.Windows.Forms.ListBox();
            this.listbox_all_medications = new System.Windows.Forms.ListBox();
            this.medicationDataSet = new VeterinaryClinicDatabase.MedicationDataSet();
            this.medicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicationTableAdapter = new VeterinaryClinicDatabase.MedicationDataSetTableAdapters.MedicationTableAdapter();
            this.tableAdapterManager2 = new VeterinaryClinicDatabase.MedicationDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_prescribed_amt = new System.Windows.Forms.TextBox();
            this.grpbx_conditions = new System.Windows.Forms.GroupBox();
            this.cond_descriptionTextBox = new System.Windows.Forms.TextBox();
            this.singleConditionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleConditionDataSet = new VeterinaryClinicDatabase.SingleConditionDataSet();
            this.cond_titleTextBox = new System.Windows.Forms.TextBox();
            this.grpbx_medications = new System.Windows.Forms.GroupBox();
            this.unitsTextBox = new System.Windows.Forms.TextBox();
            this.singleMedicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleMedicationDataSet = new VeterinaryClinicDatabase.SingleMedicationDataSet();
            this.med_nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add_condition_and_medication = new System.Windows.Forms.Button();
            this.listbox_apptmt__conds_and_meds = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save_appointment = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_appointment_detals_animal_client = new System.Windows.Forms.Label();
            this.lbl_appointmentdetails_time = new System.Windows.Forms.Label();
            this.singleConditionTableAdapter = new VeterinaryClinicDatabase.SingleConditionDataSetTableAdapters.ConditionTableAdapter();
            this.tableAdapterManager3 = new VeterinaryClinicDatabase.SingleConditionDataSetTableAdapters.TableAdapterManager();
            this.singleMedicationTableAdapter = new VeterinaryClinicDatabase.SingleMedicationDataSetTableAdapters.MedicationTableAdapter();
            this.tableAdapterManager4 = new VeterinaryClinicDatabase.SingleMedicationDataSetTableAdapters.TableAdapterManager();
            this.observedDataSet = new VeterinaryClinicDatabase.ObservedDataSet();
            this.observedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.observedTableAdapter = new VeterinaryClinicDatabase.ObservedDataSetTableAdapters.ObservedTableAdapter();
            this.tableAdapterManager5 = new VeterinaryClinicDatabase.ObservedDataSetTableAdapters.TableAdapterManager();
            this.appointmentTableAdapter = new VeterinaryClinicDatabase.AppointmentDataSetTableAdapters.AppointmentTableAdapter();
            this.tableAdapterManager = new VeterinaryClinicDatabase.AppointmentDataSetTableAdapters.TableAdapterManager();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_invoice_amt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.invoiceDataSet = new VeterinaryClinicDatabase.InvoiceDataSet();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new VeterinaryClinicDatabase.InvoiceDataSetTableAdapters.InvoiceTableAdapter();
            this.tableAdapterManager6 = new VeterinaryClinicDatabase.InvoiceDataSetTableAdapters.TableAdapterManager();
            this.checkbox_paid_now = new System.Windows.Forms.CheckBox();
            notesLabel = new System.Windows.Forms.Label();
            animal_weightLabel = new System.Windows.Forms.Label();
            cond_titleLabel = new System.Windows.Forms.Label();
            cond_descriptionLabel = new System.Windows.Forms.Label();
            med_nameLabel = new System.Windows.Forms.Label();
            unitsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationBindingSource)).BeginInit();
            this.grpbx_conditions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleConditionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleConditionDataSet)).BeginInit();
            this.grpbx_medications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleMedicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleMedicationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.observedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.observedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notesLabel.Location = new System.Drawing.Point(21, 148);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(125, 16);
            notesLabel.TabIndex = 11;
            notesLabel.Text = "Appointment Notes:";
            // 
            // animal_weightLabel
            // 
            animal_weightLabel.AutoSize = true;
            animal_weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            animal_weightLabel.Location = new System.Drawing.Point(21, 123);
            animal_weightLabel.Name = "animal_weightLabel";
            animal_weightLabel.Size = new System.Drawing.Size(226, 16);
            animal_weightLabel.TabIndex = 12;
            animal_weightLabel.Text = "Animal weight at time of appointment:";
            // 
            // cond_titleLabel
            // 
            cond_titleLabel.AutoSize = true;
            cond_titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cond_titleLabel.Location = new System.Drawing.Point(291, 18);
            cond_titleLabel.Name = "cond_titleLabel";
            cond_titleLabel.Size = new System.Drawing.Size(96, 16);
            cond_titleLabel.TabIndex = 17;
            cond_titleLabel.Text = "Condition Title:";
            // 
            // cond_descriptionLabel
            // 
            cond_descriptionLabel.AutoSize = true;
            cond_descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cond_descriptionLabel.Location = new System.Drawing.Point(291, 64);
            cond_descriptionLabel.Name = "cond_descriptionLabel";
            cond_descriptionLabel.Size = new System.Drawing.Size(138, 16);
            cond_descriptionLabel.TabIndex = 19;
            cond_descriptionLabel.Text = "Condition Description:";
            // 
            // med_nameLabel
            // 
            med_nameLabel.AutoSize = true;
            med_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            med_nameLabel.Location = new System.Drawing.Point(291, 27);
            med_nameLabel.Name = "med_nameLabel";
            med_nameLabel.Size = new System.Drawing.Size(117, 16);
            med_nameLabel.TabIndex = 22;
            med_nameLabel.Text = "Medication Name:";
            // 
            // unitsLabel
            // 
            unitsLabel.AutoSize = true;
            unitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unitsLabel.Location = new System.Drawing.Point(291, 77);
            unitsLabel.Name = "unitsLabel";
            unitsLabel.Size = new System.Drawing.Size(101, 16);
            unitsLabel.TabIndex = 24;
            unitsLabel.Text = "Available Units:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_menu
            // 
            this.lbl_menu.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.Location = new System.Drawing.Point(73, 12);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(413, 50);
            this.lbl_menu.TabIndex = 8;
            this.lbl_menu.Text = "Appointment Details";
            // 
            // txtbx_apptmt_notes
            // 
            this.txtbx_apptmt_notes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "notes", true));
            this.txtbx_apptmt_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_apptmt_notes.Location = new System.Drawing.Point(24, 167);
            this.txtbx_apptmt_notes.Multiline = true;
            this.txtbx_apptmt_notes.Name = "txtbx_apptmt_notes";
            this.txtbx_apptmt_notes.Size = new System.Drawing.Size(400, 187);
            this.txtbx_apptmt_notes.TabIndex = 12;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "Appointment";
            this.appointmentBindingSource.DataSource = this.appointmentDataSet;
            // 
            // appointmentDataSet
            // 
            this.appointmentDataSet.DataSetName = "AppointmentDataSet";
            this.appointmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtbx_animal_weight
            // 
            this.txtbx_animal_weight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "animal_weight", true));
            this.txtbx_animal_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_animal_weight.Location = new System.Drawing.Point(253, 120);
            this.txtbx_animal_weight.Name = "txtbx_animal_weight";
            this.txtbx_animal_weight.Size = new System.Drawing.Size(117, 22);
            this.txtbx_animal_weight.TabIndex = 13;
            // 
            // conditionDataSet
            // 
            this.conditionDataSet.DataSetName = "ConditionDataSet";
            this.conditionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conditionBindingSource
            // 
            this.conditionBindingSource.DataMember = "Condition";
            this.conditionBindingSource.DataSource = this.conditionDataSet;
            // 
            // conditionTableAdapter
            // 
            this.conditionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ConditionTableAdapter = this.conditionTableAdapter;
            this.tableAdapterManager1.UpdateOrder = VeterinaryClinicDatabase.ConditionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listbox_all_conditions
            // 
            this.listbox_all_conditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_all_conditions.FormattingEnabled = true;
            this.listbox_all_conditions.ItemHeight = 16;
            this.listbox_all_conditions.Location = new System.Drawing.Point(18, 21);
            this.listbox_all_conditions.Name = "listbox_all_conditions";
            this.listbox_all_conditions.Size = new System.Drawing.Size(260, 212);
            this.listbox_all_conditions.TabIndex = 14;
            this.listbox_all_conditions.SelectedValueChanged += new System.EventHandler(this.listbox_all_conditions_SelectedValueChanged);
            // 
            // listbox_all_medications
            // 
            this.listbox_all_medications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_all_medications.FormattingEnabled = true;
            this.listbox_all_medications.ItemHeight = 16;
            this.listbox_all_medications.Location = new System.Drawing.Point(17, 27);
            this.listbox_all_medications.Name = "listbox_all_medications";
            this.listbox_all_medications.Size = new System.Drawing.Size(261, 180);
            this.listbox_all_medications.TabIndex = 15;
            this.listbox_all_medications.SelectedValueChanged += new System.EventHandler(this.listbox_all_medications_SelectedValueChanged);
            // 
            // medicationDataSet
            // 
            this.medicationDataSet.DataSetName = "MedicationDataSet";
            this.medicationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicationBindingSource
            // 
            this.medicationBindingSource.DataMember = "Medication";
            this.medicationBindingSource.DataSource = this.medicationDataSet;
            // 
            // medicationTableAdapter
            // 
            this.medicationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.MedicationTableAdapter = this.medicationTableAdapter;
            this.tableAdapterManager2.UpdateOrder = VeterinaryClinicDatabase.MedicationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Amount Prescribed:";
            // 
            // txtbx_prescribed_amt
            // 
            this.txtbx_prescribed_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_prescribed_amt.Location = new System.Drawing.Point(492, 132);
            this.txtbx_prescribed_amt.Name = "txtbx_prescribed_amt";
            this.txtbx_prescribed_amt.Size = new System.Drawing.Size(100, 22);
            this.txtbx_prescribed_amt.TabIndex = 27;
            // 
            // grpbx_conditions
            // 
            this.grpbx_conditions.Controls.Add(this.cond_descriptionTextBox);
            this.grpbx_conditions.Controls.Add(this.cond_titleTextBox);
            this.grpbx_conditions.Controls.Add(this.listbox_all_conditions);
            this.grpbx_conditions.Controls.Add(cond_descriptionLabel);
            this.grpbx_conditions.Controls.Add(cond_titleLabel);
            this.grpbx_conditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbx_conditions.Location = new System.Drawing.Point(447, 113);
            this.grpbx_conditions.Name = "grpbx_conditions";
            this.grpbx_conditions.Size = new System.Drawing.Size(642, 253);
            this.grpbx_conditions.TabIndex = 28;
            this.grpbx_conditions.TabStop = false;
            this.grpbx_conditions.Text = "CONDITIONS:";
            // 
            // cond_descriptionTextBox
            // 
            this.cond_descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleConditionBindingSource, "cond_description", true));
            this.cond_descriptionTextBox.Location = new System.Drawing.Point(294, 83);
            this.cond_descriptionTextBox.Multiline = true;
            this.cond_descriptionTextBox.Name = "cond_descriptionTextBox";
            this.cond_descriptionTextBox.ReadOnly = true;
            this.cond_descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cond_descriptionTextBox.Size = new System.Drawing.Size(328, 146);
            this.cond_descriptionTextBox.TabIndex = 21;
            // 
            // singleConditionBindingSource
            // 
            this.singleConditionBindingSource.DataMember = "Condition";
            this.singleConditionBindingSource.DataSource = this.singleConditionDataSet;
            // 
            // singleConditionDataSet
            // 
            this.singleConditionDataSet.DataSetName = "SingleConditionDataSet";
            this.singleConditionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cond_titleTextBox
            // 
            this.cond_titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleConditionBindingSource, "cond_title", true));
            this.cond_titleTextBox.Location = new System.Drawing.Point(294, 39);
            this.cond_titleTextBox.Name = "cond_titleTextBox";
            this.cond_titleTextBox.ReadOnly = true;
            this.cond_titleTextBox.Size = new System.Drawing.Size(328, 22);
            this.cond_titleTextBox.TabIndex = 20;
            // 
            // grpbx_medications
            // 
            this.grpbx_medications.Controls.Add(this.unitsTextBox);
            this.grpbx_medications.Controls.Add(this.med_nameTextBox);
            this.grpbx_medications.Controls.Add(this.listbox_all_medications);
            this.grpbx_medications.Controls.Add(med_nameLabel);
            this.grpbx_medications.Controls.Add(this.txtbx_prescribed_amt);
            this.grpbx_medications.Controls.Add(this.label1);
            this.grpbx_medications.Controls.Add(unitsLabel);
            this.grpbx_medications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbx_medications.Location = new System.Drawing.Point(447, 372);
            this.grpbx_medications.Name = "grpbx_medications";
            this.grpbx_medications.Size = new System.Drawing.Size(642, 227);
            this.grpbx_medications.TabIndex = 29;
            this.grpbx_medications.TabStop = false;
            this.grpbx_medications.Text = "MEDICATIONS:";
            // 
            // unitsTextBox
            // 
            this.unitsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleMedicationBindingSource, "units", true));
            this.unitsTextBox.Location = new System.Drawing.Point(492, 74);
            this.unitsTextBox.Name = "unitsTextBox";
            this.unitsTextBox.ReadOnly = true;
            this.unitsTextBox.Size = new System.Drawing.Size(100, 22);
            this.unitsTextBox.TabIndex = 29;
            // 
            // singleMedicationBindingSource
            // 
            this.singleMedicationBindingSource.DataMember = "Medication";
            this.singleMedicationBindingSource.DataSource = this.singleMedicationDataSet;
            // 
            // singleMedicationDataSet
            // 
            this.singleMedicationDataSet.DataSetName = "SingleMedicationDataSet";
            this.singleMedicationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // med_nameTextBox
            // 
            this.med_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleMedicationBindingSource, "med_name", true));
            this.med_nameTextBox.Location = new System.Drawing.Point(294, 46);
            this.med_nameTextBox.Name = "med_nameTextBox";
            this.med_nameTextBox.ReadOnly = true;
            this.med_nameTextBox.Size = new System.Drawing.Size(298, 22);
            this.med_nameTextBox.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Kgs";
            // 
            // btn_add_condition_and_medication
            // 
            this.btn_add_condition_and_medication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_condition_and_medication.Location = new System.Drawing.Point(854, 605);
            this.btn_add_condition_and_medication.Name = "btn_add_condition_and_medication";
            this.btn_add_condition_and_medication.Size = new System.Drawing.Size(235, 30);
            this.btn_add_condition_and_medication.TabIndex = 31;
            this.btn_add_condition_and_medication.Text = "Add Condition and Medication";
            this.btn_add_condition_and_medication.UseVisualStyleBackColor = true;
            this.btn_add_condition_and_medication.Click += new System.EventHandler(this.btn_add_condition_and_medication_Click);
            // 
            // listbox_apptmt__conds_and_meds
            // 
            this.listbox_apptmt__conds_and_meds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_apptmt__conds_and_meds.FormattingEnabled = true;
            this.listbox_apptmt__conds_and_meds.ItemHeight = 16;
            this.listbox_apptmt__conds_and_meds.Location = new System.Drawing.Point(31, 394);
            this.listbox_apptmt__conds_and_meds.Name = "listbox_apptmt__conds_and_meds";
            this.listbox_apptmt__conds_and_meds.Size = new System.Drawing.Size(393, 148);
            this.listbox_apptmt__conds_and_meds.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Conditions Diagnosed and Medications Prescribed";
            // 
            // btn_save_appointment
            // 
            this.btn_save_appointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_appointment.Location = new System.Drawing.Point(342, 605);
            this.btn_save_appointment.Name = "btn_save_appointment";
            this.btn_save_appointment.Size = new System.Drawing.Size(82, 30);
            this.btn_save_appointment.TabIndex = 36;
            this.btn_save_appointment.Text = "Submit";
            this.btn_save_appointment.UseVisualStyleBackColor = true;
            this.btn_save_appointment.Click += new System.EventHandler(this.btn_save_appointment_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(253, 605);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(82, 30);
            this.btn_Cancel.TabIndex = 37;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_appointment_detals_animal_client
            // 
            this.lbl_appointment_detals_animal_client.AutoSize = true;
            this.lbl_appointment_detals_animal_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_appointment_detals_animal_client.Location = new System.Drawing.Point(21, 75);
            this.lbl_appointment_detals_animal_client.Name = "lbl_appointment_detals_animal_client";
            this.lbl_appointment_detals_animal_client.Size = new System.Drawing.Size(109, 16);
            this.lbl_appointment_detals_animal_client.TabIndex = 38;
            this.lbl_appointment_detals_animal_client.Text = "Appointment For:";
            // 
            // lbl_appointmentdetails_time
            // 
            this.lbl_appointmentdetails_time.AutoSize = true;
            this.lbl_appointmentdetails_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_appointmentdetails_time.Location = new System.Drawing.Point(21, 95);
            this.lbl_appointmentdetails_time.Name = "lbl_appointmentdetails_time";
            this.lbl_appointmentdetails_time.Size = new System.Drawing.Size(23, 16);
            this.lbl_appointmentdetails_time.TabIndex = 39;
            this.lbl_appointmentdetails_time.Text = "At:";
            // 
            // singleConditionTableAdapter
            // 
            this.singleConditionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.ConditionTableAdapter = this.singleConditionTableAdapter;
            this.tableAdapterManager3.UpdateOrder = VeterinaryClinicDatabase.SingleConditionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // singleMedicationTableAdapter
            // 
            this.singleMedicationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager4
            // 
            this.tableAdapterManager4.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager4.MedicationTableAdapter = this.singleMedicationTableAdapter;
            this.tableAdapterManager4.UpdateOrder = VeterinaryClinicDatabase.SingleMedicationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // observedDataSet
            // 
            this.observedDataSet.DataSetName = "ObservedDataSet";
            this.observedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // observedBindingSource
            // 
            this.observedBindingSource.DataMember = "Observed";
            this.observedBindingSource.DataSource = this.observedDataSet;
            // 
            // observedTableAdapter
            // 
            this.observedTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager5
            // 
            this.tableAdapterManager5.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager5.ObservedTableAdapter = this.observedTableAdapter;
            this.tableAdapterManager5.UpdateOrder = VeterinaryClinicDatabase.ObservedDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentTableAdapter = this.appointmentTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = VeterinaryClinicDatabase.AppointmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 563);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Invoice Total:";
            // 
            // txtbx_invoice_amt
            // 
            this.txtbx_invoice_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_invoice_amt.Location = new System.Drawing.Point(163, 560);
            this.txtbx_invoice_amt.Name = "txtbx_invoice_amt";
            this.txtbx_invoice_amt.Size = new System.Drawing.Size(130, 22);
            this.txtbx_invoice_amt.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 563);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "$";
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
            // tableAdapterManager6
            // 
            this.tableAdapterManager6.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager6.InvoiceTableAdapter = this.invoiceTableAdapter;
            this.tableAdapterManager6.UpdateOrder = VeterinaryClinicDatabase.InvoiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // checkbox_paid_now
            // 
            this.checkbox_paid_now.AutoSize = true;
            this.checkbox_paid_now.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_paid_now.Location = new System.Drawing.Point(339, 562);
            this.checkbox_paid_now.Name = "checkbox_paid_now";
            this.checkbox_paid_now.Size = new System.Drawing.Size(85, 20);
            this.checkbox_paid_now.TabIndex = 43;
            this.checkbox_paid_now.Text = "Paid Now";
            this.checkbox_paid_now.UseVisualStyleBackColor = true;
            // 
            // Frm_Appointment_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 655);
            this.Controls.Add(this.checkbox_paid_now);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbx_invoice_amt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_appointmentdetails_time);
            this.Controls.Add(this.lbl_appointment_detals_animal_client);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_save_appointment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listbox_apptmt__conds_and_meds);
            this.Controls.Add(this.btn_add_condition_and_medication);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpbx_medications);
            this.Controls.Add(this.grpbx_conditions);
            this.Controls.Add(animal_weightLabel);
            this.Controls.Add(this.txtbx_animal_weight);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.txtbx_apptmt_notes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_menu);
            this.Name = "Frm_Appointment_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Veterinary Clinic Application";
            this.Load += new System.EventHandler(this.Frm_Appointment_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationBindingSource)).EndInit();
            this.grpbx_conditions.ResumeLayout(false);
            this.grpbx_conditions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleConditionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleConditionDataSet)).EndInit();
            this.grpbx_medications.ResumeLayout(false);
            this.grpbx_medications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleMedicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleMedicationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.observedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.observedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_menu;
        private AppointmentDataSet appointmentDataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private AppointmentDataSetTableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private AppointmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtbx_apptmt_notes;
        private System.Windows.Forms.TextBox txtbx_animal_weight;
        private ConditionDataSet conditionDataSet;
        private System.Windows.Forms.BindingSource conditionBindingSource;
        private ConditionDataSetTableAdapters.ConditionTableAdapter conditionTableAdapter;
        private ConditionDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ListBox listbox_all_conditions;
        private System.Windows.Forms.ListBox listbox_all_medications;
        private MedicationDataSet medicationDataSet;
        private System.Windows.Forms.BindingSource medicationBindingSource;
        private MedicationDataSetTableAdapters.MedicationTableAdapter medicationTableAdapter;
        private MedicationDataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_prescribed_amt;
        private System.Windows.Forms.GroupBox grpbx_conditions;
        private System.Windows.Forms.GroupBox grpbx_medications;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add_condition_and_medication;
        private System.Windows.Forms.ListBox listbox_apptmt__conds_and_meds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save_appointment;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_appointment_detals_animal_client;
        private System.Windows.Forms.Label lbl_appointmentdetails_time;
        private SingleConditionDataSet singleConditionDataSet;
        private System.Windows.Forms.BindingSource singleConditionBindingSource;
        private SingleConditionDataSetTableAdapters.ConditionTableAdapter singleConditionTableAdapter;
        private SingleConditionDataSetTableAdapters.TableAdapterManager tableAdapterManager3;
        private System.Windows.Forms.TextBox cond_descriptionTextBox;
        private System.Windows.Forms.TextBox cond_titleTextBox;
        private SingleMedicationDataSet singleMedicationDataSet;
        private System.Windows.Forms.BindingSource singleMedicationBindingSource;
        private SingleMedicationDataSetTableAdapters.MedicationTableAdapter singleMedicationTableAdapter;
        private SingleMedicationDataSetTableAdapters.TableAdapterManager tableAdapterManager4;
        private System.Windows.Forms.TextBox unitsTextBox;
        private System.Windows.Forms.TextBox med_nameTextBox;
        private ObservedDataSet observedDataSet;
        private System.Windows.Forms.BindingSource observedBindingSource;
        private ObservedDataSetTableAdapters.ObservedTableAdapter observedTableAdapter;
        private ObservedDataSetTableAdapters.TableAdapterManager tableAdapterManager5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_invoice_amt;
        private System.Windows.Forms.Label label4;
        private InvoiceDataSet invoiceDataSet;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private InvoiceDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private InvoiceDataSetTableAdapters.TableAdapterManager tableAdapterManager6;
        private System.Windows.Forms.CheckBox checkbox_paid_now;
    }
}