namespace MoneyController
{
    partial class Pergunta
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
            this.resposta = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.Texto = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resposta
            // 
            this.resposta.Location = new System.Drawing.Point(12, 45);
            this.resposta.Name = "resposta";
            this.resposta.Size = new System.Drawing.Size(260, 20);
            this.resposta.TabIndex = 0;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(12, 71);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Texto
            // 
            this.Texto.AutoSize = true;
            this.Texto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Texto.Location = new System.Drawing.Point(104, 19);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(35, 13);
            this.Texto.TabIndex = 2;
            this.Texto.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pergunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 104);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.resposta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pergunta";
            this.Text = "Pergunta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resposta;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label Texto;
        private System.Windows.Forms.Button button2;
    }
}