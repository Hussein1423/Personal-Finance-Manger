using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Finance_Manger
{
    internal class clsFile
    {
        public string FileIncome {  get; set; }
        public string FileExpenses {  get; set; }
        public  string FileSaving { get; set; }

       public clsFile(string fileIncome,string fileExpenses,string fileSaving)
        {
            FileIncome = fileIncome;
            FileExpenses = fileExpenses;
            FileSaving = fileSaving;
        }
       public LinkedList<double> amounts(string File)
        {

            LinkedList<double> allAmounts = new LinkedList<double>();
            foreach (string line in allFinancials(File))
            {
                string[] split = line.Split('*');
                allAmounts.AddFirst(double.Parse(split[0]));
            }
            return allAmounts;
        }
       public Array allFinancials(string file)
        {
            return File.ReadAllLines(file);
        }
        public void CreateLiveChart(TabControl tabControl)
        {
            // إعداد المخطط
            LiveCharts.WinForms.CartesianChart cartesianChart = new LiveCharts.WinForms.CartesianChart();

            LinkedList<double> incomeList = amounts(FileIncome);
            var chartValues = new ChartValues<double>(incomeList);
            // إضافة بيانات إلى المخطط
            cartesianChart.Series.Add(new ColumnSeries
            {

                Title = "Income",
                Values = chartValues
            });

            LinkedList<double> expList = amounts(FileExpenses);
            var chartValuesexp = new ChartValues<double>(expList);
            cartesianChart.Series.Add(new ColumnSeries
            {
                Title = "Expenses",
                Values = chartValuesexp
            });

            LinkedList<double> saveList = amounts(FileSaving);
            var chartValuesave = new ChartValues<double>(saveList);
            cartesianChart.Series.Add(new ColumnSeries
            {
                Title = "Save",
                Values = chartValuesave
            });
            cartesianChart.AxisY.Add(new Axis
            {
                Title = "Income",
                LabelFormatter = value => value.ToString("C") // تنسيق الأرقام
            });
            cartesianChart.Dock = DockStyle.Fill;
            // عرض المخطط على النافذة
            tabControl.TabPages[0].Controls.Add(cartesianChart);
        }

        public void saveData(string join, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(join);
            }
        }

        public void readFromFile(string filePath, ListView listView)
        {
            if (File.Exists(filePath))
            {
                foreach (string line in allFinancials(filePath))
                {
                    string[] split = line.Split('*');
                    string amount = split[0];
                    string type = split[1].Trim();
                    string date = split[2].Trim();
                    string note = split[3].Trim();
                    ListViewItem item = new ListViewItem();
                    item.Text = amount;
                    item.SubItems.Add(date);
                    item.SubItems.Add(type);
                    item.SubItems.Add(note);

                    listView.Items.Add(item);
                }
            }
        }

        public void readFromSavingFile(string filePath, ListView listView)
        {
            if (File.Exists(filePath))
            {
                foreach (string line in allFinancials(filePath))
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



    }
}
