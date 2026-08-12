namespace pryBenavidezEjercitacionIG
{
    partial class frmCaso2
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
            lbNúm1 = new Label();
            lbNúm2 = new Label();
            txtNúm1 = new TextBox();
            txtNúm2 = new TextBox();
            btnSuma = new Button();
            btnResta = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            txtResultado = new TextBox();
            lbResultado = new Label();
            SuspendLayout();
            // 
            // lbNúm1
            // 
            lbNúm1.AutoSize = true;
            lbNúm1.Location = new Point(12, 9);
            lbNúm1.Name = "lbNúm1";
            lbNúm1.Size = new Size(63, 15);
            lbNúm1.TabIndex = 0;
            lbNúm1.Text = "Número 1:";
            // 
            // lbNúm2
            // 
            lbNúm2.AutoSize = true;
            lbNúm2.Location = new Point(12, 38);
            lbNúm2.Name = "lbNúm2";
            lbNúm2.Size = new Size(63, 15);
            lbNúm2.TabIndex = 1;
            lbNúm2.Text = "Número 2:";
            // 
            // txtNúm1
            // 
            txtNúm1.Location = new Point(81, 6);
            txtNúm1.Name = "txtNúm1";
            txtNúm1.Size = new Size(100, 23);
            txtNúm1.TabIndex = 2;
            // 
            // txtNúm2
            // 
            txtNúm2.Location = new Point(81, 35);
            txtNúm2.Name = "txtNúm2";
            txtNúm2.Size = new Size(100, 23);
            txtNúm2.TabIndex = 3;
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(12, 75);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(75, 23);
            btnSuma.TabIndex = 4;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(93, 75);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(75, 23);
            btnResta.TabIndex = 5;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(174, 75);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 6;
            btnMultiplicar.Text = "×";
            btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(255, 75);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 7;
            btnDividir.Text = "÷";
            btnDividir.UseVisualStyleBackColor = true;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(81, 116);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 8;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(13, 119);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(62, 15);
            lbResultado.TabIndex = 9;
            lbResultado.Text = "Resultado:";
            // 
            // frmCaso2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 205);
            Controls.Add(lbResultado);
            Controls.Add(txtResultado);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(txtNúm2);
            Controls.Add(txtNúm1);
            Controls.Add(lbNúm2);
            Controls.Add(lbNúm1);
            Name = "frmCaso2";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNúm1;
        private Label lbNúm2;
        private TextBox txtNúm1;
        private TextBox txtNúm2;
        private Button btnSuma;
        private Button btnResta;
        private Button btnMultiplicar;
        private Button btnDividir;
        private TextBox txtResultado;
        private Label lbResultado;
    }
}