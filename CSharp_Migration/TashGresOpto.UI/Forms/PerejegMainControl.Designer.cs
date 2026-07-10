namespace TashGresOpto.UI.Forms
{
    partial class PerejegMainControl
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

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.btnDailyCalc = new System.Windows.Forms.Button();
            this.btnPrintDaily = new System.Windows.Forms.Button();
            this.btnPrintCumulative = new System.Windows.Forms.Button();
            this.btnViewDates = new System.Windows.Forms.Button();
            this.btnPrintBlank = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelDateInput = new System.Windows.Forms.Panel();
            this.lblDateTitle = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.btnDateOk = new System.Windows.Forms.Button();
            this.btnDateCancel = new System.Windows.Forms.Button();
            this.panelDataEntry = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnBackFromData = new System.Windows.Forms.Button();
            
            this.panelHeader.SuspendLayout();
            this.panelMainMenu.SuspendLayout();
            this.panelDateInput.SuspendLayout();
            this.panelDataEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            
            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Size = new System.Drawing.Size(1400, 60);
            
            // lblTitle
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Text = "";
            
            // panelMainMenu
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelMainMenu.Controls.Add(this.btnDailyCalc);
            this.panelMainMenu.Controls.Add(this.btnPrintDaily);
            this.panelMainMenu.Controls.Add(this.btnPrintCumulative);
            this.panelMainMenu.Controls.Add(this.btnViewDates);
            this.panelMainMenu.Controls.Add(this.btnPrintBlank);
            this.panelMainMenu.Controls.Add(this.btnBack);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            
            int menuY = 200;
            int menuX = 450;
            int menuSpacing = 70;
            
            // btnDailyCalc
            this.btnDailyCalc.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnDailyCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailyCalc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDailyCalc.ForeColor = System.Drawing.Color.White;
            this.btnDailyCalc.Location = new System.Drawing.Point(menuX, menuY);
            this.btnDailyCalc.Size = new System.Drawing.Size(500, 55);
            this.btnDailyCalc.Text = "";
            this.btnDailyCalc.Click += new System.EventHandler(this.btnDailyCalc_Click);
            
            // btnPrintDaily
            this.btnPrintDaily.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnPrintDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintDaily.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrintDaily.ForeColor = System.Drawing.Color.White;
            this.btnPrintDaily.Location = new System.Drawing.Point(menuX, menuY + menuSpacing);
            this.btnPrintDaily.Size = new System.Drawing.Size(500, 55);
            this.btnPrintDaily.Text = "";
            this.btnPrintDaily.Click += new System.EventHandler(this.btnPrintDaily_Click);
            
            // btnPrintCumulative
            this.btnPrintCumulative.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnPrintCumulative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintCumulative.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrintCumulative.ForeColor = System.Drawing.Color.White;
            this.btnPrintCumulative.Location = new System.Drawing.Point(menuX, menuY + menuSpacing * 2);
            this.btnPrintCumulative.Size = new System.Drawing.Size(500, 55);
            this.btnPrintCumulative.Text = "";
            this.btnPrintCumulative.Click += new System.EventHandler(this.btnPrintCumulative_Click);
            
            // btnViewDates
            this.btnViewDates.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnViewDates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDates.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewDates.ForeColor = System.Drawing.Color.White;
            this.btnViewDates.Location = new System.Drawing.Point(menuX, menuY + menuSpacing * 3);
            this.btnViewDates.Size = new System.Drawing.Size(500, 55);
            this.btnViewDates.Text = "";
            this.btnViewDates.Click += new System.EventHandler(this.btnViewDates_Click);
            
            // btnPrintBlank
            this.btnPrintBlank.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnPrintBlank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintBlank.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrintBlank.ForeColor = System.Drawing.Color.White;
            this.btnPrintBlank.Location = new System.Drawing.Point(menuX, menuY + menuSpacing * 4);
            this.btnPrintBlank.Size = new System.Drawing.Size(500, 55);
            this.btnPrintBlank.Text = "";
            this.btnPrintBlank.Click += new System.EventHandler(this.btnPrintBlank_Click);
            
            // btnBack
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(menuX, menuY + menuSpacing * 5);
            this.btnBack.Size = new System.Drawing.Size(500, 55);
            this.btnBack.Text = "";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            
            // panelDateInput
            this.panelDateInput.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelDateInput.Controls.Add(this.lblDateTitle);
            this.panelDateInput.Controls.Add(this.dtpDate);
            this.panelDateInput.Controls.Add(this.lblDateTo);
            this.panelDateInput.Controls.Add(this.dtpDateEnd);
            this.panelDateInput.Controls.Add(this.btnDateOk);
            this.panelDateInput.Controls.Add(this.btnDateCancel);
            this.panelDateInput.Visible = false;
            this.panelDateInput.Dock = System.Windows.Forms.DockStyle.Fill;
            
            // lblDateTitle
            this.lblDateTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDateTitle.Location = new System.Drawing.Point(200, 250);
            this.lblDateTitle.Size = new System.Drawing.Size(1000, 30);
            this.lblDateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDateTitle.Text = "";
            
            // dtpDate
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(500, 300);
            this.dtpDate.Size = new System.Drawing.Size(200, 30);
            
            // lblDateTo
            this.lblDateTo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDateTo.Location = new System.Drawing.Point(710, 300);
            this.lblDateTo.Size = new System.Drawing.Size(80, 30);
            this.lblDateTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDateTo.Text = "по";
            
            // dtpDateEnd
            this.dtpDateEnd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEnd.Location = new System.Drawing.Point(800, 300);
            this.dtpDateEnd.Size = new System.Drawing.Size(200, 30);
            
            // btnDateOk
            this.btnDateOk.BackColor = System.Drawing.Color.FromArgb(28, 151, 99);
            this.btnDateOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateOk.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDateOk.ForeColor = System.Drawing.Color.White;
            this.btnDateOk.Location = new System.Drawing.Point(550, 370);
            this.btnDateOk.Size = new System.Drawing.Size(150, 45);
            this.btnDateOk.Text = "OK";
            this.btnDateOk.Click += new System.EventHandler(this.btnDateOk_Click);
            
            // btnDateCancel
            this.btnDateCancel.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnDateCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDateCancel.ForeColor = System.Drawing.Color.White;
            this.btnDateCancel.Location = new System.Drawing.Point(720, 370);
            this.btnDateCancel.Size = new System.Drawing.Size(150, 45);
            this.btnDateCancel.Text = "ОТМЕНА";
            this.btnDateCancel.Click += new System.EventHandler(this.btnDateCancel_Click);
            
            // panelDataEntry
            this.panelDataEntry.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelDataEntry.Controls.Add(this.dgvData);
            this.panelDataEntry.Controls.Add(this.btnSaveData);
            this.panelDataEntry.Controls.Add(this.btnBackFromData);
            this.panelDataEntry.Visible = false;
            this.panelDataEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            
            // dgvData
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.Location = new System.Drawing.Point(50, 20);
            this.dgvData.Size = new System.Drawing.Size(1300, 680);
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            
            // btnSaveData
            this.btnSaveData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveData.BackColor = System.Drawing.Color.FromArgb(28, 151, 99);
            this.btnSaveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSaveData.ForeColor = System.Drawing.Color.White;
            this.btnSaveData.Location = new System.Drawing.Point(500, 720);
            this.btnSaveData.Size = new System.Drawing.Size(180, 45);
            this.btnSaveData.Text = "СОХРАНИТЬ";
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            
            // btnBackFromData
            this.btnBackFromData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBackFromData.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnBackFromData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackFromData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBackFromData.ForeColor = System.Drawing.Color.White;
            this.btnBackFromData.Location = new System.Drawing.Point(720, 720);
            this.btnBackFromData.Size = new System.Drawing.Size(180, 45);
            this.btnBackFromData.Text = "НАЗАД";
            this.btnBackFromData.Click += new System.EventHandler(this.btnBackFromData_Click);
            
            // PerejegMainControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelDateInput);
            this.Controls.Add(this.panelDataEntry);
            this.Controls.Add(this.panelHeader);
            this.Size = new System.Drawing.Size(1400, 900);
            
            this.panelHeader.ResumeLayout(false);
            this.panelMainMenu.ResumeLayout(false);
            this.panelDateInput.ResumeLayout(false);
            this.panelDataEntry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
        }

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelMainMenu;
        private Button btnDailyCalc;
        private Button btnPrintDaily;
        private Button btnPrintCumulative;
        private Button btnViewDates;
        private Button btnPrintBlank;
        private Button btnBack;
        private Panel panelDateInput;
        private Label lblDateTitle;
        private DateTimePicker dtpDate;
        private Label lblDateTo;
        private DateTimePicker dtpDateEnd;
        private Button btnDateOk;
        private Button btnDateCancel;
        private Panel panelDataEntry;
        private DataGridView dgvData;
        private Button btnSaveData;
        private Button btnBackFromData;
    }
}
