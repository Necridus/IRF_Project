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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.hintBT = new System.Windows.Forms.Button();
            this.Vezetéknév = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keresztnév = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iskola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Munka = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(537, 49);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(507, 491);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 552);
            this.Controls.Add(this.hintBT);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button hintBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vezetéknév;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keresztnév;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iskola;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Munka;
    }
}

