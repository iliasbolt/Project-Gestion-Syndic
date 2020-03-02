namespace Syndic
{
    partial class frm_Cotisation
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
            this.pnl_form = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_selection = new System.Windows.Forms.Panel();
            this.btn_cotisation = new System.Windows.Forms.Button();
            this.btn_cotisation_Remarque = new System.Windows.Forms.Button();
            this.btn_cotisation_Document = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_form
            // 
            this.pnl_form.Location = new System.Drawing.Point(0, 43);
            this.pnl_form.Name = "pnl_form";
            this.pnl_form.Size = new System.Drawing.Size(770, 634);
            this.pnl_form.TabIndex = 9;
            this.pnl_form.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_form_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnl_selection);
            this.panel3.Controls.Add(this.btn_cotisation);
            this.panel3.Controls.Add(this.btn_cotisation_Remarque);
            this.panel3.Controls.Add(this.btn_cotisation_Document);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 43);
            this.panel3.TabIndex = 15;
            // 
            // pnl_selection
            // 
            this.pnl_selection.BackColor = System.Drawing.Color.Orange;
            this.pnl_selection.Location = new System.Drawing.Point(0, 38);
            this.pnl_selection.Name = "pnl_selection";
            this.pnl_selection.Size = new System.Drawing.Size(255, 5);
            this.pnl_selection.TabIndex = 14;
            // 
            // btn_cotisation
            // 
            this.btn_cotisation.BackColor = System.Drawing.Color.Black;
            this.btn_cotisation.FlatAppearance.BorderSize = 0;
            this.btn_cotisation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_cotisation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cotisation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cotisation.ForeColor = System.Drawing.Color.White;
            this.btn_cotisation.Location = new System.Drawing.Point(1, 0);
            this.btn_cotisation.Name = "btn_cotisation";
            this.btn_cotisation.Size = new System.Drawing.Size(256, 43);
            this.btn_cotisation.TabIndex = 11;
            this.btn_cotisation.Text = "Cotisation";
            this.btn_cotisation.UseVisualStyleBackColor = false;
            this.btn_cotisation.Click += new System.EventHandler(this.btn_cotisation_Document_Click_1);
            // 
            // btn_cotisation_Remarque
            // 
            this.btn_cotisation_Remarque.BackColor = System.Drawing.Color.Black;
            this.btn_cotisation_Remarque.FlatAppearance.BorderSize = 0;
            this.btn_cotisation_Remarque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_cotisation_Remarque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cotisation_Remarque.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cotisation_Remarque.ForeColor = System.Drawing.Color.White;
            this.btn_cotisation_Remarque.Location = new System.Drawing.Point(514, 0);
            this.btn_cotisation_Remarque.Name = "btn_cotisation_Remarque";
            this.btn_cotisation_Remarque.Size = new System.Drawing.Size(255, 43);
            this.btn_cotisation_Remarque.TabIndex = 13;
            this.btn_cotisation_Remarque.Text = "Remarque";
            this.btn_cotisation_Remarque.UseVisualStyleBackColor = false;
            this.btn_cotisation_Remarque.Click += new System.EventHandler(this.btn_cotisation_Document_Click_1);
            // 
            // btn_cotisation_Document
            // 
            this.btn_cotisation_Document.BackColor = System.Drawing.Color.Black;
            this.btn_cotisation_Document.FlatAppearance.BorderSize = 0;
            this.btn_cotisation_Document.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_cotisation_Document.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cotisation_Document.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cotisation_Document.ForeColor = System.Drawing.Color.White;
            this.btn_cotisation_Document.Location = new System.Drawing.Point(258, 0);
            this.btn_cotisation_Document.Name = "btn_cotisation_Document";
            this.btn_cotisation_Document.Size = new System.Drawing.Size(255, 43);
            this.btn_cotisation_Document.TabIndex = 12;
            this.btn_cotisation_Document.Text = "Document";
            this.btn_cotisation_Document.UseVisualStyleBackColor = false;
            this.btn_cotisation_Document.Click += new System.EventHandler(this.btn_cotisation_Document_Click_1);
            // 
            // frm_Cotisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 677);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnl_form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Cotisation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Cotisation_real";
            this.Load += new System.EventHandler(this.frm_Cotisation_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_form;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_cotisation;
        private System.Windows.Forms.Button btn_cotisation_Remarque;
        private System.Windows.Forms.Button btn_cotisation_Document;
        private System.Windows.Forms.Panel pnl_selection;
    }
}