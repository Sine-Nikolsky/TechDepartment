namespace TechDepartment.Forms
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabProgramJournal = new MetroFramework.Controls.MetroTabPage();
            this.tabDetailDB = new MetroFramework.Controls.MetroTabPage();
            this.btnSearchDetailDB = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.btnDeleteDetailDB = new MetroFramework.Controls.MetroButton();
            this.btnModifyDetailDB = new MetroFramework.Controls.MetroButton();
            this.btnAddDetailDB = new MetroFramework.Controls.MetroButton();
            this.gridDetailDB = new MetroFramework.Controls.MetroGrid();
            this.tabCoworkersDB = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.tabMachinesDB = new MetroFramework.Controls.MetroTabPage();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.metroButton8 = new MetroFramework.Controls.MetroButton();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.tabOEJournal = new MetroFramework.Controls.MetroTabPage();
            this.tabTPJournal = new MetroFramework.Controls.MetroTabPage();
            this.tabProgramReport = new MetroFramework.Controls.MetroTabPage();
            this.tabTechnologistReport = new MetroFramework.Controls.MetroTabPage();
            this.tabAnotherTaskReport = new MetroFramework.Controls.MetroTabPage();
            this.tabSummaryProgramReport = new MetroFramework.Controls.MetroTabPage();
            this.tabSummaryTechnologistReport = new MetroFramework.Controls.MetroTabPage();
            this.tabPlanUP = new MetroFramework.Controls.MetroTabPage();
            this.tabPlanTP = new MetroFramework.Controls.MetroTabPage();
            this.tileJournalsAndLists = new MetroFramework.Controls.MetroTile();
            this.tileReports = new MetroFramework.Controls.MetroTile();
            this.tilePlansAndGraphics = new MetroFramework.Controls.MetroTile();
            this.tileDBManagement = new MetroFramework.Controls.MetroTile();
            this.tileWorkAnalysis = new MetroFramework.Controls.MetroTile();
            this.tileExcelParcers = new MetroFramework.Controls.MetroTile();
            this.tabControl.SuspendLayout();
            this.tabDetailDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetailDB)).BeginInit();
            this.tabCoworkersDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.tabMachinesDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDetailDB);
            this.tabControl.Controls.Add(this.tabCoworkersDB);
            this.tabControl.Controls.Add(this.tabMachinesDB);
            this.tabControl.Controls.Add(this.tabProgramJournal);
            this.tabControl.Controls.Add(this.tabOEJournal);
            this.tabControl.Controls.Add(this.tabTPJournal);
            this.tabControl.Controls.Add(this.tabProgramReport);
            this.tabControl.Controls.Add(this.tabTechnologistReport);
            this.tabControl.Controls.Add(this.tabAnotherTaskReport);
            this.tabControl.Controls.Add(this.tabSummaryProgramReport);
            this.tabControl.Controls.Add(this.tabSummaryTechnologistReport);
            this.tabControl.Controls.Add(this.tabPlanUP);
            this.tabControl.Controls.Add(this.tabPlanTP);
            this.tabControl.Location = new System.Drawing.Point(204, 63);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 1;
            this.tabControl.Size = new System.Drawing.Size(979, 467);
            this.tabControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.tabControl.TabIndex = 0;
            this.tabControl.UseSelectable = true;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabProgramJournal
            // 
            this.tabProgramJournal.HorizontalScrollbarBarColor = true;
            this.tabProgramJournal.HorizontalScrollbarHighlightOnWheel = false;
            this.tabProgramJournal.HorizontalScrollbarSize = 10;
            this.tabProgramJournal.Location = new System.Drawing.Point(4, 38);
            this.tabProgramJournal.Name = "tabProgramJournal";
            this.tabProgramJournal.Size = new System.Drawing.Size(971, 425);
            this.tabProgramJournal.TabIndex = 0;
            this.tabProgramJournal.Text = "Журнал УП";
            this.tabProgramJournal.VerticalScrollbarBarColor = true;
            this.tabProgramJournal.VerticalScrollbarHighlightOnWheel = false;
            this.tabProgramJournal.VerticalScrollbarSize = 10;
            // 
            // tabDetailDB
            // 
            this.tabDetailDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabDetailDB.Controls.Add(this.btnSearchDetailDB);
            this.tabDetailDB.Controls.Add(this.metroTextBox1);
            this.tabDetailDB.Controls.Add(this.btnDeleteDetailDB);
            this.tabDetailDB.Controls.Add(this.btnModifyDetailDB);
            this.tabDetailDB.Controls.Add(this.btnAddDetailDB);
            this.tabDetailDB.Controls.Add(this.gridDetailDB);
            this.tabDetailDB.HorizontalScrollbarBarColor = true;
            this.tabDetailDB.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDetailDB.HorizontalScrollbarSize = 10;
            this.tabDetailDB.Location = new System.Drawing.Point(4, 38);
            this.tabDetailDB.Name = "tabDetailDB";
            this.tabDetailDB.Size = new System.Drawing.Size(971, 425);
            this.tabDetailDB.TabIndex = 10;
            this.tabDetailDB.Text = "Детали";
            this.tabDetailDB.VerticalScrollbarBarColor = true;
            this.tabDetailDB.VerticalScrollbarHighlightOnWheel = false;
            this.tabDetailDB.VerticalScrollbarSize = 10;
            // 
            // btnSearchDetailDB
            // 
            this.btnSearchDetailDB.Location = new System.Drawing.Point(339, 385);
            this.btnSearchDetailDB.Name = "btnSearchDetailDB";
            this.btnSearchDetailDB.Size = new System.Drawing.Size(89, 23);
            this.btnSearchDetailDB.TabIndex = 7;
            this.btnSearchDetailDB.Text = "Поиск";
            this.btnSearchDetailDB.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(291, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Lines = new string[] {
        "Строка поиска"};
            this.metroTextBox1.Location = new System.Drawing.Point(20, 385);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(313, 23);
            this.metroTextBox1.TabIndex = 6;
            this.metroTextBox1.Text = "Строка поиска";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnDeleteDetailDB
            // 
            this.btnDeleteDetailDB.Location = new System.Drawing.Point(674, 385);
            this.btnDeleteDetailDB.Name = "btnDeleteDetailDB";
            this.btnDeleteDetailDB.Size = new System.Drawing.Size(89, 23);
            this.btnDeleteDetailDB.TabIndex = 5;
            this.btnDeleteDetailDB.Text = "Удалить";
            this.btnDeleteDetailDB.UseSelectable = true;
            // 
            // btnModifyDetailDB
            // 
            this.btnModifyDetailDB.Location = new System.Drawing.Point(769, 385);
            this.btnModifyDetailDB.Name = "btnModifyDetailDB";
            this.btnModifyDetailDB.Size = new System.Drawing.Size(89, 23);
            this.btnModifyDetailDB.TabIndex = 4;
            this.btnModifyDetailDB.Text = "Изменить";
            this.btnModifyDetailDB.UseSelectable = true;
            // 
            // btnAddDetailDB
            // 
            this.btnAddDetailDB.Location = new System.Drawing.Point(864, 385);
            this.btnAddDetailDB.Name = "btnAddDetailDB";
            this.btnAddDetailDB.Size = new System.Drawing.Size(89, 23);
            this.btnAddDetailDB.TabIndex = 3;
            this.btnAddDetailDB.Text = "Добавить";
            this.btnAddDetailDB.UseSelectable = true;
            // 
            // gridDetailDB
            // 
            this.gridDetailDB.AllowUserToResizeRows = false;
            this.gridDetailDB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDetailDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDetailDB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridDetailDB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetailDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDetailDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDetailDB.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDetailDB.EnableHeadersVisualStyles = false;
            this.gridDetailDB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridDetailDB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDetailDB.Location = new System.Drawing.Point(20, 15);
            this.gridDetailDB.Name = "gridDetailDB";
            this.gridDetailDB.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetailDB.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDetailDB.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDetailDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetailDB.Size = new System.Drawing.Size(933, 364);
            this.gridDetailDB.TabIndex = 2;
            // 
            // tabCoworkersDB
            // 
            this.tabCoworkersDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCoworkersDB.Controls.Add(this.metroButton1);
            this.tabCoworkersDB.Controls.Add(this.metroTextBox2);
            this.tabCoworkersDB.Controls.Add(this.metroButton2);
            this.tabCoworkersDB.Controls.Add(this.metroButton3);
            this.tabCoworkersDB.Controls.Add(this.metroButton4);
            this.tabCoworkersDB.Controls.Add(this.metroGrid1);
            this.tabCoworkersDB.HorizontalScrollbarBarColor = true;
            this.tabCoworkersDB.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCoworkersDB.HorizontalScrollbarSize = 10;
            this.tabCoworkersDB.Location = new System.Drawing.Point(4, 38);
            this.tabCoworkersDB.Name = "tabCoworkersDB";
            this.tabCoworkersDB.Size = new System.Drawing.Size(971, 425);
            this.tabCoworkersDB.TabIndex = 11;
            this.tabCoworkersDB.Text = "Сотрудники";
            this.tabCoworkersDB.VerticalScrollbarBarColor = true;
            this.tabCoworkersDB.VerticalScrollbarHighlightOnWheel = false;
            this.tabCoworkersDB.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(338, 386);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(89, 23);
            this.metroButton1.TabIndex = 13;
            this.metroButton1.Text = "Поиск";
            this.metroButton1.UseSelectable = true;
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(291, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox2.Lines = new string[] {
        "Строка поиска"};
            this.metroTextBox2.Location = new System.Drawing.Point(19, 386);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(313, 23);
            this.metroTextBox2.TabIndex = 12;
            this.metroTextBox2.Text = "Строка поиска";
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(673, 386);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(89, 23);
            this.metroButton2.TabIndex = 11;
            this.metroButton2.Text = "Удалить";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(768, 386);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(89, 23);
            this.metroButton3.TabIndex = 10;
            this.metroButton3.Text = "Изменить";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(863, 386);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(89, 23);
            this.metroButton4.TabIndex = 9;
            this.metroButton4.Text = "Добавить";
            this.metroButton4.UseSelectable = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(19, 16);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(933, 364);
            this.metroGrid1.TabIndex = 8;
            // 
            // tabMachinesDB
            // 
            this.tabMachinesDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabMachinesDB.Controls.Add(this.metroButton5);
            this.tabMachinesDB.Controls.Add(this.metroTextBox3);
            this.tabMachinesDB.Controls.Add(this.metroButton6);
            this.tabMachinesDB.Controls.Add(this.metroButton7);
            this.tabMachinesDB.Controls.Add(this.metroButton8);
            this.tabMachinesDB.Controls.Add(this.metroGrid2);
            this.tabMachinesDB.HorizontalScrollbarBarColor = true;
            this.tabMachinesDB.HorizontalScrollbarHighlightOnWheel = false;
            this.tabMachinesDB.HorizontalScrollbarSize = 10;
            this.tabMachinesDB.Location = new System.Drawing.Point(4, 38);
            this.tabMachinesDB.Name = "tabMachinesDB";
            this.tabMachinesDB.Size = new System.Drawing.Size(971, 425);
            this.tabMachinesDB.TabIndex = 12;
            this.tabMachinesDB.Text = "Станки";
            this.tabMachinesDB.VerticalScrollbarBarColor = true;
            this.tabMachinesDB.VerticalScrollbarHighlightOnWheel = false;
            this.tabMachinesDB.VerticalScrollbarSize = 10;
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(338, 386);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(89, 23);
            this.metroButton5.TabIndex = 13;
            this.metroButton5.Text = "Поиск";
            this.metroButton5.UseSelectable = true;
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(291, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox3.Lines = new string[] {
        "Строка поиска"};
            this.metroTextBox3.Location = new System.Drawing.Point(19, 386);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(313, 23);
            this.metroTextBox3.TabIndex = 12;
            this.metroTextBox3.Text = "Строка поиска";
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(673, 386);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(89, 23);
            this.metroButton6.TabIndex = 11;
            this.metroButton6.Text = "Удалить";
            this.metroButton6.UseSelectable = true;
            // 
            // metroButton7
            // 
            this.metroButton7.Location = new System.Drawing.Point(768, 386);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(89, 23);
            this.metroButton7.TabIndex = 10;
            this.metroButton7.Text = "Изменить";
            this.metroButton7.UseSelectable = true;
            // 
            // metroButton8
            // 
            this.metroButton8.Location = new System.Drawing.Point(863, 386);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.Size = new System.Drawing.Size(89, 23);
            this.metroButton8.TabIndex = 9;
            this.metroButton8.Text = "Добавить";
            this.metroButton8.UseSelectable = true;
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(19, 16);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(933, 364);
            this.metroGrid2.TabIndex = 8;
            // 
            // tabOEJournal
            // 
            this.tabOEJournal.HorizontalScrollbarBarColor = true;
            this.tabOEJournal.HorizontalScrollbarHighlightOnWheel = false;
            this.tabOEJournal.HorizontalScrollbarSize = 10;
            this.tabOEJournal.Location = new System.Drawing.Point(4, 38);
            this.tabOEJournal.Name = "tabOEJournal";
            this.tabOEJournal.Size = new System.Drawing.Size(971, 425);
            this.tabOEJournal.TabIndex = 5;
            this.tabOEJournal.Text = "Журнал операционных эскизов";
            this.tabOEJournal.VerticalScrollbarBarColor = true;
            this.tabOEJournal.VerticalScrollbarHighlightOnWheel = false;
            this.tabOEJournal.VerticalScrollbarSize = 10;
            // 
            // tabTPJournal
            // 
            this.tabTPJournal.HorizontalScrollbarBarColor = true;
            this.tabTPJournal.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTPJournal.HorizontalScrollbarSize = 10;
            this.tabTPJournal.Location = new System.Drawing.Point(4, 38);
            this.tabTPJournal.Name = "tabTPJournal";
            this.tabTPJournal.Size = new System.Drawing.Size(971, 425);
            this.tabTPJournal.TabIndex = 8;
            this.tabTPJournal.Text = "Журнал разработанных ТП";
            this.tabTPJournal.VerticalScrollbarBarColor = true;
            this.tabTPJournal.VerticalScrollbarHighlightOnWheel = false;
            this.tabTPJournal.VerticalScrollbarSize = 10;
            // 
            // tabProgramReport
            // 
            this.tabProgramReport.HorizontalScrollbarBarColor = true;
            this.tabProgramReport.HorizontalScrollbarHighlightOnWheel = false;
            this.tabProgramReport.HorizontalScrollbarSize = 10;
            this.tabProgramReport.Location = new System.Drawing.Point(4, 38);
            this.tabProgramReport.Name = "tabProgramReport";
            this.tabProgramReport.Size = new System.Drawing.Size(971, 425);
            this.tabProgramReport.TabIndex = 1;
            this.tabProgramReport.Text = "Отчет о разработке УП";
            this.tabProgramReport.VerticalScrollbarBarColor = true;
            this.tabProgramReport.VerticalScrollbarHighlightOnWheel = false;
            this.tabProgramReport.VerticalScrollbarSize = 10;
            // 
            // tabTechnologistReport
            // 
            this.tabTechnologistReport.HorizontalScrollbarBarColor = true;
            this.tabTechnologistReport.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTechnologistReport.HorizontalScrollbarSize = 10;
            this.tabTechnologistReport.Location = new System.Drawing.Point(4, 38);
            this.tabTechnologistReport.Name = "tabTechnologistReport";
            this.tabTechnologistReport.Size = new System.Drawing.Size(971, 425);
            this.tabTechnologistReport.TabIndex = 7;
            this.tabTechnologistReport.Text = "Отчет о разработке ТД";
            this.tabTechnologistReport.VerticalScrollbarBarColor = true;
            this.tabTechnologistReport.VerticalScrollbarHighlightOnWheel = false;
            this.tabTechnologistReport.VerticalScrollbarSize = 10;
            // 
            // tabAnotherTaskReport
            // 
            this.tabAnotherTaskReport.HorizontalScrollbarBarColor = true;
            this.tabAnotherTaskReport.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAnotherTaskReport.HorizontalScrollbarSize = 10;
            this.tabAnotherTaskReport.Location = new System.Drawing.Point(4, 38);
            this.tabAnotherTaskReport.Name = "tabAnotherTaskReport";
            this.tabAnotherTaskReport.Size = new System.Drawing.Size(971, 425);
            this.tabAnotherTaskReport.TabIndex = 6;
            this.tabAnotherTaskReport.Text = "Прочие работы";
            this.tabAnotherTaskReport.VerticalScrollbarBarColor = true;
            this.tabAnotherTaskReport.VerticalScrollbarHighlightOnWheel = false;
            this.tabAnotherTaskReport.VerticalScrollbarSize = 10;
            // 
            // tabSummaryProgramReport
            // 
            this.tabSummaryProgramReport.HorizontalScrollbarBarColor = true;
            this.tabSummaryProgramReport.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSummaryProgramReport.HorizontalScrollbarSize = 10;
            this.tabSummaryProgramReport.Location = new System.Drawing.Point(4, 38);
            this.tabSummaryProgramReport.Name = "tabSummaryProgramReport";
            this.tabSummaryProgramReport.Size = new System.Drawing.Size(971, 425);
            this.tabSummaryProgramReport.TabIndex = 4;
            this.tabSummaryProgramReport.Text = "Сводный отчет о внедрении УП";
            this.tabSummaryProgramReport.VerticalScrollbarBarColor = true;
            this.tabSummaryProgramReport.VerticalScrollbarHighlightOnWheel = false;
            this.tabSummaryProgramReport.VerticalScrollbarSize = 10;
            // 
            // tabSummaryTechnologistReport
            // 
            this.tabSummaryTechnologistReport.HorizontalScrollbarBarColor = true;
            this.tabSummaryTechnologistReport.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSummaryTechnologistReport.HorizontalScrollbarSize = 10;
            this.tabSummaryTechnologistReport.Location = new System.Drawing.Point(4, 38);
            this.tabSummaryTechnologistReport.Name = "tabSummaryTechnologistReport";
            this.tabSummaryTechnologistReport.Size = new System.Drawing.Size(971, 425);
            this.tabSummaryTechnologistReport.TabIndex = 3;
            this.tabSummaryTechnologistReport.Text = "Сводный отчет о разработке ТД";
            this.tabSummaryTechnologistReport.VerticalScrollbarBarColor = true;
            this.tabSummaryTechnologistReport.VerticalScrollbarHighlightOnWheel = false;
            this.tabSummaryTechnologistReport.VerticalScrollbarSize = 10;
            // 
            // tabPlanUP
            // 
            this.tabPlanUP.HorizontalScrollbarBarColor = true;
            this.tabPlanUP.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPlanUP.HorizontalScrollbarSize = 10;
            this.tabPlanUP.Location = new System.Drawing.Point(4, 38);
            this.tabPlanUP.Name = "tabPlanUP";
            this.tabPlanUP.Size = new System.Drawing.Size(971, 425);
            this.tabPlanUP.TabIndex = 2;
            this.tabPlanUP.Text = "Планирование внедрения УП";
            this.tabPlanUP.VerticalScrollbarBarColor = true;
            this.tabPlanUP.VerticalScrollbarHighlightOnWheel = false;
            this.tabPlanUP.VerticalScrollbarSize = 10;
            // 
            // tabPlanTP
            // 
            this.tabPlanTP.HorizontalScrollbarBarColor = true;
            this.tabPlanTP.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPlanTP.HorizontalScrollbarSize = 10;
            this.tabPlanTP.Location = new System.Drawing.Point(4, 38);
            this.tabPlanTP.Name = "tabPlanTP";
            this.tabPlanTP.Size = new System.Drawing.Size(971, 425);
            this.tabPlanTP.TabIndex = 9;
            this.tabPlanTP.Text = "Планирование разработки ТП";
            this.tabPlanTP.VerticalScrollbarBarColor = true;
            this.tabPlanTP.VerticalScrollbarHighlightOnWheel = false;
            this.tabPlanTP.VerticalScrollbarSize = 10;
            // 
            // tileJournalsAndLists
            // 
            this.tileJournalsAndLists.ActiveControl = null;
            this.tileJournalsAndLists.Location = new System.Drawing.Point(27, 80);
            this.tileJournalsAndLists.Name = "tileJournalsAndLists";
            this.tileJournalsAndLists.Size = new System.Drawing.Size(161, 70);
            this.tileJournalsAndLists.Style = MetroFramework.MetroColorStyle.Orange;
            this.tileJournalsAndLists.TabIndex = 1;
            this.tileJournalsAndLists.Text = "Журналы и списки";
            this.tileJournalsAndLists.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileJournalsAndLists.UseSelectable = true;
            this.tileJournalsAndLists.Click += new System.EventHandler(this.ChangeTab);
            // 
            // tileReports
            // 
            this.tileReports.ActiveControl = null;
            this.tileReports.Location = new System.Drawing.Point(27, 232);
            this.tileReports.Name = "tileReports";
            this.tileReports.Size = new System.Drawing.Size(161, 70);
            this.tileReports.Style = MetroFramework.MetroColorStyle.Orange;
            this.tileReports.TabIndex = 2;
            this.tileReports.Text = "Отчеты о работе";
            this.tileReports.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileReports.UseSelectable = true;
            this.tileReports.Click += new System.EventHandler(this.ChangeTab);
            // 
            // tilePlansAndGraphics
            // 
            this.tilePlansAndGraphics.ActiveControl = null;
            this.tilePlansAndGraphics.Location = new System.Drawing.Point(27, 156);
            this.tilePlansAndGraphics.Name = "tilePlansAndGraphics";
            this.tilePlansAndGraphics.Size = new System.Drawing.Size(161, 70);
            this.tilePlansAndGraphics.Style = MetroFramework.MetroColorStyle.Orange;
            this.tilePlansAndGraphics.TabIndex = 3;
            this.tilePlansAndGraphics.Text = "Планы и графики";
            this.tilePlansAndGraphics.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tilePlansAndGraphics.UseSelectable = true;
            this.tilePlansAndGraphics.Click += new System.EventHandler(this.ChangeTab);
            // 
            // tileDBManagement
            // 
            this.tileDBManagement.ActiveControl = null;
            this.tileDBManagement.Location = new System.Drawing.Point(27, 308);
            this.tileDBManagement.Name = "tileDBManagement";
            this.tileDBManagement.Size = new System.Drawing.Size(161, 70);
            this.tileDBManagement.Style = MetroFramework.MetroColorStyle.Orange;
            this.tileDBManagement.TabIndex = 4;
            this.tileDBManagement.Text = "Базовые справочники";
            this.tileDBManagement.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileDBManagement.UseSelectable = true;
            this.tileDBManagement.Click += new System.EventHandler(this.ChangeTab);
            // 
            // tileWorkAnalysis
            // 
            this.tileWorkAnalysis.ActiveControl = null;
            this.tileWorkAnalysis.Location = new System.Drawing.Point(27, 384);
            this.tileWorkAnalysis.Name = "tileWorkAnalysis";
            this.tileWorkAnalysis.Size = new System.Drawing.Size(161, 70);
            this.tileWorkAnalysis.Style = MetroFramework.MetroColorStyle.Orange;
            this.tileWorkAnalysis.TabIndex = 5;
            this.tileWorkAnalysis.Text = "Анализ работы";
            this.tileWorkAnalysis.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileWorkAnalysis.UseSelectable = true;
            this.tileWorkAnalysis.Click += new System.EventHandler(this.ChangeTab);
            // 
            // tileExcelParcers
            // 
            this.tileExcelParcers.ActiveControl = null;
            this.tileExcelParcers.Location = new System.Drawing.Point(27, 460);
            this.tileExcelParcers.Name = "tileExcelParcers";
            this.tileExcelParcers.Size = new System.Drawing.Size(161, 70);
            this.tileExcelParcers.Style = MetroFramework.MetroColorStyle.Orange;
            this.tileExcelParcers.TabIndex = 6;
            this.tileExcelParcers.Text = "Excel-парсеры";
            this.tileExcelParcers.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileExcelParcers.UseSelectable = true;
            this.tileExcelParcers.Click += new System.EventHandler(this.ChangeTab);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 554);
            this.Controls.Add(this.tileExcelParcers);
            this.Controls.Add(this.tileWorkAnalysis);
            this.Controls.Add(this.tileReports);
            this.Controls.Add(this.tileDBManagement);
            this.Controls.Add(this.tilePlansAndGraphics);
            this.Controls.Add(this.tileJournalsAndLists);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Отдел главного технолога";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabDetailDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetailDB)).EndInit();
            this.tabCoworkersDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.tabMachinesDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage tabProgramJournal;
        private MetroFramework.Controls.MetroTabPage tabProgramReport;
        private MetroFramework.Controls.MetroTabPage tabPlanUP;
        private MetroFramework.Controls.MetroTabPage tabSummaryTechnologistReport;
        private MetroFramework.Controls.MetroTabPage tabSummaryProgramReport;
        private MetroFramework.Controls.MetroTabPage tabOEJournal;
        private MetroFramework.Controls.MetroTabPage tabAnotherTaskReport;
        private MetroFramework.Controls.MetroTabPage tabTechnologistReport;
        private MetroFramework.Controls.MetroTabPage tabTPJournal;
        private MetroFramework.Controls.MetroTabPage tabPlanTP;
        private MetroFramework.Controls.MetroTile tileJournalsAndLists;
        private MetroFramework.Controls.MetroTile tileReports;
        private MetroFramework.Controls.MetroTile tilePlansAndGraphics;
        private MetroFramework.Controls.MetroTile tileDBManagement;
        private MetroFramework.Controls.MetroTile tileWorkAnalysis;
        private MetroFramework.Controls.MetroTile tileExcelParcers;
        private MetroFramework.Controls.MetroTabPage tabDetailDB;
        private MetroFramework.Controls.MetroTabPage tabCoworkersDB;
        private MetroFramework.Controls.MetroTabPage tabMachinesDB;
        private MetroFramework.Controls.MetroGrid gridDetailDB;
        private MetroFramework.Controls.MetroButton btnAddDetailDB;
        private MetroFramework.Controls.MetroButton btnSearchDetailDB;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton btnDeleteDetailDB;
        private MetroFramework.Controls.MetroButton btnModifyDetailDB;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroButton metroButton7;
        private MetroFramework.Controls.MetroButton metroButton8;
        private MetroFramework.Controls.MetroGrid metroGrid2;
    }
}