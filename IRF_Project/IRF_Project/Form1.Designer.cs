namespace IRF_Project
{
    partial class DataVisualizationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Vezetéknév = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keresztnév = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iskola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Munka = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ChartBasis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataL = new System.Windows.Forms.Label();
            this.dataCB = new System.Windows.Forms.ComboBox();
            this.numberOfPeopleL = new System.Windows.Forms.Label();
            this.NumberL = new System.Windows.Forms.Label();
            this.allRB = new System.Windows.Forms.RadioButton();
            this.femaleRB = new System.Windows.Forms.RadioButton();
            this.maleRB = new System.Windows.Forms.RadioButton();
            this.genderL = new System.Windows.Forms.Label();
            this.ageL = new System.Windows.Forms.Label();
            this.ageCommentL = new System.Windows.Forms.Label();
            this.ageStartTB = new System.Windows.Forms.TextBox();
            this.ageEndTB = new System.Windows.Forms.TextBox();
            this.ageStartL = new System.Windows.Forms.Label();
            this.ageEndL = new System.Windows.Forms.Label();
            this.BigL = new System.Windows.Forms.Label();
            this.horizontalLine = new System.Windows.Forms.Label();
            this.verticalLine1 = new System.Windows.Forms.Label();
            this.verticalLine2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBasis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vezetéknév,
            this.Keresztnév,
            this.Kor,
            this.Nem,
            this.Iskola,
            this.Munka});
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(12, 209);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(619, 331);
            this.dataGridView.TabIndex = 0;
            // 
            // Vezetéknév
            // 
            this.Vezetéknév.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Vezetéknév.DataPropertyName = "LastName";
            this.Vezetéknév.HeaderText = "Vezetéknév";
            this.Vezetéknév.Name = "Vezetéknév";
            this.Vezetéknév.ReadOnly = true;
            this.Vezetéknév.Width = 99;
            // 
            // Keresztnév
            // 
            this.Keresztnév.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Keresztnév.DataPropertyName = "FirstName";
            this.Keresztnév.HeaderText = "Keresztnév";
            this.Keresztnév.Name = "Keresztnév";
            this.Keresztnév.ReadOnly = true;
            this.Keresztnév.Width = 95;
            // 
            // Kor
            // 
            this.Kor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Kor.DataPropertyName = "Age";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Kor.DefaultCellStyle = dataGridViewCellStyle2;
            this.Kor.HeaderText = "Kor";
            this.Kor.Name = "Kor";
            this.Kor.ReadOnly = true;
            this.Kor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Kor.Width = 51;
            // 
            // Nem
            // 
            this.Nem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nem.DataPropertyName = "Gender";
            this.Nem.HeaderText = "Nem";
            this.Nem.Name = "Nem";
            this.Nem.ReadOnly = true;
            this.Nem.Width = 57;
            // 
            // Iskola
            // 
            this.Iskola.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Iskola.DataPropertyName = "Education";
            this.Iskola.HeaderText = "Végzettség";
            this.Iskola.Name = "Iskola";
            this.Iskola.ReadOnly = true;
            this.Iskola.Width = 95;
            // 
            // Munka
            // 
            this.Munka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Munka.DataPropertyName = "HasJob";
            this.Munka.HeaderText = "Van munkája?";
            this.Munka.Name = "Munka";
            this.Munka.ReadOnly = true;
            this.Munka.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Munka.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Munka.Width = 112;
            // 
            // ChartBasis
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartBasis.ChartAreas.Add(chartArea1);
            this.ChartBasis.DataSource = this.chartBindingSource;
            legend1.Name = "Legend1";
            this.ChartBasis.Legends.Add(legend1);
            this.ChartBasis.Location = new System.Drawing.Point(637, 209);
            this.ChartBasis.Name = "ChartBasis";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.XValueMember = "ChoosenData";
            series1.YValueMembers = "Amount";
            this.ChartBasis.Series.Add(series1);
            this.ChartBasis.Size = new System.Drawing.Size(407, 331);
            this.ChartBasis.TabIndex = 1;
            this.ChartBasis.Text = "chart1";
            // 
            // dataL
            // 
            this.dataL.Location = new System.Drawing.Point(9, 75);
            this.dataL.Name = "dataL";
            this.dataL.Size = new System.Drawing.Size(168, 21);
            this.dataL.TabIndex = 28;
            this.dataL.Text = "Mely adatokat szeretné ábrázolni?";
            // 
            // dataCB
            // 
            this.dataCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataCB.FormattingEnabled = true;
            this.dataCB.Location = new System.Drawing.Point(12, 107);
            this.dataCB.Name = "dataCB";
            this.dataCB.Size = new System.Drawing.Size(228, 21);
            this.dataCB.TabIndex = 30;
            this.dataCB.SelectedValueChanged += new System.EventHandler(this.dataCB_SelectedValueChanged);
            // 
            // numberOfPeopleL
            // 
            this.numberOfPeopleL.AutoSize = true;
            this.numberOfPeopleL.Location = new System.Drawing.Point(389, 193);
            this.numberOfPeopleL.Name = "numberOfPeopleL";
            this.numberOfPeopleL.Size = new System.Drawing.Size(94, 13);
            this.numberOfPeopleL.TabIndex = 31;
            this.numberOfPeopleL.Text = "Személyek száma:";
            // 
            // NumberL
            // 
            this.NumberL.AutoSize = true;
            this.NumberL.Location = new System.Drawing.Point(489, 193);
            this.NumberL.Name = "NumberL";
            this.NumberL.Size = new System.Drawing.Size(0, 13);
            this.NumberL.TabIndex = 32;
            // 
            // allRB
            // 
            this.allRB.AutoSize = true;
            this.allRB.Location = new System.Drawing.Point(284, 151);
            this.allRB.Name = "allRB";
            this.allRB.Size = new System.Drawing.Size(68, 17);
            this.allRB.TabIndex = 35;
            this.allRB.TabStop = true;
            this.allRB.Text = "Mindenki";
            this.allRB.UseVisualStyleBackColor = true;
            this.allRB.CheckedChanged += new System.EventHandler(this.allRB_CheckedChanged);
            // 
            // femaleRB
            // 
            this.femaleRB.AutoSize = true;
            this.femaleRB.Location = new System.Drawing.Point(284, 107);
            this.femaleRB.Name = "femaleRB";
            this.femaleRB.Size = new System.Drawing.Size(45, 17);
            this.femaleRB.TabIndex = 33;
            this.femaleRB.TabStop = true;
            this.femaleRB.Text = "Nők";
            this.femaleRB.UseVisualStyleBackColor = true;
            this.femaleRB.CheckedChanged += new System.EventHandler(this.femaleRB_CheckedChanged);
            // 
            // maleRB
            // 
            this.maleRB.AutoSize = true;
            this.maleRB.Location = new System.Drawing.Point(284, 130);
            this.maleRB.Name = "maleRB";
            this.maleRB.Size = new System.Drawing.Size(57, 17);
            this.maleRB.TabIndex = 34;
            this.maleRB.TabStop = true;
            this.maleRB.Text = "Férfiak";
            this.maleRB.UseVisualStyleBackColor = true;
            this.maleRB.CheckedChanged += new System.EventHandler(this.maleRB_CheckedChanged);
            // 
            // genderL
            // 
            this.genderL.Location = new System.Drawing.Point(284, 73);
            this.genderL.Name = "genderL";
            this.genderL.Size = new System.Drawing.Size(199, 29);
            this.genderL.TabIndex = 36;
            this.genderL.Text = "Mely nemekre vonatkozóan szeretné az adott adatokat ábrázolni?";
            // 
            // ageL
            // 
            this.ageL.Location = new System.Drawing.Point(534, 73);
            this.ageL.Name = "ageL";
            this.ageL.Size = new System.Drawing.Size(177, 15);
            this.ageL.TabIndex = 38;
            this.ageL.Text = "Válassza ki, mely korosztály érdekli!";
            // 
            // ageCommentL
            // 
            this.ageCommentL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ageCommentL.Location = new System.Drawing.Point(534, 87);
            this.ageCommentL.Name = "ageCommentL";
            this.ageCommentL.Size = new System.Drawing.Size(281, 15);
            this.ageCommentL.TabIndex = 39;
            this.ageCommentL.Text = "(amennyiben nem szeretne felső határt, hagyja üresen!)";
            // 
            // ageStartTB
            // 
            this.ageStartTB.Location = new System.Drawing.Point(537, 118);
            this.ageStartTB.Name = "ageStartTB";
            this.ageStartTB.Size = new System.Drawing.Size(25, 20);
            this.ageStartTB.TabIndex = 40;
            this.ageStartTB.Leave += new System.EventHandler(this.ageStartTB_Leave);
            // 
            // ageEndTB
            // 
            this.ageEndTB.Location = new System.Drawing.Point(686, 118);
            this.ageEndTB.Name = "ageEndTB";
            this.ageEndTB.Size = new System.Drawing.Size(25, 20);
            this.ageEndTB.TabIndex = 41;
            this.ageEndTB.Leave += new System.EventHandler(this.ageEndTB_Leave);
            // 
            // ageStartL
            // 
            this.ageStartL.Location = new System.Drawing.Point(568, 121);
            this.ageStartL.Name = "ageStartL";
            this.ageStartL.Size = new System.Drawing.Size(80, 20);
            this.ageStartL.TabIndex = 42;
            this.ageStartL.Text = "éves kortól";
            // 
            // ageEndL
            // 
            this.ageEndL.Location = new System.Drawing.Point(717, 121);
            this.ageEndL.Name = "ageEndL";
            this.ageEndL.Size = new System.Drawing.Size(80, 20);
            this.ageEndL.TabIndex = 43;
            this.ageEndL.Text = "éves korig";
            // 
            // BigL
            // 
            this.BigL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BigL.Location = new System.Drawing.Point(9, 19);
            this.BigL.Name = "BigL";
            this.BigL.Size = new System.Drawing.Size(579, 39);
            this.BigL.TabIndex = 44;
            this.BigL.Text = "Olvasson be egy .csv kiterjesztésű fájlt, mely megfelel az előre kijelölt formána" +
    "k, majd válassza ki, mely adatokat szeretné megjeleníteni a diagramon és a táblá" +
    "zatban!";
            // 
            // horizontalLine
            // 
            this.horizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontalLine.Location = new System.Drawing.Point(12, 59);
            this.horizontalLine.Name = "horizontalLine";
            this.horizontalLine.Size = new System.Drawing.Size(544, 2);
            this.horizontalLine.TabIndex = 45;
            // 
            // verticalLine1
            // 
            this.verticalLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verticalLine1.Location = new System.Drawing.Point(259, 73);
            this.verticalLine1.Name = "verticalLine1";
            this.verticalLine1.Size = new System.Drawing.Size(2, 100);
            this.verticalLine1.TabIndex = 46;
            // 
            // verticalLine2
            // 
            this.verticalLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verticalLine2.Location = new System.Drawing.Point(512, 73);
            this.verticalLine2.Name = "verticalLine2";
            this.verticalLine2.Size = new System.Drawing.Size(2, 100);
            this.verticalLine2.TabIndex = 47;
            // 
            // DataVisualizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1056, 552);
            this.Controls.Add(this.verticalLine2);
            this.Controls.Add(this.verticalLine1);
            this.Controls.Add(this.horizontalLine);
            this.Controls.Add(this.BigL);
            this.Controls.Add(this.ageEndL);
            this.Controls.Add(this.ageStartL);
            this.Controls.Add(this.ageEndTB);
            this.Controls.Add(this.ageStartTB);
            this.Controls.Add(this.ageCommentL);
            this.Controls.Add(this.ageL);
            this.Controls.Add(this.genderL);
            this.Controls.Add(this.allRB);
            this.Controls.Add(this.maleRB);
            this.Controls.Add(this.femaleRB);
            this.Controls.Add(this.NumberL);
            this.Controls.Add(this.numberOfPeopleL);
            this.Controls.Add(this.dataCB);
            this.Controls.Add(this.dataL);
            this.Controls.Add(this.ChartBasis);
            this.Controls.Add(this.dataGridView);
            this.MaximumSize = new System.Drawing.Size(1072, 591);
            this.MinimumSize = new System.Drawing.Size(1072, 591);
            this.Name = "DataVisualizationForm";
            this.Text = "Adatvizualizáció";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBasis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBasis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vezetéknév;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keresztnév;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iskola;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Munka;
        private System.Windows.Forms.Label dataL;
        private System.Windows.Forms.BindingSource chartBindingSource;
        private System.Windows.Forms.ComboBox dataCB;
        private System.Windows.Forms.Label numberOfPeopleL;
        private System.Windows.Forms.Label NumberL;
        private System.Windows.Forms.RadioButton allRB;
        private System.Windows.Forms.RadioButton femaleRB;
        private System.Windows.Forms.RadioButton maleRB;
        private System.Windows.Forms.Label genderL;
        private System.Windows.Forms.Label ageL;
        private System.Windows.Forms.Label ageCommentL;
        private System.Windows.Forms.TextBox ageStartTB;
        private System.Windows.Forms.TextBox ageEndTB;
        private System.Windows.Forms.Label ageStartL;
        private System.Windows.Forms.Label ageEndL;
        private System.Windows.Forms.Label BigL;
        private System.Windows.Forms.Label horizontalLine;
        private System.Windows.Forms.Label verticalLine1;
        private System.Windows.Forms.Label verticalLine2;
    }
}

