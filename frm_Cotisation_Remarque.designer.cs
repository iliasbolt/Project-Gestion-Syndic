﻿namespace Syndic
{
    partial class frm_Cotisation_Remarque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cotisation_Remarque));
            this.lst_Remaques = new System.Windows.Forms.ListBox();
            this.cb_facture = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nomremarque = new System.Windows.Forms.TextBox();
            this.txt_remarque = new System.Windows.Forms.TextBox();
            this.txt_chercher = new System.Windows.Forms.TextBox();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_premiere = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_derniere = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.grp_facture = new System.Windows.Forms.GroupBox();
            this.grp_details = new System.Windows.Forms.GroupBox();
            this.grp_remarque = new System.Windows.Forms.GroupBox();
            this.grp_facture.SuspendLayout();
            this.grp_details.SuspendLayout();
            this.grp_remarque.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_Remaques
            // 
            this.lst_Remaques.FormattingEnabled = true;
            this.lst_Remaques.ItemHeight = 21;
            this.lst_Remaques.Location = new System.Drawing.Point(7, 71);
            this.lst_Remaques.Name = "lst_Remaques";
            this.lst_Remaques.Size = new System.Drawing.Size(288, 361);
            this.lst_Remaques.TabIndex = 4;
            this.lst_Remaques.SelectedIndexChanged += new System.EventHandler(this.lst_Remaques_SelectedIndexChanged);
            // 
            // cb_facture
            // 
            this.cb_facture.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_facture.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_facture.FormattingEnabled = true;
            this.cb_facture.Location = new System.Drawing.Point(21, 30);
            this.cb_facture.Name = "cb_facture";
            this.cb_facture.Size = new System.Drawing.Size(261, 28);
            this.cb_facture.TabIndex = 1;
            this.cb_facture.SelectedIndexChanged += new System.EventHandler(this.cb_facture_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Texte De Remarque :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nom De Remarque :";
            // 
            // txt_nomremarque
            // 
            this.txt_nomremarque.ForeColor = System.Drawing.Color.Black;
            this.txt_nomremarque.Location = new System.Drawing.Point(11, 67);
            this.txt_nomremarque.Name = "txt_nomremarque";
            this.txt_nomremarque.Size = new System.Drawing.Size(427, 27);
            this.txt_nomremarque.TabIndex = 10;
            // 
            // txt_remarque
            // 
            this.txt_remarque.Location = new System.Drawing.Point(7, 133);
            this.txt_remarque.Multiline = true;
            this.txt_remarque.Name = "txt_remarque";
            this.txt_remarque.Size = new System.Drawing.Size(432, 280);
            this.txt_remarque.TabIndex = 11;
            // 
            // txt_chercher
            // 
            this.txt_chercher.ForeColor = System.Drawing.Color.Gray;
            this.txt_chercher.Location = new System.Drawing.Point(7, 37);
            this.txt_chercher.Name = "txt_chercher";
            this.txt_chercher.Size = new System.Drawing.Size(288, 27);
            this.txt_chercher.TabIndex = 3;
            this.txt_chercher.Text = "Tapez Nom Pour Chercher";
            this.txt_chercher.TextChanged += new System.EventHandler(this.txt_chercher_TextChanged);
            this.txt_chercher.Enter += new System.EventHandler(this.txt_chercher_Enter);
            this.txt_chercher.Leave += new System.EventHandler(this.txt_chercher_Leave);
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_modifier.FlatAppearance.BorderSize = 0;
            this.btn_modifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifier.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.ForeColor = System.Drawing.Color.White;
            this.btn_modifier.Location = new System.Drawing.Point(470, 479);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(134, 41);
            this.btn_modifier.TabIndex = 19;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_premiere
            // 
            this.btn_premiere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_premiere.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_premiere.BackgroundImage")));
            this.btn_premiere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_premiere.FlatAppearance.BorderSize = 0;
            this.btn_premiere.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_premiere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_premiere.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_premiere.ForeColor = System.Drawing.Color.White;
            this.btn_premiere.Location = new System.Drawing.Point(17, 442);
            this.btn_premiere.Name = "btn_premiere";
            this.btn_premiere.Size = new System.Drawing.Size(46, 41);
            this.btn_premiere.TabIndex = 5;
            this.btn_premiere.UseVisualStyleBackColor = false;
            this.btn_premiere.Click += new System.EventHandler(this.btn_derniere_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_supprimer.FlatAppearance.BorderSize = 0;
            this.btn_supprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supprimer.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer.Location = new System.Drawing.Point(610, 479);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(134, 41);
            this.btn_supprimer.TabIndex = 20;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_suivant
            // 
            this.btn_suivant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_suivant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_suivant.BackgroundImage")));
            this.btn_suivant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_suivant.FlatAppearance.BorderSize = 0;
            this.btn_suivant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_suivant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suivant.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suivant.ForeColor = System.Drawing.Color.White;
            this.btn_suivant.Location = new System.Drawing.Point(190, 442);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(46, 41);
            this.btn_suivant.TabIndex = 7;
            this.btn_suivant.UseVisualStyleBackColor = false;
            this.btn_suivant.Click += new System.EventHandler(this.btn_derniere_Click);
            // 
            // btn_precedent
            // 
            this.btn_precedent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_precedent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_precedent.BackgroundImage")));
            this.btn_precedent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_precedent.FlatAppearance.BorderSize = 0;
            this.btn_precedent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_precedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_precedent.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_precedent.ForeColor = System.Drawing.Color.White;
            this.btn_precedent.Location = new System.Drawing.Point(69, 442);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(46, 41);
            this.btn_precedent.TabIndex = 6;
            this.btn_precedent.UseVisualStyleBackColor = false;
            this.btn_precedent.Click += new System.EventHandler(this.btn_derniere_Click);
            // 
            // btn_derniere
            // 
            this.btn_derniere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_derniere.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_derniere.BackgroundImage")));
            this.btn_derniere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_derniere.FlatAppearance.BorderSize = 0;
            this.btn_derniere.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_derniere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_derniere.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_derniere.ForeColor = System.Drawing.Color.White;
            this.btn_derniere.Location = new System.Drawing.Point(242, 442);
            this.btn_derniere.Name = "btn_derniere";
            this.btn_derniere.Size = new System.Drawing.Size(46, 41);
            this.btn_derniere.TabIndex = 8;
            this.btn_derniere.UseVisualStyleBackColor = false;
            this.btn_derniere.Click += new System.EventHandler(this.btn_derniere_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_ajouter.FlatAppearance.BorderSize = 0;
            this.btn_ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouter.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter.Location = new System.Drawing.Point(330, 479);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(134, 41);
            this.btn_ajouter.TabIndex = 18;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // grp_facture
            // 
            this.grp_facture.Controls.Add(this.cb_facture);
            this.grp_facture.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_facture.Location = new System.Drawing.Point(9, 13);
            this.grp_facture.Name = "grp_facture";
            this.grp_facture.Size = new System.Drawing.Size(301, 75);
            this.grp_facture.TabIndex = 15;
            this.grp_facture.TabStop = false;
            this.grp_facture.Text = "Les cotisation:";
            // 
            // grp_details
            // 
            this.grp_details.Controls.Add(this.label2);
            this.grp_details.Controls.Add(this.label1);
            this.grp_details.Controls.Add(this.txt_nomremarque);
            this.grp_details.Controls.Add(this.txt_remarque);
            this.grp_details.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_details.Location = new System.Drawing.Point(317, 13);
            this.grp_details.Name = "grp_details";
            this.grp_details.Size = new System.Drawing.Size(445, 433);
            this.grp_details.TabIndex = 17;
            this.grp_details.TabStop = false;
            this.grp_details.Text = "Information De Remarques :";
            this.grp_details.Enter += new System.EventHandler(this.grp_details_Enter);
            // 
            // grp_remarque
            // 
            this.grp_remarque.Controls.Add(this.lst_Remaques);
            this.grp_remarque.Controls.Add(this.btn_suivant);
            this.grp_remarque.Controls.Add(this.btn_precedent);
            this.grp_remarque.Controls.Add(this.btn_derniere);
            this.grp_remarque.Controls.Add(this.txt_chercher);
            this.grp_remarque.Controls.Add(this.btn_premiere);
            this.grp_remarque.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_remarque.Location = new System.Drawing.Point(9, 89);
            this.grp_remarque.Name = "grp_remarque";
            this.grp_remarque.Size = new System.Drawing.Size(301, 499);
            this.grp_remarque.TabIndex = 16;
            this.grp_remarque.TabStop = false;
            this.grp_remarque.Text = "Liste Des Remarques :";
            // 
            // frm_Cotisation_Remarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 634);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.grp_facture);
            this.Controls.Add(this.grp_details);
            this.Controls.Add(this.grp_remarque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Cotisation_Remarque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Cotisation_Remarque";
            this.Load += new System.EventHandler(this.frm_Cotisation_Remarque_Load);
            this.grp_facture.ResumeLayout(false);
            this.grp_details.ResumeLayout(false);
            this.grp_details.PerformLayout();
            this.grp_remarque.ResumeLayout(false);
            this.grp_remarque.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Remaques;
        private System.Windows.Forms.ComboBox cb_facture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nomremarque;
        private System.Windows.Forms.TextBox txt_remarque;
        private System.Windows.Forms.TextBox txt_chercher;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_premiere;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_derniere;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.GroupBox grp_facture;
        private System.Windows.Forms.GroupBox grp_details;
        private System.Windows.Forms.GroupBox grp_remarque;
    }
}