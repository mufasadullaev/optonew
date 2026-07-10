namespace TashGresOpto.UI.Forms
{
    partial class WyrabotkaMainControl
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelDateInput = new System.Windows.Forms.Panel();
            this.lblDateTitle = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateWarning = new System.Windows.Forms.Label();
            this.btnDateOk = new System.Windows.Forms.Button();
            this.btnDateCancel = new System.Windows.Forms.Button();
            this.panelCalcType = new System.Windows.Forms.Panel();
            this.lblCalcTypeTitle = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnRecalc = new System.Windows.Forms.Button();
            this.btnCalcTypeCancel = new System.Windows.Forms.Button();
            this.panelDataEntry = new System.Windows.Forms.Panel();
            this.lblDataTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCalculateData = new System.Windows.Forms.Button();
            this.btnDataCancel = new System.Windows.Forms.Button();
            
            this.panelHeader.SuspendLayout();
            this.panelMainMenu.SuspendLayout();
            this.panelDateInput.SuspendLayout();
            this.panelCalcType.SuspendLayout();
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
            this.panelMainMenu.Controls.Add(this.btnCalculate);
            this.panelMainMenu.Controls.Add(this.btnCopy);
            this.panelMainMenu.Controls.Add(this.btnPrint);
            this.panelMainMenu.Controls.Add(this.btnBack);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            
            int menuY = 280;
            int menuX = 500;
            int menuSpacing = 80;
            
            // btnCalculate
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(menuX, menuY);
            this.btnCalculate.Size = new System.Drawing.Size(400, 60);
            this.btnCalculate.Text = "";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            
            // btnCopy
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Location = new System.Drawing.Point(menuX, menuY + menuSpacing);
            this.btnCopy.Size = new System.Drawing.Size(400, 60);
            this.btnCopy.Text = "";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            
            // btnPrint
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(menuX, menuY + menuSpacing * 2);
            this.btnPrint.Size = new System.Drawing.Size(400, 60);
            this.btnPrint.Text = "";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            
            // btnBack
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(menuX, menuY + menuSpacing * 3);
            this.btnBack.Size = new System.Drawing.Size(400, 60);
            this.btnBack.Text = "";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            
            // panelDateInput
            this.panelDateInput.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelDateInput.Controls.Add(this.lblDateTitle);
            this.panelDateInput.Controls.Add(this.dtpDate);
            this.panelDateInput.Controls.Add(this.lblDateWarning);
            this.panelDateInput.Controls.Add(this.btnDateOk);
            this.panelDateInput.Controls.Add(this.btnDateCancel);
            this.panelDateInput.Visible = false;
            this.panelDateInput.Dock = System.Windows.Forms.DockStyle.Fill;
            
            // lblDateTitle
            this.lblDateTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDateTitle.Location = new System.Drawing.Point(300, 250);
            this.lblDateTitle.Size = new System.Drawing.Size(800, 30);
            this.lblDateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDateTitle.Text = "Укажите дату: ДД, ММ, ГГГГ";
            
            // dtpDate
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(600, 300);
            this.dtpDate.Size = new System.Drawing.Size(200, 30);
            
            // lblDateWarning
            this.lblDateWarning.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDateWarning.ForeColor = System.Drawing.Color.Red;
            this.lblDateWarning.Location = new System.Drawing.Point(300, 340);
            this.lblDateWarning.Size = new System.Drawing.Size(800, 60);
            this.lblDateWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDateWarning.Text = "Внимание! Это 1-е число месяца.";
            this.lblDateWarning.Visible = false;
            
            // btnDateOk
            this.btnDateOk.BackColor = System.Drawing.Color.FromArgb(28, 151, 99);
            this.btnDateOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateOk.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDateOk.ForeColor = System.Drawing.Color.White;
            this.btnDateOk.Location = new System.Drawing.Point(550, 420);
            this.btnDateOk.Size = new System.Drawing.Size(150, 45);
            this.btnDateOk.Text = "OK";
            this.btnDateOk.Click += new System.EventHandler(this.btnDateOk_Click);
            
            // btnDateCancel
            this.btnDateCancel.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnDateCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDateCancel.ForeColor = System.Drawing.Color.White;
            this.btnDateCancel.Location = new System.Drawing.Point(720, 420);
            this.btnDateCancel.Size = new System.Drawing.Size(150, 45);
            this.btnDateCancel.Text = "ОТМЕНА";
            this.btnDateCancel.Click += new System.EventHandler(this.btnDateCancel_Click);
            
            // panelCalcType
            this.panelCalcType.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelCalcType.Controls.Add(this.lblCalcTypeTitle);
            this.panelCalcType.Controls.Add(this.btnCalc);
            this.panelCalcType.Controls.Add(this.btnRecalc);
            this.panelCalcType.Controls.Add(this.btnCalcTypeCancel);
            this.panelCalcType.Visible = false;
            this.panelCalcType.Dock = System.Windows.Forms.DockStyle.Fill;
            
            // lblCalcTypeTitle
            this.lblCalcTypeTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCalcTypeTitle.Location = new System.Drawing.Point(300, 250);
            this.lblCalcTypeTitle.Size = new System.Drawing.Size(800, 30);
            this.lblCalcTypeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCalcTypeTitle.Text = "";
            
            // btnCalc
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(28, 151, 99);
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.Location = new System.Drawing.Point(450, 320);
            this.btnCalc.Size = new System.Drawing.Size(200, 55);
            this.btnCalc.Text = "РАСЧ";
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            
            // btnRecalc
            this.btnRecalc.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnRecalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecalc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRecalc.ForeColor = System.Drawing.Color.White;
            this.btnRecalc.Location = new System.Drawing.Point(750, 320);
            this.btnRecalc.Size = new System.Drawing.Size(200, 55);
            this.btnRecalc.Text = "ПЕРЕ";
            this.btnRecalc.Click += new System.EventHandler(this.btnRecalc_Click);
            
            // btnCalcTypeCancel
            this.btnCalcTypeCancel.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnCalcTypeCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcTypeCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCalcTypeCancel.ForeColor = System.Drawing.Color.White;
            this.btnCalcTypeCancel.Location = new System.Drawing.Point(600, 400);
            this.btnCalcTypeCancel.Size = new System.Drawing.Size(200, 45);
            this.btnCalcTypeCancel.Text = "ОТМЕНА";
            this.btnCalcTypeCancel.Click += new System.EventHandler(this.btnCalcTypeCancel_Click);
            
            // panelDataEntry
            this.panelDataEntry.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelDataEntry.Controls.Add(this.lblDataTitle);
            this.panelDataEntry.Controls.Add(this.lblDate);
            this.panelDataEntry.Controls.Add(this.lblDateValue);
            this.panelDataEntry.Controls.Add(this.dgvData);
            this.panelDataEntry.Controls.Add(this.btnSave);
            this.panelDataEntry.Controls.Add(this.btnCalculateData);
            this.panelDataEntry.Controls.Add(this.btnDataCancel);
            this.panelDataEntry.Visible = false;
            this.panelDataEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            
            // lblDataTitle
            this.lblDataTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblDataTitle.Location = new System.Drawing.Point(50, 20);
            this.lblDataTitle.Size = new System.Drawing.Size(600, 30);
            this.lblDataTitle.Text = "";
            
            // lblDate
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(700, 25);
            this.lblDate.Size = new System.Drawing.Size(100, 25);
            this.lblDate.Text = "Дата:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            
            // lblDateValue
            this.lblDateValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDateValue.Location = new System.Drawing.Point(810, 25);
            this.lblDateValue.Size = new System.Drawing.Size(200, 25);
            this.lblDateValue.Text = "";
            
            // dgvData
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.Location = new System.Drawing.Point(50, 70);
            this.dgvData.Size = new System.Drawing.Size(1300, 650);
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            
            // btnSave
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(28, 151, 99);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(400, 740);
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.Text = "СОХРАНИТЬ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            
            // btnCalculateData
            this.btnCalculateData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCalculateData.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnCalculateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCalculateData.ForeColor = System.Drawing.Color.White;
            this.btnCalculateData.Location = new System.Drawing.Point(610, 740);
            this.btnCalculateData.Size = new System.Drawing.Size(180, 45);
            this.btnCalculateData.Text = "РАССЧИТАТЬ";
            this.btnCalculateData.Click += new System.EventHandler(this.btnCalculateData_Click);
            
            // btnDataCancel
            this.btnDataCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDataCancel.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnDataCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDataCancel.ForeColor = System.Drawing.Color.White;
            this.btnDataCancel.Location = new System.Drawing.Point(820, 740);
            this.btnDataCancel.Size = new System.Drawing.Size(180, 45);
            this.btnDataCancel.Text = "ОТМЕНА";
            this.btnDataCancel.Click += new System.EventHandler(this.btnDataCancel_Click);
            
            // WyrabotkaMainControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelDateInput);
            this.Controls.Add(this.panelCalcType);
            this.Controls.Add(this.panelDataEntry);
            this.Controls.Add(this.panelHeader);
            this.Size = new System.Drawing.Size(1400, 900);
            
            this.panelHeader.ResumeLayout(false);
            this.panelMainMenu.ResumeLayout(false);
            this.panelDateInput.ResumeLayout(false);
            this.panelCalcType.ResumeLayout(false);
            this.panelDataEntry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
        }

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelMainMenu;
        private Button btnCalculate;
        private Button btnCopy;
        private Button btnPrint;
        private Button btnBack;
        private Panel panelDateInput;
        private Label lblDateTitle;
        private DateTimePicker dtpDate;
        private Label lblDateWarning;
        private Button btnDateOk;
        private Button btnDateCancel;
        private Panel panelCalcType;
        private Label lblCalcTypeTitle;
        private Button btnCalc;
        private Button btnRecalc;
        private Button btnCalcTypeCancel;
        private Panel panelDataEntry;
        private Label lblDataTitle;
        private Label lblDate;
        private Label lblDateValue;
        private DataGridView dgvData;
        private Button btnSave;
        private Button btnCalculateData;
        private Button btnDataCancel;
    }
}
