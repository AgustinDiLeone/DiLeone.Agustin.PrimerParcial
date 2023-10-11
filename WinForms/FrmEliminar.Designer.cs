namespace WinForms
{
    partial class FrmEliminar
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
            BtnAceptar = new Button();
            BtnCancelar = new Button();
            label1 = new Label();
            LblCliente = new Label();
            SuspendLayout();
            // 
            // BtnAceptar
            // 
            BtnAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAceptar.Location = new Point(12, 374);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(216, 42);
            BtnAceptar.TabIndex = 1;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCancelar.Location = new Point(249, 374);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(216, 42);
            BtnCancelar.TabIndex = 2;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(160, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 21);
            label1.TabIndex = 3;
            label1.Text = "¿Deseas eliminarlo?";
            // 
            // LblCliente
            // 
            LblCliente.AutoSize = true;
            LblCliente.Location = new Point(23, 52);
            LblCliente.Name = "LblCliente";
            LblCliente.Size = new Size(60, 15);
            LblCliente.TabIndex = 4;
            LblCliente.Text = "LblCliente";
            // 
            // FrmEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 430);
            Controls.Add(LblCliente);
            Controls.Add(label1);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptar);
            Name = "FrmEliminar";
            Text = "Eliminar";
            Load += FrmEliminar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnAceptar;
        private Button BtnCancelar;
        private Label label1;
        private Label LblCliente;
    }
}