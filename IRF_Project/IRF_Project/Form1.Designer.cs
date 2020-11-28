namespace IRF_Project
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.chartbase = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.hintBT = new System.Windows.Forms.Button();
            this.dataL = new System.Windows.Forms.Label();
            this.chartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.allRB = new System.Windows.Forms.RadioButton();
            this.femaleRB = new System.Windows.Forms.RadioButton();
            this.maleRB = new System.Windows.Forms.RadioButton();
            this.genderL = new System.Windows.Forms.Label();
            this.ageL = new System.Windows.Forms.Label();
            this.ageCommentL = new System.Windows.Forms.Label();
            this.ageStartTB = new System.Windows.Forms.TextBox();
            this.ageEndTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartbase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vezetéknév,
            this.Keresztnév,
            this.Kor,
            this.Nem,
            this.Iskola,
            this.Munka});
            this.dataGridView.Location = new System.Drawing.Point(12, 248);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(519, 292);
            this.dataGridView.TabIndex = 0;
            // 
            // Vezetéknév
            // 
            this.Vezetéknév.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Vezetéknév.DataPropertyName = "LastName";
            this.Vezetéknév.HeaderText = "Vezetéknév";
            this.Vezetéknév.Name = "Vezetéknév";
            this.Vezetéknév.ReadOnly = true;
            this.Vezetéknév.Width = 89;
            // 
            // Keresztnév
            // 
            this.Keresztnév.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Keresztnév.DataPropertyName = "FirstName";
            this.Keresztnév.HeaderText = "Keresztnév";
            this.Keresztnév.Name = "Keresztnév";
            this.Keresztnév.ReadOnly = true;
            this.Keresztnév.Width = 85;
            // 
            // Kor
            // 
            this.Kor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Kor.DataPropertyName = "Age";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Kor.DefaultCellStyle = dataGridViewCellStyle1;
            this.Kor.HeaderText = "Kor";
            this.Kor.Name = "Kor";
            this.Kor.ReadOnly = true;
            this.Kor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Kor.Width = 48;
            // 
            // Nem
            // 
            this.Nem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nem.DataPropertyName = "Gender";
            this.Nem.HeaderText = "Nem";
            this.Nem.Name = "Nem";
            this.Nem.ReadOnly = true;
            this.Nem.Width = 54;
            // 
            // Iskola
            // 
            this.Iskola.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Iskola.DataPropertyName = "Education";
            this.Iskola.HeaderText = "Végzettség";
            this.Iskola.Name = "Iskola";
            this.Iskola.ReadOnly = true;
            this.Iskola.Width = 85;
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
            // 
            // chartbase
            // 
            chartArea1.Name = "ChartArea1";
            this.chartbase.ChartAreas.Add(chartArea1);
            this.chartbase.DataSource = this.chartBindingSource;
            legend1.Name = "Legend1";
            this.chartbase.Legends.Add(legend1);
            this.chartbase.Location = new System.Drawing.Point(537, 49);
            this.chartbase.Name = "chartbase";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "ChoosenData";
            series1.YValueMembers = "Amount";
            this.chartbase.Series.Add(series1);
            this.chartbase.Size = new System.Drawing.Size(507, 491);
            this.chartbase.TabIndex = 1;
            this.chartbase.Text = "chart1";
            // 
            // hintBT
            // 
            this.hintBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hintBT.BackColor = System.Drawing.SystemColors.Highlight;
            this.hintBT.Cursor = System.Windows.Forms.Cursors.Help;
            this.hintBT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hintBT.FlatAppearance.BorderSize = 2;
            this.hintBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hintBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hintBT.ForeColor = System.Drawing.SystemColors.Window;
            this.hintBT.Location = new System.Drawing.Point(1015, 12);
            this.hintBT.Name = "hintBT";
            this.hintBT.Size = new System.Drawing.Size(29, 31);
            this.hintBT.TabIndex = 24;
            this.hintBT.Text = "?";
            this.hintBT.UseVisualStyleBackColor = false;
            this.hintBT.Click += new System.EventHandler(this.hintBT_Click);
            // 
            // dataL
            // 
            this.dataL.Location = new System.Drawing.Point(12, 12);
            this.dataL.Name = "dataL";
            this.dataL.Size = new System.Drawing.Size(266, 21);
            this.dataL.TabIndex = 28;
            this.dataL.Text = "Mely adatokat szeretné ábrázolni?";
            // 
            // dataCB
            // 
            this.dataCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataCB.FormattingEnabled = true;
            this.dataCB.Location = new System.Drawing.Point(12, 36);
            this.dataCB.Name = "dataCB";
            this.dataCB.Size = new System.Drawing.Size(228, 21);
            this.dataCB.TabIndex = 30;
            this.dataCB.SelectedValueChanged += new System.EventHandler(this.dataCB_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Személyek száma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 32;
            // 
            // allRB
            // 
            this.allRB.AutoSize = true;
            this.allRB.Location = new System.Drawing.Point(12, 151);
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
            this.femaleRB.Location = new System.Drawing.Point(12, 107);
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
            this.maleRB.Location = new System.Drawing.Point(12, 130);
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
            this.genderL.Location = new System.Drawing.Point(12, 73);
            this.genderL.Name = "genderL";
            this.genderL.Size = new System.Drawing.Size(213, 29);
            this.genderL.TabIndex = 36;
            this.genderL.Text = "Mely nemekre vonatkozóan szeretné az adott adatokat ábrázolni?";
            // 
            // ageL
            // 
            this.ageL.Location = new System.Drawing.Point(250, 73);
            this.ageL.Name = "ageL";
            this.ageL.Size = new System.Drawing.Size(227, 15);
            this.ageL.TabIndex = 38;
            this.ageL.Text = "Válassza ki, mely korosztály érdekli!";
            // 
            // ageCommentL
            // 
            this.ageCommentL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ageCommentL.Location = new System.Drawing.Point(250, 87);
            this.ageCommentL.Name = "ageCommentL";
            this.ageCommentL.Size = new System.Drawing.Size(281, 15);
            this.ageCommentL.TabIndex = 39;
            this.ageCommentL.Text = "(amennyiben nem szeretne felső határt, hagyja üresen!)";
            // 
            // ageStartTB
            // 
            this.ageStartTB.Location = new System.Drawing.Point(253, 118);
            this.ageStartTB.Name = "ageStartTB";
            this.ageStartTB.Size = new System.Drawing.Size(25, 20);
            this.ageStartTB.TabIndex = 40;
            this.ageStartTB.Leave += new System.EventHandler(this.ageStartTB_Leave);
            // 
            // ageEndTB
            // 
            this.ageEndTB.Location = new System.Drawing.Point(402, 118);
            this.ageEndTB.Name = "ageEndTB";
            this.ageEndTB.Size = new System.Drawing.Size(25, 20);
            this.ageEndTB.TabIndex = 41;
            this.ageEndTB.Leave += new System.EventHandler(this.ageEndTB_Leave);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(284, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "éves kortól";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(433, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "éves korig";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 552);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ageEndTB);
            this.Controls.Add(this.ageStartTB);
            this.Controls.Add(this.ageCommentL);
            this.Controls.Add(this.ageL);
            this.Controls.Add(this.genderL);
            this.Controls.Add(this.allRB);
            this.Controls.Add(this.maleRB);
            this.Controls.Add(this.femaleRB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataCB);
            this.Controls.Add(this.dataL);
            this.Controls.Add(this.hintBT);
            this.Controls.Add(this.chartbase);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartbase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartbase;
        private System.Windows.Forms.Button hintBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vezetéknév;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keresztnév;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iskola;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Munka;
        private System.Windows.Forms.Label dataL;
        private System.Windows.Forms.BindingSource chartBindingSource;
        private System.Windows.Forms.ComboBox dataCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton allRB;
        private System.Windows.Forms.RadioButton femaleRB;
        private System.Windows.Forms.RadioButton maleRB;
        private System.Windows.Forms.Label genderL;
        private System.Windows.Forms.Label ageL;
        private System.Windows.Forms.Label ageCommentL;
        private System.Windows.Forms.TextBox ageStartTB;
        private System.Windows.Forms.TextBox ageEndTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

