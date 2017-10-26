namespace Projet_Final
{
    partial class COMMIS
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
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.listView_Clients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button_Modifier = new System.Windows.Forms.Button();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.button_Rechercher = new System.Windows.Forms.Button();
            this.button_Afficher = new System.Windows.Forms.Button();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_rue = new System.Windows.Forms.TextBox();
            this.textBox_ville = new System.Windows.Forms.TextBox();
            this.maskedTextBox_codePostal = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_telephone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_credit = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_telecopieur = new System.Windows.Forms.MaskedTextBox();
            this.button_Quitter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_modCopieur = new System.Windows.Forms.RadioButton();
            this.radioButton_modCredit = new System.Windows.Forms.RadioButton();
            this.radioButton_modTel = new System.Windows.Forms.RadioButton();
            this.radioButton_modCP = new System.Windows.Forms.RadioButton();
            this.radioButton_modVille = new System.Windows.Forms.RadioButton();
            this.radioButton_modRue = new System.Windows.Forms.RadioButton();
            this.radioButton_modNom = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxChoixRechCredit = new System.Windows.Forms.GroupBox();
            this.radioButtonRechLimExces = new System.Windows.Forms.RadioButton();
            this.radioButtonLimRechDeficit = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_Detail = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.compteEmployéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierParametresDuCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeNousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highTechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_passageMP = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxChoixRechCredit.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Ajouter
            // 
            this.button_Ajouter.Location = new System.Drawing.Point(378, 311);
            this.button_Ajouter.Name = "button_Ajouter";
            this.button_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_Ajouter.TabIndex = 0;
            this.button_Ajouter.Text = "&Ajouter";
            this.button_Ajouter.UseVisualStyleBackColor = true;
            this.button_Ajouter.Click += new System.EventHandler(this.button_Ajouter_Click);
            // 
            // listView_Clients
            // 
            this.listView_Clients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView_Clients.FullRowSelect = true;
            this.listView_Clients.GridLines = true;
            this.listView_Clients.Location = new System.Drawing.Point(12, 403);
            this.listView_Clients.MultiSelect = false;
            this.listView_Clients.Name = "listView_Clients";
            this.listView_Clients.Size = new System.Drawing.Size(992, 185);
            this.listView_Clients.TabIndex = 1;
            this.listView_Clients.UseCompatibleStateImageBehavior = false;
            this.listView_Clients.View = System.Windows.Forms.View.Details;
            this.listView_Clients.SelectedIndexChanged += new System.EventHandler(this.listView_Clients_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Rue";
            this.columnHeader3.Width = 127;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ville";
            this.columnHeader4.Width = 108;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Code postal";
            this.columnHeader5.Width = 144;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Téléphone";
            this.columnHeader6.Width = 183;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Limite de crédit";
            this.columnHeader7.Width = 158;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Télécopieur";
            this.columnHeader8.Width = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // button_Modifier
            // 
            this.button_Modifier.Location = new System.Drawing.Point(22, 243);
            this.button_Modifier.Name = "button_Modifier";
            this.button_Modifier.Size = new System.Drawing.Size(75, 23);
            this.button_Modifier.TabIndex = 3;
            this.button_Modifier.Text = "&Modifier";
            this.button_Modifier.UseVisualStyleBackColor = true;
            this.button_Modifier.Click += new System.EventHandler(this.button_Modifier_Click);
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.Location = new System.Drawing.Point(585, 311);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_Supprimer.TabIndex = 4;
            this.button_Supprimer.Text = "&Supprimer";
            this.button_Supprimer.UseVisualStyleBackColor = true;
            this.button_Supprimer.Click += new System.EventHandler(this.button_Supprimer_Click);
            // 
            // button_Rechercher
            // 
            this.button_Rechercher.Location = new System.Drawing.Point(25, 77);
            this.button_Rechercher.Name = "button_Rechercher";
            this.button_Rechercher.Size = new System.Drawing.Size(75, 23);
            this.button_Rechercher.TabIndex = 5;
            this.button_Rechercher.Text = "&Rechercher";
            this.button_Rechercher.UseVisualStyleBackColor = true;
            this.button_Rechercher.Click += new System.EventHandler(this.button_Rechercher_Click);
            // 
            // button_Afficher
            // 
            this.button_Afficher.Location = new System.Drawing.Point(483, 311);
            this.button_Afficher.Name = "button_Afficher";
            this.button_Afficher.Size = new System.Drawing.Size(75, 23);
            this.button_Afficher.TabIndex = 6;
            this.button_Afficher.Text = "&Afficher";
            this.button_Afficher.UseVisualStyleBackColor = true;
            this.button_Afficher.Click += new System.EventHandler(this.button_Afficher_Click);
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(483, 94);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(140, 20);
            this.textBox_nom.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Code postal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Téléphone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Limite de Crédit :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Télécopieur :";
            // 
            // textBox_rue
            // 
            this.textBox_rue.Location = new System.Drawing.Point(483, 124);
            this.textBox_rue.Name = "textBox_rue";
            this.textBox_rue.Size = new System.Drawing.Size(140, 20);
            this.textBox_rue.TabIndex = 14;
            // 
            // textBox_ville
            // 
            this.textBox_ville.Location = new System.Drawing.Point(484, 152);
            this.textBox_ville.Name = "textBox_ville";
            this.textBox_ville.Size = new System.Drawing.Size(140, 20);
            this.textBox_ville.TabIndex = 15;
            // 
            // maskedTextBox_codePostal
            // 
            this.maskedTextBox_codePostal.Location = new System.Drawing.Point(484, 184);
            this.maskedTextBox_codePostal.Mask = ">L0L - 0L0";
            this.maskedTextBox_codePostal.Name = "maskedTextBox_codePostal";
            this.maskedTextBox_codePostal.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_codePostal.TabIndex = 16;
            // 
            // maskedTextBox_telephone
            // 
            this.maskedTextBox_telephone.Location = new System.Drawing.Point(484, 210);
            this.maskedTextBox_telephone.Mask = ">(000) 000 0000";
            this.maskedTextBox_telephone.Name = "maskedTextBox_telephone";
            this.maskedTextBox_telephone.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_telephone.TabIndex = 17;
            // 
            // maskedTextBox_credit
            // 
            this.maskedTextBox_credit.Location = new System.Drawing.Point(484, 236);
            this.maskedTextBox_credit.Name = "maskedTextBox_credit";
            this.maskedTextBox_credit.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_credit.TabIndex = 18;
            // 
            // maskedTextBox_telecopieur
            // 
            this.maskedTextBox_telecopieur.Location = new System.Drawing.Point(483, 261);
            this.maskedTextBox_telecopieur.Mask = ">(000) 000 0000";
            this.maskedTextBox_telecopieur.Name = "maskedTextBox_telecopieur";
            this.maskedTextBox_telecopieur.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_telecopieur.TabIndex = 19;
            // 
            // button_Quitter
            // 
            this.button_Quitter.Location = new System.Drawing.Point(929, 594);
            this.button_Quitter.Name = "button_Quitter";
            this.button_Quitter.Size = new System.Drawing.Size(75, 23);
            this.button_Quitter.TabIndex = 20;
            this.button_Quitter.Text = "&Quitter";
            this.button_Quitter.UseVisualStyleBackColor = true;
            this.button_Quitter.Click += new System.EventHandler(this.button_Quitter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_modCopieur);
            this.groupBox1.Controls.Add(this.radioButton_modCredit);
            this.groupBox1.Controls.Add(this.radioButton_modTel);
            this.groupBox1.Controls.Add(this.radioButton_modCP);
            this.groupBox1.Controls.Add(this.radioButton_modVille);
            this.groupBox1.Controls.Add(this.radioButton_modRue);
            this.groupBox1.Controls.Add(this.radioButton_modNom);
            this.groupBox1.Controls.Add(this.button_Modifier);
            this.groupBox1.Location = new System.Drawing.Point(71, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 275);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix de l\'élement à modifier";
            // 
            // radioButton_modCopieur
            // 
            this.radioButton_modCopieur.AutoSize = true;
            this.radioButton_modCopieur.Location = new System.Drawing.Point(22, 202);
            this.radioButton_modCopieur.Name = "radioButton_modCopieur";
            this.radioButton_modCopieur.Size = new System.Drawing.Size(88, 17);
            this.radioButton_modCopieur.TabIndex = 6;
            this.radioButton_modCopieur.TabStop = true;
            this.radioButton_modCopieur.Text = "le télécopieur";
            this.radioButton_modCopieur.UseVisualStyleBackColor = true;
            // 
            // radioButton_modCredit
            // 
            this.radioButton_modCredit.AutoSize = true;
            this.radioButton_modCredit.Location = new System.Drawing.Point(22, 170);
            this.radioButton_modCredit.Name = "radioButton_modCredit";
            this.radioButton_modCredit.Size = new System.Drawing.Size(103, 17);
            this.radioButton_modCredit.TabIndex = 5;
            this.radioButton_modCredit.TabStop = true;
            this.radioButton_modCredit.Text = "la limite de crédit";
            this.radioButton_modCredit.UseVisualStyleBackColor = true;
            // 
            // radioButton_modTel
            // 
            this.radioButton_modTel.AutoSize = true;
            this.radioButton_modTel.Location = new System.Drawing.Point(22, 140);
            this.radioButton_modTel.Name = "radioButton_modTel";
            this.radioButton_modTel.Size = new System.Drawing.Size(136, 17);
            this.radioButton_modTel.TabIndex = 4;
            this.radioButton_modTel.TabStop = true;
            this.radioButton_modTel.Text = "le numero de téléphone";
            this.radioButton_modTel.UseVisualStyleBackColor = true;
            // 
            // radioButton_modCP
            // 
            this.radioButton_modCP.AutoSize = true;
            this.radioButton_modCP.Location = new System.Drawing.Point(22, 111);
            this.radioButton_modCP.Name = "radioButton_modCP";
            this.radioButton_modCP.Size = new System.Drawing.Size(91, 17);
            this.radioButton_modCP.TabIndex = 3;
            this.radioButton_modCP.TabStop = true;
            this.radioButton_modCP.Text = "le code postal";
            this.radioButton_modCP.UseVisualStyleBackColor = true;
            // 
            // radioButton_modVille
            // 
            this.radioButton_modVille.AutoSize = true;
            this.radioButton_modVille.Location = new System.Drawing.Point(22, 83);
            this.radioButton_modVille.Name = "radioButton_modVille";
            this.radioButton_modVille.Size = new System.Drawing.Size(54, 17);
            this.radioButton_modVille.TabIndex = 2;
            this.radioButton_modVille.TabStop = true;
            this.radioButton_modVille.Text = "la ville";
            this.radioButton_modVille.UseVisualStyleBackColor = true;
            // 
            // radioButton_modRue
            // 
            this.radioButton_modRue.AutoSize = true;
            this.radioButton_modRue.Location = new System.Drawing.Point(22, 56);
            this.radioButton_modRue.Name = "radioButton_modRue";
            this.radioButton_modRue.Size = new System.Drawing.Size(51, 17);
            this.radioButton_modRue.TabIndex = 1;
            this.radioButton_modRue.TabStop = true;
            this.radioButton_modRue.Text = "la rue";
            this.radioButton_modRue.UseVisualStyleBackColor = true;
            // 
            // radioButton_modNom
            // 
            this.radioButton_modNom.AutoSize = true;
            this.radioButton_modNom.Location = new System.Drawing.Point(22, 29);
            this.radioButton_modNom.Name = "radioButton_modNom";
            this.radioButton_modNom.Size = new System.Drawing.Size(56, 17);
            this.radioButton_modNom.TabIndex = 0;
            this.radioButton_modNom.TabStop = true;
            this.radioButton_modNom.Text = "le nom";
            this.radioButton_modNom.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBoxChoixRechCredit);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.button_Rechercher);
            this.groupBox2.Location = new System.Drawing.Point(733, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 275);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Méthode de recherche";
            // 
            // groupBoxChoixRechCredit
            // 
            this.groupBoxChoixRechCredit.Controls.Add(this.radioButtonRechLimExces);
            this.groupBoxChoixRechCredit.Controls.Add(this.radioButtonLimRechDeficit);
            this.groupBoxChoixRechCredit.Location = new System.Drawing.Point(53, 136);
            this.groupBoxChoixRechCredit.Name = "groupBoxChoixRechCredit";
            this.groupBoxChoixRechCredit.Size = new System.Drawing.Size(145, 100);
            this.groupBoxChoixRechCredit.TabIndex = 27;
            this.groupBoxChoixRechCredit.TabStop = false;
            this.groupBoxChoixRechCredit.Text = "Selon que le crédit soit ...";
            // 
            // radioButtonRechLimExces
            // 
            this.radioButtonRechLimExces.AutoSize = true;
            this.radioButtonRechLimExces.Location = new System.Drawing.Point(35, 30);
            this.radioButtonRechLimExces.Name = "radioButtonRechLimExces";
            this.radioButtonRechLimExces.Size = new System.Drawing.Size(86, 17);
            this.radioButtonRechLimExces.TabIndex = 6;
            this.radioButtonRechLimExces.TabStop = true;
            this.radioButtonRechLimExces.Text = "excédentaire";
            this.radioButtonRechLimExces.UseVisualStyleBackColor = true;
            // 
            // radioButtonLimRechDeficit
            // 
            this.radioButtonLimRechDeficit.AutoSize = true;
            this.radioButtonLimRechDeficit.Location = new System.Drawing.Point(35, 66);
            this.radioButtonLimRechDeficit.Name = "radioButtonLimRechDeficit";
            this.radioButtonLimRechDeficit.Size = new System.Drawing.Size(70, 17);
            this.radioButtonLimRechDeficit.TabIndex = 7;
            this.radioButtonLimRechDeficit.TabStop = true;
            this.radioButtonLimRechDeficit.Text = "déficitaire";
            this.radioButtonLimRechDeficit.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nom",
            "Ville",
            "Limite de Crédit",
            "Code postal"});
            this.comboBox1.Location = new System.Drawing.Point(25, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(452, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Statut de l\'opération";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Detail
            // 
            this.label_Detail.AutoSize = true;
            this.label_Detail.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Detail.Location = new System.Drawing.Point(455, 376);
            this.label_Detail.Name = "label_Detail";
            this.label_Detail.Size = new System.Drawing.Size(35, 16);
            this.label_Detail.TabIndex = 24;
            this.label_Detail.Text = "***";
            this.label_Detail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(484, 64);
            this.maskedTextBox1.Mask = ">LL 0000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(139, 20);
            this.maskedTextBox1.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "No Client";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compteEmployéToolStripMenuItem,
            this.aProposDeNousToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // compteEmployéToolStripMenuItem
            // 
            this.compteEmployéToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierParametresDuCompteToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.compteEmployéToolStripMenuItem.Name = "compteEmployéToolStripMenuItem";
            this.compteEmployéToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.compteEmployéToolStripMenuItem.Text = "Compte Employé";
            this.compteEmployéToolStripMenuItem.Click += new System.EventHandler(this.compteEmployéToolStripMenuItem_Click);
            // 
            // modifierParametresDuCompteToolStripMenuItem
            // 
            this.modifierParametresDuCompteToolStripMenuItem.Name = "modifierParametresDuCompteToolStripMenuItem";
            this.modifierParametresDuCompteToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.modifierParametresDuCompteToolStripMenuItem.Text = "Modifier parametres du compte";
            this.modifierParametresDuCompteToolStripMenuItem.Click += new System.EventHandler(this.modifierParametresDuCompteToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // aProposDeNousToolStripMenuItem
            // 
            this.aProposDeNousToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highTechToolStripMenuItem});
            this.aProposDeNousToolStripMenuItem.Name = "aProposDeNousToolStripMenuItem";
            this.aProposDeNousToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.aProposDeNousToolStripMenuItem.Text = "A propos de nous";
            this.aProposDeNousToolStripMenuItem.Click += new System.EventHandler(this.aProposDeNousToolStripMenuItem_Click);
            // 
            // highTechToolStripMenuItem
            // 
            this.highTechToolStripMenuItem.Name = "highTechToolStripMenuItem";
            this.highTechToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.highTechToolStripMenuItem.Text = "High Tech";
            this.highTechToolStripMenuItem.Click += new System.EventHandler(this.highTechToolStripMenuItem_Click);
            // 
            // label_passageMP
            // 
            this.label_passageMP.AutoSize = true;
            this.label_passageMP.Location = new System.Drawing.Point(68, 45);
            this.label_passageMP.Name = "label_passageMP";
            this.label_passageMP.Size = new System.Drawing.Size(35, 13);
            this.label_passageMP.TabIndex = 28;
            this.label_passageMP.Text = "label9";
            // 
            // COMMIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1016, 637);
            this.Controls.Add(this.label_passageMP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label_Detail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Quitter);
            this.Controls.Add(this.maskedTextBox_telecopieur);
            this.Controls.Add(this.maskedTextBox_credit);
            this.Controls.Add(this.maskedTextBox_telephone);
            this.Controls.Add(this.maskedTextBox_codePostal);
            this.Controls.Add(this.textBox_ville);
            this.Controls.Add(this.textBox_rue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.button_Afficher);
            this.Controls.Add(this.button_Supprimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_Clients);
            this.Controls.Add(this.button_Ajouter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "COMMIS";
            this.Text = "GESTIONNAIRE DES VENTES";
            this.Load += new System.EventHandler(this.COMMIS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxChoixRechCredit.ResumeLayout(false);
            this.groupBoxChoixRechCredit.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.ListView listView_Clients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Modifier;
        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.Button button_Rechercher;
        private System.Windows.Forms.Button button_Afficher;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_rue;
        private System.Windows.Forms.TextBox textBox_ville;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_codePostal;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telephone;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_credit;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telecopieur;
        private System.Windows.Forms.Button button_Quitter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_modCP;
        private System.Windows.Forms.RadioButton radioButton_modVille;
        private System.Windows.Forms.RadioButton radioButton_modRue;
        private System.Windows.Forms.RadioButton radioButton_modNom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_modCopieur;
        private System.Windows.Forms.RadioButton radioButton_modCredit;
        private System.Windows.Forms.RadioButton radioButton_modTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_Detail;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBoxChoixRechCredit;
        private System.Windows.Forms.RadioButton radioButtonRechLimExces;
        private System.Windows.Forms.RadioButton radioButtonLimRechDeficit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem compteEmployéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierParametresDuCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposDeNousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highTechToolStripMenuItem;
        private System.Windows.Forms.Label label_passageMP;
    }
}