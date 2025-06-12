namespace Ejercicio3
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
            btnRegistrarNombre = new Button();
            lsbInvitaciones = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 39);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Invitado:";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(97, 12);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 1;
            // 
            // btnRegistrarNombre
            // 
            btnRegistrarNombre.Location = new Point(213, 12);
            btnRegistrarNombre.Name = "btnRegistrarNombre";
            btnRegistrarNombre.Size = new Size(75, 46);
            btnRegistrarNombre.TabIndex = 2;
            btnRegistrarNombre.Text = "Registrar Nombre";
            btnRegistrarNombre.UseVisualStyleBackColor = true;
            btnRegistrarNombre.Click += btnRegistrarNombre_Click;
            // 
            // lsbInvitaciones
            // 
            lsbInvitaciones.FormattingEnabled = true;
            lsbInvitaciones.ItemHeight = 15;
            lsbInvitaciones.Location = new Point(12, 75);
            lsbInvitaciones.Name = "lsbInvitaciones";
            lsbInvitaciones.Size = new Size(185, 154);
            lsbInvitaciones.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 242);
            Controls.Add(lsbInvitaciones);
            Controls.Add(btnRegistrarNombre);
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
        private Button btnRegistrarNombre;
        private ListBox lsbInvitaciones;
    }
}
