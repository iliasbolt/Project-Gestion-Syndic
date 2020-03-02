namespace Syndic
{
    partial class frm_Echeance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Echeance));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_derniere = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnl_nomPrenom = new System.Windows.Forms.Panel();
            this.btn_chercherNom = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.grp_chercher = new System.Windows.Forms.GroupBox();
            this.rd_tous = new System.Windows.Forms.RadioButton();
            this.rd_Mois = new System.Windows.Forms.RadioButton();
            this.rd_nomPrenom = new System.Windows.Forms.RadioButton();
            this.btn_premiere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_nomPrenom.SuspendLayout();
            this.grp_chercher.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_suivant.Location = new System.Drawing.Point(412, 585);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(46, 41);
            this.btn_suivant.TabIndex = 33;
            this.btn_suivant.UseVisualStyleBackColor = false;
            this.btn_suivant.Click += new System.EventHandler(this.btn_derniere_Click_1);
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
            this.btn_precedent.Location = new System.Drawing.Point(297, 585);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(46, 41);
            this.btn_precedent.TabIndex = 32;
            this.btn_precedent.UseVisualStyleBackColor = false;
            this.btn_precedent.Click += new System.EventHandler(this.btn_derniere_Click_1);
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
            this.btn_derniere.Location = new System.Drawing.Point(470, 585);
            this.btn_derniere.Name = "btn_derniere";
            this.btn_derniere.Size = new System.Drawing.Size(46, 41);
            this.btn_derniere.TabIndex = 34;
            this.btn_derniere.UseVisualStyleBackColor = false;
            this.btn_derniere.Click += new System.EventHandler(this.btn_derniere_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 48;
            this.dataGridView1.Location = new System.Drawing.Point(20, 155);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(732, 425);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // pnl_nomPrenom
            // 
            this.pnl_nomPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_nomPrenom.Controls.Add(this.btn_chercherNom);
            this.pnl_nomPrenom.Controls.Add(this.txt_search);
            this.pnl_nomPrenom.Location = new System.Drawing.Point(20, 87);
            this.pnl_nomPrenom.Name = "pnl_nomPrenom";
            this.pnl_nomPrenom.Size = new System.Drawing.Size(732, 66);
            this.pnl_nomPrenom.TabIndex = 36;
            // 
            // btn_chercherNom
            // 
            this.btn_chercherNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_chercherNom.FlatAppearance.BorderSize = 0;
            this.btn_chercherNom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_chercherNom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chercherNom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chercherNom.ForeColor = System.Drawing.Color.White;
            this.btn_chercherNom.Location = new System.Drawing.Point(592, 18);
            this.btn_chercherNom.Name = "btn_chercherNom";
            this.btn_chercherNom.Size = new System.Drawing.Size(115, 32);
            this.btn_chercherNom.TabIndex = 2;
            this.btn_chercherNom.Text = "Rechercher";
            this.btn_chercherNom.UseVisualStyleBackColor = false;
            this.btn_chercherNom.Click += new System.EventHandler(this.btn_chercherNom_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.Gray;
            this.txt_search.Location = new System.Drawing.Point(22, 18);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(524, 29);
            this.txt_search.TabIndex = 1;
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter_1);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave_1);
            // 
            // grp_chercher
            // 
            this.grp_chercher.Controls.Add(this.rd_tous);
            this.grp_chercher.Controls.Add(this.rd_Mois);
            this.grp_chercher.Controls.Add(this.rd_nomPrenom);
            this.grp_chercher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_chercher.Location = new System.Drawing.Point(20, 16);
            this.grp_chercher.Name = "grp_chercher";
            this.grp_chercher.Size = new System.Drawing.Size(732, 67);
            this.grp_chercher.TabIndex = 37;
            this.grp_chercher.TabStop = false;
            this.grp_chercher.Text = "Filter : ";
            this.grp_chercher.Enter += new System.EventHandler(this.grp_chercher_Enter);
            // 
            // rd_tous
            // 
            this.rd_tous.AutoSize = true;
            this.rd_tous.Checked = true;
            this.rd_tous.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_tous.Location = new System.Drawing.Point(170, 26);
            this.rd_tous.Name = "rd_tous";
            this.rd_tous.Size = new System.Drawing.Size(62, 25);
            this.rd_tous.TabIndex = 3;
            this.rd_tous.TabStop = true;
            this.rd_tous.Text = "Tous";
            this.rd_tous.UseVisualStyleBackColor = true;
            this.rd_tous.CheckedChanged += new System.EventHandler(this.rd_tous_CheckedChanged);
            // 
            // rd_Mois
            // 
            this.rd_Mois.AutoSize = true;
            this.rd_Mois.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Mois.Location = new System.Drawing.Point(539, 26);
            this.rd_Mois.Name = "rd_Mois";
            this.rd_Mois.Size = new System.Drawing.Size(62, 25);
            this.rd_Mois.TabIndex = 2;
            this.rd_Mois.Text = "Mois";
            this.rd_Mois.UseVisualStyleBackColor = true;
            this.rd_Mois.CheckedChanged += new System.EventHandler(this.rd_Mois_CheckedChanged);
            // 
            // rd_nomPrenom
            // 
            this.rd_nomPrenom.AutoSize = true;
            this.rd_nomPrenom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_nomPrenom.Location = new System.Drawing.Point(341, 26);
            this.rd_nomPrenom.Name = "rd_nomPrenom";
            this.rd_nomPrenom.Size = new System.Drawing.Size(81, 25);
            this.rd_nomPrenom.TabIndex = 0;
            this.rd_nomPrenom.Text = "Annee";
            this.rd_nomPrenom.UseVisualStyleBackColor = true;
            this.rd_nomPrenom.CheckedChanged += new System.EventHandler(this.rd_nomPrenom_CheckedChanged);
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
            this.btn_premiere.Location = new System.Drawing.Point(237, 585);
            this.btn_premiere.Name = "btn_premiere";
            this.btn_premiere.Size = new System.Drawing.Size(46, 41);
            this.btn_premiere.TabIndex = 31;
            this.btn_premiere.UseVisualStyleBackColor = false;
            this.btn_premiere.Click += new System.EventHandler(this.btn_derniere_Click_1);
            // 
            // frm_Echeance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 634);
            this.Controls.Add(this.pnl_nomPrenom);
            this.Controls.Add(this.grp_chercher);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_suivant);
            this.Controls.Add(this.btn_precedent);
            this.Controls.Add(this.btn_derniere);
            this.Controls.Add(this.btn_premiere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Echeance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Echeance";
            this.Load += new System.EventHandler(this.frm_Echeance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_nomPrenom.ResumeLayout(false);
            this.pnl_nomPrenom.PerformLayout();
            this.grp_chercher.ResumeLayout(false);
            this.grp_chercher.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_derniere;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnl_nomPrenom;
        private System.Windows.Forms.Button btn_chercherNom;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.GroupBox grp_chercher;
        private System.Windows.Forms.RadioButton rd_Mois;
        private System.Windows.Forms.RadioButton rd_nomPrenom;
        private System.Windows.Forms.RadioButton rd_tous;
        private System.Windows.Forms.Button btn_premiere;
    }
}