namespace TashGresOpto.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.groupDaily = new System.Windows.Forms.GroupBox();
            this.btnWyrabotka = new System.Windows.Forms.Button();
            this.btnPerejeg = new System.Windows.Forms.Button();
            this.btnBaxta = new System.Windows.Forms.Button();
            this.groupWeekly = new System.Windows.Forms.GroupBox();
            this.btnO2Gol = new System.Windows.Forms.Button();
            this.groupMonthly = new System.Windows.Forms.GroupBox();
            this.btnWymes = new System.Windows.Forms.Button();
            this.btnSelektor = new System.Windows.Forms.Button();
            this.btnAkt = new System.Windows.Forms.Button();
            this.groupOther = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnCopdata = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.groupDaily.SuspendLayout();
            this.groupWeekly.SuspendLayout();
            this.groupMonthly.SuspendLayout();
            this.groupOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1184, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1160, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.groupOther);
            this.panelMenu.Controls.Add(this.groupMonthly);
            this.panelMenu.Controls.Add(this.groupWeekly);
            this.panelMenu.Controls.Add(this.groupDaily);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 80);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(20);
            this.panelMenu.Size = new System.Drawing.Size(1184, 681);
            this.panelMenu.TabIndex = 1;
            // 
            // groupDaily
            // 
            this.groupDaily.Controls.Add(this.btnWyrabotka);
            this.groupDaily.Controls.Add(this.btnPerejeg);
            this.groupDaily.Controls.Add(this.btnBaxta);
            this.groupDaily.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupDaily.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.groupDaily.Location = new System.Drawing.Point(40, 40);
            this.groupDaily.Name = "groupDaily";
            this.groupDaily.Size = new System.Drawing.Size(520, 200);
            this.groupDaily.TabIndex = 0;
            this.groupDaily.TabStop = false;
            this.groupDaily.Text = "";
            // 
            // btnBaxta
            // 
            this.btnBaxta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBaxta.FlatAppearance.BorderSize = 0;
            this.btnBaxta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaxta.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBaxta.ForeColor = System.Drawing.Color.White;
            this.btnBaxta.Location = new System.Drawing.Point(20, 40);
            this.btnBaxta.Name = "btnBaxta";
            this.btnBaxta.Size = new System.Drawing.Size(480, 40);
            this.btnBaxta.TabIndex = 0;
            this.btnBaxta.Text = "";
            this.btnBaxta.UseVisualStyleBackColor = false;
            this.btnBaxta.Click += new System.EventHandler(this.btnBaxta_Click);
            // 
            // btnPerejeg
            // 
            this.btnPerejeg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPerejeg.FlatAppearance.BorderSize = 0;
            this.btnPerejeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerejeg.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPerejeg.ForeColor = System.Drawing.Color.White;
            this.btnPerejeg.Location = new System.Drawing.Point(20, 90);
            this.btnPerejeg.Name = "btnPerejeg";
            this.btnPerejeg.Size = new System.Drawing.Size(480, 40);
            this.btnPerejeg.TabIndex = 1;
            this.btnPerejeg.Text = "";
            this.btnPerejeg.UseVisualStyleBackColor = false;
            this.btnPerejeg.Click += new System.EventHandler(this.btnPerejeg_Click);
            // 
            // btnWyrabotka
            // 
            this.btnWyrabotka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnWyrabotka.FlatAppearance.BorderSize = 0;
            this.btnWyrabotka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWyrabotka.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnWyrabotka.ForeColor = System.Drawing.Color.White;
            this.btnWyrabotka.Location = new System.Drawing.Point(20, 140);
            this.btnWyrabotka.Name = "btnWyrabotka";
            this.btnWyrabotka.Size = new System.Drawing.Size(480, 40);
            this.btnWyrabotka.TabIndex = 2;
            this.btnWyrabotka.Text = "";
            this.btnWyrabotka.UseVisualStyleBackColor = false;
            this.btnWyrabotka.Click += new System.EventHandler(this.btnWyrabotka_Click);
            // 
            // groupWeekly
            // 
            this.groupWeekly.Controls.Add(this.btnO2Gol);
            this.groupWeekly.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupWeekly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.groupWeekly.Location = new System.Drawing.Point(600, 40);
            this.groupWeekly.Name = "groupWeekly";
            this.groupWeekly.Size = new System.Drawing.Size(520, 100);
            this.groupWeekly.TabIndex = 1;
            this.groupWeekly.TabStop = false;
            this.groupWeekly.Text = "";
            // 
            // btnO2Gol
            // 
            this.btnO2Gol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(99)))));
            this.btnO2Gol.FlatAppearance.BorderSize = 0;
            this.btnO2Gol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnO2Gol.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnO2Gol.ForeColor = System.Drawing.Color.White;
            this.btnO2Gol.Location = new System.Drawing.Point(20, 40);
            this.btnO2Gol.Name = "btnO2Gol";
            this.btnO2Gol.Size = new System.Drawing.Size(480, 40);
            this.btnO2Gol.TabIndex = 0;
            this.btnO2Gol.Text = "";
            this.btnO2Gol.UseVisualStyleBackColor = false;
            this.btnO2Gol.Click += new System.EventHandler(this.btnO2Gol_Click);
            // 
            // groupMonthly
            // 
            this.groupMonthly.Controls.Add(this.btnWymes);
            this.groupMonthly.Controls.Add(this.btnSelektor);
            this.groupMonthly.Controls.Add(this.btnAkt);
            this.groupMonthly.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupMonthly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.groupMonthly.Location = new System.Drawing.Point(40, 260);
            this.groupMonthly.Name = "groupMonthly";
            this.groupMonthly.Size = new System.Drawing.Size(520, 250);
            this.groupMonthly.TabIndex = 2;
            this.groupMonthly.TabStop = false;
            this.groupMonthly.Text = "";
            // 
            // btnAkt
            // 
            this.btnAkt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnAkt.FlatAppearance.BorderSize = 0;
            this.btnAkt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAkt.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAkt.ForeColor = System.Drawing.Color.White;
            this.btnAkt.Location = new System.Drawing.Point(20, 40);
            this.btnAkt.Name = "btnAkt";
            this.btnAkt.Size = new System.Drawing.Size(480, 40);
            this.btnAkt.TabIndex = 0;
            this.btnAkt.Text = "";
            this.btnAkt.UseVisualStyleBackColor = false;
            this.btnAkt.Click += new System.EventHandler(this.btnAkt_Click);
            // 
            // btnSelektor
            // 
            this.btnSelektor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnSelektor.FlatAppearance.BorderSize = 0;
            this.btnSelektor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelektor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSelektor.ForeColor = System.Drawing.Color.White;
            this.btnSelektor.Location = new System.Drawing.Point(20, 90);
            this.btnSelektor.Name = "btnSelektor";
            this.btnSelektor.Size = new System.Drawing.Size(480, 40);
            this.btnSelektor.TabIndex = 1;
            this.btnSelektor.Text = "";
            this.btnSelektor.UseVisualStyleBackColor = false;
            this.btnSelektor.Click += new System.EventHandler(this.btnSelektor_Click);
            // 
            // btnWymes
            // 
            this.btnWymes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnWymes.FlatAppearance.BorderSize = 0;
            this.btnWymes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWymes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnWymes.ForeColor = System.Drawing.Color.White;
            this.btnWymes.Location = new System.Drawing.Point(20, 160);
            this.btnWymes.Name = "btnWymes";
            this.btnWymes.Size = new System.Drawing.Size(480, 60);
            this.btnWymes.TabIndex = 2;
            this.btnWymes.Text = "";
            this.btnWymes.UseVisualStyleBackColor = false;
            this.btnWymes.Click += new System.EventHandler(this.btnWymes_Click);
            // 
            // groupOther
            // 
            this.groupOther.Controls.Add(this.btnHelp);
            this.groupOther.Controls.Add(this.btnCopdata);
            this.groupOther.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupOther.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.groupOther.Location = new System.Drawing.Point(600, 160);
            this.groupOther.Name = "groupOther";
            this.groupOther.Size = new System.Drawing.Size(520, 160);
            this.groupOther.TabIndex = 3;
            this.groupOther.TabStop = false;
            this.groupOther.Text = "";
            // 
            // btnCopdata
            // 
            this.btnCopdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnCopdata.FlatAppearance.BorderSize = 0;
            this.btnCopdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopdata.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCopdata.ForeColor = System.Drawing.Color.White;
            this.btnCopdata.Location = new System.Drawing.Point(20, 40);
            this.btnCopdata.Name = "btnCopdata";
            this.btnCopdata.Size = new System.Drawing.Size(480, 40);
            this.btnCopdata.TabIndex = 0;
            this.btnCopdata.Text = "";
            this.btnCopdata.UseVisualStyleBackColor = false;
            this.btnCopdata.Click += new System.EventHandler(this.btnCopdata_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(20, 90);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(480, 40);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.MinimumSize = new System.Drawing.Size(1400, 900);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.Name = "MainForm";
            this.Text = "";
            this.panelHeader.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.groupDaily.ResumeLayout(false);
            this.groupWeekly.ResumeLayout(false);
            this.groupMonthly.ResumeLayout(false);
            this.groupOther.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelMenu;
        private GroupBox groupDaily;
        private Button btnWyrabotka;
        private Button btnPerejeg;
        private Button btnBaxta;
        private GroupBox groupWeekly;
        private Button btnO2Gol;
        private GroupBox groupMonthly;
        private Button btnWymes;
        private Button btnSelektor;
        private Button btnAkt;
        private GroupBox groupOther;
        private Button btnHelp;
        private Button btnCopdata;
    }
}
