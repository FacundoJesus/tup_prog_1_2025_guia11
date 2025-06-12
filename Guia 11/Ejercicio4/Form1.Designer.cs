namespace Ejercicio4
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
            label2 = new Label();
            label3 = new Label();
            btnConvertir = new Button();
            nudHoras = new NumericUpDown();
            nudMinutos = new NumericUpDown();
            lbMinutos = new Label();
            ((System.ComponentModel.ISupportInitialize)nudHoras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinutos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Tiempo en H:M";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 13);
            label2.Name = "label2";
            label2.Size = new Size(10, 15);
            label2.TabIndex = 1;
            label2.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 56);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 2;
            label3.Text = "Tiempo en minutos:";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(266, 9);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(75, 23);
            btnConvertir.TabIndex = 3;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // nudHoras
            // 
            nudHoras.Location = new Point(107, 9);
            nudHoras.Maximum = new decimal(new int[] { 11, 0, 0, 0 });
            nudHoras.Name = "nudHoras";
            nudHoras.Size = new Size(59, 23);
            nudHoras.TabIndex = 4;
            // 
            // nudMinutos
            // 
            nudMinutos.Location = new Point(188, 9);
            nudMinutos.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudMinutos.Name = "nudMinutos";
            nudMinutos.Size = new Size(59, 23);
            nudMinutos.TabIndex = 5;
            // 
            // lbMinutos
            // 
            lbMinutos.AutoSize = true;
            lbMinutos.Location = new Point(144, 56);
            lbMinutos.Name = "lbMinutos";
            lbMinutos.Size = new Size(12, 15);
            lbMinutos.TabIndex = 6;
            lbMinutos.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 98);
            Controls.Add(lbMinutos);
            Controls.Add(nudMinutos);
            Controls.Add(nudHoras);
            Controls.Add(btnConvertir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Convertir Horas y Minutos a Minutos ";
            ((System.ComponentModel.ISupportInitialize)nudHoras).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnConvertir;
        private NumericUpDown nudHoras;
        private NumericUpDown nudMinutos;
        private Label lbMinutos;
    }
}
