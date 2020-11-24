using IRF_Project.Entities;
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

namespace IRF_Project
{
    public partial class Form1 : Form
    {
        #region Lists
        List<Person> people = new List<Person>();
        List<string> datas = new List<string>();
        #endregion
        public Form1()
        {
            InitializeComponent();
            LoadData();
            RefreshDataGridView();
            //CreateChart();
        }
        //public void CreateChart()
        //{
        //    chartbase.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        //}
        private void RefreshDataGridView()
        {
            label4.Text = people.Count.ToString();
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            dataGridView.DataSource = people;
            //chartBindingSource.DataSource = people;
            //dataGridView.Columns[0].HeaderText = "Vezetéknév";
            //dataGridView.Columns[1].HeaderText = "Keresztnév";
            //dataGridView.Columns[2].HeaderText = "Kor";
            //dataGridView.Columns[3].HeaderText = "Nem";
            //dataGridView.Columns[4].HeaderText = "Végzettség";
            //dataGridView.Columns[5].HeaderText = "Van munkája?";
        }

        private void LoadData()
        {
            using (StreamReader sr = new StreamReader("people.csv", Encoding.Default))
            {
                string[] headline = sr.ReadLine().Split(';');
                datas.Add(headline[4]);
                datas.Add(headline[5]);
                while (!sr.EndOfStream)
                {
                    bool hasJob = false;
                    string[] line = sr.ReadLine().Split(';');
                    if (line[5] == "van")
                    {
                        hasJob = true;
                    }
                    else
                    {
                        hasJob = false;
                    }
                    people.Add(new Person()
                    {
                        LastName = line[0],
                        FirstName = line[1],
                        Age = int.Parse(line[2]),
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[3]),
                        Education = line[4],
                        HasJob = hasJob
                    });
                }
            }
            dataCB.DataSource = datas;
            label4.Text = people.Count.ToString();
        }

        private void hintBT_Click(object sender, EventArgs e)
        {
            var newline = Environment.NewLine;
            MessageBox.Show(String.Format("súgó{0}üzenet", newline));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var torlendo = (from x in people
                            where x.HasJob != true
                            select x).ToList();
            foreach (Person person in torlendo)
            {
                people.Remove(person);
            }
            RefreshDataGridView();
        }

        private void resetBT_Click(object sender, EventArgs e)
        {
            people.Clear();
            LoadData();
            RefreshDataGridView();
            //CreateChart();
        }
    }
}

