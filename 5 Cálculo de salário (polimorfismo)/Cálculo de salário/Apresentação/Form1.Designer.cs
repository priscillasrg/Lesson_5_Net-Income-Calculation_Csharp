namespace Cálculo_de_salário
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
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblImposto = new System.Windows.Forms.Label();
            this.txbSalarioBruto = new System.Windows.Forms.TextBox();
            this.txbImposto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(12, 37);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(122, 13);
            this.lblSalarioBruto.TabIndex = 0;
            this.lblSalarioBruto.Text = "Informe seu salário bruto";
            // 
            // lblImposto
            // 
            this.lblImposto.AutoSize = true;
            this.lblImposto.Location = new System.Drawing.Point(12, 70);
            this.lblImposto.Name = "lblImposto";
            this.lblImposto.Size = new System.Drawing.Size(131, 13);
            this.lblImposto.TabIndex = 1;
            this.lblImposto.Text = "Informe o valor do imposto";
            // 
            // txbSalarioBruto
            // 
            this.txbSalarioBruto.Location = new System.Drawing.Point(149, 34);
            this.txbSalarioBruto.Name = "txbSalarioBruto";
            this.txbSalarioBruto.Size = new System.Drawing.Size(74, 20);
            this.txbSalarioBruto.TabIndex = 2;
            // 
            // txbImposto
            // 
            this.txbImposto.Location = new System.Drawing.Point(149, 67);
            this.txbImposto.Name = "txbImposto";
            this.txbImposto.Size = new System.Drawing.Size(74, 20);
            this.txbImposto.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(78, 106);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(80, 26);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(12, 152);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(52, 13);
            this.lblResposta.TabIndex = 5;
            this.lblResposta.Text = "Resposta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Made by Priscilla Rizzardo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(243, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbImposto);
            this.Controls.Add(this.txbSalarioBruto);
            this.Controls.Add(this.lblImposto);
            this.Controls.Add(this.lblSalarioBruto);
            this.Name = "Form1";
            this.Text = "Cálculo de salário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblImposto;
        private System.Windows.Forms.TextBox txbSalarioBruto;
        private System.Windows.Forms.TextBox txbImposto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label label1;
    }
}

