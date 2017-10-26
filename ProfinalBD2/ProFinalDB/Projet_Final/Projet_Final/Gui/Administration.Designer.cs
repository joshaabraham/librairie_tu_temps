namespace Projet_Final
{
    partial class Administration
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox_Categorie = new System.Windows.Forms.ComboBox();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.button_Modifier = new System.Windows.Forms.Button();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Rechercher = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNoID = new System.Windows.Forms.TextBox();
            this.button_Afficher = new System.Windows.Forms.Button();
            this.radioButtonId = new System.Windows.Forms.RadioButton();
            this.radioButtonNom = new System.Windows.Forms.RadioButton();
            this.radioButtonPren = new System.Windows.Forms.RadioButton();
            this.radioButtonCateg = new System.Windows.Forms.RadioButton();
            this.radioButtonNomPrenom = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Quitter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton_modNom = new System.Windows.Forms.RadioButton();
            this.radioButton_modCategorie = new System.Windows.Forms.RadioButton();
            this.radioButton_modPrenom = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highTechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMDP = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(63, 304);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(722, 221);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NoID";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mot de passe";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prenom";
            this.columnHeader3.Width = 103;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nom";
            this.columnHeader4.Width = 117;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Categorie";
            this.columnHeader5.Width = 145;
            // 
            // comboBox_Categorie
            // 
            this.comboBox_Categorie.FormattingEnabled = true;
            this.comboBox_Categorie.Items.AddRange(new object[] {
            "Gestionnaire IT",
            "Gestionnaire Ventes",
            "Commis",
            "Comptable",
            "Contrôleur"});
            this.comboBox_Categorie.Location = new System.Drawing.Point(350, 215);
            this.comboBox_Categorie.Name = "comboBox_Categorie";
            this.comboBox_Categorie.Size = new System.Drawing.Size(166, 21);
            this.comboBox_Categorie.TabIndex = 3;
            // 
            // button_Ajouter
            // 
            this.button_Ajouter.Location = new System.Drawing.Point(281, 243);
            this.button_Ajouter.Name = "button_Ajouter";
            this.button_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_Ajouter.TabIndex = 4;
            this.button_Ajouter.Text = "&Ajouter";
            this.button_Ajouter.UseVisualStyleBackColor = true;
            this.button_Ajouter.Click += new System.EventHandler(this.button_Ajouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(370, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Description";
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.Location = new System.Drawing.Point(483, 242);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_Supprimer.TabIndex = 6;
            this.button_Supprimer.Text = "&Supprimer";
            this.button_Supprimer.UseVisualStyleBackColor = true;
            this.button_Supprimer.Click += new System.EventHandler(this.button_Supprimer_Click);
            // 
            // button_Modifier
            // 
            this.button_Modifier.Location = new System.Drawing.Point(19, 153);
            this.button_Modifier.Name = "button_Modifier";
            this.button_Modifier.Size = new System.Drawing.Size(75, 23);
            this.button_Modifier.TabIndex = 13;
            this.button_Modifier.Text = "&Modifier";
            this.button_Modifier.UseVisualStyleBackColor = true;
            this.button_Modifier.Click += new System.EventHandler(this.button_Modifier_Click);
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(350, 189);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(166, 20);
            this.textBox_nom.TabIndex = 2;
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(350, 157);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(166, 20);
            this.textBox_prenom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.15F);
            this.label2.Location = new System.Drawing.Point(293, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.15F);
            this.label3.Location = new System.Drawing.Point(279, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.15F);
            this.label4.Location = new System.Drawing.Point(270, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Catégorie";
            // 
            // button_Rechercher
            // 
            this.button_Rechercher.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Rechercher.Location = new System.Drawing.Point(22, 153);
            this.button_Rechercher.Name = "button_Rechercher";
            this.button_Rechercher.Size = new System.Drawing.Size(91, 23);
            this.button_Rechercher.TabIndex = 7;
            this.button_Rechercher.Text = "&Rechercher";
            this.button_Rechercher.UseVisualStyleBackColor = true;
            this.button_Rechercher.Click += new System.EventHandler(this.button_Rechercher_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "No ID";
            // 
            // textBoxNoID
            // 
            this.textBoxNoID.Location = new System.Drawing.Point(350, 93);
            this.textBoxNoID.Name = "textBoxNoID";
            this.textBoxNoID.Size = new System.Drawing.Size(166, 20);
            this.textBoxNoID.TabIndex = 0;
            // 
            // button_Afficher
            // 
            this.button_Afficher.Location = new System.Drawing.Point(386, 242);
            this.button_Afficher.Name = "button_Afficher";
            this.button_Afficher.Size = new System.Drawing.Size(75, 23);
            this.button_Afficher.TabIndex = 5;
            this.button_Afficher.Text = "&Afficher";
            this.button_Afficher.UseVisualStyleBackColor = true;
            this.button_Afficher.Click += new System.EventHandler(this.button_Afficher_Click);
            // 
            // radioButtonId
            // 
            this.radioButtonId.AutoSize = true;
            this.radioButtonId.Location = new System.Drawing.Point(22, 31);
            this.radioButtonId.Name = "radioButtonId";
            this.radioButtonId.Size = new System.Drawing.Size(83, 17);
            this.radioButtonId.TabIndex = 8;
            this.radioButtonId.TabStop = true;
            this.radioButtonId.Text = "... par No ID";
            this.radioButtonId.UseVisualStyleBackColor = true;
            this.radioButtonId.CheckedChanged += new System.EventHandler(this.radioButtonId_CheckedChanged);
            // 
            // radioButtonNom
            // 
            this.radioButtonNom.AutoSize = true;
            this.radioButtonNom.Location = new System.Drawing.Point(22, 54);
            this.radioButtonNom.Name = "radioButtonNom";
            this.radioButtonNom.Size = new System.Drawing.Size(77, 17);
            this.radioButtonNom.TabIndex = 9;
            this.radioButtonNom.TabStop = true;
            this.radioButtonNom.Text = "... par Nom";
            this.radioButtonNom.UseVisualStyleBackColor = true;
            this.radioButtonNom.CheckedChanged += new System.EventHandler(this.radioButtonNom_CheckedChanged);
            // 
            // radioButtonPren
            // 
            this.radioButtonPren.AutoSize = true;
            this.radioButtonPren.Location = new System.Drawing.Point(22, 77);
            this.radioButtonPren.Name = "radioButtonPren";
            this.radioButtonPren.Size = new System.Drawing.Size(91, 17);
            this.radioButtonPren.TabIndex = 10;
            this.radioButtonPren.TabStop = true;
            this.radioButtonPren.Text = "... par Prenom";
            this.radioButtonPren.UseVisualStyleBackColor = true;
            this.radioButtonPren.CheckedChanged += new System.EventHandler(this.radioButtonPren_CheckedChanged);
            // 
            // radioButtonCateg
            // 
            this.radioButtonCateg.AutoSize = true;
            this.radioButtonCateg.Location = new System.Drawing.Point(22, 102);
            this.radioButtonCateg.Name = "radioButtonCateg";
            this.radioButtonCateg.Size = new System.Drawing.Size(100, 17);
            this.radioButtonCateg.TabIndex = 11;
            this.radioButtonCateg.TabStop = true;
            this.radioButtonCateg.Text = "... par Categorie";
            this.radioButtonCateg.UseVisualStyleBackColor = true;
            this.radioButtonCateg.CheckedChanged += new System.EventHandler(this.radioButtonCateg_CheckedChanged);
            // 
            // radioButtonNomPrenom
            // 
            this.radioButtonNomPrenom.AutoSize = true;
            this.radioButtonNomPrenom.Location = new System.Drawing.Point(22, 126);
            this.radioButtonNomPrenom.Name = "radioButtonNomPrenom";
            this.radioButtonNomPrenom.Size = new System.Drawing.Size(133, 17);
            this.radioButtonNomPrenom.TabIndex = 12;
            this.radioButtonNomPrenom.TabStop = true;
            this.radioButtonNomPrenom.Text = "... par Nom ET Prenom";
            this.radioButtonNomPrenom.UseVisualStyleBackColor = true;
            this.radioButtonNomPrenom.CheckedChanged += new System.EventHandler(this.radioButtonNomPrenom_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.radioButtonId);
            this.groupBox1.Controls.Add(this.radioButtonNomPrenom);
            this.groupBox1.Controls.Add(this.radioButtonNom);
            this.groupBox1.Controls.Add(this.radioButtonCateg);
            this.groupBox1.Controls.Add(this.radioButtonPren);
            this.groupBox1.Controls.Add(this.button_Rechercher);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(592, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 182);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Methode de recherche";
            // 
            // button_Quitter
            // 
            this.button_Quitter.Location = new System.Drawing.Point(710, 554);
            this.button_Quitter.Name = "button_Quitter";
            this.button_Quitter.Size = new System.Drawing.Size(75, 23);
            this.button_Quitter.TabIndex = 23;
            this.button_Quitter.Text = "&Quitter";
            this.button_Quitter.UseVisualStyleBackColor = true;
            this.button_Quitter.Click += new System.EventHandler(this.button_Quitter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton_modNom);
            this.groupBox2.Controls.Add(this.radioButton_modCategorie);
            this.groupBox2.Controls.Add(this.radioButton_modPrenom);
            this.groupBox2.Controls.Add(this.button_Modifier);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(63, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 182);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "caractéristiques";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 112);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(111, 17);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.Text = "... le mot de passe";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton_modNom
            // 
            this.radioButton_modNom.AutoSize = true;
            this.radioButton_modNom.Location = new System.Drawing.Point(19, 37);
            this.radioButton_modNom.Name = "radioButton_modNom";
            this.radioButton_modNom.Size = new System.Drawing.Size(68, 17);
            this.radioButton_modNom.TabIndex = 14;
            this.radioButton_modNom.TabStop = true;
            this.radioButton_modNom.Text = "... le nom";
            this.radioButton_modNom.UseVisualStyleBackColor = true;
            this.radioButton_modNom.CheckedChanged += new System.EventHandler(this.radioButton_modNom_CheckedChanged);
            // 
            // radioButton_modCategorie
            // 
            this.radioButton_modCategorie.AutoSize = true;
            this.radioButton_modCategorie.Location = new System.Drawing.Point(19, 85);
            this.radioButton_modCategorie.Name = "radioButton_modCategorie";
            this.radioButton_modCategorie.Size = new System.Drawing.Size(92, 17);
            this.radioButton_modCategorie.TabIndex = 16;
            this.radioButton_modCategorie.Text = "... la categorie";
            this.radioButton_modCategorie.UseVisualStyleBackColor = true;
            this.radioButton_modCategorie.CheckedChanged += new System.EventHandler(this.radioButton_modCategorie_CheckedChanged);
            // 
            // radioButton_modPrenom
            // 
            this.radioButton_modPrenom.AutoSize = true;
            this.radioButton_modPrenom.Location = new System.Drawing.Point(19, 60);
            this.radioButton_modPrenom.Name = "radioButton_modPrenom";
            this.radioButton_modPrenom.Size = new System.Drawing.Size(83, 17);
            this.radioButton_modPrenom.TabIndex = 15;
            this.radioButton_modPrenom.Text = "... le prenom";
            this.radioButton_modPrenom.UseVisualStyleBackColor = true;
            this.radioButton_modPrenom.CheckedChanged += new System.EventHandler(this.radioButton_modPrenom_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Orange;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sessionToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sessionToolStripMenuItem.Text = "Session";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highTechToolStripMenuItem});
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // highTechToolStripMenuItem
            // 
            this.highTechToolStripMenuItem.Name = "highTechToolStripMenuItem";
            this.highTechToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.highTechToolStripMenuItem.Text = "High Tech";
            this.highTechToolStripMenuItem.Click += new System.EventHandler(this.highTechToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Mot de passe";
            // 
            // textBoxMDP
            // 
            this.textBoxMDP.Location = new System.Drawing.Point(350, 126);
            this.textBoxMDP.Name = "textBoxMDP";
            this.textBoxMDP.Size = new System.Drawing.Size(166, 20);
            this.textBoxMDP.TabIndex = 40;
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 609);
            this.Controls.Add(this.textBoxMDP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Quitter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Afficher);
            this.Controls.Add(this.textBoxNoID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_prenom);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.button_Supprimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Ajouter);
            this.Controls.Add(this.comboBox_Categorie);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Administration";
            this.Text = "ADMINISTRATION";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox comboBox_Categorie;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.Button button_Modifier;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Rechercher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNoID;
        private System.Windows.Forms.Button button_Afficher;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.RadioButton radioButtonId;
        private System.Windows.Forms.RadioButton radioButtonNom;
        private System.Windows.Forms.RadioButton radioButtonPren;
        private System.Windows.Forms.RadioButton radioButtonCateg;
        private System.Windows.Forms.RadioButton radioButtonNomPrenom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Quitter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_modNom;
        private System.Windows.Forms.RadioButton radioButton_modCategorie;
        private System.Windows.Forms.RadioButton radioButton_modPrenom;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highTechToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMDP;
        private System.Windows.Forms.RadioButton radioButton3;

    }
}

