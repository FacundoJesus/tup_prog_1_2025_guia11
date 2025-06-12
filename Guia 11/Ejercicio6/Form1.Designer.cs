namespace Ejercicio6
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
            chbOpcion1 = new CheckBox();
            chbOpcion2 = new CheckBox();
            chbOpcion3 = new CheckBox();
            lbResultado = new Label();
            btnResponder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Una variable local:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 153);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Resultado:";
            // 
            // chbOpcion1
            // 
            chbOpcion1.AutoSize = true;
            chbOpcion1.Location = new Point(32, 39);
            chbOpcion1.Name = "chbOpcion1";
            chbOpcion1.Size = new Size(185, 19);
            chbOpcion1.TabIndex = 2;
            chbOpcion1.Text = "No siempre se debe inicializar.";
            chbOpcion1.UseVisualStyleBackColor = true;
            // 
            // chbOpcion2
            // 
            chbOpcion2.AutoSize = true;
            chbOpcion2.Location = new Point(32, 73);
            chbOpcion2.Name = "chbOpcion2";
            chbOpcion2.Size = new Size(156, 19);
            chbOpcion2.TabIndex = 3;
            chbOpcion2.Text = "Nunca debe inicializarse.";
            chbOpcion2.UseVisualStyleBackColor = true;
            // 
            // chbOpcion3
            // 
            chbOpcion3.AutoSize = true;
            chbOpcion3.Location = new Point(32, 112);
            chbOpcion3.Name = "chbOpcion3";
            chbOpcion3.Size = new Size(164, 19);
            chbOpcion3.TabIndex = 4;
            chbOpcion3.Text = "Siempre debe inicializarse.";
            chbOpcion3.UseVisualStyleBackColor = true;
            // 
            // lbResultado
            // 
            lbResultado.Location = new Point(12, 178);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(305, 111);
            lbResultado.TabIndex = 5;
            lbResultado.Text = "-";
            // 
            // btnResponder
            // 
            btnResponder.Location = new Point(247, 63);
            btnResponder.Name = "btnResponder";
            btnResponder.Size = new Size(75, 37);
            btnResponder.TabIndex = 6;
            btnResponder.Text = "Responder";
            btnResponder.UseVisualStyleBackColor = true;
            btnResponder.Click += btnResponder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 298);
            Controls.Add(btnResponder);
            Controls.Add(lbResultado);
            Controls.Add(chbOpcion3);
            Controls.Add(chbOpcion2);
            Controls.Add(chbOpcion1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Examen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox chbOpcion1;
        private CheckBox chbOpcion2;
        private CheckBox chbOpcion3;
        private Label lbResultado;
        private Button btnResponder;
    }
}
