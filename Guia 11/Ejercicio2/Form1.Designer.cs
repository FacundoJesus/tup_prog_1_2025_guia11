namespace Ejercicio2
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
            tbNombre = new TextBox();
            btnImprimirNombre = new Button();
            tbInvitaciones = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(77, 31);
            label1.TabIndex = 0;
            label1.Text = "Nombre del invitado:";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(95, 12);
            tbNombre.Multiline = true;
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(109, 23);
            tbNombre.TabIndex = 1;
            // 
            // btnImprimirNombre
            // 
            btnImprimirNombre.Location = new Point(210, 12);
            btnImprimirNombre.Name = "btnImprimirNombre";
            btnImprimirNombre.Size = new Size(75, 42);
            btnImprimirNombre.TabIndex = 2;
            btnImprimirNombre.Text = "Imprimir Nombre";
            btnImprimirNombre.UseVisualStyleBackColor = true;
            btnImprimirNombre.Click += btnImprimirNombre_Click;
            // 
            // tbInvitaciones
            // 
            tbInvitaciones.Location = new Point(12, 64);
            tbInvitaciones.Multiline = true;
            tbInvitaciones.Name = "tbInvitaciones";
            tbInvitaciones.Size = new Size(192, 98);
            tbInvitaciones.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 179);
            Controls.Add(tbInvitaciones);
            Controls.Add(btnImprimirNombre);
            Controls.Add(tbNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Invitaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNombre;
        private Button btnImprimirNombre;
        private TextBox tbInvitaciones;
    }
}
