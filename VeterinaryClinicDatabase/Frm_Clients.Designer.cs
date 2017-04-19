namespace VeterinaryClinicDatabase
{
    partial class Frm_Clients
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
            System.Windows.Forms.Label lbl_clients_first_name;
            System.Windows.Forms.Label lbl_clients_last_name;
            System.Windows.Forms.Label lbl_clients_contact_phone;
            System.Windows.Forms.Label lbl_clients_email;
            System.Windows.Forms.Label lbl_clients_street;
            System.Windows.Forms.Label lbl_clients_suburb;
            System.Windows.Forms.Label lbl_clients_city;
            System.Windows.Forms.Label lbl_clients_postcode;
            System.Windows.Forms.Label animal_nameLabel;
            System.Windows.Forms.Label breedLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label dobLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Clients));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Clients = new System.Windows.Forms.Label();
            this.btn_clients_clear = new System.Windows.Forms.Button();
            this.btn_search_clients = new System.Windows.Forms.Button();
            this.singleClientDataSet = new VeterinaryClinicDatabase.SingleClientDataSet();
            this.singleClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleClientTableAdapter = new VeterinaryClinicDatabase.SingleClientDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new VeterinaryClinicDatabase.SingleClientDataSetTableAdapters.TableAdapterManager();
            this.txt_clients_first_name = new System.Windows.Forms.TextBox();
            this.txt_clients_last_name = new System.Windows.Forms.TextBox();
            this.txt_clients_contact_phone = new System.Windows.Forms.TextBox();
            this.txt_clients_email = new System.Windows.Forms.TextBox();
            this.txt_clients_street = new System.Windows.Forms.TextBox();
            this.txt_clients_suburb = new System.Windows.Forms.TextBox();
            this.txt_clients_city = new System.Windows.Forms.TextBox();
            this.txt_clients_postcode = new System.Windows.Forms.TextBox();
            this.lbl_clients_address = new System.Windows.Forms.Label();
            this.btn_clients_save = new System.Windows.Forms.Button();
            this.txt_client_name_searchbox = new System.Windows.Forms.TextBox();
            this.lbl_clients_name = new System.Windows.Forms.Label();
            this.btn_clients_save_animal = new System.Windows.Forms.Button();
            this.btn_close_client_window = new System.Windows.Forms.Button();
            this.btn_reset_listbox = new System.Windows.Forms.Button();
            this.btn_client_delete = new System.Windows.Forms.Button();
            this.groupBox_clients_details = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listbox_clients_animals = new System.Windows.Forms.ListBox();
            this.groupBox_AnimalDetails = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_animal_clear_details = new System.Windows.Forms.Button();
            this.btn_clients_delete_animal = new System.Windows.Forms.Button();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.singleAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleAnimalDataSet = new VeterinaryClinicDatabase.SingleAnimalDataSet();
            this.txtbx_animal_name = new System.Windows.Forms.TextBox();
            this.combobox_animal_sex = new System.Windows.Forms.ComboBox();
            this.txtbx_animal_breed = new System.Windows.Forms.TextBox();
            this.txtbx_animal_category = new System.Windows.Forms.TextBox();
            this.listbox_Clients_AllClients = new System.Windows.Forms.ListBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientDataSet = new VeterinaryClinicDatabase.ClientDataSet();
            this.clientTableAdapter = new VeterinaryClinicDatabase.ClientDataSetTableAdapters.ClientTableAdapter();
            this.singleAnimalTableAdapter = new VeterinaryClinicDatabase.SingleAnimalDataSetTableAdapters.AnimalTableAdapter();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalDataSet = new VeterinaryClinicDatabase.AnimalDataSet();
            this.animalTableAdapter = new VeterinaryClinicDatabase.AnimalDataSetTableAdapters.AnimalTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            lbl_clients_first_name = new System.Windows.Forms.Label();
            lbl_clients_last_name = new System.Windows.Forms.Label();
            lbl_clients_contact_phone = new System.Windows.Forms.Label();
            lbl_clients_email = new System.Windows.Forms.Label();
            lbl_clients_street = new System.Windows.Forms.Label();
            lbl_clients_suburb = new System.Windows.Forms.Label();
            lbl_clients_city = new System.Windows.Forms.Label();
            lbl_clients_postcode = new System.Windows.Forms.Label();
            animal_nameLabel = new System.Windows.Forms.Label();
            breedLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            dobLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientBindingSource)).BeginInit();
            this.groupBox_clients_details.SuspendLayout();
            this.groupBox_AnimalDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleAnimalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_clients_first_name
            // 
            lbl_clients_first_name.AutoSize = true;
            lbl_clients_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_clients_first_name.Location = new System.Drawing.Point(14, 32);
            lbl_clients_first_name.Name = "lbl_clients_first_name";
            lbl_clients_first_name.Size = new System.Drawing.Size(76, 16);
            lbl_clients_first_name.TabIndex = 16;
            lbl_clients_first_name.Text = "First Name:";
            // 
            // lbl_clients_last_name
            // 
            lbl_clients_last_name.AutoSize = true;
            lbl_clients_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_clients_last_name.Location = new System.Drawing.Point(14, 58);
            lbl_clients_last_name.Name = "lbl_clients_last_name";
            lbl_clients_last_name.Size = new System.Drawing.Size(76, 16);
            lbl_clients_last_name.TabIndex = 18;
            lbl_clients_last_name.Text = "Last Name:";
            // 
            // lbl_clients_contact_phone
            // 
            lbl_clients_contact_phone.AutoSize = true;
            lbl_clients_contact_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_clients_contact_phone.Location = new System.Drawing.Point(14, 84);
            lbl_clients_contact_phone.Name = "lbl_clients_contact_phone";
            lbl_clients_contact_phone.Size = new System.Drawing.Size(98, 16);
            lbl_clients_contact_phone.TabIndex = 20;
            lbl_clients_contact_phone.Text = "Contact Phone:";
            // 
            // lbl_clients_email
            // 
            lbl_clients_email.AutoSize = true;
            lbl_clients_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_clients_email.Location = new System.Drawing.Point(14, 110);
            lbl_clients_email.Name = "lbl_clients_email";
            lbl_clients_email.Size = new System.Drawing.Size(45, 16);
            lbl_clients_email.TabIndex = 22;
            lbl_clients_email.Text = "Email:";
            // 
            // lbl_clients_street
            // 
            lbl_clients_street.AutoSize = true;
            lbl_clients_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_clients_street.Location = new System.Drawing.Point(411, 58);
            lbl_clients_street.Name = "lbl_clients_street";
            lbl_clients_street.Size = new System.Drawing.Size(46, 16);
            lbl_clients_street.TabIndex = 24;
            lbl_clients_street.Text = "Street:";
            // 
            // lbl_clients_suburb
            // 
            lbl_clients_suburb.AutoSize = true;
            lbl_clients_suburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_clients_suburb.Location = new System.Drawing.Point(411, 84);
            lbl_clients_suburb.Name = "lbl_clients_suburb";
            lbl_clients_suburb.Size = new System.Drawing.Size(54, 16);
            lbl_clients_suburb.TabIndex = 26;
            lbl_clients_suburb.Text = "Suburb:";
            // 
            // lbl_clients_city
            // 
            lbl_clients_city.AutoSize = true;
            lbl_clients_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_clients_city.Location = new System.Drawing.Point(411, 110);
            lbl_clients_city.Name = "lbl_clients_city";
            lbl_clients_city.Size = new System.Drawing.Size(33, 16);
            lbl_clients_city.TabIndex = 28;
            lbl_clients_city.Text = "City:";
            // 
            // lbl_clients_postcode
            // 
            lbl_clients_postcode.AutoSize = true;
            lbl_clients_postcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_clients_postcode.Location = new System.Drawing.Point(592, 110);
            lbl_clients_postcode.Name = "lbl_clients_postcode";
            lbl_clients_postcode.Size = new System.Drawing.Size(69, 16);
            lbl_clients_postcode.TabIndex = 30;
            lbl_clients_postcode.Text = "Postcode:";
            // 
            // animal_nameLabel
            // 
            animal_nameLabel.AutoSize = true;
            animal_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            animal_nameLabel.Location = new System.Drawing.Point(16, 30);
            animal_nameLabel.Name = "animal_nameLabel";
            animal_nameLabel.Size = new System.Drawing.Size(48, 16);
            animal_nameLabel.TabIndex = 48;
            animal_nameLabel.Text = "Name:";
            // 
            // breedLabel
            // 
            breedLabel.AutoSize = true;
            breedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            breedLabel.Location = new System.Drawing.Point(16, 56);
            breedLabel.Name = "breedLabel";
            breedLabel.Size = new System.Drawing.Size(48, 16);
            breedLabel.TabIndex = 50;
            breedLabel.Text = "Breed:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryLabel.Location = new System.Drawing.Point(16, 82);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(66, 16);
            categoryLabel.TabIndex = 52;
            categoryLabel.Text = "Category:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexLabel.Location = new System.Drawing.Point(16, 108);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(34, 16);
            sexLabel.TabIndex = 54;
            sexLabel.Text = "Sex:";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dobLabel.Location = new System.Drawing.Point(16, 137);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new System.Drawing.Size(83, 16);
            dobLabel.TabIndex = 56;
            dobLabel.Text = "Date of Birth:";
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
            // lbl_Clients
            // 
            this.lbl_Clients.AutoSize = true;
            this.lbl_Clients.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clients.Location = new System.Drawing.Point(73, 18);
            this.lbl_Clients.Name = "lbl_Clients";
            this.lbl_Clients.Size = new System.Drawing.Size(154, 44);
            this.lbl_Clients.TabIndex = 7;
            this.lbl_Clients.Text = "Clients";
            // 
            // btn_clients_clear
            // 
            this.btn_clients_clear.Enabled = false;
            this.btn_clients_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clients_clear.Location = new System.Drawing.Point(541, 151);
            this.btn_clients_clear.Name = "btn_clients_clear";
            this.btn_clients_clear.Size = new System.Drawing.Size(93, 29);
            this.btn_clients_clear.TabIndex = 10;
            this.btn_clients_clear.Text = "Clear Details";
            this.btn_clients_clear.UseVisualStyleBackColor = true;
            this.btn_clients_clear.Click += new System.EventHandler(this.btn_clients_clear_Click);
            // 
            // btn_search_clients
            // 
            this.btn_search_clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_clients.Location = new System.Drawing.Point(302, 66);
            this.btn_search_clients.Name = "btn_search_clients";
            this.btn_search_clients.Size = new System.Drawing.Size(75, 29);
            this.btn_search_clients.TabIndex = 11;
            this.btn_search_clients.Text = "Find";
            this.btn_search_clients.UseVisualStyleBackColor = true;
            this.btn_search_clients.Click += new System.EventHandler(this.btn_search_clients_Click);
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
            // txt_clients_first_name
            // 
            this.txt_clients_first_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "first_name", true));
            this.txt_clients_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clients_first_name.Location = new System.Drawing.Point(118, 29);
            this.txt_clients_first_name.Name = "txt_clients_first_name";
            this.txt_clients_first_name.Size = new System.Drawing.Size(255, 22);
            this.txt_clients_first_name.TabIndex = 17;
            this.txt_clients_first_name.TextChanged += new System.EventHandler(this.Client_Details_TextChanged);
            // 
            // txt_clients_last_name
            // 
            this.txt_clients_last_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "last_name", true));
            this.txt_clients_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clients_last_name.Location = new System.Drawing.Point(118, 55);
            this.txt_clients_last_name.Name = "txt_clients_last_name";
            this.txt_clients_last_name.Size = new System.Drawing.Size(255, 22);
            this.txt_clients_last_name.TabIndex = 19;
            this.txt_clients_last_name.TextChanged += new System.EventHandler(this.Client_Details_TextChanged);
            // 
            // txt_clients_contact_phone
            // 
            this.txt_clients_contact_phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "contact_phone", true));
            this.txt_clients_contact_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clients_contact_phone.Location = new System.Drawing.Point(118, 81);
            this.txt_clients_contact_phone.Name = "txt_clients_contact_phone";
            this.txt_clients_contact_phone.Size = new System.Drawing.Size(189, 22);
            this.txt_clients_contact_phone.TabIndex = 21;
            this.txt_clients_contact_phone.TextChanged += new System.EventHandler(this.Client_Details_TextChanged);
            // 
            // txt_clients_email
            // 
            this.txt_clients_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "email", true));
            this.txt_clients_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clients_email.Location = new System.Drawing.Point(118, 107);
            this.txt_clients_email.Name = "txt_clients_email";
            this.txt_clients_email.Size = new System.Drawing.Size(255, 22);
            this.txt_clients_email.TabIndex = 23;
            this.txt_clients_email.TextChanged += new System.EventHandler(this.Client_Details_TextChanged);
            // 
            // txt_clients_street
            // 
            this.txt_clients_street.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "street", true));
            this.txt_clients_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clients_street.Location = new System.Drawing.Point(471, 55);
            this.txt_clients_street.Name = "txt_clients_street";
            this.txt_clients_street.Size = new System.Drawing.Size(258, 22);
            this.txt_clients_street.TabIndex = 25;
            this.txt_clients_street.TextChanged += new System.EventHandler(this.Client_Details_TextChanged);
            // 
            // txt_clients_suburb
            // 
            this.txt_clients_suburb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "suburb", true));
            this.txt_clients_suburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clients_suburb.Location = new System.Drawing.Point(471, 81);
            this.txt_clients_suburb.Name = "txt_clients_suburb";
            this.txt_clients_suburb.Size = new System.Drawing.Size(258, 22);
            this.txt_clients_suburb.TabIndex = 27;
            this.txt_clients_suburb.TextChanged += new System.EventHandler(this.Client_Details_TextChanged);
            // 
            // txt_clients_city
            // 
            this.txt_clients_city.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "city", true));
            this.txt_clients_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clients_city.Location = new System.Drawing.Point(471, 107);
            this.txt_clients_city.Name = "txt_clients_city";
            this.txt_clients_city.Size = new System.Drawing.Size(115, 22);
            this.txt_clients_city.TabIndex = 29;
            this.txt_clients_city.TextChanged += new System.EventHandler(this.Client_Details_TextChanged);
            // 
            // txt_clients_postcode
            // 
            this.txt_clients_postcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleClientBindingSource, "postcode", true));
            this.txt_clients_postcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clients_postcode.Location = new System.Drawing.Point(667, 107);
            this.txt_clients_postcode.Name = "txt_clients_postcode";
            this.txt_clients_postcode.Size = new System.Drawing.Size(62, 22);
            this.txt_clients_postcode.TabIndex = 31;
            this.txt_clients_postcode.TextChanged += new System.EventHandler(this.Client_Details_TextChanged);
            // 
            // lbl_clients_address
            // 
            this.lbl_clients_address.AutoSize = true;
            this.lbl_clients_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clients_address.Location = new System.Drawing.Point(395, 34);
            this.lbl_clients_address.Name = "lbl_clients_address";
            this.lbl_clients_address.Size = new System.Drawing.Size(62, 16);
            this.lbl_clients_address.TabIndex = 32;
            this.lbl_clients_address.Text = "Address:";
            // 
            // btn_clients_save
            // 
            this.btn_clients_save.Enabled = false;
            this.btn_clients_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clients_save.Location = new System.Drawing.Point(640, 151);
            this.btn_clients_save.Name = "btn_clients_save";
            this.btn_clients_save.Size = new System.Drawing.Size(93, 29);
            this.btn_clients_save.TabIndex = 33;
            this.btn_clients_save.Text = "Save Client";
            this.btn_clients_save.UseVisualStyleBackColor = true;
            this.btn_clients_save.Click += new System.EventHandler(this.btn_clients_save_client_Click);
            // 
            // txt_client_name_searchbox
            // 
            this.txt_client_name_searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_client_name_searchbox.Location = new System.Drawing.Point(66, 69);
            this.txt_client_name_searchbox.Name = "txt_client_name_searchbox";
            this.txt_client_name_searchbox.Size = new System.Drawing.Size(230, 22);
            this.txt_client_name_searchbox.TabIndex = 34;
            // 
            // lbl_clients_name
            // 
            this.lbl_clients_name.AutoSize = true;
            this.lbl_clients_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clients_name.Location = new System.Drawing.Point(12, 72);
            this.lbl_clients_name.Name = "lbl_clients_name";
            this.lbl_clients_name.Size = new System.Drawing.Size(48, 16);
            this.lbl_clients_name.TabIndex = 35;
            this.lbl_clients_name.Text = "Name:";
            // 
            // btn_clients_save_animal
            // 
            this.btn_clients_save_animal.Enabled = false;
            this.btn_clients_save_animal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clients_save_animal.Location = new System.Drawing.Point(260, 178);
            this.btn_clients_save_animal.Name = "btn_clients_save_animal";
            this.btn_clients_save_animal.Size = new System.Drawing.Size(93, 28);
            this.btn_clients_save_animal.TabIndex = 38;
            this.btn_clients_save_animal.Text = "Add Animal";
            this.btn_clients_save_animal.UseVisualStyleBackColor = true;
            this.btn_clients_save_animal.Click += new System.EventHandler(this.add_Animal_Click);
            // 
            // btn_close_client_window
            // 
            this.btn_close_client_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close_client_window.Location = new System.Drawing.Point(1120, 494);
            this.btn_close_client_window.Name = "btn_close_client_window";
            this.btn_close_client_window.Size = new System.Drawing.Size(93, 29);
            this.btn_close_client_window.TabIndex = 39;
            this.btn_close_client_window.Text = "Close";
            this.btn_close_client_window.UseVisualStyleBackColor = true;
            this.btn_close_client_window.Click += new System.EventHandler(this.btn_close_client_window_Click);
            // 
            // btn_reset_listbox
            // 
            this.btn_reset_listbox.Enabled = false;
            this.btn_reset_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset_listbox.Location = new System.Drawing.Point(383, 66);
            this.btn_reset_listbox.Name = "btn_reset_listbox";
            this.btn_reset_listbox.Size = new System.Drawing.Size(75, 29);
            this.btn_reset_listbox.TabIndex = 40;
            this.btn_reset_listbox.Text = "Reset";
            this.btn_reset_listbox.UseVisualStyleBackColor = true;
            this.btn_reset_listbox.Click += new System.EventHandler(this.btn_reset_listbox_Click);
            // 
            // btn_client_delete
            // 
            this.btn_client_delete.Enabled = false;
            this.btn_client_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_client_delete.Location = new System.Drawing.Point(387, 151);
            this.btn_client_delete.Name = "btn_client_delete";
            this.btn_client_delete.Size = new System.Drawing.Size(100, 29);
            this.btn_client_delete.TabIndex = 41;
            this.btn_client_delete.Text = "Delete Client";
            this.btn_client_delete.UseVisualStyleBackColor = true;
            this.btn_client_delete.Click += new System.EventHandler(this.btn_client_delete_Click);
            // 
            // groupBox_clients_details
            // 
            this.groupBox_clients_details.Controls.Add(this.label7);
            this.groupBox_clients_details.Controls.Add(this.label5);
            this.groupBox_clients_details.Controls.Add(this.label4);
            this.groupBox_clients_details.Controls.Add(this.label3);
            this.groupBox_clients_details.Controls.Add(this.btn_client_delete);
            this.groupBox_clients_details.Controls.Add(this.txt_clients_email);
            this.groupBox_clients_details.Controls.Add(this.txt_clients_contact_phone);
            this.groupBox_clients_details.Controls.Add(this.txt_clients_last_name);
            this.groupBox_clients_details.Controls.Add(this.txt_clients_first_name);
            this.groupBox_clients_details.Controls.Add(this.txt_clients_street);
            this.groupBox_clients_details.Controls.Add(this.btn_clients_save);
            this.groupBox_clients_details.Controls.Add(this.txt_clients_postcode);
            this.groupBox_clients_details.Controls.Add(lbl_clients_postcode);
            this.groupBox_clients_details.Controls.Add(this.btn_clients_clear);
            this.groupBox_clients_details.Controls.Add(this.lbl_clients_address);
            this.groupBox_clients_details.Controls.Add(lbl_clients_first_name);
            this.groupBox_clients_details.Controls.Add(this.txt_clients_city);
            this.groupBox_clients_details.Controls.Add(lbl_clients_last_name);
            this.groupBox_clients_details.Controls.Add(this.txt_clients_suburb);
            this.groupBox_clients_details.Controls.Add(lbl_clients_contact_phone);
            this.groupBox_clients_details.Controls.Add(lbl_clients_email);
            this.groupBox_clients_details.Controls.Add(lbl_clients_city);
            this.groupBox_clients_details.Controls.Add(lbl_clients_street);
            this.groupBox_clients_details.Controls.Add(lbl_clients_suburb);
            this.groupBox_clients_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_clients_details.Location = new System.Drawing.Point(480, 72);
            this.groupBox_clients_details.Name = "groupBox_clients_details";
            this.groupBox_clients_details.Size = new System.Drawing.Size(742, 186);
            this.groupBox_clients_details.TabIndex = 43;
            this.groupBox_clients_details.TabStop = false;
            this.groupBox_clients_details.Text = "Client\'s Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(376, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(376, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(374, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1110, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "* Required Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Client\'s Animals:";
            // 
            // listbox_clients_animals
            // 
            this.listbox_clients_animals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_clients_animals.FormattingEnabled = true;
            this.listbox_clients_animals.ItemHeight = 16;
            this.listbox_clients_animals.Location = new System.Drawing.Point(480, 292);
            this.listbox_clients_animals.Name = "listbox_clients_animals";
            this.listbox_clients_animals.Size = new System.Drawing.Size(364, 196);
            this.listbox_clients_animals.TabIndex = 0;
            this.listbox_clients_animals.SelectedValueChanged += new System.EventHandler(this.Listbox_clients_animals_Click);
            // 
            // groupBox_AnimalDetails
            // 
            this.groupBox_AnimalDetails.Controls.Add(this.label6);
            this.groupBox_AnimalDetails.Controls.Add(this.btn_animal_clear_details);
            this.groupBox_AnimalDetails.Controls.Add(this.btn_clients_delete_animal);
            this.groupBox_AnimalDetails.Controls.Add(this.btn_clients_save_animal);
            this.groupBox_AnimalDetails.Controls.Add(animal_nameLabel);
            this.groupBox_AnimalDetails.Controls.Add(this.dobDateTimePicker);
            this.groupBox_AnimalDetails.Controls.Add(this.txtbx_animal_name);
            this.groupBox_AnimalDetails.Controls.Add(dobLabel);
            this.groupBox_AnimalDetails.Controls.Add(breedLabel);
            this.groupBox_AnimalDetails.Controls.Add(this.combobox_animal_sex);
            this.groupBox_AnimalDetails.Controls.Add(this.txtbx_animal_breed);
            this.groupBox_AnimalDetails.Controls.Add(sexLabel);
            this.groupBox_AnimalDetails.Controls.Add(categoryLabel);
            this.groupBox_AnimalDetails.Controls.Add(this.txtbx_animal_category);
            this.groupBox_AnimalDetails.Enabled = false;
            this.groupBox_AnimalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_AnimalDetails.Location = new System.Drawing.Point(860, 276);
            this.groupBox_AnimalDetails.Name = "groupBox_AnimalDetails";
            this.groupBox_AnimalDetails.Size = new System.Drawing.Size(362, 212);
            this.groupBox_AnimalDetails.TabIndex = 58;
            this.groupBox_AnimalDetails.TabStop = false;
            this.groupBox_AnimalDetails.Text = "Edit or Add Animal Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(341, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 63;
            this.label6.Text = "*";
            // 
            // btn_animal_clear_details
            // 
            this.btn_animal_clear_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_animal_clear_details.Location = new System.Drawing.Point(161, 178);
            this.btn_animal_clear_details.Name = "btn_animal_clear_details";
            this.btn_animal_clear_details.Size = new System.Drawing.Size(93, 28);
            this.btn_animal_clear_details.TabIndex = 59;
            this.btn_animal_clear_details.Text = "Clear Details";
            this.btn_animal_clear_details.UseVisualStyleBackColor = true;
            this.btn_animal_clear_details.Click += new System.EventHandler(this.btn_animal_clear_details_Click);
            // 
            // btn_clients_delete_animal
            // 
            this.btn_clients_delete_animal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clients_delete_animal.Location = new System.Drawing.Point(7, 178);
            this.btn_clients_delete_animal.Name = "btn_clients_delete_animal";
            this.btn_clients_delete_animal.Size = new System.Drawing.Size(100, 28);
            this.btn_clients_delete_animal.TabIndex = 58;
            this.btn_clients_delete_animal.Text = "Delete Animal";
            this.btn_clients_delete_animal.UseVisualStyleBackColor = true;
            this.btn_clients_delete_animal.Click += new System.EventHandler(this.btn_clients_delete_animal_Click);
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.singleAnimalBindingSource, "dob", true));
            this.dobDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobDateTimePicker.Location = new System.Drawing.Point(150, 132);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(97, 22);
            this.dobDateTimePicker.TabIndex = 57;
            this.dobDateTimePicker.ValueChanged += new System.EventHandler(this.dobDateTimePicker_ValueChanged);
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
            // txtbx_animal_name
            // 
            this.txtbx_animal_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleAnimalBindingSource, "animal_name", true));
            this.txtbx_animal_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_animal_name.Location = new System.Drawing.Point(150, 27);
            this.txtbx_animal_name.Name = "txtbx_animal_name";
            this.txtbx_animal_name.Size = new System.Drawing.Size(190, 22);
            this.txtbx_animal_name.TabIndex = 49;
            // 
            // combobox_animal_sex
            // 
            this.combobox_animal_sex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleAnimalBindingSource, "sex", true));
            this.combobox_animal_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_animal_sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_animal_sex.FormattingEnabled = true;
            this.combobox_animal_sex.Items.AddRange(new object[] {
            "Male",
            "Male-desexed",
            "Female",
            "Female-desexed"});
            this.combobox_animal_sex.Location = new System.Drawing.Point(150, 105);
            this.combobox_animal_sex.Name = "combobox_animal_sex";
            this.combobox_animal_sex.Size = new System.Drawing.Size(190, 24);
            this.combobox_animal_sex.TabIndex = 55;
            // 
            // txtbx_animal_breed
            // 
            this.txtbx_animal_breed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleAnimalBindingSource, "breed", true));
            this.txtbx_animal_breed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_animal_breed.Location = new System.Drawing.Point(150, 53);
            this.txtbx_animal_breed.Name = "txtbx_animal_breed";
            this.txtbx_animal_breed.Size = new System.Drawing.Size(190, 22);
            this.txtbx_animal_breed.TabIndex = 51;
            // 
            // txtbx_animal_category
            // 
            this.txtbx_animal_category.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singleAnimalBindingSource, "category", true));
            this.txtbx_animal_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_animal_category.Location = new System.Drawing.Point(150, 79);
            this.txtbx_animal_category.Name = "txtbx_animal_category";
            this.txtbx_animal_category.Size = new System.Drawing.Size(190, 22);
            this.txtbx_animal_category.TabIndex = 53;
            // 
            // listbox_Clients_AllClients
            // 
            this.listbox_Clients_AllClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_Clients_AllClients.FormattingEnabled = true;
            this.listbox_Clients_AllClients.ItemHeight = 16;
            this.listbox_Clients_AllClients.Location = new System.Drawing.Point(15, 103);
            this.listbox_Clients_AllClients.Name = "listbox_Clients_AllClients";
            this.listbox_Clients_AllClients.Size = new System.Drawing.Size(443, 420);
            this.listbox_Clients_AllClients.TabIndex = 45;
            this.listbox_Clients_AllClients.SelectedValueChanged += new System.EventHandler(this.Listbox_Clients_AllClients_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.clientDataSet;
            // 
            // clientDataSet
            // 
            this.clientDataSet.DataSetName = "ClientDataSet";
            this.clientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // singleAnimalTableAdapter
            // 
            this.singleAnimalTableAdapter.ClearBeforeFill = true;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this.animalDataSet;
            // 
            // animalDataSet
            // 
            this.animalDataSet.DataSetName = "AnimalDataSet";
            this.animalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(313, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "*";
            // 
            // Frm_Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 536);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close_client_window);
            this.Controls.Add(this.listbox_clients_animals);
            this.Controls.Add(this.listbox_Clients_AllClients);
            this.Controls.Add(this.btn_reset_listbox);
            this.Controls.Add(this.lbl_clients_name);
            this.Controls.Add(this.txt_client_name_searchbox);
            this.Controls.Add(this.btn_search_clients);
            this.Controls.Add(this.lbl_Clients);
            this.Controls.Add(this.groupBox_AnimalDetails);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_clients_details);
            this.Name = "Frm_Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Veterinary Clinic Application";
            this.Load += new System.EventHandler(this.Frm_Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientBindingSource)).EndInit();
            this.groupBox_clients_details.ResumeLayout(false);
            this.groupBox_clients_details.PerformLayout();
            this.groupBox_AnimalDetails.ResumeLayout(false);
            this.groupBox_AnimalDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleAnimalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Data Sources
        private ClientDataSet clientDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private ClientDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private SingleClientDataSet singleClientDataSet;
        private System.Windows.Forms.BindingSource singleClientBindingSource;
        private SingleClientDataSetTableAdapters.ClientTableAdapter singleClientTableAdapter;
        private SingleClientDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AnimalDataSet animalDataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private AnimalDataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private SingleAnimalDataSet singleAnimalDataSet;
        private System.Windows.Forms.BindingSource singleAnimalBindingSource;
        private SingleAnimalDataSetTableAdapters.AnimalTableAdapter singleAnimalTableAdapter;

        // Components
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Clients;
        private System.Windows.Forms.Button btn_clients_clear;
        private System.Windows.Forms.Button btn_search_clients;
        private System.Windows.Forms.TextBox txt_clients_first_name;
        private System.Windows.Forms.TextBox txt_clients_last_name;
        private System.Windows.Forms.TextBox txt_clients_contact_phone;
        private System.Windows.Forms.TextBox txt_clients_email;
        private System.Windows.Forms.TextBox txt_clients_street;
        private System.Windows.Forms.TextBox txt_clients_suburb;
        private System.Windows.Forms.TextBox txt_clients_city;
        private System.Windows.Forms.TextBox txt_clients_postcode;
        private System.Windows.Forms.Label lbl_clients_address;
        private System.Windows.Forms.Button btn_clients_save;
        private System.Windows.Forms.TextBox txt_client_name_searchbox;
        private System.Windows.Forms.Label lbl_clients_name;
        private System.Windows.Forms.Button btn_clients_save_animal;
        private System.Windows.Forms.Button btn_close_client_window;
        private System.Windows.Forms.Button btn_reset_listbox;
        private System.Windows.Forms.Button btn_client_delete;
        private System.Windows.Forms.GroupBox groupBox_clients_details;
        private System.Windows.Forms.ListBox listbox_Clients_AllClients;
        private System.Windows.Forms.TextBox txtbx_animal_name;
        private System.Windows.Forms.TextBox txtbx_animal_breed;
        private System.Windows.Forms.TextBox txtbx_animal_category;
        private System.Windows.Forms.ComboBox combobox_animal_sex;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox_AnimalDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listbox_clients_animals;
        private System.Windows.Forms.Button btn_clients_delete_animal;
        private System.Windows.Forms.Button btn_animal_clear_details;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}