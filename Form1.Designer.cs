namespace MoneyController
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
            this.AddNew = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.Ler = new System.Windows.Forms.Button();
            this.erase = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.AddInfo = new System.Windows.Forms.Button();
            this.ConnInfo = new System.Windows.Forms.Button();
            this.Legacy = new System.Windows.Forms.Button();
            this.BackUp = new System.Windows.Forms.Button();
            this.ApagarBK = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Outros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNew
            // 
            this.AddNew.Location = new System.Drawing.Point(12, 12);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(75, 23);
            this.AddNew.TabIndex = 0;
            this.AddNew.Text = "AddNew";
            this.AddNew.UseVisualStyleBackColor = true;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToOrderColumns = true;
            this.data.AllowUserToResizeRows = false;
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.data.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(12, 40);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Size = new System.Drawing.Size(718, 288);
            this.data.TabIndex = 1;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // Ler
            // 
            this.Ler.Location = new System.Drawing.Point(93, 11);
            this.Ler.Name = "Ler";
            this.Ler.Size = new System.Drawing.Size(75, 23);
            this.Ler.TabIndex = 2;
            this.Ler.Text = "Ler";
            this.Ler.UseVisualStyleBackColor = true;
            this.Ler.Click += new System.EventHandler(this.Ler_Click);
            // 
            // erase
            // 
            this.erase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.erase.Font = new System.Drawing.Font("Arial", 6F);
            this.erase.Location = new System.Drawing.Point(686, 334);
            this.erase.Name = "erase";
            this.erase.Size = new System.Drawing.Size(44, 18);
            this.erase.TabIndex = 3;
            this.erase.Text = "Apagar";
            this.erase.UseVisualStyleBackColor = true;
            this.erase.Click += new System.EventHandler(this.erase_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.textBox1.Location = new System.Drawing.Point(630, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Total
            // 
            this.Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(589, 14);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 6;
            this.Total.Text = "Total";
            // 
            // AddInfo
            // 
            this.AddInfo.Location = new System.Drawing.Point(174, 11);
            this.AddInfo.Name = "AddInfo";
            this.AddInfo.Size = new System.Drawing.Size(75, 23);
            this.AddInfo.TabIndex = 7;
            this.AddInfo.Text = "Outras Infos";
            this.AddInfo.UseVisualStyleBackColor = true;
            this.AddInfo.Click += new System.EventHandler(this.AddInfo_Click);
            // 
            // ConnInfo
            // 
            this.ConnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ConnInfo.Location = new System.Drawing.Point(12, 334);
            this.ConnInfo.Name = "ConnInfo";
            this.ConnInfo.Size = new System.Drawing.Size(75, 23);
            this.ConnInfo.TabIndex = 8;
            this.ConnInfo.Text = "ConexInfo";
            this.ConnInfo.UseVisualStyleBackColor = true;
            this.ConnInfo.Click += new System.EventHandler(this.ConnInfo_Click);
            // 
            // Legacy
            // 
            this.Legacy.Location = new System.Drawing.Point(93, 334);
            this.Legacy.Name = "Legacy";
            this.Legacy.Size = new System.Drawing.Size(82, 23);
            this.Legacy.TabIndex = 9;
            this.Legacy.Text = "Ler Back Up";
            this.Legacy.UseVisualStyleBackColor = true;
            this.Legacy.Click += new System.EventHandler(this.Legacy_Click);
            // 
            // BackUp
            // 
            this.BackUp.Location = new System.Drawing.Point(181, 334);
            this.BackUp.Name = "BackUp";
            this.BackUp.Size = new System.Drawing.Size(93, 23);
            this.BackUp.TabIndex = 10;
            this.BackUp.Text = "Fazer BackUp";
            this.BackUp.UseVisualStyleBackColor = true;
            this.BackUp.Click += new System.EventHandler(this.BackUp_Click);
            // 
            // ApagarBK
            // 
            this.ApagarBK.Location = new System.Drawing.Point(280, 334);
            this.ApagarBK.Name = "ApagarBK";
            this.ApagarBK.Size = new System.Drawing.Size(93, 23);
            this.ApagarBK.TabIndex = 11;
            this.ApagarBK.Text = "Erase BackUp";
            this.ApagarBK.UseVisualStyleBackColor = true;
            this.ApagarBK.Click += new System.EventHandler(this.ApagarBK_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(294, 82);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(8, 9);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // Outros
            // 
            this.Outros.Location = new System.Drawing.Point(379, 334);
            this.Outros.Name = "Outros";
            this.Outros.Size = new System.Drawing.Size(102, 23);
            this.Outros.TabIndex = 13;
            this.Outros.Text = "Pagamentos Fixos";
            this.Outros.UseVisualStyleBackColor = true;
            this.Outros.Click += new System.EventHandler(this.Outros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(747, 361);
            this.Controls.Add(this.Outros);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ApagarBK);
            this.Controls.Add(this.BackUp);
            this.Controls.Add(this.Legacy);
            this.Controls.Add(this.ConnInfo);
            this.Controls.Add(this.AddInfo);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.erase);
            this.Controls.Add(this.Ler);
            this.Controls.Add(this.data);
            this.Controls.Add(this.AddNew);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.Text = "Money Contrl";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button Ler;
        private System.Windows.Forms.Button erase;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Button AddInfo;
        private System.Windows.Forms.Button ConnInfo;
        private System.Windows.Forms.Button Legacy;
        private System.Windows.Forms.Button BackUp;
        private System.Windows.Forms.Button ApagarBK;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Outros;
    }
}

