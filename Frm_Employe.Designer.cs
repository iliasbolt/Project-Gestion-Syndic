namespace Syndic
{
    partial class Frm_Employe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Employe));
            this.pnlMenuBar = new System.Windows.Forms.Panel();
            this.pnl_selection = new System.Windows.Forms.Panel();
            this.pnlDrop = new System.Windows.Forms.Panel();
            this.btn_repos = new System.Windows.Forms.Button();
            this.btn_conge = new System.Windows.Forms.Button();
            this.btn_contrat = new System.Windows.Forms.Button();
            this.btn_remarque = new System.Windows.Forms.Button();
            this.btn_drop = new System.Windows.Forms.Button();
            this.btn_document = new System.Windows.Forms.Button();
            this.btn_employe = new System.Windows.Forms.Button();
            this.pnlForms = new System.Windows.Forms.Panel();
            this.pnlMenuBar.SuspendLayout();
            this.pnlDrop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.Controls.Add(this.pnl_selection);
            this.pnlMenuBar.Controls.Add(this.pnlDrop);
            this.pnlMenuBar.Controls.Add(this.btn_remarque);
            this.pnlMenuBar.Controls.Add(this.btn_drop);
            this.pnlMenuBar.Controls.Add(this.btn_document);
            this.pnlMenuBar.Controls.Add(this.btn_employe);
            this.pnlMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuBar.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(770, 43);
            this.pnlMenuBar.TabIndex = 0;
            // 
            // pnl_selection
            // 
            this.pnl_selection.BackColor = System.Drawing.Color.Orange;
            this.pnl_selection.Location = new System.Drawing.Point(0, 39);
            this.pnl_selection.Name = "pnl_selection";
            this.pnl_selection.Size = new System.Drawing.Size(242, 5);
            this.pnl_selection.TabIndex = 9;
            // 
            // pnlDrop
            // 
            this.pnlDrop.Controls.Add(this.btn_repos);
            this.pnlDrop.Controls.Add(this.btn_conge);
            this.pnlDrop.Controls.Add(this.btn_contrat);
            this.pnlDrop.Location = new System.Drawing.Point(527, 39);
            this.pnlDrop.Name = "pnlDrop";
            this.pnlDrop.Size = new System.Drawing.Size(243, 133);
            this.pnlDrop.TabIndex = 0;
            // 
            // btn_repos
            // 
            this.btn_repos.BackColor = System.Drawing.Color.Black;
            this.btn_repos.FlatAppearance.BorderSize = 0;
            this.btn_repos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_repos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_repos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repos.ForeColor = System.Drawing.Color.White;
            this.btn_repos.Location = new System.Drawing.Point(0, 88);
            this.btn_repos.Name = "btn_repos";
            this.btn_repos.Size = new System.Drawing.Size(242, 43);
            this.btn_repos.TabIndex = 11;
            this.btn_repos.Text = "Les Repos";
            this.btn_repos.UseVisualStyleBackColor = false;
            this.btn_repos.Click += new System.EventHandler(this.btn_employe_Click);
            // 
            // btn_conge
            // 
            this.btn_conge.BackColor = System.Drawing.Color.Black;
            this.btn_conge.FlatAppearance.BorderSize = 0;
            this.btn_conge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_conge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_conge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conge.ForeColor = System.Drawing.Color.White;
            this.btn_conge.Location = new System.Drawing.Point(0, 44);
            this.btn_conge.Name = "btn_conge";
            this.btn_conge.Size = new System.Drawing.Size(242, 43);
            this.btn_conge.TabIndex = 10;
            this.btn_conge.Text = "Les Conges";
            this.btn_conge.UseVisualStyleBackColor = false;
            this.btn_conge.Click += new System.EventHandler(this.btn_employe_Click);
            // 
            // btn_contrat
            // 
            this.btn_contrat.BackColor = System.Drawing.Color.Black;
            this.btn_contrat.FlatAppearance.BorderSize = 0;
            this.btn_contrat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_contrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contrat.ForeColor = System.Drawing.Color.White;
            this.btn_contrat.Location = new System.Drawing.Point(0, 0);
            this.btn_contrat.Name = "btn_contrat";
            this.btn_contrat.Size = new System.Drawing.Size(242, 43);
            this.btn_contrat.TabIndex = 9;
            this.btn_contrat.Text = "Les Contrats";
            this.btn_contrat.UseVisualStyleBackColor = false;
            this.btn_contrat.Click += new System.EventHandler(this.btn_employe_Click);
            // 
            // btn_remarque
            // 
            this.btn_remarque.BackColor = System.Drawing.Color.Black;
            this.btn_remarque.FlatAppearance.BorderSize = 0;
            this.btn_remarque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_remarque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remarque.ForeColor = System.Drawing.Color.White;
            this.btn_remarque.Location = new System.Drawing.Point(486, 0);
            this.btn_remarque.Name = "btn_remarque";
            this.btn_remarque.Size = new System.Drawing.Size(242, 43);
            this.btn_remarque.TabIndex = 8;
            this.btn_remarque.Text = "Les Remarques";
            this.btn_remarque.UseVisualStyleBackColor = false;
            this.btn_remarque.Click += new System.EventHandler(this.btn_employe_Click);
            // 
            // btn_drop
            // 
            this.btn_drop.BackColor = System.Drawing.Color.Black;
            this.btn_drop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_drop.BackgroundImage")));
            this.btn_drop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_drop.FlatAppearance.BorderSize = 0;
            this.btn_drop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_drop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_drop.ForeColor = System.Drawing.Color.White;
            this.btn_drop.Location = new System.Drawing.Point(730, 0);
            this.btn_drop.Name = "btn_drop";
            this.btn_drop.Size = new System.Drawing.Size(40, 43);
            this.btn_drop.TabIndex = 7;
            this.btn_drop.UseVisualStyleBackColor = false;
            this.btn_drop.Click += new System.EventHandler(this.btn_drop_Click);
            // 
            // btn_document
            // 
            this.btn_document.BackColor = System.Drawing.Color.Black;
            this.btn_document.FlatAppearance.BorderSize = 0;
            this.btn_document.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_document.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_document.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_document.ForeColor = System.Drawing.Color.White;
            this.btn_document.Location = new System.Drawing.Point(243, 0);
            this.btn_document.Name = "btn_document";
            this.btn_document.Size = new System.Drawing.Size(242, 43);
            this.btn_document.TabIndex = 6;
            this.btn_document.Text = "Les Documents";
            this.btn_document.UseVisualStyleBackColor = false;
            this.btn_document.Click += new System.EventHandler(this.btn_employe_Click);
            // 
            // btn_employe
            // 
            this.btn_employe.BackColor = System.Drawing.Color.Black;
            this.btn_employe.FlatAppearance.BorderSize = 0;
            this.btn_employe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_employe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employe.ForeColor = System.Drawing.Color.White;
            this.btn_employe.Location = new System.Drawing.Point(0, 0);
            this.btn_employe.Name = "btn_employe";
            this.btn_employe.Size = new System.Drawing.Size(242, 43);
            this.btn_employe.TabIndex = 5;
            this.btn_employe.Text = "Les Employes";
            this.btn_employe.UseVisualStyleBackColor = false;
            this.btn_employe.Click += new System.EventHandler(this.btn_employe_Click);
            // 
            // pnlForms
            // 
            this.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForms.Location = new System.Drawing.Point(0, 43);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(770, 634);
            this.pnlForms.TabIndex = 1;
            // 
            // Frm_Employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 677);
            this.Controls.Add(this.pnlForms);
            this.Controls.Add(this.pnlMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Employe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Employe";
            this.Load += new System.EventHandler(this.Frm_Employe_Load);
            this.pnlMenuBar.ResumeLayout(false);
            this.pnlDrop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuBar;
        private System.Windows.Forms.Button btn_remarque;
        private System.Windows.Forms.Button btn_drop;
        private System.Windows.Forms.Button btn_document;
        private System.Windows.Forms.Button btn_employe;
        private System.Windows.Forms.Panel pnlForms;
        private System.Windows.Forms.Panel pnlDrop;
        private System.Windows.Forms.Button btn_repos;
        private System.Windows.Forms.Button btn_conge;
        private System.Windows.Forms.Button btn_contrat;
        private System.Windows.Forms.Panel pnl_selection;
    }
}