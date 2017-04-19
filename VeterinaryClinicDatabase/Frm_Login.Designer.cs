namespace VeterinaryClinicDatabase
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.txtbox_client_login = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.singleClientDataSet = new VeterinaryClinicDatabase.SingleClientDataSet();
            this.singleClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleClientTableAdapter = new VeterinaryClinicDatabase.SingleClientDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new VeterinaryClinicDatabase.SingleClientDataSetTableAdapters.TableAdapterManager();
            this.btn_login_register = new System.Windows.Forms.Button();
            this.btn_login_exit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_client_login
            // 
            this.txtbox_client_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_client_login.Location = new System.Drawing.Point(31, 166);
            this.txtbox_client_login.Name = "txtbox_client_login";
            this.txtbox_client_login.Size = new System.Drawing.Size(259, 22);
            this.txtbox_client_login.TabIndex = 0;
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
            this.lbl_menu.Location = new System.Drawing.Point(73, 9);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(267, 135);
            this.lbl_menu.TabIndex = 6;
            this.lbl_menu.Text = "Veterinary Clinic Application";
            this.lbl_menu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(296, 160);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(88, 31);
            this.btn_login.TabIndex = 9;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
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
            // btn_login_register
            // 
            this.btn_login_register.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.btn_login_register.Location = new System.Drawing.Point(12, 231);
            this.btn_login_register.Name = "btn_login_register";
            this.btn_login_register.Size = new System.Drawing.Size(145, 43);
            this.btn_login_register.TabIndex = 10;
            this.btn_login_register.Text = "Register Now";
            this.btn_login_register.UseVisualStyleBackColor = true;
            this.btn_login_register.Click += new System.EventHandler(this.btn_login_register_Click);
            // 
            // btn_login_exit
            // 
            this.btn_login_exit.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.btn_login_exit.Location = new System.Drawing.Point(313, 231);
            this.btn_login_exit.Name = "btn_login_exit";
            this.btn_login_exit.Size = new System.Drawing.Size(88, 43);
            this.btn_login_exit.TabIndex = 11;
            this.btn_login_exit.Text = "Exit";
            this.btn_login_exit.UseVisualStyleBackColor = true;
            this.btn_login_exit.Click += new System.EventHandler(this.btn_login_exit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(346, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 286);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_login_exit);
            this.Controls.Add(this.btn_login_register);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_menu);
            this.Controls.Add(this.txtbox_client_login);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinary Clinic Application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_client_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.Button btn_login;
        private SingleClientDataSet singleClientDataSet;
        private System.Windows.Forms.BindingSource singleClientBindingSource;
        private SingleClientDataSetTableAdapters.ClientTableAdapter singleClientTableAdapter;
        private SingleClientDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btn_login_register;
        private System.Windows.Forms.Button btn_login_exit;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}