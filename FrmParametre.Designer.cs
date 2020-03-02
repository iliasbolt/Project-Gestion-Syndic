namespace Syndic
{
    partial class FrmParametre
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
            this.grp_res = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_adresse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_titre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_ville = new System.Windows.Forms.ComboBox();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_rubrique = new System.Windows.Forms.Button();
            this.grp_res.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_res
            // 
            this.grp_res.Controls.Add(this.btn_rubrique);
            this.grp_res.Controls.Add(this.cb_ville);
            this.grp_res.Controls.Add(this.label5);
            this.grp_res.Controls.Add(this.txt_titre);
            this.grp_res.Controls.Add(this.label3);
            this.grp_res.Controls.Add(this.txt_code);
            this.grp_res.Controls.Add(this.label4);
            this.grp_res.Controls.Add(this.txt_adresse);
            this.grp_res.Controls.Add(this.label2);
            this.grp_res.Controls.Add(this.txt_nom);
            this.grp_res.Controls.Add(this.label1);
            this.grp_res.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_res.Location = new System.Drawing.Point(13, 13);
            this.grp_res.Name = "grp_res";
            this.grp_res.Size = new System.Drawing.Size(487, 316);
            this.grp_res.TabIndex = 0;
            this.grp_res.TabStop = false;
            this.grp_res.Text = "Les Informations De Residence :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(146, 50);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(289, 27);
            this.txt_nom.TabIndex = 0;
            // 
            // txt_adresse
            // 
            this.txt_adresse.Location = new System.Drawing.Point(146, 100);
            this.txt_adresse.Name = "txt_adresse";
            this.txt_adresse.Size = new System.Drawing.Size(289, 27);
            this.txt_adresse.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse :";
            // 
            // txt_titre
            // 
            this.txt_titre.Location = new System.Drawing.Point(146, 257);
            this.txt_titre.Name = "txt_titre";
            this.txt_titre.Size = new System.Drawing.Size(289, 27);
            this.txt_titre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Titre Foncier :";
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(146, 207);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(289, 27);
            this.txt_code.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Code Postal :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ville :";
            // 
            // cb_ville
            // 
            this.cb_ville.FormattingEnabled = true;
            this.cb_ville.Location = new System.Drawing.Point(146, 153);
            this.cb_ville.Name = "cb_ville";
            this.cb_ville.Size = new System.Drawing.Size(289, 29);
            this.cb_ville.TabIndex = 2;
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_modifier.FlatAppearance.BorderSize = 0;
            this.btn_modifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifier.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.ForeColor = System.Drawing.Color.White;
            this.btn_modifier.Location = new System.Drawing.Point(314, 345);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(134, 41);
            this.btn_modifier.TabIndex = 5;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_rubrique
            // 
            this.btn_rubrique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_rubrique.FlatAppearance.BorderSize = 0;
            this.btn_rubrique.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_rubrique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rubrique.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rubrique.ForeColor = System.Drawing.Color.White;
            this.btn_rubrique.Location = new System.Drawing.Point(441, 150);
            this.btn_rubrique.Name = "btn_rubrique";
            this.btn_rubrique.Size = new System.Drawing.Size(31, 30);
            this.btn_rubrique.TabIndex = 61;
            this.btn_rubrique.Text = "+";
            this.btn_rubrique.UseVisualStyleBackColor = false;
            this.btn_rubrique.Click += new System.EventHandler(this.btn_rubrique_Click);
            // 
            // FrmParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 677);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.grp_res);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmParametre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmParametre";
            this.Load += new System.EventHandler(this.FrmParametre_Load);
            this.grp_res.ResumeLayout(false);
            this.grp_res.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_res;
        private System.Windows.Forms.ComboBox cb_ville;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_titre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_adresse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_rubrique;
    }
}