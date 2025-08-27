namespace Ejercicio_Automotor
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
            btnRegistrar = new Button();
            btnListar = new Button();
            lsbRegistrar = new ListBox();
            lsbListar = new ListBox();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(332, 139);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(626, 285);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // lsbRegistrar
            // 
            lsbRegistrar.FormattingEnabled = true;
            lsbRegistrar.ItemHeight = 15;
            lsbRegistrar.Location = new Point(83, 27);
            lsbRegistrar.Name = "lsbRegistrar";
            lsbRegistrar.Size = new Size(210, 169);
            lsbRegistrar.TabIndex = 2;
            // 
            // lsbListar
            // 
            lsbListar.FormattingEnabled = true;
            lsbListar.ItemHeight = 15;
            lsbListar.Location = new Point(83, 216);
            lsbListar.Name = "lsbListar";
            lsbListar.Size = new Size(506, 184);
            lsbListar.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lsbListar);
            Controls.Add(lsbRegistrar);
            Controls.Add(btnListar);
            Controls.Add(btnRegistrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrar;
        private Button btnListar;
        private ListBox lsbRegistrar;
        private ListBox lsbListar;
    }
}
