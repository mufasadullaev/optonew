namespace TashGresOpto.UI.Forms
{
    partial class O2GolMainControl
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
            this.panelDateInput = new System.Windows.Forms.Panel();
            this.lblDateInputTitle = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblLoading = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelReport = new System.Windows.Forms.Panel();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.lblByBlock = new System.Windows.Forms.Label();
            this.dgvByBlock = new System.Windows.Forms.DataGridView();
            this.lblByShift = new System.Windows.Forms.Label();
            this.dgvByShift = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBackFromReport = new System.Windows.Forms.Button();
            
            this.panelHeader.SuspendLayout();
            this.panelDateInput.SuspendLayout();
            this.panelReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvByBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvByShift)).BeginInit();
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
            
            // panelDateInput
            this.panelDateInput.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelDateInput.Controls.Add(this.lblDateInputTitle);
            this.panelDateInput.Controls.Add(this.lblStartDate);
            this.panelDateInput.Controls.Add(this.dtpStartDate);
            this.panelDateInput.Controls.Add(this.lblEndDate);
            this.panelDateInput.Controls.Add(this.dtpEndDate);
            this.panelDateInput.Controls.Add(this.lblLoading);
            this.panelDateInput.Controls.Add(this.btnGenerate);
            this.panelDateInput.Controls.Add(this.btnBack);
            this.panelDateInput.Dock = System.Windows.Forms.DockStyle.Fill;
            
            // lblDateInputTitle
            this.lblDateInputTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDateInputTitle.Location = new System.Drawing.Point(200, 200);
            this.lblDateInputTitle.Size = new System.Drawing.Size(1000, 30);
            this.lblDateInputTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDateInputTitle.Text = "";
            
            // lblStartDate
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStartDate.Location = new System.Drawing.Point(400, 270);
            this.lblStartDate.Size = new System.Drawing.Size(50, 30);
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStartDate.Text = "";
            
            // dtpStartDate
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(460, 270);
            this.dtpStartDate.Size = new System.Drawing.Size(200, 30);
            
            // lblEndDate
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEndDate.Location = new System.Drawing.Point(680, 270);
            this.lblEndDate.Size = new System.Drawing.Size(50, 30);
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEndDate.Text = "";
            
            // dtpEndDate
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(740, 270);
            this.dtpEndDate.Size = new System.Drawing.Size(200, 30);
            
            // lblLoading
            this.lblLoading.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblLoading.ForeColor = System.Drawing.Color.Red;
            this.lblLoading.Location = new System.Drawing.Point(200, 330);
            this.lblLoading.Size = new System.Drawing.Size(1000, 60);
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoading.Text = "";
            this.lblLoading.Visible = false;
            
            // btnGenerate
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(28, 151, 99);
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(500, 420);
            this.btnGenerate.Size = new System.Drawing.Size(250, 55);
            this.btnGenerate.Text = "";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            
            // btnBack
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(500, 500);
            this.btnBack.Size = new System.Drawing.Size(250, 55);
            this.btnBack.Text = "";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            
            // panelReport
            this.panelReport.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelReport.Controls.Add(this.lblReportTitle);
            this.panelReport.Controls.Add(this.lblByBlock);
            this.panelReport.Controls.Add(this.dgvByBlock);
            this.panelReport.Controls.Add(this.lblByShift);
            this.panelReport.Controls.Add(this.dgvByShift);
            this.panelReport.Controls.Add(this.btnPrint);
            this.panelReport.Controls.Add(this.btnBackFromReport);
            this.panelReport.Visible = false;
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            
            // lblReportTitle
            this.lblReportTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblReportTitle.Location = new System.Drawing.Point(50, 10);
            this.lblReportTitle.Size = new System.Drawing.Size(1300, 30);
            this.lblReportTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReportTitle.Text = "";
            
            // lblByBlock
            this.lblByBlock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblByBlock.Location = new System.Drawing.Point(50, 50);
            this.lblByBlock.Size = new System.Drawing.Size(300, 25);
            this.lblByBlock.Text = "РАСХОД ПО БЛОКАМ:";
            
            // dgvByBlock
            this.dgvByBlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvByBlock.Location = new System.Drawing.Point(50, 80);
            this.dgvByBlock.Size = new System.Drawing.Size(1300, 300);
            this.dgvByBlock.AllowUserToAddRows = false;
            this.dgvByBlock.AllowUserToDeleteRows = false;
            this.dgvByBlock.ReadOnly = true;
            
            // lblByShift
            this.lblByShift.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblByShift.Location = new System.Drawing.Point(50, 390);
            this.lblByShift.Size = new System.Drawing.Size(300, 25);
            this.lblByShift.Text = "РАСХОД ПО ВАХТАМ:";
            
            // dgvByShift
            this.dgvByShift.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvByShift.Location = new System.Drawing.Point(50, 420);
            this.dgvByShift.Size = new System.Drawing.Size(1300, 280);
            this.dgvByShift.AllowUserToAddRows = false;
            this.dgvByShift.AllowUserToDeleteRows = false;
            this.dgvByShift.ReadOnly = true;
            
            // btnPrint
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(500, 720);
            this.btnPrint.Size = new System.Drawing.Size(180, 45);
            this.btnPrint.Text = "";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            
            // btnBackFromReport
            this.btnBackFromReport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBackFromReport.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnBackFromReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackFromReport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBackFromReport.ForeColor = System.Drawing.Color.White;
            this.btnBackFromReport.Location = new System.Drawing.Point(720, 720);
            this.btnBackFromReport.Size = new System.Drawing.Size(180, 45);
            this.btnBackFromReport.Text = "";
            this.btnBackFromReport.Click += new System.EventHandler(this.btnBackFromReport_Click);
            
            // O2GolMainControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.Controls.Add(this.panelDateInput);
            this.Controls.Add(this.panelReport);
            this.Controls.Add(this.panelHeader);
            this.Size = new System.Drawing.Size(1400, 900);
            
            this.panelHeader.ResumeLayout(false);
            this.panelDateInput.ResumeLayout(false);
            this.panelReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvByBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvByShift)).EndInit();
            this.ResumeLayout(false);
        }

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelDateInput;
        private Label lblDateInputTitle;
        private Label lblStartDate;
        private DateTimePicker dtpStartDate;
        private Label lblEndDate;
        private DateTimePicker dtpEndDate;
        private Label lblLoading;
        private Button btnGenerate;
        private Button btnBack;
        private Panel panelReport;
        private Label lblReportTitle;
        private Label lblByBlock;
        private DataGridView dgvByBlock;
        private Label lblByShift;
        private DataGridView dgvByShift;
        private Button btnPrint;
        private Button btnBackFromReport;
    }
}
