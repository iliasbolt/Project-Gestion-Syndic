namespace Syndic
{
    partial class frm_cotisationDocument_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cotisationDocument_info));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.pnl_ajouter = new System.Windows.Forms.Panel();
            this.btn_vider = new System.Windows.Forms.Button();
            this.btn_annuler_ajt = new System.Windows.Forms.Button();
            this.btn_valider_ajt = new System.Windows.Forms.Button();
            this.pnl_modifier = new System.Windows.Forms.Panel();
            this.btn_annuler_mod = new System.Windows.Forms.Button();
            this.btn_valider_mod = new System.Windows.Forms.Button();
            this.cb_fct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_chemin = new System.Windows.Forms.Label();
            this.btn_ficher = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnl_ajouter.SuspendLayout();
            this.pnl_modifier.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.lbl_titre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 23);
            this.panel1.TabIndex = 68;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.Color.White;
            this.lbl_titre.Location = new System.Drawing.Point(224, 2);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(127, 18);
            this.lbl_titre.TabIndex = 1;
            this.lbl_titre.Text = "Ajouter Document";
            // 
            // pnl_ajouter
            // 
            this.pnl_ajouter.Controls.Add(this.btn_vider);
            this.pnl_ajouter.Controls.Add(this.btn_annuler_ajt);
            this.pnl_ajouter.Controls.Add(this.btn_valider_ajt);
            this.pnl_ajouter.Location = new System.Drawing.Point(50, 260);
            this.pnl_ajouter.Name = "pnl_ajouter";
            this.pnl_ajouter.Size = new System.Drawing.Size(432, 61);
            this.pnl_ajouter.TabIndex = 72;
            // 
            // btn_vider
            // 
            this.btn_vider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_vider.FlatAppearance.BorderSize = 0;
            this.btn_vider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_vider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vider.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vider.ForeColor = System.Drawing.Color.White;
            this.btn_vider.Location = new System.Drawing.Point(10, 9);
            this.btn_vider.Name = "btn_vider";
            this.btn_vider.Size = new System.Drawing.Size(134, 41);
            this.btn_vider.TabIndex = 3;
            this.btn_vider.Text = "Vider";
            this.btn_vider.UseVisualStyleBackColor = false;
            this.btn_vider.Click += new System.EventHandler(this.btn_vider_Click);
            // 
            // btn_annuler_ajt
            // 
            this.btn_annuler_ajt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_annuler_ajt.FlatAppearance.BorderSize = 0;
            this.btn_annuler_ajt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_annuler_ajt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_annuler_ajt.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler_ajt.ForeColor = System.Drawing.Color.White;
            this.btn_annuler_ajt.Location = new System.Drawing.Point(290, 9);
            this.btn_annuler_ajt.Name = "btn_annuler_ajt";
            this.btn_annuler_ajt.Size = new System.Drawing.Size(134, 41);
            this.btn_annuler_ajt.TabIndex = 5;
            this.btn_annuler_ajt.Text = "Annuler";
            this.btn_annuler_ajt.UseVisualStyleBackColor = false;
            this.btn_annuler_ajt.Click += new System.EventHandler(this.btn_annuler_ajt_Click);
            // 
            // btn_valider_ajt
            // 
            this.btn_valider_ajt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_valider_ajt.FlatAppearance.BorderSize = 0;
            this.btn_valider_ajt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_valider_ajt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_valider_ajt.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider_ajt.ForeColor = System.Drawing.Color.White;
            this.btn_valider_ajt.Location = new System.Drawing.Point(150, 9);
            this.btn_valider_ajt.Name = "btn_valider_ajt";
            this.btn_valider_ajt.Size = new System.Drawing.Size(134, 41);
            this.btn_valider_ajt.TabIndex = 4;
            this.btn_valider_ajt.Text = "Valider";
            this.btn_valider_ajt.UseVisualStyleBackColor = false;
            this.btn_valider_ajt.Click += new System.EventHandler(this.btn_valider_ajt_Click);
            // 
            // pnl_modifier
            // 
            this.pnl_modifier.Controls.Add(this.btn_annuler_mod);
            this.pnl_modifier.Controls.Add(this.btn_valider_mod);
            this.pnl_modifier.Location = new System.Drawing.Point(50, 260);
            this.pnl_modifier.Name = "pnl_modifier";
            this.pnl_modifier.Size = new System.Drawing.Size(432, 61);
            this.pnl_modifier.TabIndex = 73;
            // 
            // btn_annuler_mod
            // 
            this.btn_annuler_mod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_annuler_mod.FlatAppearance.BorderSize = 0;
            this.btn_annuler_mod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_annuler_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_annuler_mod.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler_mod.ForeColor = System.Drawing.Color.White;
            this.btn_annuler_mod.Location = new System.Drawing.Point(229, 9);
            this.btn_annuler_mod.Name = "btn_annuler_mod";
            this.btn_annuler_mod.Size = new System.Drawing.Size(134, 41);
            this.btn_annuler_mod.TabIndex = 7;
            this.btn_annuler_mod.Text = "Annuler";
            this.btn_annuler_mod.UseVisualStyleBackColor = false;
            // 
            // btn_valider_mod
            // 
            this.btn_valider_mod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_valider_mod.FlatAppearance.BorderSize = 0;
            this.btn_valider_mod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_valider_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_valider_mod.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider_mod.ForeColor = System.Drawing.Color.White;
            this.btn_valider_mod.Location = new System.Drawing.Point(64, 9);
            this.btn_valider_mod.Name = "btn_valider_mod";
            this.btn_valider_mod.Size = new System.Drawing.Size(134, 41);
            this.btn_valider_mod.TabIndex = 6;
            this.btn_valider_mod.Text = "Valider";
            this.btn_valider_mod.UseVisualStyleBackColor = false;
            // 
            // cb_fct
            // 
            this.cb_fct.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cb_fct.FormattingEnabled = true;
            this.cb_fct.Location = new System.Drawing.Point(212, 107);
            this.cb_fct.Name = "cb_fct";
            this.cb_fct.Size = new System.Drawing.Size(302, 29);
            this.cb_fct.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 75;
            this.label1.Text = "Cotisation :";
            // 
            // lbl_chemin
            // 
            this.lbl_chemin.AutoSize = true;
            this.lbl_chemin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chemin.Location = new System.Drawing.Point(264, 174);
            this.lbl_chemin.Name = "lbl_chemin";
            this.lbl_chemin.Size = new System.Drawing.Size(0, 19);
            this.lbl_chemin.TabIndex = 74;
            // 
            // btn_ficher
            // 
            this.btn_ficher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_ficher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ficher.BackgroundImage")));
            this.btn_ficher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ficher.FlatAppearance.BorderSize = 0;
            this.btn_ficher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_ficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ficher.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ficher.ForeColor = System.Drawing.Color.White;
            this.btn_ficher.Location = new System.Drawing.Point(210, 168);
            this.btn_ficher.Name = "btn_ficher";
            this.btn_ficher.Size = new System.Drawing.Size(44, 29);
            this.btn_ficher.TabIndex = 69;
            this.btn_ficher.UseVisualStyleBackColor = false;
            this.btn_ficher.Click += new System.EventHandler(this.btn_ficher_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 71;
            this.label4.Text = "Ficher :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 21);
            this.label2.TabIndex = 70;
            this.label2.Text = "Nom Document :";
            // 
            // txt_nom
            // 
            this.txt_nom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom.Location = new System.Drawing.Point(212, 49);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(302, 27);
            this.txt_nom.TabIndex = 67;
            // 
            // frm_cotisationDocument_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(566, 396);
            this.Controls.Add(this.pnl_ajouter);
            this.Controls.Add(this.pnl_modifier);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_fct);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_chemin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ficher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cotisationDocument_info";
            this.Text = "frm_cotisationDocument_info";
            this.Load += new System.EventHandler(this.frm_cotisationDocument_info_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_ajouter.ResumeLayout(false);
            this.pnl_modifier.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Panel pnl_ajouter;
        private System.Windows.Forms.Button btn_vider;
        private System.Windows.Forms.Button btn_annuler_ajt;
        private System.Windows.Forms.Button btn_valider_ajt;
        private System.Windows.Forms.Panel pnl_modifier;
        private System.Windows.Forms.Button btn_annuler_mod;
        private System.Windows.Forms.Button btn_valider_mod;
        private System.Windows.Forms.ComboBox cb_fct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_chemin;
        private System.Windows.Forms.Button btn_ficher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nom;
    }
}