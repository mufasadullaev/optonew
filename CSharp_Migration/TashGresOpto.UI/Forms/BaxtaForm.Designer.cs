namespace TashGresOpto.UI.Forms
{
    partial class BaxtaForm
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
            
            // === ГЛАВНОЕ МЕНЮ ===
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.btnViewSchedule = new System.Windows.Forms.Button();
            this.btnEditData = new System.Windows.Forms.Button();
            this.btnPrintForms = new System.Windows.Forms.Button();
            this.btnCloseMain = new System.Windows.Forms.Button();
            
            // === ПАНЕЛЬ ВЫБОРА ДАТЫ ===
            this.panelDateSelection = new System.Windows.Forms.Panel();
            this.lblDateTitle = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblCalcType = new System.Windows.Forms.Label();
            this.btnFirstCalc = new System.Windows.Forms.Button();
            this.btnRepeatCalc = new System.Windows.Forms.Button();
            this.btnCancelDate = new System.Windows.Forms.Button();
            
            // === ПАНЕЛЬ РЕДАКТИРОВАНИЯ ДАННЫХ ===
            this.panelDataEntry = new System.Windows.Forms.Panel();
            this.lblDataTitle = new System.Windows.Forms.Label();
            this.lblEditDate = new System.Windows.Forms.Label();
            this.lblEditDateValue = new System.Windows.Forms.Label();
            
            // Таблица счетчиков
            this.groupCounters = new System.Windows.Forms.GroupBox();
            this.lblBlockHeader = new System.Windows.Forms.Label();
            this.lblShiftHeader = new System.Windows.Forms.Label();
            this.lblCountersHeader = new System.Windows.Forms.Label();
            this.lblOutputHeader = new System.Windows.Forms.Label();
            this.lblSNHeader = new System.Windows.Forms.Label();
            this.dgvCounters = new System.Windows.Forms.DataGridView();
            
            // Технологические параметры
            this.groupParams = new System.Windows.Forms.GroupBox();
            this.lblParamsTitle = new System.Windows.Forms.Label();
            this.lblTim = new System.Windows.Forms.Label();
            this.numTim = new System.Windows.Forms.NumericUpDown();
            this.lblDro = new System.Windows.Forms.Label();
            this.numDro = new System.Windows.Forms.NumericUpDown();
            this.lblPwd = new System.Windows.Forms.Label();
            this.numPwd = new System.Windows.Forms.NumericUpDown();
            this.lblTpw = new System.Windows.Forms.Label();
            this.numTpw = new System.Windows.Forms.NumericUpDown();
            this.lblTk = new System.Windows.Forms.Label();
            this.numTk = new System.Windows.Forms.NumericUpDown();
            this.lblTop = new System.Windows.Forms.Label();
            this.numTop = new System.Windows.Forms.NumericUpDown();
            this.lblTpp = new System.Windows.Forms.Label();
            this.numTpp = new System.Windows.Forms.NumericUpDown();
            this.lblPop = new System.Windows.Forms.Label();
            this.numPop = new System.Windows.Forms.NumericUpDown();
            this.lblTug = new System.Windows.Forms.Label();
            this.numTug = new System.Windows.Forms.NumericUpDown();
            this.lblThw = new System.Windows.Forms.Label();
            this.numThw = new System.Windows.Forms.NumericUpDown();
            this.lblO2 = new System.Windows.Forms.Label();
            this.numO2 = new System.Windows.Forms.NumericUpDown();
            this.lblTn = new System.Windows.Forms.Label();
            this.numTn = new System.Windows.Forms.NumericUpDown();
            
            // Результаты
            this.groupResults = new System.Windows.Forms.GroupBox();
            this.lblResultsTitle = new System.Windows.Forms.Label();
            this.lblPugResult = new System.Windows.Forms.Label();
            this.txtPugResult = new System.Windows.Forms.TextBox();
            this.lblWakResult = new System.Windows.Forms.Label();
            this.txtWakResult = new System.Windows.Forms.TextBox();
            this.lblDopResult = new System.Windows.Forms.Label();
            this.txtDopResult = new System.Windows.Forms.TextBox();
            this.lblTopResult = new System.Windows.Forms.Label();
            this.txtTopResult = new System.Windows.Forms.TextBox();
            this.lblTppResult = new System.Windows.Forms.Label();
            this.txtTppResult = new System.Windows.Forms.TextBox();
            this.lblSnResult = new System.Windows.Forms.Label();
            this.txtSnResult = new System.Windows.Forms.TextBox();
            this.lblTpwResult = new System.Windows.Forms.Label();
            this.txtTpwResult = new System.Windows.Forms.TextBox();
            this.lblTotalResult = new System.Windows.Forms.Label();
            this.txtTotalResult = new System.Windows.Forms.TextBox();
            this.lblGkbtResult = new System.Windows.Forms.Label();
            this.txtGkbtResult = new System.Windows.Forms.TextBox();
            
            // Кнопки управления
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnContinueEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            
            this.panelHeader.SuspendLayout();
            this.panelMainMenu.SuspendLayout();
            this.panelDateSelection.SuspendLayout();
            this.panelDataEntry.SuspendLayout();
            this.groupCounters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounters)).BeginInit();
            this.groupParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTpw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTpp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTn)).BeginInit();
            this.groupResults.SuspendLayout();
            this.SuspendLayout();
            
            // ========== HEADER ==========
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Size = new System.Drawing.Size(1400, 60);
            
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Size = new System.Drawing.Size(1360, 35);
            this.lblTitle.Text = "";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // ========== ГЛАВНОЕ МЕНЮ ==========
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelMainMenu.Controls.Add(this.btnViewSchedule);
            this.panelMainMenu.Controls.Add(this.btnEditData);
            this.panelMainMenu.Controls.Add(this.btnPrintForms);
            this.panelMainMenu.Controls.Add(this.btnCloseMain);
            this.panelMainMenu.Location = new System.Drawing.Point(0, 60);
            this.panelMainMenu.Size = new System.Drawing.Size(1400, 840);
            
            int menuY = 200;
            int menuX = 450;
            
            this.btnViewSchedule.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnViewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewSchedule.ForeColor = System.Drawing.Color.White;
            this.btnViewSchedule.Location = new System.Drawing.Point(menuX, menuY);
            this.btnViewSchedule.Size = new System.Drawing.Size(500, 60);
            this.btnViewSchedule.Text = "";
            this.btnViewSchedule.Click += new System.EventHandler(this.btnViewSchedule_Click);
            
            this.btnEditData.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnEditData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditData.ForeColor = System.Drawing.Color.White;
            this.btnEditData.Location = new System.Drawing.Point(menuX, menuY + 80);
            this.btnEditData.Size = new System.Drawing.Size(500, 60);
            this.btnEditData.Text = "";
            this.btnEditData.Click += new System.EventHandler(this.btnEditData_Click);
            
            this.btnPrintForms.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnPrintForms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintForms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrintForms.ForeColor = System.Drawing.Color.White;
            this.btnPrintForms.Location = new System.Drawing.Point(menuX, menuY + 160);
            this.btnPrintForms.Size = new System.Drawing.Size(500, 60);
            this.btnPrintForms.Text = "";
            this.btnPrintForms.Click += new System.EventHandler(this.btnPrintForms_Click);
            
            this.btnCloseMain.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnCloseMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCloseMain.ForeColor = System.Drawing.Color.White;
            this.btnCloseMain.Location = new System.Drawing.Point(menuX, menuY + 240);
            this.btnCloseMain.Size = new System.Drawing.Size(500, 60);
            this.btnCloseMain.Text = "";
            this.btnCloseMain.Click += new System.EventHandler(this.btnCloseMain_Click);
            
            // ========== ПАНЕЛЬ ВЫБОРА ДАТЫ ==========
            this.panelDateSelection.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelDateSelection.Controls.Add(this.lblDateTitle);
            this.panelDateSelection.Controls.Add(this.dtpDate);
            this.panelDateSelection.Controls.Add(this.lblCalcType);
            this.panelDateSelection.Controls.Add(this.btnFirstCalc);
            this.panelDateSelection.Controls.Add(this.btnRepeatCalc);
            this.panelDateSelection.Controls.Add(this.btnCancelDate);
            this.panelDateSelection.Location = new System.Drawing.Point(0, 60);
            this.panelDateSelection.Size = new System.Drawing.Size(1400, 840);
            this.panelDateSelection.Visible = false;
            
            int dateY = 250;
            
            this.lblDateTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDateTitle.Location = new System.Drawing.Point(450, dateY);
            this.lblDateTitle.Size = new System.Drawing.Size(500, 30);
            this.lblDateTitle.Text = "";
            this.lblDateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(600, dateY + 50);
            this.dtpDate.Size = new System.Drawing.Size(200, 30);
            
            this.lblCalcType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCalcType.Location = new System.Drawing.Point(450, dateY + 100);
            this.lblCalcType.Size = new System.Drawing.Size(500, 30);
            this.lblCalcType.Text = "";
            this.lblCalcType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            this.btnFirstCalc.BackColor = System.Drawing.Color.FromArgb(28, 151, 99);
            this.btnFirstCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstCalc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnFirstCalc.ForeColor = System.Drawing.Color.White;
            this.btnFirstCalc.Location = new System.Drawing.Point(550, dateY + 150);
            this.btnFirstCalc.Size = new System.Drawing.Size(130, 45);
            this.btnFirstCalc.Text = "";
            this.btnFirstCalc.Click += new System.EventHandler(this.btnFirstCalc_Click);
            
            this.btnRepeatCalc.BackColor = System.Drawing.Color.FromArgb(28, 151, 99);
            this.btnRepeatCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeatCalc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRepeatCalc.ForeColor = System.Drawing.Color.White;
            this.btnRepeatCalc.Location = new System.Drawing.Point(720, dateY + 150);
            this.btnRepeatCalc.Size = new System.Drawing.Size(130, 45);
            this.btnRepeatCalc.Text = "";
            this.btnRepeatCalc.Click += new System.EventHandler(this.btnRepeatCalc_Click);
            
            this.btnCancelDate.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnCancelDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancelDate.ForeColor = System.Drawing.Color.White;
            this.btnCancelDate.Location = new System.Drawing.Point(635, dateY + 210);
            this.btnCancelDate.Size = new System.Drawing.Size(130, 45);
            this.btnCancelDate.Text = "";
            this.btnCancelDate.Click += new System.EventHandler(this.btnCancelDate_Click);
            
            // ========== ПАНЕЛЬ РЕДАКТИРОВАНИЯ ДАННЫХ ==========
            this.panelDataEntry.AutoScroll = true;
            this.panelDataEntry.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelDataEntry.Controls.Add(this.lblDataTitle);
            this.panelDataEntry.Controls.Add(this.lblEditDate);
            this.panelDataEntry.Controls.Add(this.lblEditDateValue);
            this.panelDataEntry.Controls.Add(this.groupCounters);
            this.panelDataEntry.Controls.Add(this.groupParams);
            this.panelDataEntry.Controls.Add(this.groupResults);
            this.panelDataEntry.Controls.Add(this.btnCalculate);
            this.panelDataEntry.Controls.Add(this.btnSave);
            this.panelDataEntry.Controls.Add(this.btnContinueEdit);
            this.panelDataEntry.Controls.Add(this.btnClose);
            this.panelDataEntry.Location = new System.Drawing.Point(0, 60);
            this.panelDataEntry.Size = new System.Drawing.Size(1400, 840);
            this.panelDataEntry.Visible = false;
            
            this.lblDataTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDataTitle.Location = new System.Drawing.Point(20, 10);
            this.lblDataTitle.Size = new System.Drawing.Size(1360, 30);
            this.lblDataTitle.Text = "";
            this.lblDataTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            this.lblEditDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEditDate.Location = new System.Drawing.Point(20, 50);
            this.lblEditDate.Size = new System.Drawing.Size(100, 25);
            this.lblEditDate.Text = "";
            
            this.lblEditDateValue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEditDateValue.Location = new System.Drawing.Point(120, 50);
            this.lblEditDateValue.Size = new System.Drawing.Size(150, 25);
            this.lblEditDateValue.Text = "";
            
            // Таблица счетчиков
            this.groupCounters.Controls.Add(this.dgvCounters);
            this.groupCounters.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupCounters.Location = new System.Drawing.Point(20, 90);
            this.groupCounters.Size = new System.Drawing.Size(650, 350);
            this.groupCounters.Text = "ПОКАЗАНИЯ СЧЕТЧИКОВ";
            
            this.dgvCounters.AllowUserToAddRows = false;
            this.dgvCounters.AllowUserToDeleteRows = false;
            this.dgvCounters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCounters.Location = new System.Drawing.Point(15, 30);
            this.dgvCounters.Size = new System.Drawing.Size(620, 300);
            
            // Технологические параметры
            this.groupParams.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupParams.Location = new System.Drawing.Point(690, 90);
            this.groupParams.Size = new System.Drawing.Size(690, 350);
            this.groupParams.Text = "";
            
            int paramY = 30;
            int paramSpacing = 30;
            int col1X = 15;
            int col2X = 250;
            int col3X = 365;
            int col4X = 600;
            
            // Колонка 1
            this.lblTim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTim.Location = new System.Drawing.Point(col1X, paramY);
            this.lblTim.Size = new System.Drawing.Size(180, 20);
            this.lblTim.Text = "";
            
            this.numTim.DecimalPlaces = 1;
            this.numTim.Location = new System.Drawing.Point(col2X, paramY);
            this.numTim.Maximum = 24;
            this.numTim.Size = new System.Drawing.Size(100, 25);
            this.numTim.Value = 8;
            
            paramY += paramSpacing;
            
            this.lblDro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDro.Location = new System.Drawing.Point(col1X, paramY);
            this.lblDro.Size = new System.Drawing.Size(180, 20);
            this.lblDro.Text = "";
            
            this.numDro.DecimalPlaces = 2;
            this.numDro.Location = new System.Drawing.Point(col2X, paramY);
            this.numDro.Maximum = 100;
            this.numDro.Size = new System.Drawing.Size(100, 25);
            
            paramY += paramSpacing;
            
            this.lblPwd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPwd.Location = new System.Drawing.Point(col1X, paramY);
            this.lblPwd.Size = new System.Drawing.Size(180, 20);
            this.lblPwd.Text = "";
            
            this.numPwd.Location = new System.Drawing.Point(col2X, paramY);
            this.numPwd.Maximum = 1;
            this.numPwd.Size = new System.Drawing.Size(100, 25);
            
            paramY += paramSpacing;
            
            this.lblTpw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTpw.Location = new System.Drawing.Point(col1X, paramY);
            this.lblTpw.Size = new System.Drawing.Size(180, 20);
            this.lblTpw.Text = "";
            
            this.numTpw.DecimalPlaces = 1;
            this.numTpw.Location = new System.Drawing.Point(col2X, paramY);
            this.numTpw.Maximum = 500;
            this.numTpw.Size = new System.Drawing.Size(100, 25);
            this.numTpw.Value = 270;
            
            paramY += paramSpacing;
            
            this.lblTk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTk.Location = new System.Drawing.Point(col1X, paramY);
            this.lblTk.Size = new System.Drawing.Size(180, 20);
            this.lblTk.Text = "";
            
            this.numTk.DecimalPlaces = 1;
            this.numTk.Location = new System.Drawing.Point(col2X, paramY);
            this.numTk.Maximum = 100;
            this.numTk.Size = new System.Drawing.Size(100, 25);
            this.numTk.Value = 35;
            
            paramY += paramSpacing;
            
            this.lblTop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTop.Location = new System.Drawing.Point(col1X, paramY);
            this.lblTop.Size = new System.Drawing.Size(180, 20);
            this.lblTop.Text = "";
            
            this.numTop.DecimalPlaces = 1;
            this.numTop.Location = new System.Drawing.Point(col2X, paramY);
            this.numTop.Maximum = 600;
            this.numTop.Size = new System.Drawing.Size(100, 25);
            this.numTop.Value = 545;
            
            // Колонка 2
            paramY = 30;
            
            this.lblTpp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTpp.Location = new System.Drawing.Point(col3X, paramY);
            this.lblTpp.Size = new System.Drawing.Size(180, 20);
            this.lblTpp.Text = "";
            
            this.numTpp.DecimalPlaces = 1;
            this.numTpp.Location = new System.Drawing.Point(col4X, paramY);
            this.numTpp.Maximum = 600;
            this.numTpp.Size = new System.Drawing.Size(100, 25);
            this.numTpp.Value = 545;
            
            paramY += paramSpacing;
            
            this.lblPop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPop.Location = new System.Drawing.Point(col3X, paramY);
            this.lblPop.Size = new System.Drawing.Size(180, 20);
            this.lblPop.Text = "";
            
            this.numPop.DecimalPlaces = 1;
            this.numPop.Location = new System.Drawing.Point(col4X, paramY);
            this.numPop.Maximum = 300;
            this.numPop.Size = new System.Drawing.Size(100, 25);
            this.numPop.Value = 25;
            
            paramY += paramSpacing;
            
            this.lblTug.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTug.Location = new System.Drawing.Point(col3X, paramY);
            this.lblTug.Size = new System.Drawing.Size(180, 20);
            this.lblTug.Text = "";
            
            this.numTug.DecimalPlaces = 1;
            this.numTug.Location = new System.Drawing.Point(col4X, paramY);
            this.numTug.Maximum = 2000;
            this.numTug.Size = new System.Drawing.Size(100, 25);
            this.numTug.Value = 150;
            
            paramY += paramSpacing;
            
            this.lblThw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThw.Location = new System.Drawing.Point(col3X, paramY);
            this.lblThw.Size = new System.Drawing.Size(180, 20);
            this.lblThw.Text = "";
            
            this.numThw.DecimalPlaces = 1;
            this.numThw.Location = new System.Drawing.Point(col4X, paramY);
            this.numThw.Maximum = 500;
            this.numThw.Size = new System.Drawing.Size(100, 25);
            this.numThw.Value = 450;
            
            paramY += paramSpacing;
            
            this.lblO2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblO2.Location = new System.Drawing.Point(col3X, paramY);
            this.lblO2.Size = new System.Drawing.Size(180, 20);
            this.lblO2.Text = "";
            
            this.numO2.DecimalPlaces = 2;
            this.numO2.Location = new System.Drawing.Point(col4X, paramY);
            this.numO2.Maximum = 20;
            this.numO2.Size = new System.Drawing.Size(100, 25);
            this.numO2.Value = 4.5m;
            
            paramY += paramSpacing;
            
            this.lblTn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTn.Location = new System.Drawing.Point(col3X, paramY);
            this.lblTn.Size = new System.Drawing.Size(180, 20);
            this.lblTn.Text = "";
            
            this.numTn.DecimalPlaces = 1;
            this.numTn.Location = new System.Drawing.Point(col4X, paramY);
            this.numTn.Minimum = -50;
            this.numTn.Maximum = 50;
            this.numTn.Size = new System.Drawing.Size(100, 25);
            this.numTn.Value = 20;
            
            this.groupParams.Controls.Add(this.lblTim);
            this.groupParams.Controls.Add(this.numTim);
            this.groupParams.Controls.Add(this.lblDro);
            this.groupParams.Controls.Add(this.numDro);
            this.groupParams.Controls.Add(this.lblPwd);
            this.groupParams.Controls.Add(this.numPwd);
            this.groupParams.Controls.Add(this.lblTpw);
            this.groupParams.Controls.Add(this.numTpw);
            this.groupParams.Controls.Add(this.lblTk);
            this.groupParams.Controls.Add(this.numTk);
            this.groupParams.Controls.Add(this.lblTop);
            this.groupParams.Controls.Add(this.numTop);
            this.groupParams.Controls.Add(this.lblTpp);
            this.groupParams.Controls.Add(this.numTpp);
            this.groupParams.Controls.Add(this.lblPop);
            this.groupParams.Controls.Add(this.numPop);
            this.groupParams.Controls.Add(this.lblTug);
            this.groupParams.Controls.Add(this.numTug);
            this.groupParams.Controls.Add(this.lblThw);
            this.groupParams.Controls.Add(this.numThw);
            this.groupParams.Controls.Add(this.lblO2);
            this.groupParams.Controls.Add(this.numO2);
            this.groupParams.Controls.Add(this.lblTn);
            this.groupParams.Controls.Add(this.numTn);
            
            // Результаты
            this.groupResults.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupResults.Location = new System.Drawing.Point(20, 460);
            this.groupResults.Size = new System.Drawing.Size(1360, 180);
            this.groupResults.Text = "";
            
            int resY = 30;
            int resSpacing = 30;
            int resCol1X = 15;
            int resCol2X = 250;
            int resCol3X = 380;
            int resCol4X = 615;
            int resCol5X = 745;
            int resCol6X = 980;
            
            // Строка 1
            this.lblPugResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPugResult.Location = new System.Drawing.Point(resCol1X, resY);
            this.lblPugResult.Size = new System.Drawing.Size(200, 20);
            this.lblPugResult.Text = "";
            
            this.txtPugResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPugResult.Location = new System.Drawing.Point(resCol2X, resY);
            this.txtPugResult.ReadOnly = true;
            this.txtPugResult.Size = new System.Drawing.Size(100, 25);
            
            this.lblWakResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWakResult.Location = new System.Drawing.Point(resCol3X, resY);
            this.lblWakResult.Size = new System.Drawing.Size(200, 20);
            this.lblWakResult.Text = "";
            
            this.txtWakResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWakResult.Location = new System.Drawing.Point(resCol4X, resY);
            this.txtWakResult.ReadOnly = true;
            this.txtWakResult.Size = new System.Drawing.Size(100, 25);
            
            this.lblDopResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDopResult.Location = new System.Drawing.Point(resCol5X, resY);
            this.lblDopResult.Size = new System.Drawing.Size(200, 20);
            this.lblDopResult.Text = "";
            
            this.txtDopResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDopResult.Location = new System.Drawing.Point(resCol6X, resY);
            this.txtDopResult.ReadOnly = true;
            this.txtDopResult.Size = new System.Drawing.Size(100, 25);
            
            resY += resSpacing;
            
            // Строка 2
            this.lblTopResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTopResult.Location = new System.Drawing.Point(resCol1X, resY);
            this.lblTopResult.Size = new System.Drawing.Size(200, 20);
            this.lblTopResult.Text = "";
            
            this.txtTopResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTopResult.Location = new System.Drawing.Point(resCol2X, resY);
            this.txtTopResult.ReadOnly = true;
            this.txtTopResult.Size = new System.Drawing.Size(100, 25);
            
            this.lblTppResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTppResult.Location = new System.Drawing.Point(resCol3X, resY);
            this.lblTppResult.Size = new System.Drawing.Size(200, 20);
            this.lblTppResult.Text = "";
            
            this.txtTppResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTppResult.Location = new System.Drawing.Point(resCol4X, resY);
            this.txtTppResult.ReadOnly = true;
            this.txtTppResult.Size = new System.Drawing.Size(100, 25);
            
            this.lblSnResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSnResult.Location = new System.Drawing.Point(resCol5X, resY);
            this.lblSnResult.Size = new System.Drawing.Size(200, 20);
            this.lblSnResult.Text = "";
            
            this.txtSnResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSnResult.Location = new System.Drawing.Point(resCol6X, resY);
            this.txtSnResult.ReadOnly = true;
            this.txtSnResult.Size = new System.Drawing.Size(100, 25);
            
            resY += resSpacing;
            
            // Строка 3
            this.lblTpwResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTpwResult.Location = new System.Drawing.Point(resCol1X, resY);
            this.lblTpwResult.Size = new System.Drawing.Size(200, 20);
            this.lblTpwResult.Text = "";
            
            this.txtTpwResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTpwResult.Location = new System.Drawing.Point(resCol2X, resY);
            this.txtTpwResult.ReadOnly = true;
            this.txtTpwResult.Size = new System.Drawing.Size(100, 25);
            
            this.lblTotalResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalResult.Location = new System.Drawing.Point(resCol3X, resY);
            this.lblTotalResult.Size = new System.Drawing.Size(200, 20);
            this.lblTotalResult.Text = "";
            
            this.txtTotalResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtTotalResult.Location = new System.Drawing.Point(resCol4X, resY);
            this.txtTotalResult.ReadOnly = true;
            this.txtTotalResult.Size = new System.Drawing.Size(100, 25);
            
            this.lblGkbtResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGkbtResult.Location = new System.Drawing.Point(resCol5X, resY);
            this.lblGkbtResult.Size = new System.Drawing.Size(200, 20);
            this.lblGkbtResult.Text = "";
            
            this.txtGkbtResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtGkbtResult.Location = new System.Drawing.Point(resCol6X, resY);
            this.txtGkbtResult.ReadOnly = true;
            this.txtGkbtResult.Size = new System.Drawing.Size(100, 25);
            
            this.groupResults.Controls.Add(this.lblPugResult);
            this.groupResults.Controls.Add(this.txtPugResult);
            this.groupResults.Controls.Add(this.lblWakResult);
            this.groupResults.Controls.Add(this.txtWakResult);
            this.groupResults.Controls.Add(this.lblDopResult);
            this.groupResults.Controls.Add(this.txtDopResult);
            this.groupResults.Controls.Add(this.lblTopResult);
            this.groupResults.Controls.Add(this.txtTopResult);
            this.groupResults.Controls.Add(this.lblTppResult);
            this.groupResults.Controls.Add(this.txtTppResult);
            this.groupResults.Controls.Add(this.lblSnResult);
            this.groupResults.Controls.Add(this.txtSnResult);
            this.groupResults.Controls.Add(this.lblTpwResult);
            this.groupResults.Controls.Add(this.txtTpwResult);
            this.groupResults.Controls.Add(this.lblTotalResult);
            this.groupResults.Controls.Add(this.txtTotalResult);
            this.groupResults.Controls.Add(this.lblGkbtResult);
            this.groupResults.Controls.Add(this.txtGkbtResult);
            
            // Кнопки управления
            int btnY = 660;
            
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(250, btnY);
            this.btnCalculate.Size = new System.Drawing.Size(200, 45);
            this.btnCalculate.Text = "";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(28, 151, 99);
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(470, btnY);
            this.btnSave.Size = new System.Drawing.Size(200, 45);
            this.btnSave.Text = "";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            
            this.btnContinueEdit.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.btnContinueEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinueEdit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnContinueEdit.ForeColor = System.Drawing.Color.White;
            this.btnContinueEdit.Location = new System.Drawing.Point(690, btnY);
            this.btnContinueEdit.Size = new System.Drawing.Size(270, 45);
            this.btnContinueEdit.Text = "";
            this.btnContinueEdit.Click += new System.EventHandler(this.btnContinueEdit_Click);
            
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(980, btnY);
            this.btnClose.Size = new System.Drawing.Size(250, 45);
            this.btnClose.Text = "";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            
            // BaxtaForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelDateSelection);
            this.Controls.Add(this.panelDataEntry);
            this.Controls.Add(this.panelHeader);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.panelHeader.ResumeLayout(false);
            this.panelMainMenu.ResumeLayout(false);
            this.panelDateSelection.ResumeLayout(false);
            this.panelDataEntry.ResumeLayout(false);
            this.panelDataEntry.PerformLayout();
            this.groupCounters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounters)).EndInit();
            this.groupParams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTpw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTpp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTn)).EndInit();
            this.groupResults.ResumeLayout(false);
            this.groupResults.PerformLayout();
            this.ResumeLayout(false);
        }

        // Панели
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelMainMenu;
        private Panel panelDateSelection;
        private Panel panelDataEntry;
        
        // Главное меню
        private Button btnViewSchedule;
        private Button btnEditData;
        private Button btnPrintForms;
        private Button btnCloseMain;
        
        // Выбор даты
        private Label lblDateTitle;
        private DateTimePicker dtpDate;
        private Label lblCalcType;
        private Button btnFirstCalc;
        private Button btnRepeatCalc;
        private Button btnCancelDate;
        
        // Форма ввода данных
        private Label lblDataTitle;
        private Label lblEditDate;
        private Label lblEditDateValue;
        
        // Таблица счетчиков
        private GroupBox groupCounters;
        private Label lblBlockHeader;
        private Label lblShiftHeader;
        private Label lblCountersHeader;
        private Label lblOutputHeader;
        private Label lblSNHeader;
        private DataGridView dgvCounters;
        
        // Технологические параметры
        private GroupBox groupParams;
        private Label lblParamsTitle;
        private Label lblTim;
        private NumericUpDown numTim;
        private Label lblDro;
        private NumericUpDown numDro;
        private Label lblPwd;
        private NumericUpDown numPwd;
        private Label lblTpw;
        private NumericUpDown numTpw;
        private Label lblTk;
        private NumericUpDown numTk;
        private Label lblTop;
        private NumericUpDown numTop;
        private Label lblTpp;
        private NumericUpDown numTpp;
        private Label lblPop;
        private NumericUpDown numPop;
        private Label lblTug;
        private NumericUpDown numTug;
        private Label lblThw;
        private NumericUpDown numThw;
        private Label lblO2;
        private NumericUpDown numO2;
        private Label lblTn;
        private NumericUpDown numTn;
        
        // Результаты
        private GroupBox groupResults;
        private Label lblResultsTitle;
        private Label lblPugResult;
        private TextBox txtPugResult;
        private Label lblWakResult;
        private TextBox txtWakResult;
        private Label lblDopResult;
        private TextBox txtDopResult;
        private Label lblTopResult;
        private TextBox txtTopResult;
        private Label lblTppResult;
        private TextBox txtTppResult;
        private Label lblSnResult;
        private TextBox txtSnResult;
        private Label lblTpwResult;
        private TextBox txtTpwResult;
        private Label lblTotalResult;
        private TextBox txtTotalResult;
        private Label lblGkbtResult;
        private TextBox txtGkbtResult;
        
        // Кнопки управления
        private Button btnCalculate;
        private Button btnSave;
        private Button btnContinueEdit;
        private Button btnClose;
    }
}
