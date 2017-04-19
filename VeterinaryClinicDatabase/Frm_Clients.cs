
/* @class:          Frm_Clients
 * @description:    A Windows Form class that handles the Clients area of the program.  
 *                  This Windows Form window shows a list of Clients in a listbox that 
 *                  when clicked on shows the details of a specific client in a group of textboxes.
 *                  The user can add a new client, edit a client and delete a client in this window.
 *                  The user can also add an animal to a client by filling out the Animal's Details and
 *                  clicking 'Add Animal', this will add an animal to the current client selected.
 *                  By clicking close the Window will close bringing the user back to the Menu window.
 *                  
 * @author:         Lisa Pedersen
 * @version:        1.1
 * @date            May 2016
 */

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
    public partial class Frm_Clients : Form
    {
        // a class variable that is set to false when editing a client.
        private bool newClient;
        private bool newAnimal;
        private bool dobDateChanged;
        /* @method:         Frm_Clients
         * @description:    Method that initialises the Frm_Clients form window when created.   
         * @param:          none
         */
        public Frm_Clients()
        {
            InitializeComponent();
        }

        /* @method:         Frm_Clients_Load
         * 
         * @description:    Method that is called when the Frm_Clients window is shown.
         *                  When the Frm_Clients window is loaded we fill the Clients DataGridView
         *                  with a list of clients from the database.
         * 
         * @param:          object      sender      automated parameter that is 
         *                                              the object that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void Frm_Clients_Load(object sender, EventArgs e)
        {
            try
            {
                newClient = true;
                newAnimal = true;
                dobDateChanged = false;
                this.clientTableAdapter.Fill(this.clientDataSet.Client);
                Load_AllClients_Listbox();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* @method:         Load_AllClients_Listbox
         * 
         * @description:    Method used to load the listbox_Clients_AllClients with 
         *                  the clients that are in the dataset.
         * 
         * @param:          none
         */
        private void Load_AllClients_Listbox()
        {
            String client = "";
            listbox_Clients_AllClients.Items.Clear();
            
            for (int i = 0; i < clientDataSet.Tables["Client"].Rows.Count; i++)
            {
                string name = clientDataSet.Tables["Client"].Rows[i].ItemArray[1].ToString() + " " + 
                    clientDataSet.Tables["Client"].Rows[i].ItemArray[2].ToString();
                string email = clientDataSet.Tables["Client"].Rows[i].ItemArray[3].ToString();
                client = name.PadRight(50 - name.Length) + '\t' + email;
                listbox_Clients_AllClients.Items.Add(client);
            }
        }

        /* @method:         btn_search_clients_Click
         * 
         * @description:    Click method for the btn_search_clients 'Find' button.
         *                  Depending on which searchbox is being used, the Client's listBox
         *                  is filled with database records that match.  Then the appropriate textbox
         *                  is cleared of text. 
         *                  The btn_reset_listbox button is then enabled to allow the user the ability
         *                  to reset the listbox to its original state.
         * 
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void btn_search_clients_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_client_name_searchbox.TextLength > 0)
                {
                    clientTableAdapter.FillByClientName(clientDataSet.Client, txt_client_name_searchbox.Text);
                    Load_AllClients_Listbox();
                    txt_client_name_searchbox.Clear();
                    btn_reset_listbox.Enabled = true;
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        /* @method:         btn_reset_listbox_Click
         * 
         * @description:    Click method for the btn_reset_listbox 'Reset' button.
         *                  It resets the Client's listbox to show all clients from the database,
         *                  then clears any text in the ClientName searchbox.
         * 
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void btn_reset_listbox_Click(object sender, EventArgs e)
        {
             try
             {
                clientTableAdapter.Fill(clientDataSet.Client);
                Load_AllClients_Listbox();
                txt_client_name_searchbox.Clear();
                btn_reset_listbox.Enabled = false;
             }
             catch (System.Exception ex)
             {
                 System.Windows.Forms.MessageBox.Show(ex.Message);
             }
        }

        /* @method:        Listbox_Clients_AllClients_Click
        * 
        * @description:    A listbox Click method for when the client's listbox is clicked.
        *                  Gets the client id of the specific client that is clicked in the listbox
        *                  then fills the client details textboxes with the appropriate client's data from the database.
        *                  Also fills the Client's Animals listbox with the client's Animals.
        *                  Now that there is a specific client displayed, the AddAnimal, ClearDetails and
        *                  DeleteClient buttons are enabled.  Also sets the newClient variable to false incase
        *                  the user wants to save any changes to the client's information.
        * 
        * @param:          object      sender      automated parameter that is the object 
        *                                              that calls on this method.
        *                  EventArgs   e           automated parameter that holds information
        *                                              about the click event.
        */
        private void Listbox_Clients_AllClients_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listbox_Clients_AllClients.SelectedIndex;
                string clientIDstring = clientDataSet.Tables["Client"].Rows[index].ItemArray[0].ToString();

                singleClientTableAdapter.Fill(singleClientDataSet.Client, Convert.ToInt32(clientIDstring));
                animalTableAdapter.Fill(animalDataSet.Animal, Convert.ToInt32(clientIDstring));
                Load_SingleClientsAnimals_Listbox();


                groupBox_AnimalDetails.Enabled = true;
                btn_clients_save_animal.Enabled = true;
                btn_clients_clear.Enabled = true;
                btn_client_delete.Enabled = true;
                newClient = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        /* @method:         Load_AllClientsAnimals_Listbox
         * 
         * @description:    Method used to load the listbox_clients_animals with 
         *                  the specific client's animals that are in the dataset.
         * 
         * @param:          none
         */
        private void Load_SingleClientsAnimals_Listbox()
        {
            String animal = "";
            listbox_clients_animals.Items.Clear();

            for (int i = 0; i < animalDataSet.Tables["Animal"].Rows.Count; i++)
            {
                string animalName = animalDataSet.Tables["Animal"].Rows[i].ItemArray[1].ToString();
                string animalBreed = animalDataSet.Tables["Animal"].Rows[i].ItemArray[2].ToString();
                string animalSex = animalDataSet.Tables["Animal"].Rows[i].ItemArray[4].ToString();

                animal = animalName.PadRight(32 - animalName.Length) + "\t" + animalBreed.PadRight(32 - animalBreed.Length) +
                    "\t" + animalSex;
                listbox_clients_animals.Items.Add(animal);
            }
        }

        /* @method:         btn_clients_save_client_Click
         * 
         * @description:    Click method for the btn_clients_save 'Save Client' button.
         *                  First we check to see if the client is a newClient or the user is 
         *                  editing an existing client.
         *                  If user is adding a new client create a new row, adding data then update
         *                  the database, if editing an existing client update the database.
         *                  Then refresh the Client's DataGridView and clear the textboxes.
         * 
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void btn_clients_save_client_Click(object sender, EventArgs e)
        {
            try
            {
                if (newClient)
                {
                    if (txtbx_animal_name.Text.Length <= 0)
                    {
                        MessageBox.Show("Please fill out animal details for initial animal when registering a new client.");
                    }
                    else
                    {
                        // Create new row for the Clients dataset
                        DataRow newClientRow = singleClientDataSet.Tables["Client"].NewRow();

                        // Get values from input controls and put into the new row
                        newClientRow["first_name"] = CheckIfNull(txt_clients_first_name.Text);
                        newClientRow["last_name"] = CheckIfNull(txt_clients_last_name.Text);
                        newClientRow["contact_phone"] = CheckIfNull(txt_clients_contact_phone.Text);
                        newClientRow["email"] = CheckIfNull(txt_clients_email.Text);
                        newClientRow["street"] = CheckIfNull(txt_clients_street.Text);
                        newClientRow["suburb"] = CheckIfNull(txt_clients_suburb.Text);
                        newClientRow["city"] = CheckIfNull(txt_clients_city.Text);
                        newClientRow["postcode"] = CheckIfNull(txt_clients_postcode.Text);

                        // Add the row to the dataset and then update the database with the new information
                        singleClientDataSet.Tables["Client"].Rows.Add(newClientRow);
                        singleClientTableAdapter.Update(singleClientDataSet.Client);

                        singleClientTableAdapter.FillByClientEmail(singleClientDataSet.Client, txt_clients_email.Text);
                        string clientidstring = singleClientDataSet.Tables["Client"].Rows[0].ItemArray[0].ToString();

                        // Create a new row for the Animal dataset.
                        DataRow newAnimalRow = singleAnimalDataSet.Tables["Animal"].NewRow();

                        // Get values from the input controls and put into the new row.
                        newAnimalRow["animal_name"] = CheckIfNull(txtbx_animal_name.Text);
                        newAnimalRow["breed"] = CheckIfNull(txtbx_animal_breed.Text);
                        newAnimalRow["category"] = CheckIfNull(txtbx_animal_category.Text);
                        newAnimalRow["sex"] = CheckIfNull(combobox_animal_sex.Text);
                        if (dobDateChanged) { newAnimalRow["dob"] = Convert.ToDateTime(dobDateTimePicker.Text); } else { newAnimalRow["dob"] = DBNull.Value; }
                        newAnimalRow["animal_owner"] = Convert.ToInt32(clientidstring);

                        // Add the row to the dataset and then update the database with the new data
                        singleAnimalDataSet.Tables["Animal"].Rows.Add(newAnimalRow);
                        singleAnimalTableAdapter.Update(singleAnimalDataSet.Animal);
                    }
                    // Retrieve a refreshed copy of data from database then call the ClearClientInformation method.
                    clientTableAdapter.Fill(clientDataSet.Client);
                    Load_AllClients_Listbox();
                    ClearClientInformation();
                }
                else
                {
                    // Else when editing a client we need to update the database when the save button is clicked
                    this.Validate();
                    singleClientBindingSource.EndEdit();
                    singleClientTableAdapter.Update(singleClientDataSet);

                    // Retrieve a refreshed copy of data from database then call the ClearClientInformation method.
                    clientTableAdapter.Fill(clientDataSet.Client);
                    Load_AllClients_Listbox();
                    ClearClientInformation();
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private Object CheckIfNull(string text)
        {
            if (String.IsNullOrEmpty(text)) return DBNull.Value; else return text;
        }

        /* @method:         btn_clients_clear_Click
         * 
         * @description:    Click method for the btn_clients_clear 'Clear Details' button.
         *                  Calls on the ClearClientInformation method.
         * 
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void btn_clients_clear_Click(object sender, EventArgs e)
        {
            try
            {
                ClearClientInformation();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        /* @method:         ClearClientInformation
         * 
         * @description:    Loops through all controls, if the control is a textbox
         *                  it is cleared of text.
         *                  Because Client information is cleared we disable the addAnimal,
         *                  clearDetails, and DeleteClient buttons and enable the SaveClient
         *                  button.  
         *                  Then the Animal DataGridView is cleared and the newClient
         *                  variable is set to true in case we save a new client's data.
         * 
         * @param:          none
         */
        private void ClearClientInformation()
        {
            foreach (Control c in this.groupBox_clients_details.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Clear();
                }
            }
            ClearAnimalInformation();

            // When clearing the details of clients disable the appropriate controls
            btn_clients_clear.Enabled = false;
            btn_client_delete.Enabled = false;
            btn_clients_save.Enabled = false;
            btn_clients_save_animal.Enabled = false;
            groupBox_AnimalDetails.Enabled = false;
            listbox_clients_animals.Items.Clear();
            singleClientTableAdapter.Fill(singleClientDataSet.Client, 0);
            // Because we are clearing the textboxes adding a new client
            newClient = true;
            
        }

        private void ClearAnimalInformation()
        {
            foreach (Control c in this.groupBox_AnimalDetails.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Clear();
                }
                else if (c is ComboBox) 
                {
                    (c as ComboBox).SelectedIndex = -1;
                }
            }
            singleAnimalTableAdapter.Fill(singleAnimalDataSet.Animal, 0);
            btn_clients_delete_animal.Enabled = false;
            btn_clients_save_animal.Text = "Add Animal";
            newAnimal = true;
            dobDateChanged = false;
        }

        /* @method:         btn_client_delete_Click
         * 
         * @description:    Click method for the btn_client_delete 'Delete Client' button.
         *                  When deleting a client, the Animals that are connected to the Client
         *                  are first deleted from the database, then the client itself is deleted
         *                  from the database.
         *                  Then the Client's DataGridView is reset to show the change.
         *                  Then the textboxes and buttons are cleared.
         *                  
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void btn_client_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int clientID = Convert.ToInt32(singleClientDataSet.Tables["Client"].Rows[0].ItemArray[0].ToString());
                animalTableAdapter.DeleteByClientID(clientID);
                singleClientTableAdapter.DeleteClientQuery(clientID);
                clientTableAdapter.Fill(clientDataSet.Client);
                Load_AllClients_Listbox();
                animalTableAdapter.Fill(animalDataSet.Animal, -1);
                ClearClientInformation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* @method:         Listbox_clients_animals_Click
         * 
         * @description:    Click method for the Listbox_clients_animals_Click when the clients
         *                  clients animals list box is clicked.
         *                  When selecting an animal in the Client's animals listbox the animal's 
         *                  details is filled into the textboxes in the Animals Details.
         *                  
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void Listbox_clients_animals_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listbox_clients_animals.SelectedIndex;
                newAnimal = false;
                string animalIDstring = animalDataSet.Tables["Animal"].Rows[index].ItemArray[0].ToString();
                singleAnimalTableAdapter.Fill(singleAnimalDataSet.Animal, Convert.ToInt32(animalIDstring));
                btn_clients_save_animal.Text = "Save";
                btn_clients_delete_animal.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* @method:         add_Animal_Click
         * 
         * @description:    A click method for the btn_clients_save_animal 'Add Animal' button.
         *                  If an animal in the client's animals listbox is clicked the user is editing an animal. 
         *                  Else we are adding a new animal.
         *                  
         *                  
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void add_Animal_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the ClientID from the current client in the singleClientDataset which is filling the client details textboxes.
                string clientIDstring = singleClientDataSet.Tables["Client"].Rows[0].ItemArray[0].ToString();
                
                if (newAnimal)
                {
                    // Create a new row for the Animal dataset.
                    DataRow newAnimalRow = singleAnimalDataSet.Tables["Animal"].NewRow();

                    // Get values from the input controls and put into the new row.
                    newAnimalRow["animal_name"] = CheckIfNull(txtbx_animal_name.Text);
                    newAnimalRow["breed"] = CheckIfNull(txtbx_animal_breed.Text);
                    newAnimalRow["category"] = CheckIfNull(txtbx_animal_category.Text);
                    newAnimalRow["sex"] = CheckIfNull(combobox_animal_sex.Text);
                    if (dobDateChanged) { newAnimalRow["dob"] = Convert.ToDateTime(dobDateTimePicker.Text); } else { newAnimalRow["dob"] = DBNull.Value; }
                    newAnimalRow["animal_owner"] = Convert.ToInt32(clientIDstring);
                    
                    // Add the row to the dataset and then update the database with the new data
                    singleAnimalDataSet.Tables["Animal"].Rows.Add(newAnimalRow);
                    singleAnimalTableAdapter.Update(singleAnimalDataSet.Animal);
                }
                else
                {
                    this.Validate();
                    singleAnimalBindingSource.EndEdit();
                    singleAnimalTableAdapter.Update(singleAnimalDataSet);
                }

                animalTableAdapter.Fill(animalDataSet.Animal, Convert.ToInt32(clientIDstring));
                Load_SingleClientsAnimals_Listbox();
                ClearAnimalInformation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /* @method:         btn_clients_delete_animal_Click
         * 
         * @description:    Method for the btn_Clients_Delete_animal 'Remove Animal' button.
         *                  When an animal is being viewed in the Edit or Add Animal Details textboxes
         *                  the animal can be deleted from the database.
         *                  
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void btn_clients_delete_animal_Click(object sender, EventArgs e)
        {
            try
            {
                string animalID = singleAnimalDataSet.Tables["Animal"].Rows[0].ItemArray[0].ToString();
                singleAnimalTableAdapter.DeleteAnimalQuery(Convert.ToInt32(animalID));
                // Get the ClientID from the current client in the singleClientDataset which is filling the client details textboxes.
                string clientIDstring = singleClientDataSet.Tables["Client"].Rows[0].ItemArray[0].ToString();
                animalTableAdapter.Fill(animalDataSet.Animal, Convert.ToInt32(clientIDstring));
                Load_SingleClientsAnimals_Listbox();
                ClearAnimalInformation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* @method:         btn_animal_clear_details_Click
         * 
         * @description:    Click method for the btn_animal_clear_details 'Clear Details' button.
         *                  Calls on the ClearAnimalInformation method.
         * 
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void btn_animal_clear_details_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAnimalInformation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /* @method:         btn_close_client_window_Click
         * 
         * @description:    Click method for the btn_close_client_window 'Close' button.
         *                  If the Close button is clicked the Frm_Clients Windows Form window is
         *                  closed and the user is taken back to the Frm_Menu Windows Form window.
         *                  
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void btn_close_client_window_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_clients_first_name.TextLength > 0)
                {
                    DialogResult dialogResult = MessageBox.Show(
                        "Are you sure you want to close the client window? Any changes that have not been saved will be lost.", 
                        "Close", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* @method:         Client_Details_TextChanged
         * 
         * @description:    Method for if the text is changed in the Client Details textboxes.
         *                  If Client Details is amended then the 'Clear Details' button is 
         *                  Enabled.
         *                  
         * @param:          object      sender      automated parameter that is the object 
         *                                              that calls on this method.
         *                  EventArgs   e           automated parameter that holds information
         *                                              about the click event.
         */
        private void Client_Details_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!btn_clients_clear.Enabled)
                {
                    btn_clients_clear.Enabled = true;
                    btn_clients_save_animal.Enabled = true;
                    btn_clients_save.Enabled = true;
                }
                groupBox_AnimalDetails.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dobDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dobDateChanged = true;
        }
    }  // END: Partial Class: Frm_Clients
}  // END: Namespace VeterinaryClinicDatabase
