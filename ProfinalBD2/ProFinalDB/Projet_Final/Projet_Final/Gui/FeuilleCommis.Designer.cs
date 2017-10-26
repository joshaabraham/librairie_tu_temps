namespace Projet_Final.Fomulaires
{
    partial class FeuilleCommis
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
            this.listView_Livre = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Commande = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Ajout = new System.Windows.Forms.Button();
            this.button_Retrait = new System.Windows.Forms.Button();
            this.comboBox_Client = new System.Windows.Forms.ComboBox();
            this.textBox_Quantite = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deHtCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Enre_Com = new System.Windows.Forms.Button();
            this.label_personne = new System.Windows.Forms.Label();
            this.listView_CommandeF = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Afficher = new System.Windows.Forms.Button();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Livre
            // 
            this.listView_Livre.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_Livre.FullRowSelect = true;
            this.listView_Livre.GridLines = true;
            this.listView_Livre.Location = new System.Drawing.Point(23, 89);
            this.listView_Livre.Name = "listView_Livre";
            this.listView_Livre.Size = new System.Drawing.Size(340, 207);
            this.listView_Livre.TabIndex = 0;
            this.listView_Livre.UseCompatibleStateImageBehavior = false;
            this.listView_Livre.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ISBN";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Titre";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prix";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Stock";
            // 
            // listView_Commande
            // 
            this.listView_Commande.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView_Commande.FullRowSelect = true;
            this.listView_Commande.GridLines = true;
            this.listView_Commande.Location = new System.Drawing.Point(532, 89);
            this.listView_Commande.Name = "listView_Commande";
            this.listView_Commande.Size = new System.Drawing.Size(369, 207);
            this.listView_Commande.TabIndex = 1;
            this.listView_Commande.UseCompatibleStateImageBehavior = false;
            this.listView_Commande.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ISBN";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Titre";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Prix";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Stock";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Prix total";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "No Client";
            // 
            // button_Ajout
            // 
            this.button_Ajout.Location = new System.Drawing.Point(424, 213);
            this.button_Ajout.Name = "button_Ajout";
            this.button_Ajout.Size = new System.Drawing.Size(46, 23);
            this.button_Ajout.TabIndex = 2;
            this.button_Ajout.Text = ">";
            this.button_Ajout.UseVisualStyleBackColor = true;
            this.button_Ajout.Click += new System.EventHandler(this.button_Ajout_Click);
            // 
            // button_Retrait
            // 
            this.button_Retrait.Location = new System.Drawing.Point(424, 157);
            this.button_Retrait.Name = "button_Retrait";
            this.button_Retrait.Size = new System.Drawing.Size(46, 23);
            this.button_Retrait.TabIndex = 3;
            this.button_Retrait.Text = "<";
            this.button_Retrait.UseVisualStyleBackColor = true;
            this.button_Retrait.Click += new System.EventHandler(this.button_Retrait_Click);
            // 
            // comboBox_Client
            // 
            this.comboBox_Client.FormattingEnabled = true;
            this.comboBox_Client.Location = new System.Drawing.Point(23, 47);
            this.comboBox_Client.Name = "comboBox_Client";
            this.comboBox_Client.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Client.TabIndex = 4;
            // 
            // textBox_Quantite
            // 
            this.textBox_Quantite.Location = new System.Drawing.Point(397, 89);
            this.textBox_Quantite.Name = "textBox_Quantite";
            this.textBox_Quantite.Size = new System.Drawing.Size(100, 20);
            this.textBox_Quantite.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeToolStripMenuItem
            // 
            this.employeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierPasswordToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.employeToolStripMenuItem.Name = "employeToolStripMenuItem";
            this.employeToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.employeToolStripMenuItem.Text = "Employe";
            // 
            // modifierPasswordToolStripMenuItem
            // 
            this.modifierPasswordToolStripMenuItem.Name = "modifierPasswordToolStripMenuItem";
            this.modifierPasswordToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.modifierPasswordToolStripMenuItem.Text = "Modifier Password";
            this.modifierPasswordToolStripMenuItem.Click += new System.EventHandler(this.modifierPasswordToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deHtCompanyToolStripMenuItem});
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aProposToolStripMenuItem.Text = "A Propos";
            // 
            // deHtCompanyToolStripMenuItem
            // 
            this.deHtCompanyToolStripMenuItem.Name = "deHtCompanyToolStripMenuItem";
            this.deHtCompanyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.deHtCompanyToolStripMenuItem.Text = "...de Ht Company";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(653, 55);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(19, 13);
            this.label_total.TabIndex = 7;
            this.label_total.Text = "***";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total de la commande :";
            // 
            // button_Enre_Com
            // 
            this.button_Enre_Com.Location = new System.Drawing.Point(754, 300);
            this.button_Enre_Com.Name = "button_Enre_Com";
            this.button_Enre_Com.Size = new System.Drawing.Size(146, 23);
            this.button_Enre_Com.TabIndex = 9;
            this.button_Enre_Com.Text = "Enregistrer Commande";
            this.button_Enre_Com.UseVisualStyleBackColor = true;
            this.button_Enre_Com.Click += new System.EventHandler(this.button_Enre_Com_Click);
            // 
            // label_personne
            // 
            this.label_personne.AutoSize = true;
            this.label_personne.Location = new System.Drawing.Point(26, 73);
            this.label_personne.Name = "label_personne";
            this.label_personne.Size = new System.Drawing.Size(0, 13);
            this.label_personne.TabIndex = 10;
            // 
            // listView_CommandeF
            // 
            this.listView_CommandeF.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.listView_CommandeF.GridLines = true;
            this.listView_CommandeF.Location = new System.Drawing.Point(29, 388);
            this.listView_CommandeF.Name = "listView_CommandeF";
            this.listView_CommandeF.Size = new System.Drawing.Size(871, 178);
            this.listView_CommandeF.TabIndex = 11;
            this.listView_CommandeF.UseCompatibleStateImageBehavior = false;
            this.listView_CommandeF.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "No Commande";
            this.columnHeader11.Width = 140;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "ISBN";
            this.columnHeader12.Width = 78;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Titre";
            this.columnHeader13.Width = 113;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Nom du client";
            this.columnHeader14.Width = 106;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Date d\'enregistrement";
            this.columnHeader15.Width = 129;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "date de livraison";
            this.columnHeader16.Width = 120;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Quantité";
            this.columnHeader17.Width = 67;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Tarif";
            this.columnHeader18.Width = 110;
            // 
            // button_Afficher
            // 
            this.button_Afficher.Location = new System.Drawing.Point(825, 572);
            this.button_Afficher.Name = "button_Afficher";
            this.button_Afficher.Size = new System.Drawing.Size(75, 23);
            this.button_Afficher.TabIndex = 12;
            this.button_Afficher.Text = "Afficher tout";
            this.button_Afficher.UseVisualStyleBackColor = true;
            this.button_Afficher.Click += new System.EventHandler(this.button_Afficher_Click);
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.Location = new System.Drawing.Point(721, 572);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_Supprimer.TabIndex = 13;
            this.button_Supprimer.Text = "&Supprimer";
            this.button_Supprimer.UseVisualStyleBackColor = true;
            this.button_Supprimer.Click += new System.EventHandler(this.button_Supprimer_Click);
            // 
            // FeuilleCommis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(940, 607);
            this.Controls.Add(this.button_Supprimer);
            this.Controls.Add(this.button_Afficher);
            this.Controls.Add(this.listView_CommandeF);
            this.Controls.Add(this.label_personne);
            this.Controls.Add(this.button_Enre_Com);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.textBox_Quantite);
            this.Controls.Add(this.comboBox_Client);
            this.Controls.Add(this.button_Retrait);
            this.Controls.Add(this.button_Ajout);
            this.Controls.Add(this.listView_Commande);
            this.Controls.Add(this.listView_Livre);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FeuilleCommis";
            this.Text = "FeuilleCommis";
            this.Load += new System.EventHandler(this.FeuilleCommis_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Livre;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView_Commande;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button button_Ajout;
        private System.Windows.Forms.Button button_Retrait;
        private System.Windows.Forms.ComboBox comboBox_Client;
        private System.Windows.Forms.TextBox textBox_Quantite;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deHtCompanyToolStripMenuItem;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button button_Enre_Com;
        private System.Windows.Forms.Label label_personne;
        private System.Windows.Forms.ListView listView_CommandeF;
        private System.Windows.Forms.Button button_Afficher;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Button button_Supprimer;
    }
}