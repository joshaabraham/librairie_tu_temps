namespace Projet_Final.Fomulaires
{
    partial class FormAuteur
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.textBox_AuNom = new System.Windows.Forms.TextBox();
            this.textBox_AuPrenom = new System.Windows.Forms.TextBox();
            this.textBox_AuCourriel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Statut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(5, 191);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(381, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prenom";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Courriel";
            this.columnHeader4.Width = 131;
            // 
            // button_Ajouter
            // 
            this.button_Ajouter.Location = new System.Drawing.Point(262, 139);
            this.button_Ajouter.Name = "button_Ajouter";
            this.button_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_Ajouter.TabIndex = 1;
            this.button_Ajouter.Text = "&Ajouter";
            this.button_Ajouter.UseVisualStyleBackColor = true;
            this.button_Ajouter.Click += new System.EventHandler(this.button_Ajouter_Click);
            // 
            // textBox_AuNom
            // 
            this.textBox_AuNom.Location = new System.Drawing.Point(95, 60);
            this.textBox_AuNom.Name = "textBox_AuNom";
            this.textBox_AuNom.Size = new System.Drawing.Size(100, 20);
            this.textBox_AuNom.TabIndex = 2;
            // 
            // textBox_AuPrenom
            // 
            this.textBox_AuPrenom.Location = new System.Drawing.Point(95, 99);
            this.textBox_AuPrenom.Name = "textBox_AuPrenom";
            this.textBox_AuPrenom.Size = new System.Drawing.Size(100, 20);
            this.textBox_AuPrenom.TabIndex = 3;
            // 
            // textBox_AuCourriel
            // 
            this.textBox_AuCourriel.Location = new System.Drawing.Point(95, 139);
            this.textBox_AuCourriel.Name = "textBox_AuCourriel";
            this.textBox_AuCourriel.Size = new System.Drawing.Size(100, 20);
            this.textBox_AuCourriel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Courriel";
            // 
            // label_Statut
            // 
            this.label_Statut.AutoSize = true;
            this.label_Statut.Location = new System.Drawing.Point(262, 59);
            this.label_Statut.Name = "label_Statut";
            this.label_Statut.Size = new System.Drawing.Size(19, 13);
            this.label_Statut.TabIndex = 8;
            this.label_Statut.Text = "***";
            // 
            // FormAuteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 292);
            this.Controls.Add(this.label_Statut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_AuCourriel);
            this.Controls.Add(this.textBox_AuPrenom);
            this.Controls.Add(this.textBox_AuNom);
            this.Controls.Add(this.button_Ajouter);
            this.Controls.Add(this.listView1);
            this.Name = "FormAuteur";
            this.Text = "FormAuteur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.TextBox textBox_AuNom;
        private System.Windows.Forms.TextBox textBox_AuPrenom;
        private System.Windows.Forms.TextBox textBox_AuCourriel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Statut;
    }
}