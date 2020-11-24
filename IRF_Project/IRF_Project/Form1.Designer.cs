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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Vezetéknév = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keresztnév = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iskola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Munka = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chartbase = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.hintBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.goBT = new System.Windows.Forms.Button();
            this.chartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.allRB = new System.Windows.Forms.RadioButton();
            this.femaleRB = new System.Windows.Forms.RadioButton();
            this.maleRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.resetBT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Kor.DefaultCellStyle = dataGridViewCellStyle2;
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
            chartArea2.Name = "ChartArea1";
            this.chartbase.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartbase.Legends.Add(legend2);
            this.chartbase.Location = new System.Drawing.Point(537, 49);
            this.chartbase.Name = "chartbase";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartbase.Series.Add(series2);
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
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mely adatokat szeretné ábrázolni?";
            // 
            // goBT
            // 
            this.goBT.Location = new System.Drawing.Point(22, 203);
            this.goBT.Name = "goBT";
            this.goBT.Size = new System.Drawing.Size(75, 23);
            this.goBT.TabIndex = 29;
            this.goBT.Text = "Mehet!";
            this.goBT.UseVisualStyleBackColor = true;
            this.goBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataCB
            // 
            this.dataCB.FormattingEnabled = true;
            this.dataCB.Location = new System.Drawing.Point(12, 36);
            this.dataCB.Name = "dataCB";
            this.dataCB.Size = new System.Drawing.Size(263, 21);
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
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mely nemekre vonatkozóan szeretné az adott adatokat ábrázolni?";
            // 
            // resetBT
            // 
            this.resetBT.Location = new System.Drawing.Point(115, 203);
            this.resetBT.Name = "resetBT";
            this.resetBT.Size = new System.Drawing.Size(75, 23);
            this.resetBT.TabIndex = 37;
            this.resetBT.Text = "Mégse";
            this.resetBT.UseVisualStyleBackColor = true;
            this.resetBT.Click += new System.EventHandler(this.resetBT_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(250, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Válassza ki, mely korosztály érdekli!";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(250, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "(amennyiben nem szeretne felső határt, hagyja üresen!)";
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resetBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allRB);
            this.Controls.Add(this.maleRB);
            this.Controls.Add(this.femaleRB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataCB);
            this.Controls.Add(this.goBT);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goBT;
        private System.Windows.Forms.BindingSource chartBindingSource;
        private System.Windows.Forms.ComboBox dataCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton allRB;
        private System.Windows.Forms.RadioButton femaleRB;
        private System.Windows.Forms.RadioButton maleRB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetBT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ageStartTB;
        private System.Windows.Forms.TextBox ageEndTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

