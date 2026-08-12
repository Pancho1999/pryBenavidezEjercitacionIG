namespace pryBenavidezEjercitacionIG
{
    partial class frmCaso1
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEdad = new TextBox();
            txtCarrera = new TextBox();
            lbNombre = new Label();
            lbApellido = new Label();
            lbEdad = new Label();
            lbCarrera = new Label();
            btnPresentar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(97, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(97, 58);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(97, 87);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(46, 23);
            txtEdad.TabIndex = 2;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(97, 116);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(100, 23);
            txtCarrera.TabIndex = 3;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(12, 32);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(54, 15);
            lbNombre.TabIndex = 4;
            lbNombre.Text = "Nombre:";
            lbNombre.Click += label1_Click;
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Location = new Point(12, 61);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(54, 15);
            lbApellido.TabIndex = 5;
            lbApellido.Text = "Apellido:";
            // 
            // lbEdad
            // 
            lbEdad.AutoSize = true;
            lbEdad.Location = new Point(12, 90);
            lbEdad.Name = "lbEdad";
            lbEdad.Size = new Size(36, 15);
            lbEdad.TabIndex = 6;
            lbEdad.Text = "Edad:";
            lbEdad.Click += label3_Click;
            // 
            // lbCarrera
            // 
            lbCarrera.AutoSize = true;
            lbCarrera.Location = new Point(12, 119);
            lbCarrera.Name = "lbCarrera";
            lbCarrera.Size = new Size(48, 15);
            lbCarrera.TabIndex = 7;
            lbCarrera.Text = "Carrera:";
            // 
            // btnPresentar
            // 
            btnPresentar.Location = new Point(122, 292);
            btnPresentar.Name = "btnPresentar";
            btnPresentar.Size = new Size(75, 23);
            btnPresentar.TabIndex = 8;
            btnPresentar.Text = "Presentar";
            btnPresentar.UseVisualStyleBackColor = true;
            btnPresentar.Click += button1_Click;
            // 
            // frmCaso1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 370);
            Controls.Add(btnPresentar);
            Controls.Add(lbCarrera);
            Controls.Add(lbEdad);
            Controls.Add(lbApellido);
            Controls.Add(lbNombre);
            Controls.Add(txtCarrera);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "frmCaso1";
            Text = "Mi Presentación";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEdad;
        private TextBox txtCarrera;
        private Label lbNombre;
        private Label lbApellido;
        private Label lbEdad;
        private Label lbCarrera;
        private Button btnPresentar;
    }
}