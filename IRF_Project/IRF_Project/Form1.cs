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

        #region Properties

        CostumButton _fileButton;
        CostumButton _startButton;
        CostumButton _resetButton;
        string _educationComboBoxOption = "";
        string _jobComboBoxOption = "";
        string _choosenData = "";
        int _minAge;
        int _maxAge;
        int _ageStart;
        int _ageEnd;
        Gender _choosenGender = Gender.All;
        string _newLine = Environment.NewLine;
        string _fileName = "";
        bool _reset = false;

        #endregion

        public Form1()
        {
            InitializeComponent();
            LoadScreen();
            //CreateChart();
        }

        public void LoadScreen()
        {
            CostumButton fileButton = new CostumButton(dataCB.Width, dataCB.Height * 2, chartbase.Left - ageL.Left, dataL.Top, "Fájl betöltése");
            Controls.Add(fileButton);
            _fileButton = fileButton;
            fileButton.Enabled = true;
            fileButton.Click += FileButton_Click; ;

            CostumButton startButton = new CostumButton(allRB.Width, allRB.Height * 2, fileButton.Left, allRB.Top, "Mehet!");
            Controls.Add(startButton);
            _startButton = startButton;
            startButton.Enabled = false;
            startButton.Click += StartButton_Click;

            CostumButton resetButton = new CostumButton(allRB.Width, allRB.Height * 2, chartbase.Left - ageL.Left / 2, startButton.Top, "Reset");
            Controls.Add(resetButton);
            _resetButton = resetButton;
            resetButton.Enabled = false;
            resetButton.Click += ResetButton_Click; ;
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            LoadData();
            RefreshDataGridView();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            List<Person> toDelete = new List<Person>();

            if (ageStartTB.Text.Equals(""))
            {
                ageStartTB.Text = _minAge.ToString();
            }
            _ageStart = int.Parse(ageStartTB.Text);
            if (ageEndTB.Text.Equals(""))
            {
                ageEndTB.Text = _maxAge.ToString();
            }
            _ageEnd = int.Parse(ageEndTB.Text);
            if (_ageStart > _ageEnd)
            {
                MessageBox.Show(string.Format("A kor esetében a kezdőértéknek kisebbnek {0} kell lennie, mint a záróértéknek!", _newLine));
                return;
            }
            toDelete = ChooseGender(_choosenGender);
            foreach (Person person in toDelete)
            {
                people.Remove(person);
            }
            RefreshDataGridView();
        }

        private List<Person> ChooseGender(Gender choosenGender)
        {
            List<Person> toDelete = new List<Person>();
            List<Person> toDeleteAgeMin = new List<Person>();
            List<Person> toDeleteAgeMax = new List<Person>();
            List<Person> toDeleteGender = new List<Person>();
            toDeleteAgeMin = (from x in people
                              where x.Age < _ageStart
                              select x).ToList();
            toDeleteAgeMax = (from x in people
                              where x.Age > _ageEnd
                              select x).ToList();
            foreach (var person in toDeleteAgeMin)
            {
                toDelete.Add(person);
            }
            foreach (var person in toDeleteAgeMax)
            {
                toDelete.Add(person);
            }

            if (choosenGender != Gender.All)
            {
                toDeleteGender = (from x in people
                                  where x.Gender != _choosenGender
                                  select x).ToList();
                foreach (var person in toDeleteGender)
                {
                    toDelete.Add(person);
                }
            }
            return toDelete;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            people.Clear();
            femaleRB.Checked = false;
            maleRB.Checked = false;
            allRB.Checked = false;
            _startButton.Enabled = false;
            ageStartTB.Text = "";
            ageEndTB.Text = "";
            dataCB.SelectedIndex = 0;
            _reset = true;
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
            people.Clear();
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();

            ///
            ///Commented out for faster testing
            ///

            //if (!_reset)
            //{
            //    OpenFileDialog ofd = new OpenFileDialog();
            //    if (ofd.ShowDialog() != DialogResult.OK)
            //    {
            //        _resetButton.Enabled = false;
            //        _startButton.Enabled = false;
            //        return;
            //    }
            //    _fileName = ofd.FileName;

            //}
            //else
            //{
            _fileName = "people.csv";
            //}
            using (StreamReader sr = new StreamReader(_fileName, Encoding.Default))
            {
                string[] headline = sr.ReadLine().Split(';');
                _educationComboBoxOption = headline[4];
                _jobComboBoxOption = headline[5];
                datas.Add(_educationComboBoxOption);
                datas.Add(_jobComboBoxOption);
                while (!sr.EndOfStream)
                {
                    bool hasJob = false;
                    string[] line = sr.ReadLine().Split(';');
                    if (line[5].Equals("van"))
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
            SaveAgeInterval();
            dataCB.DataSource = datas;
            label4.Text = people.Count.ToString();
            _resetButton.Enabled = true;
            _reset = false;
        }

        private void SaveAgeInterval()
        {
            var lowestAge = (from x in people
                             orderby x.Age ascending
                             select x.Age).First();
            _minAge = lowestAge;

            var highestAge = (from x in people
                              orderby x.Age descending
                              select x.Age).First();
            _maxAge = highestAge;
        }

        private void hintBT_Click(object sender, EventArgs e)
        {
            var newline = Environment.NewLine;
            MessageBox.Show(String.Format("súgó{0}üzenet", newline));
        }

        private void dataCB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (dataCB.SelectedValue.ToString().Equals(_educationComboBoxOption))
            {
                _choosenData = "Education";
            }
            else if (dataCB.SelectedValue.ToString().Equals(_jobComboBoxOption))
            {
                _choosenData = "hasJob";
            }
        }

        private void ageStartTB_Leave(object sender, EventArgs e)
        {
            if (ageStartTB.Text.Equals(""))
            {
                ageStartTB.Text = _minAge.ToString();
            }
            else
            {
                try
                {
                    if (int.Parse(ageStartTB.Text) > _maxAge)
                    {
                        MessageBox.Show(string.Format("A maximális életkor a beolvasott fájl alapján: {0}", _maxAge.ToString()));
                        ageStartTB.Text = "";
                        ageStartTB.Focus();
                    }
                    else if (int.Parse(ageStartTB.Text) < _minAge)
                    {
                        MessageBox.Show(string.Format("A minimális életkor a beolvasott fájl alapján: {0}", _minAge.ToString()));
                        ageStartTB.Text = _minAge.ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Csak egy számot írjon be!");
                    ageStartTB.Focus();
                }
            }
        }

        private void ageEndTB_Leave(object sender, EventArgs e)
        {
            if (ageEndTB.Text.Equals(""))
            {
                ageEndTB.Text = _maxAge.ToString();
            }
            else
            {
                try
                {
                    if (int.Parse(ageEndTB.Text) < _minAge)
                    {
                        MessageBox.Show(string.Format("A minimális életkor a beolvasott fájl alapján: {0}", _minAge.ToString()));
                        ageEndTB.Text = "";
                        ageEndTB.Focus();
                    }
                    else if (int.Parse(ageEndTB.Text) > _maxAge)
                    {
                        MessageBox.Show(string.Format("A maximális életkor a beolvasott fájl alapján: {0}", _maxAge.ToString()));
                        ageEndTB.Text = _maxAge.ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Csak egy számot írjon be!");
                    ageEndTB.Focus();
                }
            }
        }

        private void femaleRB_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleRB.Checked)
            {
                _choosenGender = Gender.Female;
            }
            _startButton.Enabled = true;
        }

        private void maleRB_CheckedChanged(object sender, EventArgs e)
        {
            if (maleRB.Checked)
            {
                _choosenGender = Gender.Male;
            }
            _startButton.Enabled = true;
        }

        private void allRB_CheckedChanged(object sender, EventArgs e)
        {
            if (allRB.Checked)
            {
                _choosenGender = Gender.All;
            }
            _startButton.Enabled = true;
        }
    }
}

