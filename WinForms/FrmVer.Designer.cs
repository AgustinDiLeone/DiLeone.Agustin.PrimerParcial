namespace WinForms
{
    partial class FrmVer
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
            LblMostrar = new Label();
            LblTitulo = new Label();
            BtnVolver = new Button();
            SuspendLayout();
            // 
            // LblMostrar
            // 
            LblMostrar.AutoSize = true;
            LblMostrar.Location = new Point(12, 61);
            LblMostrar.Name = "LblMostrar";
            LblMostrar.Size = new Size(38, 15);
            LblMostrar.TabIndex = 0;
            LblMostrar.Text = "label1";
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblTitulo.Location = new Point(169, 22);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(57, 21);
            LblTitulo.TabIndex = 1;
            LblTitulo.Text = "label1";
            // 
            // BtnVolver
            // 
            BtnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnVolver.Location = new Point(12, 401);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(446, 37);
            BtnVolver.TabIndex = 2;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = true;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // FrmVer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 450);
            Controls.Add(BtnVolver);
            Controls.Add(LblTitulo);
            Controls.Add(LblMostrar);
            Name = "FrmVer";
            Text = "FrmVer";
            Load += FrmVer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblMostrar;
        private Label LblTitulo;
        private Button BtnVolver;
    }
}