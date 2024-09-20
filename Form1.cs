using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public void  saveData(string join,string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(join);
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
                saveData(join(msktxtAmountI,dtpDateI,cbxTypesI,rtbNotesI),FileIncome);
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
                saveData(join(msktxtAmountE, dtpDateE, cbxTypesE, rtbNotesE), FileExpenses);
                MessageBox.Show("Successfully,Your Personal Financial Was Saved ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxTypesE.Text = "";
                msktxtAmountE.Clear();
                
            }
            else
            {
                MessageBox.Show("Error Your Fieldes are empty ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Array lTasks(string file)
        {
            return File.ReadAllLines(file);
        }
        public void readFromFile(string filePath,ListView listView)
        {
            if (File.Exists(filePath))
            {
                foreach (string line in lTasks(filePath))
                {
                    string[] split = line.Split('*');
                    string amount = split[0];
                    string type = split[1].Trim();
                    string date = split[2].Trim();
                    string note = split[3].Trim();
                    ListViewItem item = new ListViewItem();
                    item.Text = amount;
                    item.SubItems.Add(type);
                    item.SubItems.Add(date);
                    item.SubItems.Add(note);
                 
                    listView.Items.Add(item);
                }
            }
        }
        public void readFromSavingFile(string filePath, ListView listView)
        {
            if (File.Exists(filePath))
            {
                foreach (string line in lTasks(filePath))
                {
                    if (line != "")
                    {
                        string[] split = line.Split('*');
                        string amount = split[0];
                        string days = split[1].Trim();
                        string months = split[2].Trim();
                        string years = split[3].Trim();
                        string notes = split[4].Trim();
                        ListViewItem item = new ListViewItem();
                        item.Text = amount;
                        item.SubItems.Add(days);
                        item.SubItems.Add(months);
                        item.SubItems.Add(years);
                        item.SubItems.Add(notes);
                        listView.Items.Add(item);
                    }
                }
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                listView1.Items.Clear();
                readFromFile(FileIncome,listView1);
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                listView2.Items.Clear();
                readFromFile(FileExpenses,listView2);
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                listView3.Items.Clear();
                readFromSavingFile(FileSaving, listView3);
            }
        }

        private void btnSaveS_Click(object sender, EventArgs e)
        {
            if(msktxtAmountS.Text != "" && msktxtDaysS.Text !="" || msktxtMonthsS.Text != "" || msktxtYearsS.Text != "")
            {
               saveData(join(msktxtAmountS, msktxtDaysS, msktxtMonthsS, msktxtYearsS,rtbNotesS),FileSaving);
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
        bool isInYear(String yearFromFile,String yearInList)
        {
          int YearFile = Int32.Parse(yearFromFile);
          int YearList = Int32.Parse(yearInList);
            if (YearFile <= YearList)
            {
                return true;
            }
            return false;
        }
        bool isInMonth(String monthFromFile, String monthInList)
        {

            int MonthFile = Int32.Parse(monthFromFile);
            int MonthList = Int32.Parse(monthInList);
            if (MonthFile <= MonthList)
            {
                return true;
            }
            return false;
        }
    
        ListViewItem createItem()
        {
            ListViewItem Item = new ListViewItem();
            Item.Text = MonthFrom() + " - " + MonthTo();
            Item.SubItems.Add(YearFrom() + "-" + YearTo());
            Array allIncome = lTasks(FileIncome);
            Array allExpenses = lTasks(FileExpenses);
            float totalIncome = 0.0f;
            foreach (String item in allIncome)
            {
                string[] split = item.Split('*');
                string amount = split[0];
                string month = split[1].Trim().Split('/')[0];
                string year = split[1].Trim().Split('/')[2];
                if (isInMonth(month,MonthFrom()))
                {
                    totalIncome += float.Parse(amount);
                }
            }
            Item.SubItems.Add(totalIncome.ToString());
            float totalExpenses = 0.0f;
            foreach (String item in allExpenses)
            {
                string[] split = item.Split('*');
                string amount = split[0];
                string month = split[1].Trim().Split('/')[0];
                string year = split[1].Trim().Split('/')[2];
                if (isInMonth(month, MonthFrom()))
                {
                    totalExpenses += float.Parse(amount);
                }
            }
            Item.SubItems.Add(totalExpenses.ToString());
            return Item;
        }
        private void btnShowR_Click(object sender, EventArgs e)
        {
            listView4.Items.Add(createItem());
        }
    }
}
