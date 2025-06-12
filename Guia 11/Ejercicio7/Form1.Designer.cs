namespace Ejercicio7
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
            groupBox1 = new GroupBox();
            rbInsuficiente = new RadioButton();
            rbBueno = new RadioButton();
            rbExcelente = new RadioButton();
            groupBox2 = new GroupBox();
            rbFull = new RadioButton();
            rbBase = new RadioButton();
            groupBox3 = new GroupBox();
            lbFull = new Label();
            lbBase = new Label();
            lbInsuficientes = new Label();
            lbBuenos = new Label();
            lbExcelentes = new Label();
            lbTotal = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnVotar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbInsuficiente);
            groupBox1.Controls.Add(rbBueno);
            groupBox1.Controls.Add(rbExcelente);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(206, 147);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opinión";
            // 
            // rbInsuficiente
            // 
            rbInsuficiente.AutoSize = true;
            rbInsuficiente.Location = new Point(15, 107);
            rbInsuficiente.Name = "rbInsuficiente";
            rbInsuficiente.Size = new Size(86, 19);
            rbInsuficiente.TabIndex = 2;
            rbInsuficiente.TabStop = true;
            rbInsuficiente.Text = "Insuficiente";
            rbInsuficiente.UseVisualStyleBackColor = true;
            // 
            // rbBueno
            // 
            rbBueno.AutoSize = true;
            rbBueno.Location = new Point(15, 68);
            rbBueno.Name = "rbBueno";
            rbBueno.Size = new Size(59, 19);
            rbBueno.TabIndex = 1;
            rbBueno.TabStop = true;
            rbBueno.Text = "Bueno";
            rbBueno.UseVisualStyleBackColor = true;
            // 
            // rbExcelente
            // 
            rbExcelente.AutoSize = true;
            rbExcelente.Location = new Point(15, 31);
            rbExcelente.Name = "rbExcelente";
            rbExcelente.Size = new Size(75, 19);
            rbExcelente.TabIndex = 0;
            rbExcelente.TabStop = true;
            rbExcelente.Text = "Excelente";
            rbExcelente.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbFull);
            groupBox2.Controls.Add(rbBase);
            groupBox2.Location = new Point(12, 174);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(206, 122);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de Producto";
            // 
            // rbFull
            // 
            rbFull.AutoSize = true;
            rbFull.Location = new Point(15, 77);
            rbFull.Name = "rbFull";
            rbFull.Size = new Size(51, 19);
            rbFull.TabIndex = 4;
            rbFull.TabStop = true;
            rbFull.Text = "FULL";
            rbFull.UseVisualStyleBackColor = true;
            // 
            // rbBase
            // 
            rbBase.AutoSize = true;
            rbBase.Location = new Point(15, 34);
            rbBase.Name = "rbBase";
            rbBase.Size = new Size(52, 19);
            rbBase.TabIndex = 3;
            rbBase.TabStop = true;
            rbBase.Text = "BASE";
            rbBase.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbFull);
            groupBox3.Controls.Add(lbBase);
            groupBox3.Controls.Add(lbInsuficientes);
            groupBox3.Controls.Add(lbBuenos);
            groupBox3.Controls.Add(lbExcelentes);
            groupBox3.Controls.Add(lbTotal);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(12, 316);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(301, 232);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resultados de la encuesta";
            // 
            // lbFull
            // 
            lbFull.AutoSize = true;
            lbFull.Location = new Point(194, 204);
            lbFull.Name = "lbFull";
            lbFull.Size = new Size(12, 15);
            lbFull.TabIndex = 11;
            lbFull.Text = "-";
            // 
            // lbBase
            // 
            lbBase.AutoSize = true;
            lbBase.Location = new Point(194, 174);
            lbBase.Name = "lbBase";
            lbBase.Size = new Size(12, 15);
            lbBase.TabIndex = 10;
            lbBase.Text = "-";
            // 
            // lbInsuficientes
            // 
            lbInsuficientes.AutoSize = true;
            lbInsuficientes.Location = new Point(194, 128);
            lbInsuficientes.Name = "lbInsuficientes";
            lbInsuficientes.Size = new Size(12, 15);
            lbInsuficientes.TabIndex = 9;
            lbInsuficientes.Text = "-";
            // 
            // lbBuenos
            // 
            lbBuenos.AutoSize = true;
            lbBuenos.Location = new Point(194, 99);
            lbBuenos.Name = "lbBuenos";
            lbBuenos.Size = new Size(12, 15);
            lbBuenos.TabIndex = 8;
            lbBuenos.Text = "-";
            // 
            // lbExcelentes
            // 
            lbExcelentes.AutoSize = true;
            lbExcelentes.Location = new Point(194, 69);
            lbExcelentes.Name = "lbExcelentes";
            lbExcelentes.Size = new Size(12, 15);
            lbExcelentes.TabIndex = 7;
            lbExcelentes.Text = "-";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(194, 38);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(12, 15);
            lbTotal.TabIndex = 6;
            lbTotal.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 204);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 5;
            label6.Text = "Cantidad de FULL:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 174);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 4;
            label5.Text = "Cantidad de BASE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 128);
            label4.Name = "label4";
            label4.Size = new Size(143, 15);
            label4.TabIndex = 3;
            label4.Text = "Cantidad de Insuficientes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 99);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 2;
            label3.Text = "Cantidad de Buenos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 69);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 1;
            label2.Text = "Cantidad de Excelentes:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de votaciones:";
            // 
            // btnVotar
            // 
            btnVotar.Location = new Point(238, 147);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(75, 42);
            btnVotar.TabIndex = 3;
            btnVotar.Text = "Votar";
            btnVotar.UseVisualStyleBackColor = true;
            btnVotar.Click += btnVotar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 560);
            Controls.Add(btnVotar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Encuesta de Servicio";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbInsuficiente;
        private RadioButton rbBueno;
        private RadioButton rbExcelente;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton rbFull;
        private RadioButton rbBase;
        private Button btnVotar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbFull;
        private Label lbBase;
        private Label lbInsuficientes;
        private Label lbBuenos;
        private Label lbExcelentes;
        private Label lbTotal;
    }
}
