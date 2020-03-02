namespace Syndic
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_bar = new System.Windows.Forms.Panel();
            this.btn_meni_logo = new System.Windows.Forms.Button();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.btn_minimaze = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_echeance = new System.Windows.Forms.Button();
            this.btn_historique = new System.Windows.Forms.Button();
            this.btn_deconnection = new System.Windows.Forms.Button();
            this.btn_parametre = new System.Windows.Forms.Button();
            this.btn_statistique = new System.Windows.Forms.Button();
            this.btn_fournisseur = new System.Windows.Forms.Button();
            this.btn_cotisation = new System.Windows.Forms.Button();
            this.btn_article = new System.Windows.Forms.Button();
            this.btn_utilisateur = new System.Windows.Forms.Button();
            this.btn_proprietaire = new System.Windows.Forms.Button();
            this.btn_employe = new System.Windows.Forms.Button();
            this.btn_bien = new System.Windows.Forms.Button();
            this.btn_facture = new System.Windows.Forms.Button();
            this.btn_recette = new System.Windows.Forms.Button();
            this.btn_immeuble = new System.Windows.Forms.Button();
            this.btn_tableBord = new System.Windows.Forms.Button();
            this.pnl_forms = new System.Windows.Forms.Panel();
            this.pnl_bar.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_bar
            // 
            this.pnl_bar.BackColor = System.Drawing.Color.White;
            this.pnl_bar.Controls.Add(this.btn_meni_logo);
            this.pnl_bar.Controls.Add(this.lbl_titre);
            this.pnl_bar.Controls.Add(this.btn_minimaze);
            this.pnl_bar.Controls.Add(this.btn_close);
            this.pnl_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_bar.Location = new System.Drawing.Point(0, 0);
            this.pnl_bar.Name = "pnl_bar";
            this.pnl_bar.Size = new System.Drawing.Size(1000, 23);
            this.pnl_bar.TabIndex = 0;
            this.pnl_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_bar_MouseMove);
            // 
            // btn_meni_logo
            // 
            this.btn_meni_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_meni_logo.BackgroundImage")));
            this.btn_meni_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_meni_logo.FlatAppearance.BorderSize = 0;
            this.btn_meni_logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_meni_logo.Location = new System.Drawing.Point(10, 0);
            this.btn_meni_logo.Name = "btn_meni_logo";
            this.btn_meni_logo.Size = new System.Drawing.Size(22, 24);
            this.btn_meni_logo.TabIndex = 3;
            this.btn_meni_logo.UseVisualStyleBackColor = true;
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(45, 3);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(143, 15);
            this.lbl_titre.TabIndex = 3;
            this.lbl_titre.Text = "Tableau de bord - Syndic";
            // 
            // btn_minimaze
            // 
            this.btn_minimaze.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_minimaze.BackgroundImage")));
            this.btn_minimaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_minimaze.FlatAppearance.BorderSize = 0;
            this.btn_minimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimaze.Location = new System.Drawing.Point(950, -1);
            this.btn_minimaze.Name = "btn_minimaze";
            this.btn_minimaze.Size = new System.Drawing.Size(22, 24);
            this.btn_minimaze.TabIndex = 3;
            this.btn_minimaze.UseVisualStyleBackColor = true;
            this.btn_minimaze.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(978, -1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(22, 24);
            this.btn_close.TabIndex = 2;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.pnl_menu.Controls.Add(this.pictureBox1);
            this.pnl_menu.Controls.Add(this.btn_echeance);
            this.pnl_menu.Controls.Add(this.btn_historique);
            this.pnl_menu.Controls.Add(this.btn_deconnection);
            this.pnl_menu.Controls.Add(this.btn_parametre);
            this.pnl_menu.Controls.Add(this.btn_statistique);
            this.pnl_menu.Controls.Add(this.btn_fournisseur);
            this.pnl_menu.Controls.Add(this.btn_cotisation);
            this.pnl_menu.Controls.Add(this.btn_article);
            this.pnl_menu.Controls.Add(this.btn_utilisateur);
            this.pnl_menu.Controls.Add(this.btn_proprietaire);
            this.pnl_menu.Controls.Add(this.btn_employe);
            this.pnl_menu.Controls.Add(this.btn_bien);
            this.pnl_menu.Controls.Add(this.btn_facture);
            this.pnl_menu.Controls.Add(this.btn_recette);
            this.pnl_menu.Controls.Add(this.btn_immeuble);
            this.pnl_menu.Controls.Add(this.btn_tableBord);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 23);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(230, 677);
            this.pnl_menu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_echeance
            // 
            this.btn_echeance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_echeance.FlatAppearance.BorderSize = 0;
            this.btn_echeance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_echeance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_echeance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_echeance.ForeColor = System.Drawing.Color.White;
            this.btn_echeance.Image = ((System.Drawing.Image)(resources.GetObject("btn_echeance.Image")));
            this.btn_echeance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_echeance.Location = new System.Drawing.Point(0, 223);
            this.btn_echeance.Name = "btn_echeance";
            this.btn_echeance.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_echeance.Size = new System.Drawing.Size(230, 40);
            this.btn_echeance.TabIndex = 31;
            this.btn_echeance.Text = "Échéance";
            this.btn_echeance.UseVisualStyleBackColor = false;
            this.btn_echeance.Click += new System.EventHandler(this.btn_tableBord_Click);
            // 
            // btn_historique
            // 
            this.btn_historique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_historique.FlatAppearance.BorderSize = 0;
            this.btn_historique.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_historique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_historique.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_historique.ForeColor = System.Drawing.Color.White;
            this.btn_historique.Image = ((System.Drawing.Image)(resources.GetObject("btn_historique.Image")));
            this.btn_historique.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_historique.Location = new System.Drawing.Point(0, 551);
            this.btn_historique.Name = "btn_historique";
            this.btn_historique.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_historique.Size = new System.Drawing.Size(230, 40);
            this.btn_historique.TabIndex = 24;
            this.btn_historique.Text = "Historique";
            this.btn_historique.UseVisualStyleBackColor = false;
            this.btn_historique.Click += new System.EventHandler(this.btn_tableBord_Click);
            // 
            // btn_deconnection
            // 
            this.btn_deconnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_deconnection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_deconnection.BackgroundImage")));
            this.btn_deconnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_deconnection.FlatAppearance.BorderSize = 0;
            this.btn_deconnection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_deconnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deconnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deconnection.ForeColor = System.Drawing.Color.White;
            this.btn_deconnection.Location = new System.Drawing.Point(65, 642);
            this.btn_deconnection.Name = "btn_deconnection";
            this.btn_deconnection.Size = new System.Drawing.Size(30, 25);
            this.btn_deconnection.TabIndex = 30;
            this.btn_deconnection.UseVisualStyleBackColor = false;
            this.btn_deconnection.Click += new System.EventHandler(this.btn_tableBord_Click);
            // 
            // btn_parametre
            // 
            this.btn_parametre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_parametre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_parametre.BackgroundImage")));
            this.btn_parametre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_parametre.FlatAppearance.BorderSize = 0;
            this.btn_parametre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_parametre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_parametre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_parametre.ForeColor = System.Drawing.Color.White;
            this.btn_parametre.Location = new System.Drawing.Point(124, 642);
            this.btn_parametre.Name = "btn_parametre";
            this.btn_parametre.Size = new System.Drawing.Size(30, 25);
            this.btn_parametre.TabIndex = 29;
            this.btn_parametre.UseVisualStyleBackColor = false;
            this.btn_parametre.Click += new System.EventHandler(this.btn_tableBord_Click);
            // 
            // btn_statistique
            // 
            this.btn_statistique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_statistique.FlatAppearance.BorderSize = 0;
            this.btn_statistique.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_statistique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_statistique.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statistique.ForeColor = System.Drawing.Color.White;
            this.btn_statistique.Image = ((System.Drawing.Image)(resources.GetObject("btn_statistique.Image")));
            this.btn_statistique.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_statistique.Location = new System.Drawing.Point(0, 592);
            this.btn_statistique.Name = "btn_statistique";
            this.btn_statistique.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_statistique.Size = new System.Drawing.Size(230, 40);
            this.btn_statistique.TabIndex = 28;
            this.btn_statistique.Text = "Statistique";
            this.btn_statistique.UseVisualStyleBackColor = false;
            this.btn_statistique.Click += new System.EventHandler(this.btn_tableBord_Click);
            // 
            // btn_fournisseur
            // 
            this.btn_fournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_fournisseur.FlatAppearance.BorderSize = 0;
            this.btn_fournisseur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_fournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fournisseur.ForeColor = System.Drawing.Color.White;
            this.btn_fournisseur.Image = ((System.Drawing.Image)(resources.GetObject("btn_fournisseur.Image")));
            this.btn_fournisseur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fournisseur.Location = new System.Drawing.Point(0, 469);
            this.btn_fournisseur.Name = "btn_fournisseur";
            this.btn_fournisseur.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_fournisseur.Size = new System.Drawing.Size(230, 40);
            this.btn_fournisseur.TabIndex = 26;
            this.btn_fournisseur.Text = "Fournisseur";
            this.btn_fournisseur.UseVisualStyleBackColor = false;
            this.btn_fournisseur.Click += new System.EventHandler(this.btn_tableBord_Click);
            // 
            // btn_cotisation
            // 
            this.btn_cotisation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_cotisation.FlatAppearance.BorderSize = 0;
            this.btn_cotisation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_cotisation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cotisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cotisation.ForeColor = System.Drawing.Color.White;
            this.btn_cotisation.Image = ((System.Drawing.Image)(resources.GetObject("btn_cotisation.Image")));
            this.btn_cotisation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cotisation.Location = new System.Drawing.Point(0, 182);
            this.btn_cotisation.Name = "btn_cotisation";
            this.btn_cotisation.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_cotisation.Size = new System.Drawing.Size(230, 40);
            this.btn_cotisation.TabIndex = 19;
            this.btn_cotisation.Text = "Cotisation";
            this.btn_cotisation.UseVisualStyleBackColor = false;
            this.btn_cotisation.Click += new System.EventHandler(this.btn_tableBord_Click);
            // 
            // btn_article
            // 
            this.btn_article.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_article.FlatAppearance.BorderSize = 0;
            this.btn_article.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_article.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_article.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_article.ForeColor = System.Drawing.Color.White;
            this.btn_article.Image = ((System.Drawing.Image)(resources.GetObject("btn_article.Image")));
            this.btn_article.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_article.Location = new System.Drawing.Point(0, 510);
            this.btn_article.Name = "btn_article";
            this.btn_article.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_article.Size = new System.Drawing.Size(230, 40);
            this.btn_article.TabIndex = 27;
            this.btn_article.Text = "Article";
            this.btn_article.UseVisualStyleBackColor = false;
            this.btn_article.Click += new System.EventHandler(this.btn_tableBord_Click);
            // 
            // btn_utilisateur
            // 
            this.btn_utilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_utilisateur.FlatAppearance.BorderSize = 0;
            this.btn_utilisateur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_utilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_utilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_utilisateur.ForeColor = System.Drawing.Color.White;
            this.btn_utilisateur.Image = ((System.Drawing.Image)(resources.GetObject("btn_utilisateur.Image")));
            this.btn_utilisateur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_utilisateur.Location = new System.Drawing.Point(0, 428);
            this.btn_utilisateur.Name = "btn_utilisateur";
            this.btn_utilisateur.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_utilisateur.Size = new System.Drawing.Size(230, 40);
            this.btn_utilisateur.TabIndex = 25;
            this.btn_utilisateur.Text = "Utilisateur";
            this.btn_utilisateur.UseVisualStyleBackColor = false;
            this.btn_utilisateur.Click += new System.EventHandler(this.btn_tableBord_Click);
            // 
            // btn_proprietaire
            // 
            this.btn_proprietaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_proprietaire.FlatAppearance.BorderSize = 0;
            this.btn_proprietaire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_proprietaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proprietaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proprietaire.ForeColor = System.Drawing.Color.White;
            this.btn_proprietaire.Image = ((System.Drawing.Image)(resources.GetObject("btn_proprietaire.Image")));
            this.btn_proprietaire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_proprietaire.Location = new System.Drawing.Point(0, 346);
            this.btn_proprietaire.Name = "btn_proprietaire";
            this.btn_proprietaire.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_proprietaire.Size = new System.Drawing.Size(230, 40);
            this.btn_proprietaire.TabIndex = 22;
            this.btn_proprietaire.Text = "Propriétaire";
            this.btn_proprietaire.UseVisualStyleBackColor = false;
            this.btn_proprietaire.Click += new System.EventHandler(this.btn_tableBord_Click);
            // 
            // btn_employe
            // 
            this.btn_employe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_employe.FlatAppearance.BorderSize = 0;
            this.btn_employe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_employe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employe.ForeColor = System.Drawing.Color.White;
            this.btn_employe.Image = ((System.Drawing.Image)(resources.GetObject("btn_employe.Image")));
            this.btn_employe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_employe.Location = new System.Drawing.Point(0, 387);
            this.btn_employe.Name = "btn_employe";
            this.btn_employe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_employe.Size = new System.Drawing.Size(230, 40);
            this.btn_employe.TabIndex = 23;
            this.btn_employe.Text = "Employee";
            this.btn_employe.UseVisualStyleBackColor = false;
            this.btn_employe.Click += new System.EventHandler(this.btn_tableBord_Click);
            // 
            // btn_bien
            // 
            this.btn_bien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_bien.FlatAppearance.BorderSize = 0;
            this.btn_bien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_bien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bien.ForeColor = System.Drawing.Color.White;
            this.btn_bien.Image = ((System.Drawing.Image)(resources.GetObject("btn_bien.Image")));
            this.btn_bien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bien.Location = new System.Drawing.Point(0, 305);
            this.btn_bien.Name = "btn_bien";
            this.btn_bien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_bien.Size = new System.Drawing.Size(230, 40);
            this.btn_bien.TabIndex = 21;
            this.btn_bien.Text = "Bien";
            this.btn_bien.UseVisualStyleBackColor = false;
            this.btn_bien.Click += new System.EventHandler(this.btn_tableBord_Click);
            // 
            // btn_facture
            // 
            this.btn_facture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_facture.FlatAppearance.BorderSize = 0;
            this.btn_facture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_facture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facture.ForeColor = System.Drawing.Color.White;
            this.btn_facture.Image = ((System.Drawing.Image)(resources.GetObject("btn_facture.Image")));
            this.btn_facture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_facture.Location = new System.Drawing.Point(0, 100);
            this.btn_facture.Name = "btn_facture";
            this.btn_facture.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_facture.Size = new System.Drawing.Size(230, 40);
            this.btn_facture.TabIndex = 17;
            this.btn_facture.Text = "Facture";
            this.btn_facture.UseVisualStyleBackColor = false;
            this.btn_facture.Click += new System.EventHandler(this.btn_tableBord_Click);
            // 
            // btn_recette
            // 
            this.btn_recette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_recette.FlatAppearance.BorderSize = 0;
            this.btn_recette.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_recette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recette.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recette.ForeColor = System.Drawing.Color.White;
            this.btn_recette.Image = ((System.Drawing.Image)(resources.GetObject("btn_recette.Image")));
            this.btn_recette.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_recette.Location = new System.Drawing.Point(0, 141);
            this.btn_recette.Name = "btn_recette";
            this.btn_recette.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_recette.Size = new System.Drawing.Size(230, 40);
            this.btn_recette.TabIndex = 18;
            this.btn_recette.Text = "Recette";
            this.btn_recette.UseVisualStyleBackColor = false;
            this.btn_recette.Click += new System.EventHandler(this.btn_tableBord_Click);
            // 
            // btn_immeuble
            // 
            this.btn_immeuble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_immeuble.FlatAppearance.BorderSize = 0;
            this.btn_immeuble.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_immeuble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_immeuble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_immeuble.ForeColor = System.Drawing.Color.White;
            this.btn_immeuble.Image = ((System.Drawing.Image)(resources.GetObject("btn_immeuble.Image")));
            this.btn_immeuble.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_immeuble.Location = new System.Drawing.Point(0, 264);
            this.btn_immeuble.Name = "btn_immeuble";
            this.btn_immeuble.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_immeuble.Size = new System.Drawing.Size(230, 40);
            this.btn_immeuble.TabIndex = 20;
            this.btn_immeuble.Text = "Immeuble";
            this.btn_immeuble.UseVisualStyleBackColor = false;
            this.btn_immeuble.Click += new System.EventHandler(this.btn_tableBord_Click);
            // 
            // btn_tableBord
            // 
            this.btn_tableBord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_tableBord.FlatAppearance.BorderSize = 0;
            this.btn_tableBord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_tableBord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tableBord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tableBord.ForeColor = System.Drawing.Color.White;
            this.btn_tableBord.Image = ((System.Drawing.Image)(resources.GetObject("btn_tableBord.Image")));
            this.btn_tableBord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tableBord.Location = new System.Drawing.Point(0, 59);
            this.btn_tableBord.Name = "btn_tableBord";
            this.btn_tableBord.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_tableBord.Size = new System.Drawing.Size(230, 40);
            this.btn_tableBord.TabIndex = 16;
            this.btn_tableBord.Text = "Tableau de bord";
            this.btn_tableBord.UseVisualStyleBackColor = false;
            this.btn_tableBord.Click += new System.EventHandler(this.btn_tableBord_Click);
            // 
            // pnl_forms
            // 
            this.pnl_forms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_forms.Location = new System.Drawing.Point(230, 23);
            this.pnl_forms.Name = "pnl_forms";
            this.pnl_forms.Size = new System.Drawing.Size(770, 677);
            this.pnl_forms.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.pnl_forms);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.pnl_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_bar.ResumeLayout(false);
            this.pnl_bar.PerformLayout();
            this.pnl_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_bar;
        private System.Windows.Forms.Button btn_minimaze;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Button btn_echeance;
        private System.Windows.Forms.Button btn_historique;
        private System.Windows.Forms.Button btn_deconnection;
        private System.Windows.Forms.Button btn_parametre;
        private System.Windows.Forms.Button btn_statistique;
        private System.Windows.Forms.Button btn_fournisseur;
        private System.Windows.Forms.Button btn_cotisation;
        private System.Windows.Forms.Button btn_article;
        private System.Windows.Forms.Button btn_utilisateur;
        private System.Windows.Forms.Button btn_proprietaire;
        private System.Windows.Forms.Button btn_employe;
        private System.Windows.Forms.Button btn_bien;
        private System.Windows.Forms.Button btn_facture;
        private System.Windows.Forms.Button btn_recette;
        private System.Windows.Forms.Button btn_immeuble;
        private System.Windows.Forms.Button btn_tableBord;
        private System.Windows.Forms.Panel pnl_forms;
        private System.Windows.Forms.Button btn_meni_logo;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

