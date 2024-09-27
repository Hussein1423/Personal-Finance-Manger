using System;
using OfficeOpenXml;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System.Collections.Generic;




namespace Personal_Finance_Manger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string FileIncome = @"K:\My backups\DataBase\AddIncome.txt";
        static string FileExpenses = @"K:\My backups\DataBase\AddExpenses.txt";
        static string FileSaving = @"K:\My backups\DataBase\AddSavings.txt";

        clsFile file = new clsFile(FileIncome,FileExpenses,FileSaving);

        private void ExportToExcel(ListView listView)
    {
            // تعيين الترخيص المجاني باستخدام المسار الكامل
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Report");

                    // إضافة رؤوس الأعمدة
                    worksheet.Cells[1, 1].Value = "Month";
                    worksheet.Cells[1, 2].Value = "Year";
                    worksheet.Cells[1, 3].Value = "TotalIncome";
                    worksheet.Cells[1, 4].Value = "TotalExpenses";

                    // إضافة البيانات من ListView إلى ملف Excel
                    for (int i = 0; i < listView.Items.Count; i++)
                    {
                        worksheet.Cells[i + 2, 1].Value = listView.Items[i].SubItems[0].Text;  
                        worksheet.Cells[i + 2, 2].Value = listView.Items[i].SubItems[1].Text;  
                        worksheet.Cells[i + 2, 3].Value = listView.Items[i].SubItems[2].Text;
                        worksheet.Cells[i + 2, 4].Value = listView.Items[i].SubItems[3].Text;
                    }

                    // حفظ الملف
                    FileInfo excelFile = new FileInfo(sfd.FileName);
                    excelPackage.SaveAs(excelFile);
                }
            }
        }
    }

    
        public string join(MaskedTextBox maskedTextBox,DateTimePicker dateTimePicker,ComboBox comboBox,RichTextBox richTextBox)
        {
            string join = "";
            join += maskedTextBox.Text.Trim();
            join += "*" +dateTimePicker.Value;
            join += "*" + comboBox.Text;
            join += "*" + richTextBox.Text;
            return join;
        }
        public string join(MaskedTextBox maskedTextBox, MaskedTextBox maskedTextBox1, MaskedTextBox maskedTextBox2, MaskedTextBox maskedTextBox3, RichTextBox richTextBox)
        {
            string join = "";
            join += maskedTextBox.Text.Trim();
            join += "*" + maskedTextBox1.Text.Trim();     
            join += "*" + maskedTextBox2.Text.Trim();
            join += "*" + maskedTextBox3.Text.Trim();
            join += "*" + richTextBox.Text;
            return join;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            // base.OnResize(e);
            
            tabControl1.ItemSize = new Size(tabControl1.Height / tabControl1.TabCount - 1, 40);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (msktxtAmountI.Text != "" && !string.IsNullOrEmpty(cbxTypesI.Text))
            {
                clsFile.saveData(join(msktxtAmountI,dtpDateI,cbxTypesI,rtbNotesI),file.FileIncome);
                MessageBox.Show("Successfully,Your Personal Financial Was Saved ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxTypesI.Text = "";
                msktxtAmountI.Clear();
            }
            else
            {
                MessageBox.Show("Error Your Fieldes are empty ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void msktxtAmountI_Validating(object sender, CancelEventArgs e)
        {
            if(msktxtAmountI.Text == "")
            {
                msktxtAmountI.Focus();
            }
            else 
            {
            cbxTypesI.Focus();
            }
           
        }

        private void cbxTypesI_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbxTypesI.Text))
            {
                cbxTypesI.Focus();
            }
        }

        private void msktxtAmountE_Validating(object sender, CancelEventArgs e)
        {
            if (msktxtAmountE.Text == "")
            {
                msktxtAmountE.Focus();
            }
            else
            {
                cbxTypesE.Focus();
            }
        }

        private void cbxTypesE_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbxTypesE.Text))
            {
                cbxTypesE.Focus();
            }
        }

        private void btnSaveE_Click(object sender, EventArgs e)
        {
            if (msktxtAmountE.Text != "" && !string.IsNullOrEmpty(cbxTypesE.Text))
            {
                clsFile.saveData(join(msktxtAmountE, dtpDateE, cbxTypesE, rtbNotesE), file.FileExpenses);
                MessageBox.Show("Successfully,Your Personal Financial Was Saved ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxTypesE.Text = "";
                msktxtAmountE.Clear();
                
            }
            else
            {
                MessageBox.Show("Error Your Fieldes are empty ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                listView1.Items.Clear();
                clsFile.readFromFile(file.FileIncome,listView1);
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                listView2.Items.Clear();
                clsFile.readFromFile(file.FileExpenses,listView2);
            }
            else if (tabControl1.SelectedIndex == 0)
            {
              
                tabControl1.TabPages[0].Controls.Clear();
                file.CreateLiveChart(tabControl1);
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                listView3.Items.Clear();
                clsFile.readFromSavingFile(file.FileSaving, listView3);
            }
            else if(tabControl1.SelectedIndex == 4)
            {
               clsDate.makeFromDateLessThanToDate(dtpDateFromR,dtpDateToR);
            }
        }

        private void btnSaveS_Click(object sender, EventArgs e)
        {
            if(msktxtAmountS.Text != "" && msktxtDaysS.Text !="" || msktxtMonthsS.Text != "" || msktxtYearsS.Text != "")
            {
               clsFile.saveData(join(msktxtAmountS, msktxtDaysS, msktxtMonthsS, msktxtYearsS,rtbNotesS),file.FileSaving);
                MessageBox.Show("Successfully,Your Saving Was Saved ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error Your Fieldes are empty ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        ListViewItem createItem(DateTimePicker dateFrom,DateTimePicker dateTo)
        {
            ListViewItem Item = new ListViewItem();
            Item.Text = clsDate.MonthFrom(dateFrom) + " - " + clsDate.MonthTo(dateTo);
            Item.SubItems.Add(clsDate.YearFrom(dateFrom) + "-" + clsDate.YearTo(dateTo));
            Array allIncome = clsFile.allFinancials(FileIncome);
            Array allExpenses = clsFile.allFinancials(FileExpenses);
            float totalIncome = 0.0f;
            foreach (String item in allIncome)
            {
                String[] items =  clsDate.shareMyDataToItem(item);
                if (clsDate.isInMonth(items[1],clsDate.MonthFrom(dateFrom),clsDate.MonthTo(dateTo)) && clsDate.isInYear(items[2], clsDate.YearFrom(dateFrom), clsDate.YearTo(dateTo)))
                {
                    totalIncome += float.Parse(items[0]);
                }
            }
            Item.SubItems.Add(totalIncome.ToString());
            float totalExpenses = 0.0f;
            foreach (String item in allExpenses)
            {
                String[] items = clsDate.shareMyDataToItem(item);
                if (clsDate.isInMonth(items[1], clsDate.MonthFrom(dateFrom), clsDate.MonthTo(dateTo)) && clsDate.isInYear(items[2], clsDate.YearFrom(dateFrom), clsDate.YearTo(dateTo)))
                {
                    totalExpenses += float.Parse(items[0]);
                }
            }
            Item.SubItems.Add(totalExpenses.ToString());
            return Item;
        }
        private void btnShowR_Click(object sender, EventArgs e)
        {
            listView4.Items.Add(createItem(dtpDateFromR,dtpDateToR));
        }
        
        private void dtpDateToR_ValueChanged(object sender, EventArgs e)
        {
            clsDate.makeFromDateLessThanToDate(dtpDateFromR,dtpDateToR);
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(listView4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            file.CreateLiveChart(tabControl1);
        }
    }
}
