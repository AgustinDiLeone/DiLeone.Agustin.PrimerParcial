namespace WinForms
{
    partial class FrmManejoDispositivo
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
            LblTitulo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            CmbTipo = new ComboBox();
            CmbDispositivos = new ComboBox();
            TxtId = new TextBox();
            TxtCantidad = new TextBox();
            TxtMarca = new TextBox();
            TxtModelo = new TextBox();
            TxtPrecio = new TextBox();
            BtnAceptar = new Button();
            BtnCancelar = new Button();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblTitulo.Location = new Point(19, 27);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(57, 21);
            LblTitulo.TabIndex = 1;
            LblTitulo.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 76);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 2;
            label1.Text = "Dispositivo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 142);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 3;
            label2.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 206);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 280);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 5;
            label4.Text = "Tipo de factura:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(259, 76);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 6;
            label5.Text = "Marca:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(259, 142);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 7;
            label6.Text = "Modelo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(259, 206);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 8;
            label7.Text = "Precio:";
            // 
            // CmbTipo
            // 
            CmbTipo.FormattingEnabled = true;
            CmbTipo.Location = new Point(61, 305);
            CmbTipo.Name = "CmbTipo";
            CmbTipo.Size = new Size(121, 23);
            CmbTipo.TabIndex = 11;
            // 
            // CmbDispositivos
            // 
            CmbDispositivos.FormattingEnabled = true;
            CmbDispositivos.Location = new Point(61, 94);
            CmbDispositivos.Name = "CmbDispositivos";
            CmbDispositivos.Size = new Size(121, 23);
            CmbDispositivos.TabIndex = 12;
            // 
            // TxtId
            // 
            TxtId.Location = new Point(61, 165);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(121, 23);
            TxtId.TabIndex = 13;
            // 
            // TxtCantidad
            // 
            TxtCantidad.Location = new Point(61, 235);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(121, 23);
            TxtCantidad.TabIndex = 14;
            // 
            // TxtMarca
            // 
            TxtMarca.Location = new Point(274, 94);
            TxtMarca.Name = "TxtMarca";
            TxtMarca.Size = new Size(137, 23);
            TxtMarca.TabIndex = 15;
            // 
            // TxtModelo
            // 
            TxtModelo.Location = new Point(274, 165);
            TxtModelo.Name = "TxtModelo";
            TxtModelo.Size = new Size(137, 23);
            TxtModelo.TabIndex = 16;
            // 
            // TxtPrecio
            // 
            TxtPrecio.Location = new Point(274, 235);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(137, 23);
            TxtPrecio.TabIndex = 17;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(19, 376);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(193, 30);
            BtnAceptar.TabIndex = 18;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(242, 376);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(193, 30);
            BtnCancelar.TabIndex = 19;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // FrmManejoDispositivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 422);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptar);
            Controls.Add(TxtPrecio);
            Controls.Add(TxtModelo);
            Controls.Add(TxtMarca);
            Controls.Add(TxtCantidad);
            Controls.Add(TxtId);
            Controls.Add(CmbDispositivos);
            Controls.Add(CmbTipo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LblTitulo);
            Name = "FrmManejoDispositivo";
            Text = "FrmProducto";
            Load += FrmManejoDispositivo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblTitulo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox CmbTipo;
        private ComboBox CmbDispositivos;
        private TextBox TxtId;
        private TextBox TxtCantidad;
        private TextBox TxtMarca;
        private TextBox TxtModelo;
        private TextBox TxtPrecio;
        private Button BtnAceptar;
        private Button BtnCancelar;
    }
}