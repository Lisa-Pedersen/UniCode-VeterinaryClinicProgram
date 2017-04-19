namespace VeterinaryClinicDatabase
{
    partial class Frm_Staff
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
            System.Windows.Forms.Label lbl_staff_first_name;
            System.Windows.Forms.Label lbl_staff_last_name;
            System.Windows.Forms.Label lbl_staff_role;
            System.Windows.Forms.Label lbl_specialty_name;
            System.Windows.Forms.Label lbl_specialty_description;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Staff));
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffDataSet = new VeterinaryClinicDatabase.StaffDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_header_staff = new System.Windows.Forms.Label();
            this.singleStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleStaffDataSet = new VeterinaryClinicDatabase.SingleStaffDataSet();
            this.staffTableAdapter = new VeterinaryClinicDatabase.StaffDataSetTableAdapters.StaffTableAdapter();
            this.singleStaffTableAdapter = new VeterinaryClinicDatabase.SingleStaffDataSetTableAdapters.StaffTableAdapter();
            this.tableAdapterManager = new VeterinaryClinicDatabase.SingleStaffDataSetTableAdapters.TableAdapterManager();
            this.txt_staff_first_name = new System.Windows.Forms.TextBox();
            this.btn_staff_save = new System.Windows.Forms.Button();
            this.txt_staff_last_name = new System.Windows.Forms.TextBox();
            this.btn_staff_clear = new System.Windows.Forms.Button();
            this.comboBox_staff_role = new System.Windows.Forms.ComboBox();
            this.btn_staff_delete = new System.Windows.Forms.Button();
            this.groupBox_staff_details = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_specialty_remove = new System.Windows.Forms.Button();
            this.listbox_singleStaff_specialties = new System.Windows.Forms.ListBox();
            this.lbl_staff_specialties = new System.Windows.Forms.Label();
            this.lbl_staff_name_search = new System.Windows.Forms.Label();
            this.txt_staff_name_searchbox = new System.Windows.Forms.TextBox();
            this.btn_find_staff = new System.Windows.Forms.Button();
            this.btn_reset_staff_listbox = new System.Windows.Forms.Button();
            this.btn_staff_close = new System.Windows.Forms.Button();
            this.listbox_AllStaff = new System.Windows.Forms.ListBox();
            this.listbox_avaliable_specialties = new System.Windows.Forms.ListBox();
            this.groupbox_Specialties = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_specialty_add = new System.Windows.Forms.Button();
            this.specialty_nameTextBox = new System.Windows.Forms.TextBox();
            this.singleSpecialtyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleSpecialtyDataSet = new VeterinaryClinicDatabase.SingleSpecialtyDataSet();
            this.specialty_descriptionTextBox = new System.Windows.Forms.TextBox();
            this.singleSpecialtyTableAdapter = new VeterinaryClinicDatabase.SingleSpecialtyDataSetTableAdapters.SpecialtyTableAdapter();
            this.specialtyDataSet = new VeterinaryClinicDatabase.SpecialtyDataSet();
            this.specialtyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialtyTableAdapter = new VeterinaryClinicDatabase.SpecialtyDataSetTableAdapters.SpecialtyTableAdapter();
            this.singleStaffSpecialtyDataSet = new VeterinaryClinicDatabase.SingleStaffSpecialtyDataSet();
            this.singleStaffspecialtyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleStaffSpecialtyTableAdapter = new VeterinaryClinicDatabase.SingleStaffSpecialtyDataSetTableAdapters.SpecialtyTableAdapter();
            this.staffSpecialtyDataSet = new VeterinaryClinicDatabase.StaffSpecialtyDataSet();
            this.staffSpecialtyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffSpecialtyTableAdapter = new VeterinaryClinicDatabase.StaffSpecialtyDataSetTableAdapters.StaffSpecialtyTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            lbl_staff_first_name = new System.Windows.Forms.Label();
            lbl_staff_last_name = new System.Windows.Forms.Label();
            lbl_staff_role = new System.Windows.Forms.Label();
            lbl_specialty_name = new System.Windows.Forms.Label();
            lbl_specialty_description = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffDataSet)).BeginInit();
            this.groupBox_staff_details.SuspendLayout();
            this.groupbox_Specialties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleSpecialtyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleSpecialtyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffSpecialtyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffspecialtyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffSpecialtyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffSpecialtyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_staff_first_name
            // 
            lbl_staff_first_name.AutoSize = true;
            lbl_staff_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_staff_first_name.Location = new System.Drawing.Point(13, 33);
            lbl_staff_first_name.Name = "lbl_staff_first_name";
            lbl_staff_first_name.Size = new System.Drawing.Size(73, 16);
            lbl_staff_first_name.TabIndex = 9;
            lbl_staff_first_name.Text = "First Name";
            // 
            // lbl_staff_last_name
            // 
            lbl_staff_last_name.AutoSize = true;
            lbl_staff_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_staff_last_name.Location = new System.Drawing.Point(13, 59);
            lbl_staff_last_name.Name = "lbl_staff_last_name";
            lbl_staff_last_name.Size = new System.Drawing.Size(76, 16);
            lbl_staff_last_name.TabIndex = 11;
            lbl_staff_last_name.Text = "Last Name:";
            // 
            // lbl_staff_role
            // 
            lbl_staff_role.AutoSize = true;
            lbl_staff_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_staff_role.Location = new System.Drawing.Point(13, 85);
            lbl_staff_role.Name = "lbl_staff_role";
            lbl_staff_role.Size = new System.Drawing.Size(40, 16);
            lbl_staff_role.TabIndex = 13;
            lbl_staff_role.Text = "Role:";
            // 
            // lbl_specialty_name
            // 
            lbl_specialty_name.AutoSize = true;
            lbl_specialty_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_specialty_name.Location = new System.Drawing.Point(383, 54);
            lbl_specialty_name.Name = "lbl_specialty_name";
            lbl_specialty_name.Size = new System.Drawing.Size(48, 16);
            lbl_specialty_name.TabIndex = 34;
            lbl_specialty_name.Text = "Name:";
            // 
            // lbl_specialty_description
            // 
            lbl_specialty_description.AutoSize = true;
            lbl_specialty_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_specialty_description.Location = new System.Drawing.Point(384, 98);
            lbl_specialty_description.Name = "lbl_specialty_description";
            lbl_specialty_description.Size = new System.Drawing.Size(79, 16);
            lbl_specialty_description.TabIndex = 36;
            lbl_specialty_description.Text = "Description:";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.staffDataSet;
            // 
            // staffDataSet
            // 
            this.staffDataSet.DataSetName = "StaffDataSet";
            this.staffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_header_staff
            // 
            this.lbl_header_staff.AutoSize = true;
            this.lbl_header_staff.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header_staff.Location = new System.Drawing.Point(73, 18);
            this.lbl_header_staff.Name = "lbl_header_staff";
            this.lbl_header_staff.Size = new System.Drawing.Size(120, 44);
            this.lbl_header_staff.TabIndex = 7;
            this.lbl_header_staff.Text = "Staff";
            // 
            // singleStaffBindingSource
            // 
            this.singleStaffBindingSource.DataMember = "Staff";
            this.singleStaffBindingSource.DataSource = this.singleStaffDataSet;
            // 
            // singleStaffDataSet
            // 
            this.singleStaffDataSet.DataSetName = "SingleStaffDataSet";
            this.singleStaffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // singleStaffTableAdapter
            // 
            this.singleStaffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StaffTableAdapter = this.singleStaffTableAdapter;
            this.tableAdapterManager.UpdateOrder = VeterinaryClinicDatabase.SingleStaffDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txt_staff_first_name
            // 
            this.txt_staff_first_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleStaffBindingSource, "first_name", true));
            this.txt_staff_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staff_first_name.Location = new System.Drawing.Point(127, 30);
            this.txt_staff_first_name.Name = "txt_staff_first_name";
            this.txt_staff_first_name.Size = new System.Drawing.Size(200, 22);
            this.txt_staff_first_name.TabIndex = 10;
            this.txt_staff_first_name.TextChanged += new System.EventHandler(this.Staff_Details_TextChanged);
            // 
            // btn_staff_save
            // 
            this.btn_staff_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_save.Location = new System.Drawing.Point(223, 133);
            this.btn_staff_save.Name = "btn_staff_save";
            this.btn_staff_save.Size = new System.Drawing.Size(97, 27);
            this.btn_staff_save.TabIndex = 24;
            this.btn_staff_save.Text = "Save Staff";
            this.btn_staff_save.UseVisualStyleBackColor = true;
            this.btn_staff_save.Click += new System.EventHandler(this.btn_staff_save_Click);
            // 
            // txt_staff_last_name
            // 
            this.txt_staff_last_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleStaffBindingSource, "last_name", true));
            this.txt_staff_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staff_last_name.Location = new System.Drawing.Point(127, 56);
            this.txt_staff_last_name.Name = "txt_staff_last_name";
            this.txt_staff_last_name.Size = new System.Drawing.Size(200, 22);
            this.txt_staff_last_name.TabIndex = 12;
            this.txt_staff_last_name.TextChanged += new System.EventHandler(this.Staff_Details_TextChanged);
            // 
            // btn_staff_clear
            // 
            this.btn_staff_clear.Enabled = false;
            this.btn_staff_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_clear.Location = new System.Drawing.Point(120, 133);
            this.btn_staff_clear.Name = "btn_staff_clear";
            this.btn_staff_clear.Size = new System.Drawing.Size(97, 27);
            this.btn_staff_clear.TabIndex = 25;
            this.btn_staff_clear.Text = "Clear Details";
            this.btn_staff_clear.UseVisualStyleBackColor = true;
            this.btn_staff_clear.Click += new System.EventHandler(this.btn_staff_clear_Click);
            // 
            // comboBox_staff_role
            // 
            this.comboBox_staff_role.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleStaffBindingSource, "staff_role", true));
            this.comboBox_staff_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_staff_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_staff_role.FormattingEnabled = true;
            this.comboBox_staff_role.Items.AddRange(new object[] {
            "Veterinarian",
            "Office Staff",
            "Duty Manager"});
            this.comboBox_staff_role.Location = new System.Drawing.Point(127, 82);
            this.comboBox_staff_role.Name = "comboBox_staff_role";
            this.comboBox_staff_role.Size = new System.Drawing.Size(200, 24);
            this.comboBox_staff_role.TabIndex = 14;
            this.comboBox_staff_role.TextChanged += new System.EventHandler(this.Staff_Details_TextChanged);
            // 
            // btn_staff_delete
            // 
            this.btn_staff_delete.Enabled = false;
            this.btn_staff_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_delete.Location = new System.Drawing.Point(9, 133);
            this.btn_staff_delete.Name = "btn_staff_delete";
            this.btn_staff_delete.Size = new System.Drawing.Size(97, 27);
            this.btn_staff_delete.TabIndex = 27;
            this.btn_staff_delete.Text = "Delete Staff";
            this.btn_staff_delete.UseVisualStyleBackColor = true;
            this.btn_staff_delete.Click += new System.EventHandler(this.btn_staff_delete_Click);
            // 
            // groupBox_staff_details
            // 
            this.groupBox_staff_details.Controls.Add(this.label4);
            this.groupBox_staff_details.Controls.Add(this.label3);
            this.groupBox_staff_details.Controls.Add(this.label5);
            this.groupBox_staff_details.Controls.Add(this.btn_specialty_remove);
            this.groupBox_staff_details.Controls.Add(this.btn_staff_delete);
            this.groupBox_staff_details.Controls.Add(this.comboBox_staff_role);
            this.groupBox_staff_details.Controls.Add(this.listbox_singleStaff_specialties);
            this.groupBox_staff_details.Controls.Add(lbl_staff_role);
            this.groupBox_staff_details.Controls.Add(this.btn_staff_clear);
            this.groupBox_staff_details.Controls.Add(this.txt_staff_last_name);
            this.groupBox_staff_details.Controls.Add(this.btn_staff_save);
            this.groupBox_staff_details.Controls.Add(this.lbl_staff_specialties);
            this.groupBox_staff_details.Controls.Add(lbl_staff_last_name);
            this.groupBox_staff_details.Controls.Add(this.txt_staff_first_name);
            this.groupBox_staff_details.Controls.Add(lbl_staff_first_name);
            this.groupBox_staff_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_staff_details.Location = new System.Drawing.Point(424, 70);
            this.groupBox_staff_details.Name = "groupBox_staff_details";
            this.groupBox_staff_details.Size = new System.Drawing.Size(844, 166);
            this.groupBox_staff_details.TabIndex = 29;
            this.groupBox_staff_details.TabStop = false;
            this.groupBox_staff_details.Text = "Staff Details:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(329, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(329, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(626, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "* (at least one)";
            // 
            // btn_specialty_remove
            // 
            this.btn_specialty_remove.Enabled = false;
            this.btn_specialty_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_specialty_remove.Location = new System.Drawing.Point(711, 133);
            this.btn_specialty_remove.Name = "btn_specialty_remove";
            this.btn_specialty_remove.Size = new System.Drawing.Size(127, 27);
            this.btn_specialty_remove.TabIndex = 40;
            this.btn_specialty_remove.Text = "Remove Specialty";
            this.btn_specialty_remove.UseVisualStyleBackColor = true;
            this.btn_specialty_remove.Click += new System.EventHandler(this.btn_specialty_remove_Click);
            // 
            // listbox_singleStaff_specialties
            // 
            this.listbox_singleStaff_specialties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_singleStaff_specialties.FormattingEnabled = true;
            this.listbox_singleStaff_specialties.ItemHeight = 16;
            this.listbox_singleStaff_specialties.Location = new System.Drawing.Point(358, 44);
            this.listbox_singleStaff_specialties.Name = "listbox_singleStaff_specialties";
            this.listbox_singleStaff_specialties.Size = new System.Drawing.Size(347, 116);
            this.listbox_singleStaff_specialties.TabIndex = 31;
            this.listbox_singleStaff_specialties.SelectedValueChanged += new System.EventHandler(this.Specialties_Listboxes_Click);
            // 
            // lbl_staff_specialties
            // 
            this.lbl_staff_specialties.AutoSize = true;
            this.lbl_staff_specialties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staff_specialties.Location = new System.Drawing.Point(355, 25);
            this.lbl_staff_specialties.Name = "lbl_staff_specialties";
            this.lbl_staff_specialties.Size = new System.Drawing.Size(182, 16);
            this.lbl_staff_specialties.TabIndex = 22;
            this.lbl_staff_specialties.Text = "Veterinarian Staff Specialties:";
            // 
            // lbl_staff_name_search
            // 
            this.lbl_staff_name_search.AutoSize = true;
            this.lbl_staff_name_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staff_name_search.Location = new System.Drawing.Point(12, 75);
            this.lbl_staff_name_search.Name = "lbl_staff_name_search";
            this.lbl_staff_name_search.Size = new System.Drawing.Size(48, 16);
            this.lbl_staff_name_search.TabIndex = 17;
            this.lbl_staff_name_search.Text = "Name:";
            // 
            // txt_staff_name_searchbox
            // 
            this.txt_staff_name_searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staff_name_searchbox.Location = new System.Drawing.Point(66, 72);
            this.txt_staff_name_searchbox.Name = "txt_staff_name_searchbox";
            this.txt_staff_name_searchbox.Size = new System.Drawing.Size(180, 22);
            this.txt_staff_name_searchbox.TabIndex = 18;
            // 
            // btn_find_staff
            // 
            this.btn_find_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find_staff.Location = new System.Drawing.Point(252, 70);
            this.btn_find_staff.Name = "btn_find_staff";
            this.btn_find_staff.Size = new System.Drawing.Size(75, 27);
            this.btn_find_staff.TabIndex = 19;
            this.btn_find_staff.Text = "Find";
            this.btn_find_staff.UseVisualStyleBackColor = true;
            this.btn_find_staff.Click += new System.EventHandler(this.btn_find_staff_Click);
            // 
            // btn_reset_staff_listbox
            // 
            this.btn_reset_staff_listbox.Enabled = false;
            this.btn_reset_staff_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset_staff_listbox.Location = new System.Drawing.Point(333, 70);
            this.btn_reset_staff_listbox.Name = "btn_reset_staff_listbox";
            this.btn_reset_staff_listbox.Size = new System.Drawing.Size(75, 27);
            this.btn_reset_staff_listbox.TabIndex = 20;
            this.btn_reset_staff_listbox.Text = "Reset";
            this.btn_reset_staff_listbox.UseVisualStyleBackColor = true;
            this.btn_reset_staff_listbox.Click += new System.EventHandler(this.btn_reset_staff_listbox_Click);
            // 
            // btn_staff_close
            // 
            this.btn_staff_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_close.Location = new System.Drawing.Point(1193, 477);
            this.btn_staff_close.Name = "btn_staff_close";
            this.btn_staff_close.Size = new System.Drawing.Size(87, 31);
            this.btn_staff_close.TabIndex = 23;
            this.btn_staff_close.Text = "Close";
            this.btn_staff_close.UseVisualStyleBackColor = true;
            this.btn_staff_close.Click += new System.EventHandler(this.btn_staff_close_Click);
            // 
            // listbox_AllStaff
            // 
            this.listbox_AllStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_AllStaff.FormattingEnabled = true;
            this.listbox_AllStaff.ItemHeight = 16;
            this.listbox_AllStaff.Location = new System.Drawing.Point(12, 103);
            this.listbox_AllStaff.Name = "listbox_AllStaff";
            this.listbox_AllStaff.Size = new System.Drawing.Size(396, 404);
            this.listbox_AllStaff.TabIndex = 30;
            this.listbox_AllStaff.SelectedValueChanged += new System.EventHandler(this.listbox_AllStaff_Click);
            // 
            // listbox_avaliable_specialties
            // 
            this.listbox_avaliable_specialties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_avaliable_specialties.FormattingEnabled = true;
            this.listbox_avaliable_specialties.ItemHeight = 16;
            this.listbox_avaliable_specialties.Location = new System.Drawing.Point(16, 25);
            this.listbox_avaliable_specialties.Name = "listbox_avaliable_specialties";
            this.listbox_avaliable_specialties.Size = new System.Drawing.Size(361, 228);
            this.listbox_avaliable_specialties.TabIndex = 32;
            this.listbox_avaliable_specialties.SelectedValueChanged += new System.EventHandler(this.Specialties_Listboxes_Click);
            // 
            // groupbox_Specialties
            // 
            this.groupbox_Specialties.Controls.Add(this.label1);
            this.groupbox_Specialties.Controls.Add(this.btn_specialty_add);
            this.groupbox_Specialties.Controls.Add(lbl_specialty_name);
            this.groupbox_Specialties.Controls.Add(this.specialty_nameTextBox);
            this.groupbox_Specialties.Controls.Add(lbl_specialty_description);
            this.groupbox_Specialties.Controls.Add(this.specialty_descriptionTextBox);
            this.groupbox_Specialties.Controls.Add(this.listbox_avaliable_specialties);
            this.groupbox_Specialties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_Specialties.Location = new System.Drawing.Point(424, 242);
            this.groupbox_Specialties.Name = "groupbox_Specialties";
            this.groupbox_Specialties.Size = new System.Drawing.Size(755, 265);
            this.groupbox_Specialties.TabIndex = 33;
            this.groupbox_Specialties.TabStop = false;
            this.groupbox_Specialties.Text = "Specialties Available to Add to a Veterinarian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Specialty Details:";
            // 
            // btn_specialty_add
            // 
            this.btn_specialty_add.Enabled = false;
            this.btn_specialty_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_specialty_add.Location = new System.Drawing.Point(622, 232);
            this.btn_specialty_add.Name = "btn_specialty_add";
            this.btn_specialty_add.Size = new System.Drawing.Size(127, 27);
            this.btn_specialty_add.TabIndex = 38;
            this.btn_specialty_add.Text = "Add Specialty";
            this.btn_specialty_add.UseVisualStyleBackColor = true;
            this.btn_specialty_add.Click += new System.EventHandler(this.btn_specialty_add_Click);
            // 
            // specialty_nameTextBox
            // 
            this.specialty_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleSpecialtyBindingSource, "specialty_name", true));
            this.specialty_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialty_nameTextBox.Location = new System.Drawing.Point(399, 73);
            this.specialty_nameTextBox.Name = "specialty_nameTextBox";
            this.specialty_nameTextBox.ReadOnly = true;
            this.specialty_nameTextBox.Size = new System.Drawing.Size(350, 22);
            this.specialty_nameTextBox.TabIndex = 35;
            // 
            // singleSpecialtyBindingSource
            // 
            this.singleSpecialtyBindingSource.DataMember = "Specialty";
            this.singleSpecialtyBindingSource.DataSource = this.singleSpecialtyDataSet;
            // 
            // singleSpecialtyDataSet
            // 
            this.singleSpecialtyDataSet.DataSetName = "SingleSpecialtyDataSet";
            this.singleSpecialtyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialty_descriptionTextBox
            // 
            this.specialty_descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleSpecialtyBindingSource, "specialty_description", true));
            this.specialty_descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialty_descriptionTextBox.Location = new System.Drawing.Point(399, 117);
            this.specialty_descriptionTextBox.Multiline = true;
            this.specialty_descriptionTextBox.Name = "specialty_descriptionTextBox";
            this.specialty_descriptionTextBox.ReadOnly = true;
            this.specialty_descriptionTextBox.Size = new System.Drawing.Size(350, 104);
            this.specialty_descriptionTextBox.TabIndex = 37;
            // 
            // singleSpecialtyTableAdapter
            // 
            this.singleSpecialtyTableAdapter.ClearBeforeFill = true;
            // 
            // specialtyDataSet
            // 
            this.specialtyDataSet.DataSetName = "SpecialtyDataSet";
            this.specialtyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialtyBindingSource
            // 
            this.specialtyBindingSource.DataMember = "Specialty";
            this.specialtyBindingSource.DataSource = this.specialtyDataSet;
            // 
            // specialtyTableAdapter
            // 
            this.specialtyTableAdapter.ClearBeforeFill = true;
            // 
            // singleStaffSpecialtyDataSet
            // 
            this.singleStaffSpecialtyDataSet.DataSetName = "SingleStaffSpecialtyDataSet";
            this.singleStaffSpecialtyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // singleStaffspecialtyBindingSource
            // 
            this.singleStaffspecialtyBindingSource.DataMember = "Specialty";
            this.singleStaffspecialtyBindingSource.DataSource = this.singleStaffSpecialtyDataSet;
            // 
            // singleStaffSpecialtyTableAdapter
            // 
            this.singleStaffSpecialtyTableAdapter.ClearBeforeFill = true;
            // 
            // staffSpecialtyDataSet
            // 
            this.staffSpecialtyDataSet.DataSetName = "StaffSpecialtyDataSet";
            this.staffSpecialtyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffSpecialtyBindingSource
            // 
            this.staffSpecialtyBindingSource.DataMember = "StaffSpecialty";
            this.staffSpecialtyBindingSource.DataSource = this.staffSpecialtyDataSet;
            // 
            // staffSpecialtyTableAdapter
            // 
            this.staffSpecialtyTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1156, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "* Required Information";
            // 
            // Frm_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 520);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupbox_Specialties);
            this.Controls.Add(this.listbox_AllStaff);
            this.Controls.Add(this.btn_staff_close);
            this.Controls.Add(this.btn_reset_staff_listbox);
            this.Controls.Add(this.btn_find_staff);
            this.Controls.Add(this.txt_staff_name_searchbox);
            this.Controls.Add(this.lbl_staff_name_search);
            this.Controls.Add(this.lbl_header_staff);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_staff_details);
            this.Name = "Frm_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Veterinary Clinic Application";
            this.Load += new System.EventHandler(this.Frm_Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffDataSet)).EndInit();
            this.groupBox_staff_details.ResumeLayout(false);
            this.groupBox_staff_details.PerformLayout();
            this.groupbox_Specialties.ResumeLayout(false);
            this.groupbox_Specialties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleSpecialtyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleSpecialtyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffSpecialtyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffspecialtyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffSpecialtyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffSpecialtyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Datasets
        private StaffDataSet staffDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private StaffDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private SingleStaffDataSet singleStaffDataSet;
        private System.Windows.Forms.BindingSource singleStaffBindingSource;
        private SingleStaffDataSetTableAdapters.StaffTableAdapter singleStaffTableAdapter;
        private SingleStaffDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private SpecialtyDataSet specialtyDataSet;
        private System.Windows.Forms.BindingSource specialtyBindingSource;
        private SpecialtyDataSetTableAdapters.SpecialtyTableAdapter specialtyTableAdapter;
        private SingleSpecialtyDataSet singleSpecialtyDataSet;
        private System.Windows.Forms.BindingSource singleSpecialtyBindingSource;
        private SingleSpecialtyDataSetTableAdapters.SpecialtyTableAdapter singleSpecialtyTableAdapter;
        private SingleStaffSpecialtyDataSet singleStaffSpecialtyDataSet;
        private System.Windows.Forms.BindingSource singleStaffspecialtyBindingSource;
        private SingleStaffSpecialtyDataSetTableAdapters.SpecialtyTableAdapter singleStaffSpecialtyTableAdapter;

        // Controls
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_header_staff;
        private System.Windows.Forms.TextBox txt_staff_first_name;
        private System.Windows.Forms.Button btn_staff_save;
        private System.Windows.Forms.TextBox txt_staff_last_name;
        private System.Windows.Forms.Button btn_staff_clear;
        private System.Windows.Forms.ComboBox comboBox_staff_role;
        private System.Windows.Forms.Button btn_staff_delete;
        private System.Windows.Forms.GroupBox groupBox_staff_details;
        private System.Windows.Forms.Label lbl_staff_name_search;
        private System.Windows.Forms.TextBox txt_staff_name_searchbox;
        private System.Windows.Forms.Button btn_find_staff;
        private System.Windows.Forms.Button btn_reset_staff_listbox;
        private System.Windows.Forms.Label lbl_staff_specialties;
        private System.Windows.Forms.Button btn_staff_close;
        private System.Windows.Forms.ListBox listbox_AllStaff;
        private System.Windows.Forms.ListBox listbox_singleStaff_specialties;
        private System.Windows.Forms.ListBox listbox_avaliable_specialties;
        private System.Windows.Forms.GroupBox groupbox_Specialties;
        private System.Windows.Forms.TextBox specialty_nameTextBox;
        private System.Windows.Forms.TextBox specialty_descriptionTextBox;
        private System.Windows.Forms.Button btn_specialty_remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_specialty_add;
        private StaffSpecialtyDataSet staffSpecialtyDataSet;
        private System.Windows.Forms.BindingSource staffSpecialtyBindingSource;
        private StaffSpecialtyDataSetTableAdapters.StaffSpecialtyTableAdapter staffSpecialtyTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}