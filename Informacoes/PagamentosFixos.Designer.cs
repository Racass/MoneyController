namespace MoneyController.Informacoes
{
    partial class PagamentosFixos
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
            this.DiaPag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Quantia = new System.Windows.Forms.TextBox();
            this.local = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddLocal = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(181, 103);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DiaPag
            // 
            this.DiaPag.Location = new System.Drawing.Point(127, 15);
            this.DiaPag.Name = "DiaPag";
            this.DiaPag.Size = new System.Drawing.Size(100, 20);
            this.DiaPag.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dia do Pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantia";
            // 
            // Quantia
            // 
            this.Quantia.Location = new System.Drawing.Point(127, 41);
            this.Quantia.Name = "Quantia";
            this.Quantia.Size = new System.Drawing.Size(100, 20);
            this.Quantia.TabIndex = 3;
            // 
            // local
            // 
            this.local.FormattingEnabled = true;
            this.local.Location = new System.Drawing.Point(127, 67);
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(100, 30);
            this.local.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Empresa Pagamento";
            // 
            // AddLocal
            // 
            this.AddLocal.Location = new System.Drawing.Point(102, 103);
            this.AddLocal.Name = "AddLocal";
            this.AddLocal.Size = new System.Drawing.Size(75, 23);
            this.AddLocal.TabIndex = 7;
            this.AddLocal.Text = "AddLocal";
            this.AddLocal.UseVisualStyleBackColor = true;
            this.AddLocal.Click += new System.EventHandler(this.AddLocal_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(21, 103);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 8;
            this.Add.Text = "AddPayment";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // PagamentosFixos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(270, 135);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.AddLocal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.local);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Quantia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiaPag);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PagamentosFixos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagamentosFixos";
            this.Load += new System.EventHandler(this.PagamentosFixos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox DiaPag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Quantia;
        private System.Windows.Forms.ListBox local;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddLocal;
        private System.Windows.Forms.Button Add;
    }
}