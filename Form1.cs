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
                file.saveData(join(msktxtAmountI,dtpDateI,cbxTypesI,rtbNotesI),file.FileIncome);
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
                file.saveData(join(msktxtAmountE, dtpDateE, cbxTypesE, rtbNotesE), file.FileExpenses);
                MessageBox.Show("Successfully,Your Personal Financial Was Saved ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxTypesE.Text = "";
                msktxtAmountE.Clear();
                
            }
            else
            {
                MessageBox.Show("Error Your Fieldes are empty ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void makeFromDateLessThanToDate()
        {
            dtpDateFromR.MaxDate = dtpDateToR.Value;
            dtpDateToR.MaxDate = DateTime.Now;
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                listView1.Items.Clear();
                file.readFromFile(file.FileIncome,listView1);
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                listView2.Items.Clear();
                file.readFromFile(file.FileExpenses,listView2);
            }
            else if (tabControl1.SelectedIndex == 0)
            {
              
                tabControl1.TabPages[0].Controls.Clear();
                file.CreateLiveChart(tabControl1);
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                listView3.Items.Clear();
                file.readFromSavingFile(file.FileSaving, listView3);
            }
            else if(tabControl1.SelectedIndex == 4)
            {
               makeFromDateLessThanToDate();
            }
        }

        private void btnSaveS_Click(object sender, EventArgs e)
        {
            if(msktxtAmountS.Text != "" && msktxtDaysS.Text !="" || msktxtMonthsS.Text != "" || msktxtYearsS.Text != "")
            {
               file.saveData(join(msktxtAmountS, msktxtDaysS, msktxtMonthsS, msktxtYearsS,rtbNotesS),file.FileSaving);
                MessageBox.Show("Successfully,Your Saving Was Saved ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error Your Fieldes are empty ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string MonthFrom()
        {
            return dtpDateFromR.Value.Month.ToString();
        }

        string MonthTo()
        {
            return dtpDateToR.Value.Month.ToString();
        }

        string YearFrom()
        {
            return dtpDateFromR.Value.Year.ToString();
        }

        string YearTo()
        {
            return dtpDateToR.Value.Year.ToString();
        }
        bool isInYear(String yearFromFile,String yearFrom,String yearTo)
        {
          int YearFile = Int32.Parse(yearFromFile);
          int YearFrom = Int32.Parse(yearFrom);
          int YearTo   = Int32.Parse(yearTo);
            if (YearFile >= YearFrom && YearFile <= YearTo)
            {
                return true;
            }
            return false;
        }
        bool isInMonth(String monthFromFile, String monthFrom,String monthTo)
        {

            int MonthFile = Int32.Parse(monthFromFile);
            int MonthFrom = Int32.Parse(monthFrom);
            int MonthTo = Int32.Parse(monthTo);
            if (MonthFile >= MonthFrom && MonthFile <= MonthTo)
            {
                return true;
            }
            return false;
        }
        String[] shareMyDataToItem(String item)
        {
            string[] split = item.Split('*');
            string[] items = { split[0], split[1].Trim().Split('/')[0], split[1].Trim().Split('/')[2].Split(' ')[0] };
            return items;
            
        }
        ListViewItem createItem()
        {
            ListViewItem Item = new ListViewItem();
            Item.Text = MonthFrom() + " - " + MonthTo();
            Item.SubItems.Add(YearFrom() + "-" + YearTo());
            Array allIncome = file.allFinancials(FileIncome);
            Array allExpenses = file.allFinancials(FileExpenses);
            float totalIncome = 0.0f;
            foreach (String item in allIncome)
            {
                String[] items =  shareMyDataToItem(item);
                if (isInMonth(items[1],MonthFrom(),MonthTo()) && isInYear(items[2], YearFrom(),YearTo()))
                {
                    totalIncome += float.Parse(items[0]);
                }
            }
            Item.SubItems.Add(totalIncome.ToString());
            float totalExpenses = 0.0f;
            foreach (String item in allExpenses)
            {
                String[] items = shareMyDataToItem(item);
                if (isInMonth(items[1], MonthFrom(), MonthTo()) && isInYear(items[2], YearFrom(), YearTo()))
                {
                    totalExpenses += float.Parse(items[0]);
                }
            }
            Item.SubItems.Add(totalExpenses.ToString());
            return Item;
        }
        private void btnShowR_Click(object sender, EventArgs e)
        {
            listView4.Items.Add(createItem());
        }
        
        private void dtpDateToR_ValueChanged(object sender, EventArgs e)
        {
            makeFromDateLessThanToDate();
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
