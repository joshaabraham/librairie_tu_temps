namespace Projet_Final.Fomulaires
{
    partial class modifParametreCompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifParametreCompte));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MP1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MP2 = new System.Windows.Forms.TextBox();
            this.button_Valider = new System.Windows.Forms.Button();
            this.label_error = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_MP_Actuel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nouveau mot de passe :";
            // 
            // textBox_MP1
            // 
            this.textBox_MP1.Location = new System.Drawing.Point(166, 61);
            this.textBox_MP1.Name = "textBox_MP1";
            this.textBox_MP1.Size = new System.Drawing.Size(159, 20);
            this.textBox_MP1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Re-écrivez le :";
            // 
            // textBox_MP2
            // 
            this.textBox_MP2.Location = new System.Drawing.Point(166, 100);
            this.textBox_MP2.Name = "textBox_MP2";
            this.textBox_MP2.Size = new System.Drawing.Size(159, 20);
            this.textBox_MP2.TabIndex = 1;
            // 
            // button_Valider
            // 
            this.button_Valider.Location = new System.Drawing.Point(226, 146);
            this.button_Valider.Name = "button_Valider";
            this.button_Valider.Size = new System.Drawing.Size(99, 34);
            this.button_Valider.TabIndex = 2;
            this.button_Valider.Text = "&Valider";
            this.button_Valider.UseVisualStyleBackColor = true;
            this.button_Valider.Click += new System.EventHandler(this.button_Valider_Click);
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_error.ForeColor = System.Drawing.Color.OliveDrab;
            this.label_error.Location = new System.Drawing.Point(69, 149);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(31, 24);
            this.label_error.TabIndex = 5;
            this.label_error.Text = "***";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Votre mot de passe actuel : ";
            // 
            // label_MP_Actuel
            // 
            this.label_MP_Actuel.AutoSize = true;
            this.label_MP_Actuel.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MP_Actuel.ForeColor = System.Drawing.Color.OliveDrab;
            this.label_MP_Actuel.Location = new System.Drawing.Point(223, 25);
            this.label_MP_Actuel.Name = "label_MP_Actuel";
            this.label_MP_Actuel.Size = new System.Drawing.Size(29, 17);
            this.label_MP_Actuel.TabIndex = 7;
            this.label_MP_Actuel.Text = "***";
            // 
            // modifParametreCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(439, 203);
            this.Controls.Add(this.label_MP_Actuel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.button_Valider);
            this.Controls.Add(this.textBox_MP2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_MP1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "modifParametreCompte";
            this.Text = "Changement de mot de passe";
            this.Load += new System.EventHandler(this.modifParametreCompte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MP1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_MP2;
        private System.Windows.Forms.Button button_Valider;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_MP_Actuel;
    }
}