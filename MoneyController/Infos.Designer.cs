﻿namespace MoneyController
{
    partial class Infos
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
            this.dayByDay = new System.Windows.Forms.TextBox();
            this.EndMonth = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.card = new System.Windows.Forms.TextBox();
            this.CardG = new System.Windows.Forms.Label();
            this.din = new System.Windows.Forms.TextBox();
            this.Debito = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Poup = new System.Windows.Forms.Label();
            this.poupanc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RDebit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dayByDay
            // 
            this.dayByDay.Location = new System.Drawing.Point(12, 12);
            this.dayByDay.Name = "dayByDay";
            this.dayByDay.Size = new System.Drawing.Size(100, 20);
            this.dayByDay.TabIndex = 0;
            // 
            // EndMonth
            // 
            this.EndMonth.AutoSize = true;
            this.EndMonth.Location = new System.Drawing.Point(118, 15);
            this.EndMonth.Name = "EndMonth";
            this.EndMonth.Size = new System.Drawing.Size(76, 13);
            this.EndMonth.TabIndex = 1;
            this.EndMonth.Text = "R$ / dia (tudo)";
            this.EndMonth.Click += new System.EventHandler(this.label1_Click);
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(208, 15);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 2;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // card
            // 
            this.card.Location = new System.Drawing.Point(12, 63);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(100, 20);
            this.card.TabIndex = 3;
            // 
            // CardG
            // 
            this.CardG.AutoSize = true;
            this.CardG.Location = new System.Drawing.Point(118, 66);
            this.CardG.Name = "CardG";
            this.CardG.Size = new System.Drawing.Size(84, 13);
            this.CardG.TabIndex = 4;
            this.CardG.Text = "Saldo no credito";
            // 
            // din
            // 
            this.din.Location = new System.Drawing.Point(12, 89);
            this.din.Name = "din";
            this.din.Size = new System.Drawing.Size(100, 20);
            this.din.TabIndex = 5;
            this.din.TextChanged += new System.EventHandler(this.Debit_TextChanged);
            // 
            // Debito
            // 
            this.Debito.AutoSize = true;
            this.Debito.Location = new System.Drawing.Point(118, 92);
            this.Debito.Name = "Debito";
            this.Debito.Size = new System.Drawing.Size(83, 13);
            this.Debito.TabIndex = 6;
            this.Debito.Text = "Saldo no Debito";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(208, 171);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Poup
            // 
            this.Poup.AutoSize = true;
            this.Poup.Location = new System.Drawing.Point(118, 118);
            this.Poup.Name = "Poup";
            this.Poup.Size = new System.Drawing.Size(101, 13);
            this.Poup.TabIndex = 9;
            this.Poup.Text = "Saldo na Poupança";
            // 
            // poupanc
            // 
            this.poupanc.Location = new System.Drawing.Point(12, 115);
            this.poupanc.Name = "poupanc";
            this.poupanc.Size = new System.Drawing.Size(100, 20);
            this.poupanc.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "R$ / dia (Debito)";
            // 
            // RDebit
            // 
            this.RDebit.Location = new System.Drawing.Point(12, 37);
            this.RDebit.Name = "RDebit";
            this.RDebit.Size = new System.Drawing.Size(100, 20);
            this.RDebit.TabIndex = 10;
            // 
            // Infos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(292, 206);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RDebit);
            this.Controls.Add(this.Poup);
            this.Controls.Add(this.poupanc);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Debito);
            this.Controls.Add(this.din);
            this.Controls.Add(this.CardG);
            this.Controls.Add(this.card);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.EndMonth);
            this.Controls.Add(this.dayByDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Infos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Infos";
            this.Load += new System.EventHandler(this.Infos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dayByDay;
        private System.Windows.Forms.Label EndMonth;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.TextBox card;
        private System.Windows.Forms.Label CardG;
        private System.Windows.Forms.TextBox din;
        private System.Windows.Forms.Label Debito;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Poup;
        private System.Windows.Forms.TextBox poupanc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RDebit;
    }
}