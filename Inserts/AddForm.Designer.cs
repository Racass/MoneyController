﻿namespace MoneyController
{
    partial class AddForm
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
            this.Exit = new System.Windows.Forms.Button();
            this.QuantBox = new System.Windows.Forms.TextBox();
            this.Quantia = new System.Windows.Forms.Label();
            this.Local = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.DataBox = new System.Windows.Forms.TextBox();
            this.Hora = new System.Windows.Forms.Label();
            this.HourBox = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PlusMinus = new System.Windows.Forms.CheckBox();
            this.locais = new System.Windows.Forms.ListBox();
            this.NewLocal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(168, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.TabStop = false;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // QuantBox
            // 
            this.QuantBox.Location = new System.Drawing.Point(62, 12);
            this.QuantBox.Name = "QuantBox";
            this.QuantBox.Size = new System.Drawing.Size(100, 20);
            this.QuantBox.TabIndex = 1;
            this.QuantBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Quantia
            // 
            this.Quantia.AutoSize = true;
            this.Quantia.Location = new System.Drawing.Point(3, 15);
            this.Quantia.Name = "Quantia";
            this.Quantia.Size = new System.Drawing.Size(44, 13);
            this.Quantia.TabIndex = 2;
            this.Quantia.Text = "Quantia";
            // 
            // Local
            // 
            this.Local.AutoSize = true;
            this.Local.Location = new System.Drawing.Point(3, 41);
            this.Local.Name = "Local";
            this.Local.Size = new System.Drawing.Size(33, 13);
            this.Local.TabIndex = 4;
            this.Local.Text = "Local";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(3, 86);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(30, 13);
            this.Data.TabIndex = 6;
            this.Data.Text = "Data";
            // 
            // DataBox
            // 
            this.DataBox.Location = new System.Drawing.Point(62, 83);
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(100, 20);
            this.DataBox.TabIndex = 4;
            this.DataBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.Location = new System.Drawing.Point(3, 112);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(30, 13);
            this.Hora.TabIndex = 10;
            this.Hora.Text = "Hora";
            // 
            // HourBox
            // 
            this.HourBox.Location = new System.Drawing.Point(62, 109);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(100, 20);
            this.HourBox.TabIndex = 5;
            this.HourBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(169, 68);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Debito",
            "Credito",
            "Poupança"});
            this.listBox1.Location = new System.Drawing.Point(6, 135);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 30);
            this.listBox1.TabIndex = 11;
            this.listBox1.TabStop = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // PlusMinus
            // 
            this.PlusMinus.AutoSize = true;
            this.PlusMinus.Location = new System.Drawing.Point(168, 111);
            this.PlusMinus.Name = "PlusMinus";
            this.PlusMinus.Size = new System.Drawing.Size(82, 17);
            this.PlusMinus.TabIndex = 12;
            this.PlusMinus.Text = "Recebendo";
            this.PlusMinus.UseVisualStyleBackColor = true;
            this.PlusMinus.CheckedChanged += new System.EventHandler(this.PlusMinus_CheckedChanged);
            // 
            // locais
            // 
            this.locais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locais.FormattingEnabled = true;
            this.locais.HorizontalExtent = 10;
            this.locais.HorizontalScrollbar = true;
            this.locais.Location = new System.Drawing.Point(62, 38);
            this.locais.Name = "locais";
            this.locais.Size = new System.Drawing.Size(100, 39);
            this.locais.TabIndex = 13;
            // 
            // NewLocal
            // 
            this.NewLocal.Location = new System.Drawing.Point(168, 38);
            this.NewLocal.Name = "NewLocal";
            this.NewLocal.Size = new System.Drawing.Size(75, 24);
            this.NewLocal.TabIndex = 14;
            this.NewLocal.Text = "Add Local";
            this.NewLocal.UseVisualStyleBackColor = true;
            this.NewLocal.Click += new System.EventHandler(this.NewLocal_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(256, 170);
            this.Controls.Add(this.NewLocal);
            this.Controls.Add(this.locais);
            this.Controls.Add(this.PlusMinus);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.HourBox);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.DataBox);
            this.Controls.Add(this.Local);
            this.Controls.Add(this.Quantia);
            this.Controls.Add(this.QuantBox);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddNew";
            this.Load += new System.EventHandler(this.AddNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox QuantBox;
        private System.Windows.Forms.Label Quantia;
        private System.Windows.Forms.Label Local;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.TextBox DataBox;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.TextBox HourBox;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox PlusMinus;
        private System.Windows.Forms.ListBox locais;
        private System.Windows.Forms.Button NewLocal;
    }
}