namespace VeterinaryClinicDatabase
{
    partial class Frm_Client_Access
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
            System.Windows.Forms.Label contact_phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label suburbLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label postcodeLabel;
            System.Windows.Forms.Label animal_nameLabel;
            System.Windows.Forms.Label breedLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label dobLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Client_Access));
            this.singleClientDataSet = new VeterinaryClinicDatabase.SingleClientDataSet();
            this.singleClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleClientTableAdapter = new VeterinaryClinicDatabase.SingleClientDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new VeterinaryClinicDatabase.SingleClientDataSetTableAdapters.TableAdapterManager();
            this.contact_phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.suburbTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.postcodeTextBox = new System.Windows.Forms.TextBox();
            this.lbl_Client_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpbox_singleclients_details = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_singleclient_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbox_singleclient_animals = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_singleclient_clearanimal_details = new System.Windows.Forms.Button();
            this.btn_singleclient_saveanimal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.animal_nameTextBox = new System.Windows.Forms.TextBox();
            this.singleAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleAnimalDataSet = new VeterinaryClinicDatabase.SingleAnimalDataSet();
            this.breedTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listbox_singleclient_animals = new System.Windows.Forms.ListBox();
            this.btn_add_appointment = new System.Windows.Forms.Button();
            this.singleAnimalTableAdapter = new VeterinaryClinicDatabase.SingleAnimalDataSetTableAdapters.AnimalTableAdapter();
            this.groupBox_appointment_details = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.specialty_descriptionTextBox = new System.Windows.Forms.TextBox();
            this.singleSpecialtyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleSpecialtyDataSet = new VeterinaryClinicDatabase.SingleSpecialtyDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listbox_appointment_staffSpecialties = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_appointment_staff = new System.Windows.Forms.ComboBox();
            this.listbox_appointment_scheduleslots = new System.Windows.Forms.ListBox();
            this.dtp_appointment_date = new System.Windows.Forms.DateTimePicker();
            this.scheduleSlotDataSet = new VeterinaryClinicDatabase.ScheduleSlotDataSet();
            this.scheduleSlotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleSlotTableAdapter = new VeterinaryClinicDatabase.ScheduleSlotDataSetTableAdapters.ScheduleSlotTableAdapter();
            this.animalDataSet = new VeterinaryClinicDatabase.AnimalDataSet();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new VeterinaryClinicDatabase.AnimalDataSetTableAdapters.AnimalTableAdapter();
            this.singleStaffDataSet = new VeterinaryClinicDatabase.SingleStaffDataSet();
            this.singleStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleStaffTableAdapter = new VeterinaryClinicDatabase.SingleStaffDataSetTableAdapters.StaffTableAdapter();
            this.staffDataSet = new VeterinaryClinicDatabase.StaffDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new VeterinaryClinicDatabase.StaffDataSetTableAdapters.StaffTableAdapter();
            this.singleStaffSpecialtyDataSet = new VeterinaryClinicDatabase.SingleStaffSpecialtyDataSet();
            this.singleStaffSpecialtyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleStaffSpecialtyTableAdapter = new VeterinaryClinicDatabase.SingleStaffSpecialtyDataSetTableAdapters.SpecialtyTableAdapter();
            this.singleSpecialtyTableAdapter = new VeterinaryClinicDatabase.SingleSpecialtyDataSetTableAdapters.SpecialtyTableAdapter();
            this.tableAdapterManager1 = new VeterinaryClinicDatabase.SingleSpecialtyDataSetTableAdapters.TableAdapterManager();
            this.btn_client_access_logout = new System.Windows.Forms.Button();
            this.listBox_upcoming_appointments = new System.Windows.Forms.ListBox();
            this.lbl_upcoming_appointments = new System.Windows.Forms.Label();
            this.appointmentDataSet = new VeterinaryClinicDatabase.AppointmentDataSet();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTableAdapter = new VeterinaryClinicDatabase.AppointmentDataSetTableAdapters.AppointmentTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            contact_phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            suburbLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            postcodeLabel = new System.Windows.Forms.Label();
            animal_nameLabel = new System.Windows.Forms.Label();
            breedLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            dobLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpbox_singleclients_details.SuspendLayout();
            this.grpbox_singleclient_animals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleAnimalDataSet)).BeginInit();
            this.groupBox_appointment_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleSpecialtyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleSpecialtyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleSlotDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleSlotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffSpecialtyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffSpecialtyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contact_phoneLabel
            // 
            contact_phoneLabel.AutoSize = true;
            contact_phoneLabel.Location = new System.Drawing.Point(6, 21);
            contact_phoneLabel.Name = "contact_phoneLabel";
            contact_phoneLabel.Size = new System.Drawing.Size(98, 16);
            contact_phoneLabel.TabIndex = 6;
            contact_phoneLabel.Text = "Contact Phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(6, 47);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(89, 16);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email (Login):";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(6, 100);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(46, 16);
            streetLabel.TabIndex = 10;
            streetLabel.Text = "Street:";
            // 
            // suburbLabel
            // 
            suburbLabel.AutoSize = true;
            suburbLabel.Location = new System.Drawing.Point(6, 126);
            suburbLabel.Name = "suburbLabel";
            suburbLabel.Size = new System.Drawing.Size(54, 16);
            suburbLabel.TabIndex = 12;
            suburbLabel.Text = "Suburb:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(6, 152);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(33, 16);
            cityLabel.TabIndex = 14;
            cityLabel.Text = "City:";
            // 
            // postcodeLabel
            // 
            postcodeLabel.AutoSize = true;
            postcodeLabel.Location = new System.Drawing.Point(274, 152);
            postcodeLabel.Name = "postcodeLabel";
            postcodeLabel.Size = new System.Drawing.Size(69, 16);
            postcodeLabel.TabIndex = 16;
            postcodeLabel.Text = "Postcode:";
            // 
            // animal_nameLabel
            // 
            animal_nameLabel.AutoSize = true;
            animal_nameLabel.Location = new System.Drawing.Point(338, 49);
            animal_nameLabel.Name = "animal_nameLabel";
            animal_nameLabel.Size = new System.Drawing.Size(48, 16);
            animal_nameLabel.TabIndex = 3;
            animal_nameLabel.Text = "Name:";
            // 
            // breedLabel
            // 
            breedLabel.AutoSize = true;
            breedLabel.Location = new System.Drawing.Point(338, 77);
            breedLabel.Name = "breedLabel";
            breedLabel.Size = new System.Drawing.Size(48, 16);
            breedLabel.TabIndex = 5;
            breedLabel.Text = "Breed:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(338, 105);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(66, 16);
            categoryLabel.TabIndex = 7;
            categoryLabel.Text = "Category:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(338, 133);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(34, 16);
            sexLabel.TabIndex = 9;
            sexLabel.Text = "Sex:";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new System.Drawing.Point(338, 164);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new System.Drawing.Size(83, 16);
            dobLabel.TabIndex = 11;
            dobLabel.Text = "Date of Birth:";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = this.singleClientTableAdapter;
            this.tableAdapterManager.UpdateOrder = VeterinaryClinicDatabase.SingleClientDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contact_phoneTextBox
            // 
            this.contact_phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "contact_phone", true));
            this.contact_phoneTextBox.Location = new System.Drawing.Point(106, 18);
            this.contact_phoneTextBox.Name = "contact_phoneTextBox";
            this.contact_phoneTextBox.Size = new System.Drawing.Size(237, 22);
            this.contact_phoneTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(106, 44);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(237, 22);
            this.emailTextBox.TabIndex = 9;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "street", true));
            this.streetTextBox.Location = new System.Drawing.Point(106, 97);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(336, 22);
            this.streetTextBox.TabIndex = 11;
            // 
            // suburbTextBox
            // 
            this.suburbTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "suburb", true));
            this.suburbTextBox.Location = new System.Drawing.Point(106, 123);
            this.suburbTextBox.Name = "suburbTextBox";
            this.suburbTextBox.Size = new System.Drawing.Size(336, 22);
            this.suburbTextBox.TabIndex = 13;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(106, 149);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(162, 22);
            this.cityTextBox.TabIndex = 15;
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "postcode", true));
            this.postcodeTextBox.Location = new System.Drawing.Point(349, 149);
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(93, 22);
            this.postcodeTextBox.TabIndex = 17;
            // 
            // lbl_Client_name
            // 
            this.lbl_Client_name.AutoSize = true;
            this.lbl_Client_name.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Client_name.Location = new System.Drawing.Point(73, 18);
            this.lbl_Client_name.Name = "lbl_Client_name";
            this.lbl_Client_name.Size = new System.Drawing.Size(136, 44);
            this.lbl_Client_name.TabIndex = 19;
            this.lbl_Client_name.Text = "Hello ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // grpbox_singleclients_details
            // 
            this.grpbox_singleclients_details.Controls.Add(this.label13);
            this.grpbox_singleclients_details.Controls.Add(this.label9);
            this.grpbox_singleclients_details.Controls.Add(this.btn_singleclient_save);
            this.grpbox_singleclients_details.Controls.Add(this.label1);
            this.grpbox_singleclients_details.Controls.Add(this.postcodeTextBox);
            this.grpbox_singleclients_details.Controls.Add(postcodeLabel);
            this.grpbox_singleclients_details.Controls.Add(this.cityTextBox);
            this.grpbox_singleclients_details.Controls.Add(cityLabel);
            this.grpbox_singleclients_details.Controls.Add(this.suburbTextBox);
            this.grpbox_singleclients_details.Controls.Add(suburbLabel);
            this.grpbox_singleclients_details.Controls.Add(contact_phoneLabel);
            this.grpbox_singleclients_details.Controls.Add(this.streetTextBox);
            this.grpbox_singleclients_details.Controls.Add(this.contact_phoneTextBox);
            this.grpbox_singleclients_details.Controls.Add(streetLabel);
            this.grpbox_singleclients_details.Controls.Add(emailLabel);
            this.grpbox_singleclients_details.Controls.Add(this.emailTextBox);
            this.grpbox_singleclients_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox_singleclients_details.Location = new System.Drawing.Point(12, 84);
            this.grpbox_singleclients_details.Name = "grpbox_singleclients_details";
            this.grpbox_singleclients_details.Size = new System.Drawing.Size(455, 230);
            this.grpbox_singleclients_details.TabIndex = 20;
            this.grpbox_singleclients_details.TabStop = false;
            this.grpbox_singleclients_details.Text = "Your Details";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(346, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 16);
            this.label13.TabIndex = 45;
            this.label13.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(346, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "*";
            // 
            // btn_singleclient_save
            // 
            this.btn_singleclient_save.Location = new System.Drawing.Point(336, 196);
            this.btn_singleclient_save.Name = "btn_singleclient_save";
            this.btn_singleclient_save.Size = new System.Drawing.Size(113, 28);
            this.btn_singleclient_save.TabIndex = 19;
            this.btn_singleclient_save.Text = "Save Changes";
            this.btn_singleclient_save.UseVisualStyleBackColor = true;
            this.btn_singleclient_save.Click += new System.EventHandler(this.btn_singleclient_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Address";
            // 
            // grpbox_singleclient_animals
            // 
            this.grpbox_singleclient_animals.Controls.Add(this.label10);
            this.grpbox_singleclient_animals.Controls.Add(this.btn_singleclient_clearanimal_details);
            this.grpbox_singleclient_animals.Controls.Add(this.btn_singleclient_saveanimal);
            this.grpbox_singleclient_animals.Controls.Add(this.label2);
            this.grpbox_singleclient_animals.Controls.Add(animal_nameLabel);
            this.grpbox_singleclient_animals.Controls.Add(this.animal_nameTextBox);
            this.grpbox_singleclient_animals.Controls.Add(breedLabel);
            this.grpbox_singleclient_animals.Controls.Add(this.breedTextBox);
            this.grpbox_singleclient_animals.Controls.Add(categoryLabel);
            this.grpbox_singleclient_animals.Controls.Add(this.categoryTextBox);
            this.grpbox_singleclient_animals.Controls.Add(sexLabel);
            this.grpbox_singleclient_animals.Controls.Add(this.sexComboBox);
            this.grpbox_singleclient_animals.Controls.Add(dobLabel);
            this.grpbox_singleclient_animals.Controls.Add(this.dobDateTimePicker);
            this.grpbox_singleclient_animals.Controls.Add(this.listbox_singleclient_animals);
            this.grpbox_singleclient_animals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox_singleclient_animals.Location = new System.Drawing.Point(473, 84);
            this.grpbox_singleclient_animals.Name = "grpbox_singleclient_animals";
            this.grpbox_singleclient_animals.Size = new System.Drawing.Size(747, 230);
            this.grpbox_singleclient_animals.TabIndex = 21;
            this.grpbox_singleclient_animals.TabStop = false;
            this.grpbox_singleclient_animals.Text = "Your Animals";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(667, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "*";
            // 
            // btn_singleclient_clearanimal_details
            // 
            this.btn_singleclient_clearanimal_details.Location = new System.Drawing.Point(509, 196);
            this.btn_singleclient_clearanimal_details.Name = "btn_singleclient_clearanimal_details";
            this.btn_singleclient_clearanimal_details.Size = new System.Drawing.Size(113, 28);
            this.btn_singleclient_clearanimal_details.TabIndex = 15;
            this.btn_singleclient_clearanimal_details.Text = "Clear Details";
            this.btn_singleclient_clearanimal_details.UseVisualStyleBackColor = true;
            this.btn_singleclient_clearanimal_details.Click += new System.EventHandler(this.btn_singleclient_clearanimal_details_Click);
            // 
            // btn_singleclient_saveanimal
            // 
            this.btn_singleclient_saveanimal.Location = new System.Drawing.Point(628, 196);
            this.btn_singleclient_saveanimal.Name = "btn_singleclient_saveanimal";
            this.btn_singleclient_saveanimal.Size = new System.Drawing.Size(113, 28);
            this.btn_singleclient_saveanimal.TabIndex = 14;
            this.btn_singleclient_saveanimal.Text = "Add Animal";
            this.btn_singleclient_saveanimal.UseVisualStyleBackColor = true;
            this.btn_singleclient_saveanimal.Click += new System.EventHandler(this.btn_singleclient_saveanimal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Animal Details";
            // 
            // animal_nameTextBox
            // 
            this.animal_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleAnimalBindingSource, "animal_name", true));
            this.animal_nameTextBox.Location = new System.Drawing.Point(465, 46);
            this.animal_nameTextBox.Name = "animal_nameTextBox";
            this.animal_nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.animal_nameTextBox.TabIndex = 4;
            // 
            // singleAnimalBindingSource
            // 
            this.singleAnimalBindingSource.DataMember = "Animal";
            this.singleAnimalBindingSource.DataSource = this.singleAnimalDataSet;
            // 
            // singleAnimalDataSet
            // 
            this.singleAnimalDataSet.DataSetName = "SingleAnimalDataSet";
            this.singleAnimalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // breedTextBox
            // 
            this.breedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleAnimalBindingSource, "breed", true));
            this.breedTextBox.Location = new System.Drawing.Point(465, 74);
            this.breedTextBox.Name = "breedTextBox";
            this.breedTextBox.Size = new System.Drawing.Size(200, 22);
            this.breedTextBox.TabIndex = 6;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleAnimalBindingSource, "category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(465, 102);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(200, 22);
            this.categoryTextBox.TabIndex = 8;
            // 
            // sexComboBox
            // 
            this.sexComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleAnimalBindingSource, "sex", true));
            this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Male",
            "Male-desexed",
            "Female",
            "Female-desexed"});
            this.sexComboBox.Location = new System.Drawing.Point(465, 130);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(200, 24);
            this.sexComboBox.TabIndex = 10;
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.singleAnimalBindingSource, "dob", true));
            this.dobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobDateTimePicker.Location = new System.Drawing.Point(465, 160);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(142, 22);
            this.dobDateTimePicker.TabIndex = 12;
            this.dobDateTimePicker.ValueChanged += new System.EventHandler(this.dobDateTimePicker_ValueChanged);
            // 
            // listbox_singleclient_animals
            // 
            this.listbox_singleclient_animals.FormattingEnabled = true;
            this.listbox_singleclient_animals.ItemHeight = 16;
            this.listbox_singleclient_animals.Location = new System.Drawing.Point(9, 21);
            this.listbox_singleclient_animals.Name = "listbox_singleclient_animals";
            this.listbox_singleclient_animals.Size = new System.Drawing.Size(316, 196);
            this.listbox_singleclient_animals.TabIndex = 0;
            this.listbox_singleclient_animals.SelectedValueChanged += new System.EventHandler(this.listbox_singleclient_animals_SelectedValueChanged);
            // 
            // btn_add_appointment
            // 
            this.btn_add_appointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_appointment.Location = new System.Drawing.Point(472, 323);
            this.btn_add_appointment.Name = "btn_add_appointment";
            this.btn_add_appointment.Size = new System.Drawing.Size(135, 28);
            this.btn_add_appointment.TabIndex = 16;
            this.btn_add_appointment.Text = "Add Appointment";
            this.btn_add_appointment.UseVisualStyleBackColor = true;
            this.btn_add_appointment.Click += new System.EventHandler(this.btn_add_appointment_Click);
            // 
            // singleAnimalTableAdapter
            // 
            this.singleAnimalTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox_appointment_details
            // 
            this.groupBox_appointment_details.Controls.Add(this.label12);
            this.groupBox_appointment_details.Controls.Add(this.label11);
            this.groupBox_appointment_details.Controls.Add(this.btn_add_appointment);
            this.groupBox_appointment_details.Controls.Add(this.specialty_descriptionTextBox);
            this.groupBox_appointment_details.Controls.Add(this.label7);
            this.groupBox_appointment_details.Controls.Add(this.label6);
            this.groupBox_appointment_details.Controls.Add(this.label5);
            this.groupBox_appointment_details.Controls.Add(this.label4);
            this.groupBox_appointment_details.Controls.Add(this.listbox_appointment_staffSpecialties);
            this.groupBox_appointment_details.Controls.Add(this.label3);
            this.groupBox_appointment_details.Controls.Add(this.comboBox_appointment_staff);
            this.groupBox_appointment_details.Controls.Add(this.listbox_appointment_scheduleslots);
            this.groupBox_appointment_details.Controls.Add(this.dtp_appointment_date);
            this.groupBox_appointment_details.Enabled = false;
            this.groupBox_appointment_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_appointment_details.Location = new System.Drawing.Point(601, 320);
            this.groupBox_appointment_details.Name = "groupBox_appointment_details";
            this.groupBox_appointment_details.Size = new System.Drawing.Size(619, 360);
            this.groupBox_appointment_details.TabIndex = 22;
            this.groupBox_appointment_details.TabStop = false;
            this.groupBox_appointment_details.Text = "New Appointment For ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(483, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(324, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "*";
            // 
            // specialty_descriptionTextBox
            // 
            this.specialty_descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleSpecialtyBindingSource, "specialty_description", true));
            this.specialty_descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialty_descriptionTextBox.Location = new System.Drawing.Point(31, 223);
            this.specialty_descriptionTextBox.Multiline = true;
            this.specialty_descriptionTextBox.Name = "specialty_descriptionTextBox";
            this.specialty_descriptionTextBox.ReadOnly = true;
            this.specialty_descriptionTextBox.Size = new System.Drawing.Size(332, 121);
            this.specialty_descriptionTextBox.TabIndex = 12;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Specialty Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Available Times:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Appointment Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Who specialises in:";
            // 
            // listbox_appointment_staffSpecialties
            // 
            this.listbox_appointment_staffSpecialties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_appointment_staffSpecialties.FormattingEnabled = true;
            this.listbox_appointment_staffSpecialties.ItemHeight = 16;
            this.listbox_appointment_staffSpecialties.Location = new System.Drawing.Point(31, 85);
            this.listbox_appointment_staffSpecialties.Name = "listbox_appointment_staffSpecialties";
            this.listbox_appointment_staffSpecialties.Size = new System.Drawing.Size(332, 116);
            this.listbox_appointment_staffSpecialties.TabIndex = 4;
            this.listbox_appointment_staffSpecialties.SelectedValueChanged += new System.EventHandler(this.listbox_appointment_staffSpecialties_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "With Vet:";
            // 
            // comboBox_appointment_staff
            // 
            this.comboBox_appointment_staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_appointment_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_appointment_staff.FormattingEnabled = true;
            this.comboBox_appointment_staff.Location = new System.Drawing.Point(81, 32);
            this.comboBox_appointment_staff.Name = "comboBox_appointment_staff";
            this.comboBox_appointment_staff.Size = new System.Drawing.Size(237, 24);
            this.comboBox_appointment_staff.TabIndex = 2;
            this.comboBox_appointment_staff.SelectedValueChanged += new System.EventHandler(this.comboBox_appointment_staff_SelectedValueChanged);
            // 
            // listbox_appointment_scheduleslots
            // 
            this.listbox_appointment_scheduleslots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_appointment_scheduleslots.FormattingEnabled = true;
            this.listbox_appointment_scheduleslots.ItemHeight = 16;
            this.listbox_appointment_scheduleslots.Location = new System.Drawing.Point(379, 89);
            this.listbox_appointment_scheduleslots.Name = "listbox_appointment_scheduleslots";
            this.listbox_appointment_scheduleslots.Size = new System.Drawing.Size(228, 228);
            this.listbox_appointment_scheduleslots.TabIndex = 1;
            // 
            // dtp_appointment_date
            // 
            this.dtp_appointment_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_appointment_date.Location = new System.Drawing.Point(379, 45);
            this.dtp_appointment_date.Name = "dtp_appointment_date";
            this.dtp_appointment_date.Size = new System.Drawing.Size(228, 22);
            this.dtp_appointment_date.TabIndex = 0;
            this.dtp_appointment_date.ValueChanged += new System.EventHandler(this.dtp_appointment_date_ValueChanged);
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
            // animalDataSet
            // 
            this.animalDataSet.DataSetName = "AnimalDataSet";
            this.animalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this.animalDataSet;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
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
            // singleStaffSpecialtyDataSet
            // 
            this.singleStaffSpecialtyDataSet.DataSetName = "SingleStaffSpecialtyDataSet";
            this.singleStaffSpecialtyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // singleStaffSpecialtyBindingSource
            // 
            this.singleStaffSpecialtyBindingSource.DataMember = "Specialty";
            this.singleStaffSpecialtyBindingSource.DataSource = this.singleStaffSpecialtyDataSet;
            // 
            // singleStaffSpecialtyTableAdapter
            // 
            this.singleStaffSpecialtyTableAdapter.ClearBeforeFill = true;
            // 
            // singleSpecialtyTableAdapter
            // 
            this.singleSpecialtyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.SpecialtyTableAdapter = this.singleSpecialtyTableAdapter;
            this.tableAdapterManager1.UpdateOrder = VeterinaryClinicDatabase.SingleSpecialtyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btn_client_access_logout
            // 
            this.btn_client_access_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_client_access_logout.Location = new System.Drawing.Point(1125, 36);
            this.btn_client_access_logout.Name = "btn_client_access_logout";
            this.btn_client_access_logout.Size = new System.Drawing.Size(103, 28);
            this.btn_client_access_logout.TabIndex = 23;
            this.btn_client_access_logout.Text = "Log Out";
            this.btn_client_access_logout.UseVisualStyleBackColor = true;
            this.btn_client_access_logout.Click += new System.EventHandler(this.btn_client_access_logout_Click);
            // 
            // listBox_upcoming_appointments
            // 
            this.listBox_upcoming_appointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_upcoming_appointments.FormattingEnabled = true;
            this.listBox_upcoming_appointments.ItemHeight = 16;
            this.listBox_upcoming_appointments.Location = new System.Drawing.Point(21, 352);
            this.listBox_upcoming_appointments.Name = "listBox_upcoming_appointments";
            this.listBox_upcoming_appointments.Size = new System.Drawing.Size(561, 324);
            this.listBox_upcoming_appointments.TabIndex = 24;
            // 
            // lbl_upcoming_appointments
            // 
            this.lbl_upcoming_appointments.AutoSize = true;
            this.lbl_upcoming_appointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_upcoming_appointments.Location = new System.Drawing.Point(8, 320);
            this.lbl_upcoming_appointments.Name = "lbl_upcoming_appointments";
            this.lbl_upcoming_appointments.Size = new System.Drawing.Size(216, 20);
            this.lbl_upcoming_appointments.TabIndex = 25;
            this.lbl_upcoming_appointments.Text = "Upcoming Appointments For ";
            // 
            // appointmentDataSet
            // 
            this.appointmentDataSet.DataSetName = "AppointmentsDataSet";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(353, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "* Required Information";
            // 
            // Frm_Client_Access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 700);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_upcoming_appointments);
            this.Controls.Add(this.listBox_upcoming_appointments);
            this.Controls.Add(this.btn_client_access_logout);
            this.Controls.Add(this.groupBox_appointment_details);
            this.Controls.Add(this.grpbox_singleclient_animals);
            this.Controls.Add(this.grpbox_singleclients_details);
            this.Controls.Add(this.lbl_Client_name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_Client_Access";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Veterinary Clinic Application";
            this.Load += new System.EventHandler(this.Frm_Client_Access_Load);
            ((System.ComponentModel.ISupportInitialize)(this.singleClientDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpbox_singleclients_details.ResumeLayout(false);
            this.grpbox_singleclients_details.PerformLayout();
            this.grpbox_singleclient_animals.ResumeLayout(false);
            this.grpbox_singleclient_animals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleAnimalDataSet)).EndInit();
            this.groupBox_appointment_details.ResumeLayout(false);
            this.groupBox_appointment_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleSpecialtyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleSpecialtyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleSlotDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleSlotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffSpecialtyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleStaffSpecialtyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SingleClientDataSet singleClientDataSet;
        private System.Windows.Forms.BindingSource singleClientBindingSource;
        private SingleClientDataSetTableAdapters.ClientTableAdapter singleClientTableAdapter;
        private SingleClientDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox contact_phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox suburbTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox postcodeTextBox;
        private System.Windows.Forms.Label lbl_Client_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpbox_singleclients_details;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_singleclient_save;
        private System.Windows.Forms.GroupBox grpbox_singleclient_animals;
        private System.Windows.Forms.ListBox listbox_singleclient_animals;
        private SingleAnimalDataSet singleAnimalDataSet;
        private System.Windows.Forms.BindingSource singleAnimalBindingSource;
        private SingleAnimalDataSetTableAdapters.AnimalTableAdapter singleAnimalTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox animal_nameTextBox;
        private System.Windows.Forms.TextBox breedTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.Button btn_singleclient_clearanimal_details;
        private System.Windows.Forms.Button btn_singleclient_saveanimal;
        private System.Windows.Forms.GroupBox groupBox_appointment_details;
        private ScheduleSlotDataSet scheduleSlotDataSet;
        private System.Windows.Forms.BindingSource scheduleSlotBindingSource;
        private ScheduleSlotDataSetTableAdapters.ScheduleSlotTableAdapter scheduleSlotTableAdapter;
        private System.Windows.Forms.ListBox listbox_appointment_scheduleslots;
        private System.Windows.Forms.DateTimePicker dtp_appointment_date;
        private AnimalDataSet animalDataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private AnimalDataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private SingleStaffDataSet singleStaffDataSet;
        private System.Windows.Forms.BindingSource singleStaffBindingSource;
        private SingleStaffDataSetTableAdapters.StaffTableAdapter singleStaffTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listbox_appointment_staffSpecialties;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_appointment_staff;
        private System.Windows.Forms.Button btn_add_appointment;
        private StaffDataSet staffDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private StaffDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private SingleStaffSpecialtyDataSet singleStaffSpecialtyDataSet;
        private System.Windows.Forms.BindingSource singleStaffSpecialtyBindingSource;
        private SingleStaffSpecialtyDataSetTableAdapters.SpecialtyTableAdapter singleStaffSpecialtyTableAdapter;
        private SingleSpecialtyDataSet singleSpecialtyDataSet;
        private System.Windows.Forms.BindingSource singleSpecialtyBindingSource;
        private SingleSpecialtyDataSetTableAdapters.SpecialtyTableAdapter singleSpecialtyTableAdapter;
        private System.Windows.Forms.TextBox specialty_descriptionTextBox;
        private System.Windows.Forms.Label label7;
        private SingleSpecialtyDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button btn_client_access_logout;
        private AppointmentDataSet appointmentDataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private AppointmentDataSetTableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.ListBox listBox_upcoming_appointments;
        private System.Windows.Forms.Label lbl_upcoming_appointments;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
    }
}