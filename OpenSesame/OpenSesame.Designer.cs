namespace OpenSesame
{
    partial class WIN_MAIN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_MAIN));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BTN_SAVE_TO_DB = new System.Windows.Forms.Button();
            this.BTN_GEN_PW = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TB_NEW_URL_LOGIN = new System.Windows.Forms.TextBox();
            this.TB_NEW_SERVICE = new System.Windows.Forms.TextBox();
            this.BTN_NEW_CPY_PWD = new System.Windows.Forms.Button();
            this.TB_NEW_PASSWORD = new System.Windows.Forms.TextBox();
            this.TB_NEW_USERNAME = new System.Windows.Forms.TextBox();
            this.BTN_NEW_CPY_USERNAME = new System.Windows.Forms.Button();
            this.INDEX_PW = new System.Windows.Forms.NumericUpDown();
            this.TAB_PAGE_1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_GO = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_DEL = new System.Windows.Forms.Button();
            this.BTN_CPY_PWD = new System.Windows.Forms.Button();
            this.TB_PASSWORD = new System.Windows.Forms.TextBox();
            this.TB_USERNAME = new System.Windows.Forms.TextBox();
            this.BTN_CPY_USERNAME = new System.Windows.Forms.Button();
            this.DROPDOWN = new System.Windows.Forms.ComboBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.INDEX_PW)).BeginInit();
            this.TAB_PAGE_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.TAB_PAGE_1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 161);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::OpenSesame.Properties.Resources.Back;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.BTN_SAVE_TO_DB);
            this.tabPage2.Controls.Add(this.BTN_GEN_PW);
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 130);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Neue Zugangsdaten erstellen und speichern";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::OpenSesame.Properties.Resources.OpenSesame;
            this.pictureBox2.Location = new System.Drawing.Point(473, -17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.ToolTip.SetToolTip(this.pictureBox2, "OpenSesame by Devaliuz");
            // 
            // BTN_SAVE_TO_DB
            // 
            this.BTN_SAVE_TO_DB.BackColor = System.Drawing.Color.Black;
            this.BTN_SAVE_TO_DB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_SAVE_TO_DB.ForeColor = System.Drawing.Color.PeachPuff;
            this.BTN_SAVE_TO_DB.Location = new System.Drawing.Point(458, 70);
            this.BTN_SAVE_TO_DB.Name = "BTN_SAVE_TO_DB";
            this.BTN_SAVE_TO_DB.Size = new System.Drawing.Size(75, 23);
            this.BTN_SAVE_TO_DB.TabIndex = 5;
            this.BTN_SAVE_TO_DB.Text = "Speichern";
            this.ToolTip.SetToolTip(this.BTN_SAVE_TO_DB, "Speichere in die Datenbank");
            this.BTN_SAVE_TO_DB.UseVisualStyleBackColor = false;
            this.BTN_SAVE_TO_DB.Click += new System.EventHandler(this.BTN_SAVE_TO_DB_Click);
            // 
            // BTN_GEN_PW
            // 
            this.BTN_GEN_PW.BackColor = System.Drawing.Color.Black;
            this.BTN_GEN_PW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_GEN_PW.ForeColor = System.Drawing.Color.PeachPuff;
            this.BTN_GEN_PW.Location = new System.Drawing.Point(458, 96);
            this.BTN_GEN_PW.Name = "BTN_GEN_PW";
            this.BTN_GEN_PW.Size = new System.Drawing.Size(75, 23);
            this.BTN_GEN_PW.TabIndex = 6;
            this.BTN_GEN_PW.Text = "Generieren";
            this.ToolTip.SetToolTip(this.BTN_GEN_PW, "Generiere ein Passwort in eingestellter Länge!");
            this.BTN_GEN_PW.UseVisualStyleBackColor = false;
            this.BTN_GEN_PW.Click += new System.EventHandler(this.BTN_GEN_PW_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Controls.Add(this.TB_NEW_URL_LOGIN, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TB_NEW_SERVICE, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_NEW_CPY_PWD, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.TB_NEW_PASSWORD, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TB_NEW_USERNAME, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.BTN_NEW_CPY_USERNAME, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.INDEX_PW, 3, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(454, 120);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // TB_NEW_URL_LOGIN
            // 
            this.TB_NEW_URL_LOGIN.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TB_NEW_URL_LOGIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_NEW_URL_LOGIN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_NEW_URL_LOGIN.ForeColor = System.Drawing.Color.PeachPuff;
            this.TB_NEW_URL_LOGIN.Location = new System.Drawing.Point(31, 33);
            this.TB_NEW_URL_LOGIN.Name = "TB_NEW_URL_LOGIN";
            this.TB_NEW_URL_LOGIN.PlaceholderText = "Login URL (Optional)";
            this.TB_NEW_URL_LOGIN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_NEW_URL_LOGIN.Size = new System.Drawing.Size(306, 27);
            this.TB_NEW_URL_LOGIN.TabIndex = 1;
            this.ToolTip.SetToolTip(this.TB_NEW_URL_LOGIN, "Kompletten URL zum Anmeldebildschirm eintragen");
            // 
            // TB_NEW_SERVICE
            // 
            this.TB_NEW_SERVICE.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TB_NEW_SERVICE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_NEW_SERVICE.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_NEW_SERVICE.ForeColor = System.Drawing.Color.PeachPuff;
            this.TB_NEW_SERVICE.Location = new System.Drawing.Point(31, 3);
            this.TB_NEW_SERVICE.Name = "TB_NEW_SERVICE";
            this.TB_NEW_SERVICE.PlaceholderText = "Dienst";
            this.TB_NEW_SERVICE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_NEW_SERVICE.Size = new System.Drawing.Size(306, 27);
            this.TB_NEW_SERVICE.TabIndex = 0;
            this.ToolTip.SetToolTip(this.TB_NEW_SERVICE, "Für welchen Dienst Daten abspeichern?");
            // 
            // BTN_NEW_CPY_PWD
            // 
            this.BTN_NEW_CPY_PWD.BackColor = System.Drawing.Color.Black;
            this.BTN_NEW_CPY_PWD.BackgroundImage = global::OpenSesame.Properties.Resources.pngwing_com;
            this.BTN_NEW_CPY_PWD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_NEW_CPY_PWD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_NEW_CPY_PWD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_NEW_CPY_PWD.Location = new System.Drawing.Point(343, 93);
            this.BTN_NEW_CPY_PWD.Name = "BTN_NEW_CPY_PWD";
            this.BTN_NEW_CPY_PWD.Size = new System.Drawing.Size(50, 24);
            this.BTN_NEW_CPY_PWD.TabIndex = 8;
            this.ToolTip.SetToolTip(this.BTN_NEW_CPY_PWD, "Kopiere Passwort");
            this.BTN_NEW_CPY_PWD.UseVisualStyleBackColor = false;
            this.BTN_NEW_CPY_PWD.Click += new System.EventHandler(this.BTN_NEW_CPY_PWD_Click);
            // 
            // TB_NEW_PASSWORD
            // 
            this.TB_NEW_PASSWORD.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TB_NEW_PASSWORD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_NEW_PASSWORD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_NEW_PASSWORD.ForeColor = System.Drawing.Color.PeachPuff;
            this.TB_NEW_PASSWORD.Location = new System.Drawing.Point(31, 93);
            this.TB_NEW_PASSWORD.Name = "TB_NEW_PASSWORD";
            this.TB_NEW_PASSWORD.PlaceholderText = "Passwort";
            this.TB_NEW_PASSWORD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_NEW_PASSWORD.Size = new System.Drawing.Size(306, 27);
            this.TB_NEW_PASSWORD.TabIndex = 3;
            this.ToolTip.SetToolTip(this.TB_NEW_PASSWORD, "Passwort eintragen, oder generieren lassen.");
            this.TB_NEW_PASSWORD.UseSystemPasswordChar = true;
            // 
            // TB_NEW_USERNAME
            // 
            this.TB_NEW_USERNAME.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TB_NEW_USERNAME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_NEW_USERNAME.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_NEW_USERNAME.ForeColor = System.Drawing.Color.PeachPuff;
            this.TB_NEW_USERNAME.Location = new System.Drawing.Point(31, 63);
            this.TB_NEW_USERNAME.Name = "TB_NEW_USERNAME";
            this.TB_NEW_USERNAME.PlaceholderText = "Benutzername";
            this.TB_NEW_USERNAME.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_NEW_USERNAME.Size = new System.Drawing.Size(306, 27);
            this.TB_NEW_USERNAME.TabIndex = 2;
            this.ToolTip.SetToolTip(this.TB_NEW_USERNAME, "Benutzernamen eintragen");
            // 
            // BTN_NEW_CPY_USERNAME
            // 
            this.BTN_NEW_CPY_USERNAME.BackColor = System.Drawing.Color.Black;
            this.BTN_NEW_CPY_USERNAME.BackgroundImage = global::OpenSesame.Properties.Resources.pngwing_com;
            this.BTN_NEW_CPY_USERNAME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_NEW_CPY_USERNAME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_NEW_CPY_USERNAME.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_NEW_CPY_USERNAME.Location = new System.Drawing.Point(343, 63);
            this.BTN_NEW_CPY_USERNAME.Name = "BTN_NEW_CPY_USERNAME";
            this.BTN_NEW_CPY_USERNAME.Size = new System.Drawing.Size(50, 24);
            this.BTN_NEW_CPY_USERNAME.TabIndex = 7;
            this.ToolTip.SetToolTip(this.BTN_NEW_CPY_USERNAME, "Kopiere Benutzernamen");
            this.BTN_NEW_CPY_USERNAME.UseVisualStyleBackColor = false;
            this.BTN_NEW_CPY_USERNAME.Click += new System.EventHandler(this.BTN_NEW_CPY_USERNAME_Click);
            // 
            // INDEX_PW
            // 
            this.INDEX_PW.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.INDEX_PW.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.INDEX_PW.ForeColor = System.Drawing.Color.PeachPuff;
            this.INDEX_PW.Location = new System.Drawing.Point(399, 93);
            this.INDEX_PW.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.INDEX_PW.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.INDEX_PW.Name = "INDEX_PW";
            this.INDEX_PW.Size = new System.Drawing.Size(50, 27);
            this.INDEX_PW.TabIndex = 4;
            this.ToolTip.SetToolTip(this.INDEX_PW, "Wieviele stellen soll das erstellte Passwort haben? (8-32)");
            this.INDEX_PW.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // TAB_PAGE_1
            // 
            this.TAB_PAGE_1.BackgroundImage = global::OpenSesame.Properties.Resources.Back;
            this.TAB_PAGE_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TAB_PAGE_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TAB_PAGE_1.Controls.Add(this.pictureBox1);
            this.TAB_PAGE_1.Controls.Add(this.BTN_GO);
            this.TAB_PAGE_1.Controls.Add(this.tableLayoutPanel1);
            this.TAB_PAGE_1.Location = new System.Drawing.Point(4, 27);
            this.TAB_PAGE_1.Name = "TAB_PAGE_1";
            this.TAB_PAGE_1.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_PAGE_1.Size = new System.Drawing.Size(576, 130);
            this.TAB_PAGE_1.TabIndex = 0;
            this.TAB_PAGE_1.Text = "Gespeicherte Zugangsdaten";
            this.TAB_PAGE_1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::OpenSesame.Properties.Resources.OpenSesame;
            this.pictureBox1.Location = new System.Drawing.Point(439, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.ToolTip.SetToolTip(this.pictureBox1, "OpenSesame by Devaliuz");
            // 
            // BTN_GO
            // 
            this.BTN_GO.BackColor = System.Drawing.Color.Black;
            this.BTN_GO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_GO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_GO.ForeColor = System.Drawing.Color.PeachPuff;
            this.BTN_GO.Location = new System.Drawing.Point(458, 95);
            this.BTN_GO.Name = "BTN_GO";
            this.BTN_GO.Size = new System.Drawing.Size(100, 25);
            this.BTN_GO.TabIndex = 1;
            this.BTN_GO.Text = "Anmelden!";
            this.ToolTip.SetToolTip(this.BTN_GO, "Rufe den Anmeldebildschirm auf");
            this.BTN_GO.UseVisualStyleBackColor = false;
            this.BTN_GO.Click += new System.EventHandler(this.BTN_GO_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.BTN_DEL, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_CPY_PWD, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.TB_PASSWORD, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TB_USERNAME, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BTN_CPY_USERNAME, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.DROPDOWN, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(449, 120);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BTN_DEL
            // 
            this.BTN_DEL.BackColor = System.Drawing.Color.Black;
            this.BTN_DEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_DEL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_DEL.ForeColor = System.Drawing.Color.PeachPuff;
            this.BTN_DEL.Location = new System.Drawing.Point(339, 15);
            this.BTN_DEL.Name = "BTN_DEL";
            this.BTN_DEL.Size = new System.Drawing.Size(78, 24);
            this.BTN_DEL.TabIndex = 5;
            this.BTN_DEL.Text = "Löschen";
            this.ToolTip.SetToolTip(this.BTN_DEL, "Lösche die hinterlegten Anmeldedaten");
            this.BTN_DEL.UseVisualStyleBackColor = false;
            this.BTN_DEL.Click += new System.EventHandler(this.BTN_DEL_Click);
            // 
            // BTN_CPY_PWD
            // 
            this.BTN_CPY_PWD.BackColor = System.Drawing.Color.Black;
            this.BTN_CPY_PWD.BackgroundImage = global::OpenSesame.Properties.Resources.pngwing_com;
            this.BTN_CPY_PWD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_CPY_PWD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_CPY_PWD.Location = new System.Drawing.Point(339, 75);
            this.BTN_CPY_PWD.Name = "BTN_CPY_PWD";
            this.BTN_CPY_PWD.Size = new System.Drawing.Size(78, 24);
            this.BTN_CPY_PWD.TabIndex = 3;
            this.ToolTip.SetToolTip(this.BTN_CPY_PWD, "Kopiere Passwort");
            this.BTN_CPY_PWD.UseVisualStyleBackColor = false;
            this.BTN_CPY_PWD.Click += new System.EventHandler(this.BTN_CPY_PWD_Click);
            // 
            // TB_PASSWORD
            // 
            this.TB_PASSWORD.BackColor = System.Drawing.Color.Black;
            this.TB_PASSWORD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_PASSWORD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_PASSWORD.ForeColor = System.Drawing.Color.PeachPuff;
            this.TB_PASSWORD.Location = new System.Drawing.Point(25, 75);
            this.TB_PASSWORD.Name = "TB_PASSWORD";
            this.TB_PASSWORD.PlaceholderText = "Passwort";
            this.TB_PASSWORD.ReadOnly = true;
            this.TB_PASSWORD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_PASSWORD.Size = new System.Drawing.Size(308, 27);
            this.TB_PASSWORD.TabIndex = 1;
            this.ToolTip.SetToolTip(this.TB_PASSWORD, "Passwort für Dienst");
            this.TB_PASSWORD.UseSystemPasswordChar = true;
            // 
            // TB_USERNAME
            // 
            this.TB_USERNAME.BackColor = System.Drawing.Color.Black;
            this.TB_USERNAME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_USERNAME.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_USERNAME.ForeColor = System.Drawing.Color.PeachPuff;
            this.TB_USERNAME.Location = new System.Drawing.Point(25, 45);
            this.TB_USERNAME.Name = "TB_USERNAME";
            this.TB_USERNAME.PlaceholderText = "Benutzername";
            this.TB_USERNAME.ReadOnly = true;
            this.TB_USERNAME.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_USERNAME.Size = new System.Drawing.Size(308, 27);
            this.TB_USERNAME.TabIndex = 0;
            this.ToolTip.SetToolTip(this.TB_USERNAME, "Nutzername für Dienst");
            // 
            // BTN_CPY_USERNAME
            // 
            this.BTN_CPY_USERNAME.BackColor = System.Drawing.Color.Black;
            this.BTN_CPY_USERNAME.BackgroundImage = global::OpenSesame.Properties.Resources.pngwing_com;
            this.BTN_CPY_USERNAME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_CPY_USERNAME.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_CPY_USERNAME.Location = new System.Drawing.Point(339, 45);
            this.BTN_CPY_USERNAME.Name = "BTN_CPY_USERNAME";
            this.BTN_CPY_USERNAME.Size = new System.Drawing.Size(78, 24);
            this.BTN_CPY_USERNAME.TabIndex = 2;
            this.ToolTip.SetToolTip(this.BTN_CPY_USERNAME, "Kopiere Nutzernamen");
            this.BTN_CPY_USERNAME.UseVisualStyleBackColor = false;
            this.BTN_CPY_USERNAME.Click += new System.EventHandler(this.BTN_CPY_USERNAME_Click);
            // 
            // DROPDOWN
            // 
            this.DROPDOWN.BackColor = System.Drawing.Color.Black;
            this.DROPDOWN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DROPDOWN.ForeColor = System.Drawing.Color.PeachPuff;
            this.DROPDOWN.FormattingEnabled = true;
            this.DROPDOWN.Location = new System.Drawing.Point(25, 15);
            this.DROPDOWN.Name = "DROPDOWN";
            this.DROPDOWN.Size = new System.Drawing.Size(308, 28);
            this.DROPDOWN.TabIndex = 4;
            this.ToolTip.SetToolTip(this.DROPDOWN, "Hier werden alle gespeicherten Dienste aufgelistet.");
            this.DROPDOWN.SelectedIndexChanged += new System.EventHandler(this.DROPDOWN_SelectedIndexChanged);
            this.DROPDOWN.Click += new System.EventHandler(this.DROPDOWN_Click);
            // 
            // WIN_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 200);
            this.MinimumSize = new System.Drawing.Size(600, 200);
            this.Name = "WIN_MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenSesame";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.INDEX_PW)).EndInit();
            this.TAB_PAGE_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private PictureBox pictureBox2;
        private Button BTN_SAVE_TO_DB;
        private Button BTN_GEN_PW;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox TB_NEW_URL_LOGIN;
        private TextBox TB_NEW_SERVICE;
        private Button BTN_NEW_CPY_PWD;
        private TextBox TB_NEW_PASSWORD;
        private TextBox TB_NEW_USERNAME;
        private Button BTN_NEW_CPY_USERNAME;
        private NumericUpDown INDEX_PW;
        private TabPage TAB_PAGE_1;
        private PictureBox pictureBox1;
        private Button BTN_GO;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BTN_DEL;
        private Button BTN_CPY_PWD;
        private TextBox TB_PASSWORD;
        private TextBox TB_USERNAME;
        private Button BTN_CPY_USERNAME;
        private ComboBox DROPDOWN;
        private ToolTip ToolTip;
    }
}