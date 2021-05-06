namespace LoupGarou
{
    partial class Plateforme
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.rb_Osalle = new System.Windows.Forms.RadioButton();
            this.rb_Rsalle = new System.Windows.Forms.RadioButton();
            this.p_Osalle = new System.Windows.Forms.Panel();
            this.tb_AdresseSOS = new System.Windows.Forms.TextBox();
            this.tb_PortPOS = new System.Windows.Forms.TextBox();
            this.p_Rsalle = new System.Windows.Forms.Panel();
            this.tc_Client = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.l_narration = new System.Windows.Forms.Label();
            this.gb_Narration = new System.Windows.Forms.GroupBox();
            this.gb_ForumV = new System.Windows.Forms.GroupBox();
            this.lb_lesMessagesFV = new System.Windows.Forms.ListBox();
            this.gb_Vote = new System.Windows.Forms.GroupBox();
            this.gb_ForumL = new System.Windows.Forms.GroupBox();
            this.lb_lesMessagesFL = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gb_Reseau = new System.Windows.Forms.GroupBox();
            this.lb_lesMessagesR = new System.Windows.Forms.ListBox();
            this.tb_Capacite = new System.Windows.Forms.TextBox();
            this.tb_AdresseSRS = new System.Windows.Forms.TextBox();
            this.tb_PortCRs = new System.Windows.Forms.TextBox();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_AdresseCRS = new System.Windows.Forms.TextBox();
            this.cb_Vote = new System.Windows.Forms.ComboBox();
            this.bt_FV = new System.Windows.Forms.Button();
            this.bt_FL = new System.Windows.Forms.Button();
            this.bt_R = new System.Windows.Forms.Button();
            this.bt_Vote = new System.Windows.Forms.Button();
            this.bt_Salle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_Narration = new System.Windows.Forms.ListBox();
            this.tb_leMessageFV = new System.Windows.Forms.RichTextBox();
            this.tb_leMessageFL = new System.Windows.Forms.RichTextBox();
            this.tb_leMessageR = new System.Windows.Forms.RichTextBox();
            this.p_Osalle.SuspendLayout();
            this.p_Rsalle.SuspendLayout();
            this.tc_Client.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gb_Narration.SuspendLayout();
            this.gb_ForumV.SuspendLayout();
            this.gb_Vote.SuspendLayout();
            this.gb_ForumL.SuspendLayout();
            this.gb_Reseau.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_Osalle
            // 
            this.rb_Osalle.AutoSize = true;
            this.rb_Osalle.Location = new System.Drawing.Point(8, 12);
            this.rb_Osalle.Name = "rb_Osalle";
            this.rb_Osalle.Size = new System.Drawing.Size(125, 17);
            this.rb_Osalle.TabIndex = 0;
            this.rb_Osalle.TabStop = true;
            this.rb_Osalle.Text = "Ouverture d\'une salle";
            this.rb_Osalle.UseVisualStyleBackColor = true;
            this.rb_Osalle.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_Rsalle
            // 
            this.rb_Rsalle.AutoSize = true;
            this.rb_Rsalle.Location = new System.Drawing.Point(8, 88);
            this.rb_Rsalle.Name = "rb_Rsalle";
            this.rb_Rsalle.Size = new System.Drawing.Size(115, 17);
            this.rb_Rsalle.TabIndex = 1;
            this.rb_Rsalle.TabStop = true;
            this.rb_Rsalle.Text = "Réjoindre une salle";
            this.rb_Rsalle.UseVisualStyleBackColor = true;
            // 
            // p_Osalle
            // 
            this.p_Osalle.Controls.Add(this.label3);
            this.p_Osalle.Controls.Add(this.label2);
            this.p_Osalle.Controls.Add(this.l_narration);
            this.p_Osalle.Controls.Add(this.tb_AdresseSOS);
            this.p_Osalle.Controls.Add(this.tb_PortPOS);
            this.p_Osalle.Controls.Add(this.tb_Capacite);
            this.p_Osalle.Location = new System.Drawing.Point(21, 35);
            this.p_Osalle.Name = "p_Osalle";
            this.p_Osalle.Size = new System.Drawing.Size(447, 44);
            this.p_Osalle.TabIndex = 2;
            // 
            // tb_AdresseSOS
            // 
            this.tb_AdresseSOS.Location = new System.Drawing.Point(107, 15);
            this.tb_AdresseSOS.Name = "tb_AdresseSOS";
            this.tb_AdresseSOS.Size = new System.Drawing.Size(70, 20);
            this.tb_AdresseSOS.TabIndex = 10;
            // 
            // tb_PortPOS
            // 
            this.tb_PortPOS.Location = new System.Drawing.Point(223, 15);
            this.tb_PortPOS.Name = "tb_PortPOS";
            this.tb_PortPOS.Size = new System.Drawing.Size(40, 20);
            this.tb_PortPOS.TabIndex = 11;
            // 
            // p_Rsalle
            // 
            this.p_Rsalle.Controls.Add(this.label7);
            this.p_Rsalle.Controls.Add(this.label6);
            this.p_Rsalle.Controls.Add(this.label5);
            this.p_Rsalle.Controls.Add(this.label4);
            this.p_Rsalle.Controls.Add(this.tb_AdresseCRS);
            this.p_Rsalle.Controls.Add(this.tb_Login);
            this.p_Rsalle.Controls.Add(this.tb_PortCRs);
            this.p_Rsalle.Controls.Add(this.tb_AdresseSRS);
            this.p_Rsalle.Location = new System.Drawing.Point(21, 111);
            this.p_Rsalle.Name = "p_Rsalle";
            this.p_Rsalle.Size = new System.Drawing.Size(533, 49);
            this.p_Rsalle.TabIndex = 3;
            // 
            // tc_Client
            // 
            this.tc_Client.Controls.Add(this.tabPage1);
            this.tc_Client.Controls.Add(this.tabPage2);
            this.tc_Client.Controls.Add(this.tabPage3);
            this.tc_Client.Location = new System.Drawing.Point(25, 209);
            this.tc_Client.Name = "tc_Client";
            this.tc_Client.SelectedIndex = 0;
            this.tc_Client.Size = new System.Drawing.Size(557, 238);
            this.tc_Client.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.gb_Narration);
            this.tabPage1.Controls.Add(this.gb_ForumV);
            this.tabPage1.Controls.Add(this.gb_Vote);
            this.tabPage1.Controls.Add(this.gb_ForumL);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(549, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Accueil";
            // 
            // l_narration
            // 
            this.l_narration.AutoSize = true;
            this.l_narration.Location = new System.Drawing.Point(15, 18);
            this.l_narration.Name = "l_narration";
            this.l_narration.Size = new System.Drawing.Size(88, 13);
            this.l_narration.TabIndex = 0;
            this.l_narration.Text = "Adresse Serveur:";
            this.l_narration.Click += new System.EventHandler(this.L_narration_Click);
            // 
            // gb_Narration
            // 
            this.gb_Narration.Controls.Add(this.lb_Narration);
            this.gb_Narration.Location = new System.Drawing.Point(13, 22);
            this.gb_Narration.Name = "gb_Narration";
            this.gb_Narration.Size = new System.Drawing.Size(200, 74);
            this.gb_Narration.TabIndex = 5;
            this.gb_Narration.TabStop = false;
            this.gb_Narration.Text = "Histoire";
            // 
            // gb_ForumV
            // 
            this.gb_ForumV.Controls.Add(this.lb_lesMessagesFV);
            this.gb_ForumV.Controls.Add(this.tb_leMessageFV);
            this.gb_ForumV.Controls.Add(this.bt_FV);
            this.gb_ForumV.Location = new System.Drawing.Point(221, 22);
            this.gb_ForumV.Name = "gb_ForumV";
            this.gb_ForumV.Size = new System.Drawing.Size(132, 170);
            this.gb_ForumV.TabIndex = 7;
            this.gb_ForumV.TabStop = false;
            this.gb_ForumV.Text = "Forum des Villageois";
            // 
            // lb_lesMessagesFV
            // 
            this.lb_lesMessagesFV.FormattingEnabled = true;
            this.lb_lesMessagesFV.Location = new System.Drawing.Point(23, 19);
            this.lb_lesMessagesFV.Name = "lb_lesMessagesFV";
            this.lb_lesMessagesFV.Size = new System.Drawing.Size(85, 95);
            this.lb_lesMessagesFV.TabIndex = 0;
            // 
            // gb_Vote
            // 
            this.gb_Vote.Controls.Add(this.cb_Vote);
            this.gb_Vote.Controls.Add(this.bt_Vote);
            this.gb_Vote.Location = new System.Drawing.Point(13, 109);
            this.gb_Vote.Name = "gb_Vote";
            this.gb_Vote.Size = new System.Drawing.Size(200, 83);
            this.gb_Vote.TabIndex = 6;
            this.gb_Vote.TabStop = false;
            this.gb_Vote.Text = "Vote";
            // 
            // gb_ForumL
            // 
            this.gb_ForumL.Controls.Add(this.tb_leMessageFL);
            this.gb_ForumL.Controls.Add(this.lb_lesMessagesFL);
            this.gb_ForumL.Controls.Add(this.bt_FL);
            this.gb_ForumL.Location = new System.Drawing.Point(373, 22);
            this.gb_ForumL.Name = "gb_ForumL";
            this.gb_ForumL.Size = new System.Drawing.Size(156, 170);
            this.gb_ForumL.TabIndex = 8;
            this.gb_ForumL.TabStop = false;
            this.gb_ForumL.Text = "Forum des Loups";
            // 
            // lb_lesMessagesFL
            // 
            this.lb_lesMessagesFL.FormattingEnabled = true;
            this.lb_lesMessagesFL.Location = new System.Drawing.Point(31, 19);
            this.lb_lesMessagesFL.Name = "lb_lesMessagesFL";
            this.lb_lesMessagesFL.Size = new System.Drawing.Size(96, 95);
            this.lb_lesMessagesFL.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(545, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compte";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(545, 212);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Déconnexion";
            // 
            // gb_Reseau
            // 
            this.gb_Reseau.Controls.Add(this.bt_R);
            this.gb_Reseau.Controls.Add(this.tb_leMessageR);
            this.gb_Reseau.Controls.Add(this.lb_lesMessagesR);
            this.gb_Reseau.Location = new System.Drawing.Point(588, 18);
            this.gb_Reseau.Name = "gb_Reseau";
            this.gb_Reseau.Size = new System.Drawing.Size(200, 420);
            this.gb_Reseau.TabIndex = 9;
            this.gb_Reseau.TabStop = false;
            this.gb_Reseau.Text = "Test Reseau";
            // 
            // lb_lesMessagesR
            // 
            this.lb_lesMessagesR.FormattingEnabled = true;
            this.lb_lesMessagesR.Location = new System.Drawing.Point(29, 19);
            this.lb_lesMessagesR.Name = "lb_lesMessagesR";
            this.lb_lesMessagesR.Size = new System.Drawing.Size(142, 329);
            this.lb_lesMessagesR.TabIndex = 2;
            this.lb_lesMessagesR.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // tb_Capacite
            // 
            this.tb_Capacite.Location = new System.Drawing.Point(387, 15);
            this.tb_Capacite.Name = "tb_Capacite";
            this.tb_Capacite.Size = new System.Drawing.Size(54, 20);
            this.tb_Capacite.TabIndex = 12;
            // 
            // tb_AdresseSRS
            // 
            this.tb_AdresseSRS.Location = new System.Drawing.Point(106, 17);
            this.tb_AdresseSRS.Name = "tb_AdresseSRS";
            this.tb_AdresseSRS.Size = new System.Drawing.Size(71, 20);
            this.tb_AdresseSRS.TabIndex = 13;
            this.tb_AdresseSRS.TextChanged += new System.EventHandler(this.Tb_AdresseSRS_TextChanged);
            // 
            // tb_PortCRs
            // 
            this.tb_PortCRs.Location = new System.Drawing.Point(223, 17);
            this.tb_PortCRs.Name = "tb_PortCRs";
            this.tb_PortCRs.Size = new System.Drawing.Size(40, 20);
            this.tb_PortCRs.TabIndex = 14;
            this.tb_PortCRs.TextChanged += new System.EventHandler(this.Tb_PortCRs_TextChanged);
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(461, 17);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(57, 20);
            this.tb_Login.TabIndex = 15;
            // 
            // tb_AdresseCRS
            // 
            this.tb_AdresseCRS.Location = new System.Drawing.Point(361, 17);
            this.tb_AdresseCRS.Name = "tb_AdresseCRS";
            this.tb_AdresseCRS.Size = new System.Drawing.Size(48, 20);
            this.tb_AdresseCRS.TabIndex = 10;
            this.tb_AdresseCRS.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // cb_Vote
            // 
            this.cb_Vote.FormattingEnabled = true;
            this.cb_Vote.Location = new System.Drawing.Point(43, 30);
            this.cb_Vote.Name = "cb_Vote";
            this.cb_Vote.Size = new System.Drawing.Size(121, 21);
            this.cb_Vote.TabIndex = 10;
            // 
            // bt_FV
            // 
            this.bt_FV.Location = new System.Drawing.Point(23, 144);
            this.bt_FV.Name = "bt_FV";
            this.bt_FV.Size = new System.Drawing.Size(85, 20);
            this.bt_FV.TabIndex = 10;
            this.bt_FV.Text = "VALIDER";
            this.bt_FV.UseVisualStyleBackColor = true;
            this.bt_FV.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // bt_FL
            // 
            this.bt_FL.Location = new System.Drawing.Point(31, 144);
            this.bt_FL.Name = "bt_FL";
            this.bt_FL.Size = new System.Drawing.Size(96, 20);
            this.bt_FL.TabIndex = 11;
            this.bt_FL.Text = "VALIDER";
            this.bt_FL.UseVisualStyleBackColor = true;
            // 
            // bt_R
            // 
            this.bt_R.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bt_R.Location = new System.Drawing.Point(29, 379);
            this.bt_R.Name = "bt_R";
            this.bt_R.Size = new System.Drawing.Size(141, 20);
            this.bt_R.TabIndex = 12;
            this.bt_R.Text = "VALIDER";
            this.bt_R.UseVisualStyleBackColor = true;
            this.bt_R.Click += new System.EventHandler(this.Button3_Click);
            // 
            // bt_Vote
            // 
            this.bt_Vote.Location = new System.Drawing.Point(43, 57);
            this.bt_Vote.Name = "bt_Vote";
            this.bt_Vote.Size = new System.Drawing.Size(121, 20);
            this.bt_Vote.TabIndex = 13;
            this.bt_Vote.Text = "VALIDER";
            this.bt_Vote.UseVisualStyleBackColor = true;
            // 
            // bt_Salle
            // 
            this.bt_Salle.Location = new System.Drawing.Point(225, 169);
            this.bt_Salle.Name = "bt_Salle";
            this.bt_Salle.Size = new System.Drawing.Size(75, 23);
            this.bt_Salle.TabIndex = 14;
            this.bt_Salle.Text = "VALIDER";
            this.bt_Salle.UseVisualStyleBackColor = true;
            this.bt_Salle.Click += new System.EventHandler(this.Bt_Salle_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rb_Osalle);
            this.panel1.Controls.Add(this.bt_Salle);
            this.panel1.Controls.Add(this.p_Osalle);
            this.panel1.Controls.Add(this.rb_Rsalle);
            this.panel1.Controls.Add(this.p_Rsalle);
            this.panel1.Location = new System.Drawing.Point(25, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 196);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Port:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Capacité:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Adresse Serveur:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Adresse Client:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Login:";
            // 
            // lb_Narration
            // 
            this.lb_Narration.FormattingEnabled = true;
            this.lb_Narration.Location = new System.Drawing.Point(22, 19);
            this.lb_Narration.Name = "lb_Narration";
            this.lb_Narration.Size = new System.Drawing.Size(149, 43);
            this.lb_Narration.TabIndex = 0;
            this.lb_Narration.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // tb_leMessageFV
            // 
            this.tb_leMessageFV.Location = new System.Drawing.Point(23, 120);
            this.tb_leMessageFV.Name = "tb_leMessageFV";
            this.tb_leMessageFV.Size = new System.Drawing.Size(85, 20);
            this.tb_leMessageFV.TabIndex = 16;
            this.tb_leMessageFV.Text = "";
            this.tb_leMessageFV.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // tb_leMessageFL
            // 
            this.tb_leMessageFL.Location = new System.Drawing.Point(31, 120);
            this.tb_leMessageFL.Name = "tb_leMessageFL";
            this.tb_leMessageFL.Size = new System.Drawing.Size(96, 20);
            this.tb_leMessageFL.TabIndex = 17;
            this.tb_leMessageFL.Text = "";
            this.tb_leMessageFL.TextChanged += new System.EventHandler(this.RichTextBox3_TextChanged);
            // 
            // tb_leMessageR
            // 
            this.tb_leMessageR.Location = new System.Drawing.Point(29, 357);
            this.tb_leMessageR.Name = "tb_leMessageR";
            this.tb_leMessageR.Size = new System.Drawing.Size(142, 20);
            this.tb_leMessageR.TabIndex = 17;
            this.tb_leMessageR.Text = "";
            this.tb_leMessageR.TextChanged += new System.EventHandler(this.RichTextBox4_TextChanged);
            // 
            // Plateforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_Reseau);
            this.Controls.Add(this.tc_Client);
            this.Name = "Plateforme";
            this.Text = "Loup Garou";
            this.Load += new System.EventHandler(this.Plateforme_Load);
            this.p_Osalle.ResumeLayout(false);
            this.p_Osalle.PerformLayout();
            this.p_Rsalle.ResumeLayout(false);
            this.p_Rsalle.PerformLayout();
            this.tc_Client.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gb_Narration.ResumeLayout(false);
            this.gb_ForumV.ResumeLayout(false);
            this.gb_Vote.ResumeLayout(false);
            this.gb_ForumL.ResumeLayout(false);
            this.gb_Reseau.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_Osalle;
        private System.Windows.Forms.RadioButton rb_Rsalle;
        private System.Windows.Forms.Panel p_Osalle;
        private System.Windows.Forms.Panel p_Rsalle;
        private System.Windows.Forms.TabControl tc_Client;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox gb_ForumV;
        private System.Windows.Forms.GroupBox gb_Narration;
        private System.Windows.Forms.GroupBox gb_Vote;
        private System.Windows.Forms.GroupBox gb_ForumL;
        private System.Windows.Forms.GroupBox gb_Reseau;
        private System.Windows.Forms.Label l_narration;
        private System.Windows.Forms.ListBox lb_lesMessagesFV;
        private System.Windows.Forms.ListBox lb_lesMessagesFL;
        private System.Windows.Forms.ListBox lb_lesMessagesR;
        private System.Windows.Forms.TextBox tb_AdresseSOS;
        private System.Windows.Forms.TextBox tb_PortPOS;
        private System.Windows.Forms.TextBox tb_Capacite;
        private System.Windows.Forms.TextBox tb_AdresseSRS;
        private System.Windows.Forms.TextBox tb_PortCRs;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.TextBox tb_AdresseCRS;
        private System.Windows.Forms.Button bt_FV;
        private System.Windows.Forms.ComboBox cb_Vote;
        private System.Windows.Forms.Button bt_Vote;
        private System.Windows.Forms.Button bt_FL;
        private System.Windows.Forms.Button bt_R;
        private System.Windows.Forms.Button bt_Salle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lb_Narration;
        private System.Windows.Forms.RichTextBox tb_leMessageFV;
        private System.Windows.Forms.RichTextBox tb_leMessageFL;
        private System.Windows.Forms.RichTextBox tb_leMessageR;
    }
}

