namespace Personal_Finance_Manger
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabIncome = new System.Windows.Forms.TabPage();
            this.btnSaveI = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbNotesI = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTypesI = new System.Windows.Forms.ComboBox();
            this.dtpDateI = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.msktxtAmountI = new System.Windows.Forms.MaskedTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Notes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabExpenses = new System.Windows.Forms.TabPage();
            this.btnSaveE = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbNotesE = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxTypesE = new System.Windows.Forms.ComboBox();
            this.dtpDateE = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.msktxtAmountE = new System.Windows.Forms.MaskedTextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabSavings = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.amountS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.days = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.months = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.years = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notesS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.msktxtYearsS = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.msktxtMonthsS = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.msktxtDaysS = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSaveS = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.rtbNotesS = new System.Windows.Forms.RichTextBox();
            this.msktxtAmountS = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Reports = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpDateToR = new System.Windows.Forms.DateTimePicker();
            this.btnShowR = new System.Windows.Forms.Button();
            this.dtpDateFromR = new System.Windows.Forms.DateTimePicker();
            this.listView4 = new System.Windows.Forms.ListView();
            this.reportMonths = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reportYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reportTotalIncome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reportTotalExpernses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabIncome.SuspendLayout();
            this.tabExpenses.SuspendLayout();
            this.tabSavings.SuspendLayout();
            this.Reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabIncome);
            this.tabControl1.Controls.Add(this.tabExpenses);
            this.tabControl1.Controls.Add(this.tabSavings);
            this.tabControl1.Controls.Add(this.Reports);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(89, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 450);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabHome
            // 
            this.tabHome.Location = new System.Drawing.Point(44, 4);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(755, 442);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tabIncome
            // 
            this.tabIncome.Controls.Add(this.btnSaveI);
            this.tabIncome.Controls.Add(this.label4);
            this.tabIncome.Controls.Add(this.rtbNotesI);
            this.tabIncome.Controls.Add(this.label3);
            this.tabIncome.Controls.Add(this.label2);
            this.tabIncome.Controls.Add(this.cbxTypesI);
            this.tabIncome.Controls.Add(this.dtpDateI);
            this.tabIncome.Controls.Add(this.label1);
            this.tabIncome.Controls.Add(this.msktxtAmountI);
            this.tabIncome.Controls.Add(this.listView1);
            this.tabIncome.Location = new System.Drawing.Point(44, 4);
            this.tabIncome.Name = "tabIncome";
            this.tabIncome.Padding = new System.Windows.Forms.Padding(3);
            this.tabIncome.Size = new System.Drawing.Size(755, 442);
            this.tabIncome.TabIndex = 1;
            this.tabIncome.Text = "Income";
            this.tabIncome.UseVisualStyleBackColor = true;
            // 
            // btnSaveI
            // 
            this.btnSaveI.Location = new System.Drawing.Point(647, 116);
            this.btnSaveI.Name = "btnSaveI";
            this.btnSaveI.Size = new System.Drawing.Size(75, 37);
            this.btnSaveI.TabIndex = 10;
            this.btnSaveI.Text = "Save";
            this.btnSaveI.UseVisualStyleBackColor = true;
            this.btnSaveI.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Notes";
            // 
            // rtbNotesI
            // 
            this.rtbNotesI.Location = new System.Drawing.Point(66, 74);
            this.rtbNotesI.Name = "rtbNotesI";
            this.rtbNotesI.Size = new System.Drawing.Size(557, 79);
            this.rtbNotesI.TabIndex = 8;
            this.rtbNotesI.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Types";
            // 
            // cbxTypesI
            // 
            this.errorProvider1.SetError(this.cbxTypesI, "Required");
            this.cbxTypesI.FormattingEnabled = true;
            this.cbxTypesI.Items.AddRange(new object[] {
            "Salary",
            "Frindship",
            "Relationship",
            "Rent",
            "Alms",
            "Award",
            "Other"});
            this.cbxTypesI.Location = new System.Drawing.Point(180, 29);
            this.cbxTypesI.Name = "cbxTypesI";
            this.cbxTypesI.Size = new System.Drawing.Size(175, 27);
            this.cbxTypesI.TabIndex = 5;
            this.cbxTypesI.Validating += new System.ComponentModel.CancelEventHandler(this.cbxTypesI_Validating);
            // 
            // dtpDateI
            // 
            this.dtpDateI.CustomFormat = "dd-MMM-yyyy";
            this.dtpDateI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateI.Location = new System.Drawing.Point(390, 29);
            this.dtpDateI.Name = "dtpDateI";
            this.dtpDateI.Size = new System.Drawing.Size(172, 27);
            this.dtpDateI.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount";
            // 
            // msktxtAmountI
            // 
            this.errorProvider1.SetError(this.msktxtAmountI, "Required");
            this.msktxtAmountI.Location = new System.Drawing.Point(11, 29);
            this.msktxtAmountI.Mask = "0000000000000000";
            this.msktxtAmountI.Name = "msktxtAmountI";
            this.msktxtAmountI.Size = new System.Drawing.Size(152, 27);
            this.msktxtAmountI.TabIndex = 0;
            this.msktxtAmountI.Validating += new System.ComponentModel.CancelEventHandler(this.msktxtAmountI_Validating);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Amount,
            this.Type,
            this.Date,
            this.Notes});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 159);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(760, 287);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 89;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // Notes
            // 
            this.Notes.Text = "Notes";
            // 
            // tabExpenses
            // 
            this.tabExpenses.Controls.Add(this.btnSaveE);
            this.tabExpenses.Controls.Add(this.label5);
            this.tabExpenses.Controls.Add(this.rtbNotesE);
            this.tabExpenses.Controls.Add(this.label6);
            this.tabExpenses.Controls.Add(this.label7);
            this.tabExpenses.Controls.Add(this.cbxTypesE);
            this.tabExpenses.Controls.Add(this.dtpDateE);
            this.tabExpenses.Controls.Add(this.label8);
            this.tabExpenses.Controls.Add(this.msktxtAmountE);
            this.tabExpenses.Controls.Add(this.listView2);
            this.tabExpenses.Location = new System.Drawing.Point(44, 4);
            this.tabExpenses.Name = "tabExpenses";
            this.tabExpenses.Padding = new System.Windows.Forms.Padding(3);
            this.tabExpenses.Size = new System.Drawing.Size(755, 442);
            this.tabExpenses.TabIndex = 2;
            this.tabExpenses.Text = "Expenses";
            this.tabExpenses.UseVisualStyleBackColor = true;
            // 
            // btnSaveE
            // 
            this.btnSaveE.Location = new System.Drawing.Point(646, 111);
            this.btnSaveE.Name = "btnSaveE";
            this.btnSaveE.Size = new System.Drawing.Size(75, 37);
            this.btnSaveE.TabIndex = 19;
            this.btnSaveE.Text = "Save";
            this.btnSaveE.UseVisualStyleBackColor = true;
            this.btnSaveE.Click += new System.EventHandler(this.btnSaveE_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Notes";
            // 
            // rtbNotesE
            // 
            this.rtbNotesE.Location = new System.Drawing.Point(64, 69);
            this.rtbNotesE.Name = "rtbNotesE";
            this.rtbNotesE.Size = new System.Drawing.Size(557, 79);
            this.rtbNotesE.TabIndex = 17;
            this.rtbNotesE.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Types";
            // 
            // cbxTypesE
            // 
            this.errorProvider1.SetError(this.cbxTypesE, "Required");
            this.cbxTypesE.FormattingEnabled = true;
            this.cbxTypesE.Items.AddRange(new object[] {
            "Eat",
            "Drink",
            "Transport",
            "Entertainment",
            "Alms",
            "Net / Account",
            "Tuition",
            "Institute",
            "Other"});
            this.cbxTypesE.Location = new System.Drawing.Point(178, 24);
            this.cbxTypesE.Name = "cbxTypesE";
            this.cbxTypesE.Size = new System.Drawing.Size(175, 27);
            this.cbxTypesE.TabIndex = 14;
            this.cbxTypesE.Validating += new System.ComponentModel.CancelEventHandler(this.cbxTypesE_Validating);
            // 
            // dtpDateE
            // 
            this.dtpDateE.CustomFormat = "dd-MMM-yyyy";
            this.dtpDateE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateE.Location = new System.Drawing.Point(388, 24);
            this.dtpDateE.Name = "dtpDateE";
            this.dtpDateE.Size = new System.Drawing.Size(172, 27);
            this.dtpDateE.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Amount";
            // 
            // msktxtAmountE
            // 
            this.errorProvider1.SetError(this.msktxtAmountE, "Required");
            this.msktxtAmountE.Location = new System.Drawing.Point(9, 24);
            this.msktxtAmountE.Mask = "0000000000000000";
            this.msktxtAmountE.Name = "msktxtAmountE";
            this.msktxtAmountE.Size = new System.Drawing.Size(152, 27);
            this.msktxtAmountE.TabIndex = 11;
            this.msktxtAmountE.Validating += new System.ComponentModel.CancelEventHandler(this.msktxtAmountE_Validating);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(-3, 154);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(760, 287);
            this.listView2.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView2.TabIndex = 10;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Amount";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Notes";
            // 
            // tabSavings
            // 
            this.tabSavings.Controls.Add(this.listView3);
            this.tabSavings.Controls.Add(this.msktxtYearsS);
            this.tabSavings.Controls.Add(this.label13);
            this.tabSavings.Controls.Add(this.msktxtMonthsS);
            this.tabSavings.Controls.Add(this.label12);
            this.tabSavings.Controls.Add(this.msktxtDaysS);
            this.tabSavings.Controls.Add(this.label11);
            this.tabSavings.Controls.Add(this.btnSaveS);
            this.tabSavings.Controls.Add(this.label10);
            this.tabSavings.Controls.Add(this.rtbNotesS);
            this.tabSavings.Controls.Add(this.msktxtAmountS);
            this.tabSavings.Controls.Add(this.label9);
            this.tabSavings.Location = new System.Drawing.Point(44, 4);
            this.tabSavings.Name = "tabSavings";
            this.tabSavings.Size = new System.Drawing.Size(755, 442);
            this.tabSavings.TabIndex = 3;
            this.tabSavings.Text = "Savings";
            this.tabSavings.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.amountS,
            this.days,
            this.months,
            this.years,
            this.notesS});
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(-1, 159);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(760, 287);
            this.listView3.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView3.TabIndex = 24;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // amountS
            // 
            this.amountS.Text = "Amount";
            this.amountS.Width = 89;
            // 
            // days
            // 
            this.days.Text = "Days";
            // 
            // months
            // 
            this.months.Text = "Months";
            // 
            // years
            // 
            this.years.Text = "Years";
            // 
            // notesS
            // 
            this.notesS.Text = "Notes";
            // 
            // msktxtYearsS
            // 
            this.msktxtYearsS.Location = new System.Drawing.Point(522, 24);
            this.msktxtYearsS.Mask = "00";
            this.msktxtYearsS.Name = "msktxtYearsS";
            this.msktxtYearsS.Size = new System.Drawing.Size(152, 27);
            this.msktxtYearsS.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(518, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 19);
            this.label13.TabIndex = 22;
            this.label13.Text = "Years";
            // 
            // msktxtMonthsS
            // 
            this.msktxtMonthsS.Location = new System.Drawing.Point(352, 24);
            this.msktxtMonthsS.Mask = "00";
            this.msktxtMonthsS.Name = "msktxtMonthsS";
            this.msktxtMonthsS.Size = new System.Drawing.Size(152, 27);
            this.msktxtMonthsS.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(348, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "Months";
            // 
            // msktxtDaysS
            // 
            this.msktxtDaysS.Location = new System.Drawing.Point(180, 24);
            this.msktxtDaysS.Mask = "00";
            this.msktxtDaysS.Name = "msktxtDaysS";
            this.msktxtDaysS.Size = new System.Drawing.Size(152, 27);
            this.msktxtDaysS.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 19);
            this.label11.TabIndex = 18;
            this.label11.Text = "Days";
            // 
            // btnSaveS
            // 
            this.btnSaveS.Location = new System.Drawing.Point(647, 116);
            this.btnSaveS.Name = "btnSaveS";
            this.btnSaveS.Size = new System.Drawing.Size(75, 37);
            this.btnSaveS.TabIndex = 17;
            this.btnSaveS.Text = "Save";
            this.btnSaveS.UseVisualStyleBackColor = true;
            this.btnSaveS.Click += new System.EventHandler(this.btnSaveS_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Notes";
            // 
            // rtbNotesS
            // 
            this.rtbNotesS.Location = new System.Drawing.Point(66, 74);
            this.rtbNotesS.Name = "rtbNotesS";
            this.rtbNotesS.Size = new System.Drawing.Size(557, 79);
            this.rtbNotesS.TabIndex = 15;
            this.rtbNotesS.Text = "";
            // 
            // msktxtAmountS
            // 
            this.errorProvider1.SetError(this.msktxtAmountS, "Required");
            this.msktxtAmountS.Location = new System.Drawing.Point(9, 24);
            this.msktxtAmountS.Mask = "0000000000000000";
            this.msktxtAmountS.Name = "msktxtAmountS";
            this.msktxtAmountS.Size = new System.Drawing.Size(152, 27);
            this.msktxtAmountS.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Amount";
            // 
            // Reports
            // 
            this.Reports.Controls.Add(this.label15);
            this.Reports.Controls.Add(this.label14);
            this.Reports.Controls.Add(this.dtpDateToR);
            this.Reports.Controls.Add(this.btnShowR);
            this.Reports.Controls.Add(this.dtpDateFromR);
            this.Reports.Controls.Add(this.listView4);
            this.Reports.Location = new System.Drawing.Point(44, 4);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(755, 442);
            this.Reports.TabIndex = 4;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(237, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 19);
            this.label15.TabIndex = 30;
            this.label15.Text = "To Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 19);
            this.label14.TabIndex = 29;
            this.label14.Text = "From Date";
            // 
            // dtpDateToR
            // 
            this.dtpDateToR.CustomFormat = "MMM-yyyy";
            this.dtpDateToR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateToR.Location = new System.Drawing.Point(241, 38);
            this.dtpDateToR.Name = "dtpDateToR";
            this.dtpDateToR.Size = new System.Drawing.Size(140, 27);
            this.dtpDateToR.TabIndex = 28;
            // 
            // btnShowR
            // 
            this.btnShowR.Location = new System.Drawing.Point(133, 95);
            this.btnShowR.Name = "btnShowR";
            this.btnShowR.Size = new System.Drawing.Size(140, 34);
            this.btnShowR.TabIndex = 27;
            this.btnShowR.Text = "Show";
            this.btnShowR.UseVisualStyleBackColor = true;
            this.btnShowR.Click += new System.EventHandler(this.btnShowR_Click);
            // 
            // dtpDateFromR
            // 
            this.dtpDateFromR.CustomFormat = "MMM-yyyy";
            this.dtpDateFromR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFromR.Location = new System.Drawing.Point(13, 38);
            this.dtpDateFromR.Name = "dtpDateFromR";
            this.dtpDateFromR.Size = new System.Drawing.Size(140, 27);
            this.dtpDateFromR.TabIndex = 26;
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.reportMonths,
            this.reportYear,
            this.reportTotalIncome,
            this.reportTotalExpernses});
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(-1, 159);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(760, 287);
            this.listView4.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView4.TabIndex = 25;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // reportMonths
            // 
            this.reportMonths.Text = "Month";
            this.reportMonths.Width = 89;
            // 
            // reportYear
            // 
            this.reportYear.Text = "Year";
            // 
            // reportTotalIncome
            // 
            this.reportTotalIncome.Text = "TotalIncome";
            this.reportTotalIncome.Width = 227;
            // 
            // reportTotalExpernses
            // 
            this.reportTotalExpernses.Text = "TotalExpernses";
            this.reportTotalExpernses.Width = 121;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabIncome.ResumeLayout(false);
            this.tabIncome.PerformLayout();
            this.tabExpenses.ResumeLayout(false);
            this.tabExpenses.PerformLayout();
            this.tabSavings.ResumeLayout(false);
            this.tabSavings.PerformLayout();
            this.Reports.ResumeLayout(false);
            this.Reports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabIncome;
        private System.Windows.Forms.TabPage tabExpenses;
        private System.Windows.Forms.TabPage tabSavings;
        private System.Windows.Forms.TabPage Reports;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Notes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msktxtAmountI;
        private System.Windows.Forms.DateTimePicker dtpDateI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTypesI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbNotesI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbNotesE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxTypesE;
        private System.Windows.Forms.DateTimePicker dtpDateE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox msktxtAmountE;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnSaveI;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSaveE;
        private System.Windows.Forms.Button btnSaveS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbNotesS;
        private System.Windows.Forms.MaskedTextBox msktxtAmountS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox msktxtDaysS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox msktxtYearsS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox msktxtMonthsS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader amountS;
        private System.Windows.Forms.ColumnHeader days;
        private System.Windows.Forms.ColumnHeader months;
        private System.Windows.Forms.ColumnHeader years;
        private System.Windows.Forms.ColumnHeader notesS;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader reportMonths;
        private System.Windows.Forms.ColumnHeader reportYear;
        private System.Windows.Forms.ColumnHeader reportTotalIncome;
        private System.Windows.Forms.ColumnHeader reportTotalExpernses;
        private System.Windows.Forms.DateTimePicker dtpDateFromR;
        private System.Windows.Forms.Button btnShowR;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpDateToR;
    }
}

