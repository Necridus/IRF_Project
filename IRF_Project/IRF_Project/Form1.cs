using IRF_Project.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IRF_Project
{

    /// <summary>
    /// 
    /// TODO List
    /// </summary>
    /// chart-ban ne true-false legyen, hanem normál igen/nem

    public partial class DataVisualizationForm : Form
    {
        #region Lists

        List<Person> people = new List<Person>();
        List<Person> peopleBeforeModifications = new List<Person>();
        List<string> datas = new List<string>();
        List<string> headerTexts = new List<string>();

        #endregion

        #region Variables

        ControllerButton _fileButton;
        ControllerButton _startButton;
        ControllerButton _resetButton;
        string _educationComboBoxOption = "";
        string _jobComboBoxOption = "";
        string _choosenData = "";
        int _minAge;
        int _maxAge;
        int _ageStart;
        int _ageEnd;
        int _lastAgeEnd;
        Gender _choosenGender = Gender.Mindenki;
        string _newLine = Environment.NewLine;
        string _fileName = "";
        bool _reset = false;
        string newline = Environment.NewLine;

        #endregion

        public DataVisualizationForm()
        {
            InitializeComponent();

            LoadCostumButtons();
            LoadHintButtons();

            dataGridView.Visible = false;
            numberOfPeopleL.Visible = false;
            NumberL.Visible = false;
            allRB.Enabled = false;
            maleRB.Enabled = false;
            femaleRB.Enabled = false;
            dataCB.Enabled = false;
            ageStartTB.Enabled = false;
            ageEndTB.Enabled = false;
        }

        private void LoadCostumButtons()
        {
            ControllerButton fileButton = new ControllerButton(dataCB.Width, dataCB.Height * 2, BigL.Width + 50, BigL.Top, "Fájl betöltése", Color.GhostWhite);
            Controls.Add(fileButton);
            _fileButton = fileButton;
            _fileButton.Enabled = true;
            fileButton.Click += FileButton_Click;

            ControllerButton startButton = new ControllerButton(allRB.Width * 2, allRB.Height * 2, fileButton.Left + fileButton.Width + 25, ageL.Top, "Megjelenítés", Color.Green);
            Controls.Add(startButton);
            _startButton = startButton;
            _startButton.Enabled = false;
            startButton.Click += StartButton_Click;

            ControllerButton resetButton = new ControllerButton(allRB.Width * 2, allRB.Height * 2, startButton.Left, startButton.Top + 50, "Újra", Color.Red);
            Controls.Add(resetButton);
            _resetButton = resetButton;
            _resetButton.Enabled = false;
            resetButton.Click += ResetButton_Click;
        }

        private void LoadHintButtons()
        {
            HintButton dataHintButton = new HintButton(dataL.Left + dataL.Size.Width, dataL.Top - 5, String.Format("A fájl betöltése után lehetősége van kiválasztani,{0}mely adatok megoszlására kíváncsi!", newline));
            Controls.Add(dataHintButton);

            HintButton genderHintButton = new HintButton(genderL.Left + genderL.Size.Width, genderL.Top - 5, String.Format("A fájl betöltése után arra is lehetősége van, hogy kiválassza,{0}melyik nem esetében kíváncsi a megfelelő adatokra!{0}{0}Csak ebben az esetben lesz elérhető a 'Megjelenítés' gomb!{0}{0}Amennyiben mégsem azt a nemet választaná, ne felejtse el az 'újra' gombot megnyomni!", newline));
            Controls.Add(genderHintButton);

            HintButton ageHintButton = new HintButton(ageL.Left + ageL.Size.Width, ageL.Top - 5, String.Format("Válassza ki, milyen korú személyeket szeretne megjeleníteni!{0}{0}Amennyiben üresen hagyja, automatikusan a szélsőértékeket választja ki a program!", newline));
            Controls.Add(ageHintButton);

            HintButton fileHintButton = new HintButton(_fileButton.Left + _fileButton.Size.Width + 5, _fileButton.Top + _fileButton.Height / 4, String.Format("Ahhoz, hogy egy fájlt megfelelően be tudjon olvasni,{0}a következő oszlopokat kell tartalmaznia (ezen sorrendben):{0}{0}Vezetéknév (szöveg){0}Keresztnév (szöveg){0}Kor (szám){0}Nem (Férfi=1/Nő=2){0}Legmagasabb iskolai végzettség (szöveg){0}van munkája (van/nincs)", newline));
            Controls.Add(fileHintButton);

        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            _reset = false;
            LoadData();
            if (people.Count > 0)
            {
                dataGridView.Visible = true;
                numberOfPeopleL.Visible = true;
                NumberL.Visible = true;
                RefreshDataGridView();
            }
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

            if (_lastAgeEnd < _ageEnd)
            {
                MessageBox.Show("Az alkalmazásban használt szűrő a teljes adathalmazból való törlésen alapszik, így annak érdekében, hogy ismét egy tágabb intervallum adatait jelenítse meg, nyomja meg először az 'Újra' gombot, hogy a lista újra teljes legyen!");
                return;
            }

            if (_ageStart > _ageEnd)
            {
                MessageBox.Show(string.Format("A kor esetében a kezdőértéknek kisebbnek {0} kell lennie, mint a záróértéknek!", _newLine));
                return;
            }

            toDelete = ChoosePeopleToDelete(_choosenGender);

            foreach (Person person in toDelete)
            {
                people.Remove(person);
            }

            RefreshDataGridView();
            CreateChart();

            _lastAgeEnd = _ageEnd;
            allRB.Enabled = false;
            maleRB.Enabled = false;
            femaleRB.Enabled = false;
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

        private List<Person> ChoosePeopleToDelete(Gender choosenGender)
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

            if (choosenGender != Gender.Mindenki)
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

        private void CreateChart()
        {
            if (_choosenData.Equals("Education"))
            {
                var dataAmount = from x in people
                                 group x by x.Education
                             into g
                                 select new ChartData()
                                 {
                                     ChoosenData = g.Key,
                                     Amount = (from x in g select x).Count()
                                 };
                chartBindingSource.DataSource = dataAmount.ToList();
            }
            else
            {
                var dataAmount = from x in people
                                 group x by x.HasJob
                             into g
                                 select new ChartData()
                                 {
                                     ChoosenData = g.Key.ToString(),
                                     Amount = (from x in g select x).Count()
                                 };
                chartBindingSource.DataSource = dataAmount.ToList();
            }
            ChartBasis.DataBind();
        }

        private void RefreshDataGridView()
        {
            NumberL.Text = people.Count.ToString();
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            dataGridView.DataSource = people;
            MakeHeaderAndDesignColumns();
        }

        private void MakeHeaderAndDesignColumns()
        {
            int count = 0;
            foreach (var headerText in headerTexts)
            {
                dataGridView.Columns[count].HeaderText = headerText;
                dataGridView.Columns[count].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                count++;
            }
            dataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (_choosenData.Equals("Education"))
            {
                dataGridView.Columns[4].DefaultCellStyle.BackColor = Color.LightYellow;
            }
            else
            {
                dataGridView.Columns[5].DefaultCellStyle.BackColor = Color.LightYellow;
            }
        }

        private void LoadData()
        {

            if (!_reset)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                people.Clear();
                dataGridView.DataSource = null;
                dataGridView.Rows.Clear();
                headerTexts.Clear();
                foreach (var series in ChartBasis.Series)
                {
                    series.Points.Clear();
                }

                using (StreamReader sr = new StreamReader(ofd.FileName, Encoding.Default))
                {
                    try
                    {
                        string[] headline = sr.ReadLine().Split(';');
                        for (int i = 0; i <= 5; i++)
                        {
                            headerTexts.Add(headline[i]);
                        }
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
                    catch (Exception)
                    {
                        MessageBox.Show(String.Format("Kérem, hogy megfelelő felépítésű fájlt próbáljon beolvasni!{0}{0}Jó példa erre a people.csv fájl, ami megtalálható a program{0}megfelelő mappájában!", newline));
                        return;
                    }

                }
                LoadUnmodifiedPeopleList();
                SaveAgeInterval();

                dataCB.DataSource = datas;
                NumberL.Text = people.Count.ToString();
                _reset = false;
                dataCB.Enabled = true;
                ageEndTB.Enabled = true;
                ageStartTB.Enabled = true;
                _resetButton.Enabled = true;
            }
            else
            {
                people.Clear();
                foreach (Person person in peopleBeforeModifications)
                {
                    people.Add(person);
                }
                SaveAgeInterval();
            }
            allRB.Enabled = true;
            femaleRB.Enabled = true;
            maleRB.Enabled = true;
        }

        private void LoadUnmodifiedPeopleList()
        {
            peopleBeforeModifications.Clear();
            foreach (Person person in people)
            {
                peopleBeforeModifications.Add(person);
            }
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

            _lastAgeEnd = _maxAge;
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

        private void femaleRB_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleRB.Checked)
            {
                _choosenGender = Gender.Nő;
            }
            _startButton.Enabled = true;
        }

        private void maleRB_CheckedChanged(object sender, EventArgs e)
        {
            if (maleRB.Checked)
            {
                _choosenGender = Gender.Férfi;
            }
            _startButton.Enabled = true;
        }

        private void allRB_CheckedChanged(object sender, EventArgs e)
        {
            if (allRB.Checked)
            {
                _choosenGender = Gender.Mindenki;
            }
            _startButton.Enabled = true;
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
    }
}

