namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxNumero1 = new TextBox();
            lblNumero1 = new Label();
            lblNumero2 = new Label();
            tbxNumero2 = new TextBox();
            lblResultado = new Label();
            btnResultado = new Button();
            rdbtnAdicao = new RadioButton();
            rdbtnSubtracao = new RadioButton();
            rdbtnMultiplicacao = new RadioButton();
            rdbtnDivicao = new RadioButton();
            SuspendLayout();
            // 
            // tbxNumero1
            // 
            tbxNumero1.Location = new Point(108, 12);
            tbxNumero1.Name = "tbxNumero1";
            tbxNumero1.Size = new Size(226, 23);
            tbxNumero1.TabIndex = 0;
            tbxNumero1.TextAlign = HorizontalAlignment.Right;
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(39, 15);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(63, 15);
            lblNumero1.TabIndex = 1;
            lblNumero1.Text = "Número 1:";
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(39, 44);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(63, 15);
            lblNumero2.TabIndex = 3;
            lblNumero2.Text = "Número 2:";
            // 
            // tbxNumero2
            // 
            tbxNumero2.Location = new Point(108, 41);
            tbxNumero2.Name = "tbxNumero2";
            tbxNumero2.Size = new Size(226, 23);
            tbxNumero2.TabIndex = 2;
            tbxNumero2.TextAlign = HorizontalAlignment.Right;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(275, 104);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado";
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(108, 100);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(75, 23);
            btnResultado.TabIndex = 5;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // rdbtnAdicao
            // 
            rdbtnAdicao.AutoSize = true;
            rdbtnAdicao.Location = new Point(108, 75);
            rdbtnAdicao.Name = "rdbtnAdicao";
            rdbtnAdicao.Size = new Size(33, 19);
            rdbtnAdicao.TabIndex = 6;
            rdbtnAdicao.TabStop = true;
            rdbtnAdicao.Text = "+";
            rdbtnAdicao.UseVisualStyleBackColor = true;
            // 
            // rdbtnSubtracao
            // 
            rdbtnSubtracao.AutoSize = true;
            rdbtnSubtracao.Location = new Point(147, 75);
            rdbtnSubtracao.Name = "rdbtnSubtracao";
            rdbtnSubtracao.Size = new Size(30, 19);
            rdbtnSubtracao.TabIndex = 7;
            rdbtnSubtracao.TabStop = true;
            rdbtnSubtracao.Text = "-";
            rdbtnSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbtnMultiplicacao
            // 
            rdbtnMultiplicacao.AutoSize = true;
            rdbtnMultiplicacao.Location = new Point(186, 75);
            rdbtnMultiplicacao.Name = "rdbtnMultiplicacao";
            rdbtnMultiplicacao.Size = new Size(30, 19);
            rdbtnMultiplicacao.TabIndex = 8;
            rdbtnMultiplicacao.TabStop = true;
            rdbtnMultiplicacao.Text = "*";
            rdbtnMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbtnDivicao
            // 
            rdbtnDivicao.AutoSize = true;
            rdbtnDivicao.Location = new Point(225, 75);
            rdbtnDivicao.Name = "rdbtnDivicao";
            rdbtnDivicao.Size = new Size(30, 19);
            rdbtnDivicao.TabIndex = 9;
            rdbtnDivicao.TabStop = true;
            rdbtnDivicao.Text = "/";
            rdbtnDivicao.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 186);
            Controls.Add(rdbtnDivicao);
            Controls.Add(rdbtnMultiplicacao);
            Controls.Add(rdbtnSubtracao);
            Controls.Add(rdbtnAdicao);
            Controls.Add(btnResultado);
            Controls.Add(lblResultado);
            Controls.Add(lblNumero2);
            Controls.Add(tbxNumero2);
            Controls.Add(lblNumero1);
            Controls.Add(tbxNumero1);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxNumero1;
        private TextBox tbxNumero2;

        private Label lblNumero1;
        private Label lblNumero2;
        private Label lblResultado;

        private Button btnResultado;

        private RadioButton rdbtnAdicao;
        private RadioButton rdbtnSubtracao;
        private RadioButton rdbtnMultiplicacao;
        private RadioButton rdbtnDivicao;
    }
}