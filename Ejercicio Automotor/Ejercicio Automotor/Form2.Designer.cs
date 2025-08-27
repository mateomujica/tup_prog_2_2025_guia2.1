namespace Ejercicio_Automotor
{
    partial class Form2
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
            button1 = new Button();
            btnCancelar = new Button();
            tbxDNI = new TextBox();
            tbxNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(59, 159);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(175, 159);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tbxDNI
            // 
            tbxDNI.Location = new Point(80, 48);
            tbxDNI.Name = "tbxDNI";
            tbxDNI.Size = new Size(100, 23);
            tbxDNI.TabIndex = 2;
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(80, 104);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(100, 23);
            tbxNombre.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 51);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 4;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 112);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 268);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbxNombre);
            Controls.Add(tbxDNI);
            Controls.Add(btnCancelar);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button button1;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        public TextBox tbxDNI;
        public TextBox tbxNombre;
    }
}