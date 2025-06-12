namespace Ejercicio5
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
            rbExcelente = new RadioButton();
            rbBueno = new RadioButton();
            rbInsuficiente = new RadioButton();
            btnVotar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbExcelentes = new Label();
            lbBuenos = new Label();
            lbInsuficientes = new Label();
            lbTotal = new Label();
            SuspendLayout();
            // 
            // rbExcelente
            // 
            rbExcelente.AutoSize = true;
            rbExcelente.Location = new Point(12, 12);
            rbExcelente.Name = "rbExcelente";
            rbExcelente.Size = new Size(75, 19);
            rbExcelente.TabIndex = 0;
            rbExcelente.TabStop = true;
            rbExcelente.Text = "Excelente";
            rbExcelente.UseVisualStyleBackColor = true;
            // 
            // rbBueno
            // 
            rbBueno.AutoSize = true;
            rbBueno.Location = new Point(12, 48);
            rbBueno.Name = "rbBueno";
            rbBueno.Size = new Size(59, 19);
            rbBueno.TabIndex = 1;
            rbBueno.TabStop = true;
            rbBueno.Text = "Bueno";
            rbBueno.UseVisualStyleBackColor = true;
            // 
            // rbInsuficiente
            // 
            rbInsuficiente.AutoSize = true;
            rbInsuficiente.Location = new Point(12, 87);
            rbInsuficiente.Name = "rbInsuficiente";
            rbInsuficiente.Size = new Size(86, 19);
            rbInsuficiente.TabIndex = 2;
            rbInsuficiente.TabStop = true;
            rbInsuficiente.Text = "Insuficiente";
            rbInsuficiente.UseVisualStyleBackColor = true;
            // 
            // btnVotar
            // 
            btnVotar.Location = new Point(153, 46);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(75, 23);
            btnVotar.TabIndex = 3;
            btnVotar.Text = "Votar";
            btnVotar.UseVisualStyleBackColor = true;
            btnVotar.Click += btnVotar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 133);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 4;
            label1.Text = "Cantidad de votos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 168);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 5;
            label2.Text = "Excelentes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 205);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Buenos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 241);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 7;
            label4.Text = "Insuficientes:";
            // 
            // lbExcelentes
            // 
            lbExcelentes.AutoSize = true;
            lbExcelentes.Location = new Point(153, 168);
            lbExcelentes.Name = "lbExcelentes";
            lbExcelentes.Size = new Size(12, 15);
            lbExcelentes.TabIndex = 8;
            lbExcelentes.Text = "-";
            // 
            // lbBuenos
            // 
            lbBuenos.AutoSize = true;
            lbBuenos.Location = new Point(153, 205);
            lbBuenos.Name = "lbBuenos";
            lbBuenos.Size = new Size(12, 15);
            lbBuenos.TabIndex = 9;
            lbBuenos.Text = "-";
            // 
            // lbInsuficientes
            // 
            lbInsuficientes.AutoSize = true;
            lbInsuficientes.Location = new Point(153, 241);
            lbInsuficientes.Name = "lbInsuficientes";
            lbInsuficientes.Size = new Size(12, 15);
            lbInsuficientes.TabIndex = 10;
            lbInsuficientes.Text = "-";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(153, 133);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(12, 15);
            lbTotal.TabIndex = 11;
            lbTotal.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 278);
            Controls.Add(lbTotal);
            Controls.Add(lbInsuficientes);
            Controls.Add(lbBuenos);
            Controls.Add(lbExcelentes);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVotar);
            Controls.Add(rbInsuficiente);
            Controls.Add(rbBueno);
            Controls.Add(rbExcelente);
            Name = "Form1";
            Text = "Encuesta de Servicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbExcelente;
        private RadioButton rbBueno;
        private RadioButton rbInsuficiente;
        private Button btnVotar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbExcelentes;
        private Label lbBuenos;
        private Label lbInsuficientes;
        private Label lbTotal;
    }
}
