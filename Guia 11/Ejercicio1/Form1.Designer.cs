namespace Ejercicio1
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
            label1 = new Label();
            lbIngresarNumero = new Label();
            btnGenerar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 41);
            label1.TabIndex = 0;
            label1.Text = "Número Generado:";
            // 
            // lbIngresarNumero
            // 
            lbIngresarNumero.AutoSize = true;
            lbIngresarNumero.Location = new Point(96, 19);
            lbIngresarNumero.Name = "lbIngresarNumero";
            lbIngresarNumero.Size = new Size(94, 15);
            lbIngresarNumero.TabIndex = 1;
            lbIngresarNumero.Text = "Ingresar número";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(229, 15);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 73);
            Controls.Add(btnGenerar);
            Controls.Add(lbIngresarNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Generar número";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbIngresarNumero;
        private Button btnGenerar;
    }
}
