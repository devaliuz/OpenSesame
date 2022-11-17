using System.Data.SQLite;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;


namespace OpenSesame
{
    public partial class WIN_MAIN : Form
    {
        DB db = new DB();

        public WIN_MAIN()
        {
            InitializeComponent();
            LoadDropdown();
            BTN_DEL.Visible = false;
            BTN_GO.Visible = false;
        }

        private void BTN_GEN_PW_Click(object sender, EventArgs e)
        {
            try
            {
                string PW = "";                                                                                                             //Sets empty String for PW
                Random rd = new Random();                                                                                                   //initializes randomclass
                while (PW.Length < INDEX_PW.Value)                                                                                           //repeats while Password is shorter than wanted value
                {
                    int rdascii = rd.Next(33, 123);                                                                                          //gives random number between 33 and 123
                    if (rdascii >= 33 && rdascii != 34 && rdascii <= 38 || rdascii >= 47 && rdascii <= 57 || rdascii >= 60 && rdascii <= 90 || rdascii >= 97)    //checks if rnd number could be converted to useable char
                    {
                        char c = (char)rdascii;                                                                                             //converts rdascii into a readable char
                        PW += c;                                                                                                            //adds readable char to Password
                    }
                }
                TB_NEW_PASSWORD.Text = PW;                                                                                                  //Shows the random generated Password
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_NEW_CPY_PWD_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, TB_NEW_PASSWORD.Text);                                                                   //Copies Text into Clipboard
        }

        private void BTN_NEW_CPY_USERNAME_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, TB_NEW_USERNAME.Text);                                                                  //"-"
        }

        private void BTN_CPY_USERNAME_Click(object sender, EventArgs e)                                                                 //"-"
        {
            Clipboard.SetData(DataFormats.Text, TB_USERNAME.Text);
        }

        private void BTN_CPY_PWD_Click(object sender, EventArgs e)                                                                      //"-"
        {
            Clipboard.SetData(DataFormats.Text, TB_PASSWORD.Text);
        }

        private void DROPDOWN_KeyPress(object sender, KeyPressEventArgs e)                                                              //prevents User from Typing into the Dropdown
        {
            e.Handled = true;
        }
        private void BTN_SAVE_TO_DB_Click(object sender, EventArgs e)                                                                   //Saves Userdata to DB
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source = Data.sqlite3"))                                //Creates Connection to DB
                {
                    connection.Open();                                                                                                  //Opens Connection to DB
                    using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM UserData WHERE Service = '" + TB_NEW_SERVICE.Text + "'", connection))   //Creates query for SQLite to search if Entry for Service already exists
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())                                                       //combines Query and Readfunvtion
                        {
                            if (reader.Read() == true)                                                                                  //tries to find all Entries with same name as user has given
                            {
                                MessageBox.Show("Für den Dienst " + TB_NEW_SERVICE.Text + " sind bereits Anmeldedaten vorhanden! Die Daten wurden NICHT gespeichert!"); //If found Entries with same name, informs user to chose another Service-Name
                            }
                            else
                            {
                                string Service = TB_NEW_SERVICE.Text;                                                               //Saves Userinput into variable 
                                string Username = encrypt(TB_NEW_USERNAME.Text);                                                    //Saves Userinput encrypted into variable
                                string Password = encrypt(TB_NEW_PASSWORD.Text);                                                    //-"-
                                string URL = TB_NEW_URL_LOGIN.Text;                                                                 //Saves Userinput into variable 
                                if (Service == "" || TB_NEW_USERNAME.Text == "" || TB_NEW_PASSWORD.Text == "")                      //Checks, if all needed inputfields are filled
                                {
                                    MessageBox.Show("Bitte Dienst, Nutzernamen und Passwort eingeben!");                            //reminds user, to fill all fields which are needed
                                }
                                else
                                {
                                    SQLiteCommand command1 = new SQLiteCommand("INSERT INTO UserData('Service','Username','Password', 'URL') VALUES(@Service,@Username,@Password,@URL)", connection); //SQLitecommand for saving data into correct collums
                                    command1.Parameters.AddWithValue("@Service", Service);                                          //gives Value to SQLite-Variable                             
                                    command1.Parameters.AddWithValue("@Username", Username);
                                    command1.Parameters.AddWithValue("@Password", Password);
                                    command1.Parameters.AddWithValue("@URL", URL);
                                    command1.ExecuteNonQuery();                                                                     //writes all data from above into the collumns
                                    TB_NEW_SERVICE.Text = "";                                                                       //Clears inputfields
                                    TB_NEW_USERNAME.Text = "";
                                    TB_NEW_PASSWORD.Text = "";
                                    TB_NEW_URL_LOGIN.Text = "";
                                    MessageBox.Show("Daten für " + Service + " hinzugefügt!");                                      //gives feedback to the user
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                                                                                        //shows, what exactly went wrong, if something went wrong
            }
        }

        private void DROPDOWN_Click(object sender, EventArgs e)
        {
            LoadDropdown();
            BTN_DEL.Visible = false;
            BTN_GO.Visible = false;
        }

        private void DROPDOWN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "'" + this.DROPDOWN.SelectedItem.ToString() + "'";                                                             //saves selected Item into variable

            if ((str != "") && (str != "Dienst wählen"))                                                                                //checks if there actually was something selected from Database          
            {
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection("Data Source = Data.sqlite3"))
                    {
                        connection.Open();
                        using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM UserData WHERE Service = " + str, connection))     //creates SQlite-Command to select needed values
                        {

                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                reader.Read();
                                TB_USERNAME.Text = decrypt(reader["Username"].ToString());                                                  //writes decrypted Username into correct space
                                TB_PASSWORD.Text = decrypt(reader["Password"].ToString());                                                  //writes decrypted Password into correct space
                            }
                        }
                    }
                    BTN_DEL.Visible = true;                                                                                                 //opens Option to delete selected data
                    BTN_GO.Visible = true;                                                                                                  //opens Option to start browsing the website for Logging into selected service
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private static string encrypt(string toEncrypt)
        {
            try
            {
                string password = "xw66AtED8AemHUD/GGsKKw==";                                                                                   //Fix password as default for encryption "Rot13" encrypted
                byte[] buffer = Encoding.Unicode.GetBytes(toEncrypt);
                using (Aes aes = Aes.Create())
                {
                    byte[] salt = new byte[] { 0x49, 0x76, 0x61, 110, 0x20, 0x4d, 0x65, 100, 0x76, 0x65, 100, 0x65, 0x79 };                     //creates "salt" to blur the actual encryption
                    Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, salt);
                    aes.Key = bytes.GetBytes(0x20);
                    aes.IV = bytes.GetBytes(0x10);                                                                                              //creates a prefix to blur where the actual encrypted part starts
                    using (MemoryStream stream = new MemoryStream())
                    {
                        using (CryptoStream stream2 = new CryptoStream((Stream)stream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            stream2.Write(buffer, 0, buffer.Length);
                            stream2.Close();                                                                                                     //merges raw-data+password+salt+prefix
                        }
                        toEncrypt = Convert.ToBase64String(stream.ToArray());                                                                   //creates useable string from bytes
                    }
                }
                return toEncrypt;                                                                                                               //returns the encrypted string
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        private static string decrypt(string toDecrypt)
        {
            try
            {
                string password = "xw66AtED8AemHUD/GGsKKw==";
                toDecrypt = toDecrypt.Replace(" ", "+");
                byte[] buffer = Convert.FromBase64String(toDecrypt);
                using (Aes aes = Aes.Create())
                {
                    byte[] salt = new byte[] { 0x49, 0x76, 0x61, 110, 0x20, 0x4d, 0x65, 100, 0x76, 0x65, 100, 0x65, 0x79 };
                    Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, salt);
                    aes.Key = bytes.GetBytes(0x20);
                    aes.IV = bytes.GetBytes(0x10);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        using (CryptoStream stream2 = new CryptoStream(stream, aes.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            stream2.Write(buffer, 0, buffer.Length);
                            stream2.Close();
                        }
                        toDecrypt = Encoding.Unicode.GetString(stream.ToArray());
                    }
                }
                return toDecrypt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        void LoadDropdown()
        {
            DROPDOWN.Text = "Service wählen!";
            try
            {
                DROPDOWN.Items.Clear();
                TB_USERNAME.Text = "";
                TB_PASSWORD.Text = "";
                string[] strArray = db.Load();
                for (int i = 0; i < strArray.Length; i++)
                {
                    DROPDOWN.Items.Add(strArray[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_DEL_Click(object sender, EventArgs e)
        {
            TB_USERNAME.ReadOnly = false;
            {
                string str = "'" + DROPDOWN.SelectedItem.ToString() + "'";
                if (str != null)
                {
                    if (TB_USERNAME.Text != "LÖSCHEN!" && TB_USERNAME.Text != "Löschen" && TB_USERNAME.Text != "löschen")
                    {
                        MessageBox.Show("Um die Zugangsadaten für " + str + " zu löschen, schreiben Sie bitte LÖSCHEN! in das Benutzernamenfeld und drücken erneut auf Löschen!");
                    }
                    else
                    {
                        try
                        {
                            using (SQLiteConnection connection = new SQLiteConnection("Data Source = Data.sqlite3"))
                            {
                                connection.Open();
                                using (SQLiteCommand command = new SQLiteCommand("DELETE FROM UserData WHERE Service = " + str + ";", connection))
                                {

                                    command.ExecuteNonQuery();
                                }
                                MessageBox.Show("Die Zugangsadaten für " + str + " wurden gelöscht!");
                            }

                            DROPDOWN.Text = "Dienst wählen";
                            TB_PASSWORD.Text = "";
                            TB_USERNAME.Text = "";
                            BTN_DEL.Visible = false;
                            BTN_GO.Visible = false;
                            LoadDropdown();
                            TB_USERNAME.ReadOnly = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void BTN_GO_Click(object sender, EventArgs e)
        {
            string str = "'" + this.DROPDOWN.SelectedItem.ToString() + "'";
            string user = "";
            string pw = "";
            try
            {
                if (DROPDOWN.SelectedItem != null)
                {
                    try
                    {
                        using (SQLiteConnection connection = new SQLiteConnection("Data Source = Data.sqlite3"))
                        {
                            connection.Open();
                            using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM UserData WHERE Service = " + str, connection))
                            {

                                using (SQLiteDataReader reader = command.ExecuteReader())
                                {
                                    reader.Read();
                                    str = reader["URL"].ToString();
                                    user = decrypt(reader["Username"].ToString());
                                    pw = decrypt(reader["Password"].ToString());
                                }
                            }
                        }
                        BTN_DEL.Visible = true;
                        BTN_GO.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (str == "")
                    {
                        MessageBox.Show("Kein URL für diesen Dienst hinterlegt!");
                    }
                    else
                    {
                        ProcessStartInfo processStartInfo = new ProcessStartInfo();
                        processStartInfo.FileName = str;
                        processStartInfo.UseShellExecute = true;
                        Process.Start(processStartInfo);

                    }
                }
                else
                {
                    MessageBox.Show("Bitte erst einen Dienst auswählen!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}