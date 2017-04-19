namespace VeterinaryClinicDatabase
{
    partial class Frm_Client_Registration
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
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label last_nameLabel;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Client_Registration));
            this.lbl_registration_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.singleClientDataSet = new VeterinaryClinicDatabase.SingleClientDataSet();
            this.singleClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleClientTableAdapter = new VeterinaryClinicDatabase.SingleClientDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new VeterinaryClinicDatabase.SingleClientDataSetTableAdapters.TableAdapterManager();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.contact_phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.suburbTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.postcodeTextBox = new System.Windows.Forms.TextBox();
            this.groupbox_clientregistration_details = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.animal_nameTextBox = new System.Windows.Forms.TextBox();
            this.singleAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleAnimalDataSet = new VeterinaryClinicDatabase.SingleAnimalDataSet();
            this.breedTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.singleAnimalTableAdapter = new VeterinaryClinicDatabase.SingleAnimalDataSetTableAdapters.AnimalTableAdapter();
            this.btn_saveregistration = new System.Windows.Forms.Button();
            this.animalDataSet = new VeterinaryClinicDatabase.AnimalDataSet();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new VeterinaryClinicDatabase.AnimalDataSetTableAdapters.AnimalTableAdapter();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientBindingSource)).BeginInit();
            this.groupbox_clientregistration_details.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleAnimalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(17, 27);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(76, 16);
            first_nameLabel.TabIndex = 25;
            first_nameLabel.Text = "First Name:";
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(17, 53);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(76, 16);
            last_nameLabel.TabIndex = 27;
            last_nameLabel.Text = "Last Name:";
            // 
            // contact_phoneLabel
            // 
            contact_phoneLabel.AutoSize = true;
            contact_phoneLabel.Location = new System.Drawing.Point(17, 79);
            contact_phoneLabel.Name = "contact_phoneLabel";
            contact_phoneLabel.Size = new System.Drawing.Size(98, 16);
            contact_phoneLabel.TabIndex = 29;
            contact_phoneLabel.Text = "Contact Phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(17, 105);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(89, 16);
            emailLabel.TabIndex = 31;
            emailLabel.Text = "Email (Login):";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(17, 157);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(46, 16);
            streetLabel.TabIndex = 33;
            streetLabel.Text = "Street:";
            // 
            // suburbLabel
            // 
            suburbLabel.AutoSize = true;
            suburbLabel.Location = new System.Drawing.Point(17, 183);
            suburbLabel.Name = "suburbLabel";
            suburbLabel.Size = new System.Drawing.Size(54, 16);
            suburbLabel.TabIndex = 35;
            suburbLabel.Text = "Suburb:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(17, 209);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(33, 16);
            cityLabel.TabIndex = 37;
            cityLabel.Text = "City:";
            // 
            // postcodeLabel
            // 
            postcodeLabel.AutoSize = true;
            postcodeLabel.Location = new System.Drawing.Point(292, 209);
            postcodeLabel.Name = "postcodeLabel";
            postcodeLabel.Size = new System.Drawing.Size(69, 16);
            postcodeLabel.TabIndex = 39;
            postcodeLabel.Text = "Postcode:";
            // 
            // animal_nameLabel
            // 
            animal_nameLabel.AutoSize = true;
            animal_nameLabel.Location = new System.Drawing.Point(17, 27);
            animal_nameLabel.Name = "animal_nameLabel";
            animal_nameLabel.Size = new System.Drawing.Size(48, 16);
            animal_nameLabel.TabIndex = 2;
            animal_nameLabel.Text = "Name:";
            // 
            // breedLabel
            // 
            breedLabel.AutoSize = true;
            breedLabel.Location = new System.Drawing.Point(17, 55);
            breedLabel.Name = "breedLabel";
            breedLabel.Size = new System.Drawing.Size(48, 16);
            breedLabel.TabIndex = 4;
            breedLabel.Text = "Breed:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(17, 83);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(66, 16);
            categoryLabel.TabIndex = 6;
            categoryLabel.Text = "Category:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(17, 111);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(34, 16);
            sexLabel.TabIndex = 8;
            sexLabel.Text = "Sex:";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new System.Drawing.Point(17, 142);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new System.Drawing.Size(83, 16);
            dobLabel.TabIndex = 10;
            dobLabel.Text = "Date of Birth:";
            // 
            // lbl_registration_title
            // 
            this.lbl_registration_title.AutoSize = true;
            this.lbl_registration_title.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registration_title.Location = new System.Drawing.Point(73, 18);
            this.lbl_registration_title.Name = "lbl_registration_title";
            this.lbl_registration_title.Size = new System.Drawing.Size(391, 44);
            this.lbl_registration_title.TabIndex = 21;
            this.lbl_registration_title.Text = "Client Registration";
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
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "first_name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(122, 21);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(178, 22);
            this.first_nameTextBox.TabIndex = 26;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "last_name", true));
            this.last_nameTextBox.Location = new System.Drawing.Point(122, 47);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(178, 22);
            this.last_nameTextBox.TabIndex = 28;
            // 
            // contact_phoneTextBox
            // 
            this.contact_phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "contact_phone", true));
            this.contact_phoneTextBox.Location = new System.Drawing.Point(122, 73);
            this.contact_phoneTextBox.Name = "contact_phoneTextBox";
            this.contact_phoneTextBox.Size = new System.Drawing.Size(178, 22);
            this.contact_phoneTextBox.TabIndex = 30;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(122, 99);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(303, 22);
            this.emailTextBox.TabIndex = 32;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "street", true));
            this.streetTextBox.Location = new System.Drawing.Point(122, 154);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(322, 22);
            this.streetTextBox.TabIndex = 34;
            // 
            // suburbTextBox
            // 
            this.suburbTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "suburb", true));
            this.suburbTextBox.Location = new System.Drawing.Point(122, 180);
            this.suburbTextBox.Name = "suburbTextBox";
            this.suburbTextBox.Size = new System.Drawing.Size(322, 22);
            this.suburbTextBox.TabIndex = 36;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(122, 206);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(164, 22);
            this.cityTextBox.TabIndex = 38;
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "postcode", true));
            this.postcodeTextBox.Location = new System.Drawing.Point(366, 206);
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(78, 22);
            this.postcodeTextBox.TabIndex = 40;
            // 
            // groupbox_clientregistration_details
            // 
            this.groupbox_clientregistration_details.Controls.Add(this.label6);
            this.groupbox_clientregistration_details.Controls.Add(this.label7);
            this.groupbox_clientregistration_details.Controls.Add(this.label4);
            this.groupbox_clientregistration_details.Controls.Add(this.label3);
            this.groupbox_clientregistration_details.Controls.Add(this.label1);
            this.groupbox_clientregistration_details.Controls.Add(this.postcodeTextBox);
            this.groupbox_clientregistration_details.Controls.Add(postcodeLabel);
            this.groupbox_clientregistration_details.Controls.Add(first_nameLabel);
            this.groupbox_clientregistration_details.Controls.Add(this.cityTextBox);
            this.groupbox_clientregistration_details.Controls.Add(this.first_nameTextBox);
            this.groupbox_clientregistration_details.Controls.Add(cityLabel);
            this.groupbox_clientregistration_details.Controls.Add(last_nameLabel);
            this.groupbox_clientregistration_details.Controls.Add(this.suburbTextBox);
            this.groupbox_clientregistration_details.Controls.Add(this.last_nameTextBox);
            this.groupbox_clientregistration_details.Controls.Add(suburbLabel);
            this.groupbox_clientregistration_details.Controls.Add(contact_phoneLabel);
            this.groupbox_clientregistration_details.Controls.Add(this.streetTextBox);
            this.groupbox_clientregistration_details.Controls.Add(this.contact_phoneTextBox);
            this.groupbox_clientregistration_details.Controls.Add(streetLabel);
            this.groupbox_clientregistration_details.Controls.Add(emailLabel);
            this.groupbox_clientregistration_details.Controls.Add(this.emailTextBox);
            this.groupbox_clientregistration_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_clientregistration_details.Location = new System.Drawing.Point(22, 80);
            this.groupbox_clientregistration_details.Name = "groupbox_clientregistration_details";
            this.groupbox_clientregistration_details.Size = new System.Drawing.Size(459, 248);
            this.groupbox_clientregistration_details.TabIndex = 41;
            this.groupbox_clientregistration_details.TabStop = false;
            this.groupbox_clientregistration_details.Text = "Your Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(429, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(301, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(302, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(animal_nameLabel);
            this.groupBox1.Controls.Add(this.animal_nameTextBox);
            this.groupBox1.Controls.Add(breedLabel);
            this.groupBox1.Controls.Add(this.breedTextBox);
            this.groupBox1.Controls.Add(categoryLabel);
            this.groupBox1.Controls.Add(this.categoryTextBox);
            this.groupBox1.Controls.Add(sexLabel);
            this.groupBox1.Controls.Add(this.sexComboBox);
            this.groupBox1.Controls.Add(dobLabel);
            this.groupBox1.Controls.Add(this.dobDateTimePicker);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 179);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "First Animal Registered";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(326, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "*";
            // 
            // animal_nameTextBox
            // 
            this.animal_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleAnimalBindingSource, "animal_name", true));
            this.animal_nameTextBox.Location = new System.Drawing.Point(122, 24);
            this.animal_nameTextBox.Name = "animal_nameTextBox";
            this.animal_nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.animal_nameTextBox.TabIndex = 3;
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
            this.breedTextBox.Location = new System.Drawing.Point(122, 52);
            this.breedTextBox.Name = "breedTextBox";
            this.breedTextBox.Size = new System.Drawing.Size(200, 22);
            this.breedTextBox.TabIndex = 5;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleAnimalBindingSource, "category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(122, 80);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(200, 22);
            this.categoryTextBox.TabIndex = 7;
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
            this.sexComboBox.Location = new System.Drawing.Point(122, 108);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(200, 24);
            this.sexComboBox.TabIndex = 9;
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.singleAnimalBindingSource, "dob", true));
            this.dobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobDateTimePicker.Location = new System.Drawing.Point(122, 138);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(135, 22);
            this.dobDateTimePicker.TabIndex = 11;
            this.dobDateTimePicker.ValueChanged += new System.EventHandler(this.dobDateTimePicker_ValueChanged);
            // 
            // singleAnimalTableAdapter
            // 
            this.singleAnimalTableAdapter.ClearBeforeFill = true;
            // 
            // btn_saveregistration
            // 
            this.btn_saveregistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveregistration.Location = new System.Drawing.Point(388, 446);
            this.btn_saveregistration.Name = "btn_saveregistration";
            this.btn_saveregistration.Size = new System.Drawing.Size(93, 31);
            this.btn_saveregistration.TabIndex = 44;
            this.btn_saveregistration.Text = "Register";
            this.btn_saveregistration.UseVisualStyleBackColor = true;
            this.btn_saveregistration.Click += new System.EventHandler(this.btn_saveregistration_Click);
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
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(388, 483);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(94, 31);
            this.btn_Cancel.TabIndex = 45;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(369, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "* Required Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(301, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "*";
            // 
            // Frm_Client_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 526);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_saveregistration);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupbox_clientregistration_details);
            this.Controls.Add(this.lbl_registration_title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_Client_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Veterinary Clinic Application";
            this.Load += new System.EventHandler(this.Frm_Client_Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientBindingSource)).EndInit();
            this.groupbox_clientregistration_details.ResumeLayout(false);
            this.groupbox_clientregistration_details.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleAnimalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_registration_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SingleClientDataSet singleClientDataSet;
        private System.Windows.Forms.BindingSource singleClientBindingSource;
        private SingleClientDataSetTableAdapters.ClientTableAdapter singleClientTableAdapter;
        private SingleClientDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox contact_phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox suburbTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox postcodeTextBox;
        private System.Windows.Forms.GroupBox groupbox_clientregistration_details;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private SingleAnimalDataSet singleAnimalDataSet;
        private System.Windows.Forms.BindingSource singleAnimalBindingSource;
        private SingleAnimalDataSetTableAdapters.AnimalTableAdapter singleAnimalTableAdapter;
        private System.Windows.Forms.TextBox animal_nameTextBox;
        private System.Windows.Forms.TextBox breedTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.Button btn_saveregistration;
        private AnimalDataSet animalDataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private AnimalDataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}