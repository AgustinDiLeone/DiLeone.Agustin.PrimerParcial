﻿namespace WinForms
{
    partial class FrmCrud
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
            lstBox = new ListBox();
            grpOrdenCarac = new GroupBox();
            grpOrden = new GroupBox();
            BtnDescendente = new CheckBox();
            BtnAscendente = new CheckBox();
            BtnOrdenar = new Button();
            BtnVer = new Button();
            BtnModificar = new Button();
            BtnEliminar = new Button();
            BtnAgregar = new Button();
            LblUsuarioConectado = new Label();
            grpOrden.SuspendLayout();
            SuspendLayout();
            // 
            // lstBox
            // 
            lstBox.FormattingEnabled = true;
            lstBox.ItemHeight = 15;
            lstBox.Location = new Point(29, 31);
            lstBox.Name = "lstBox";
            lstBox.ScrollAlwaysVisible = true;
            lstBox.Size = new Size(395, 379);
            lstBox.TabIndex = 0;
            lstBox.SelectedIndexChanged += lstBox_SelectedIndexChanged;
            // 
            // grpOrdenCarac
            // 
            grpOrdenCarac.Location = new Point(483, 63);
            grpOrdenCarac.Name = "grpOrdenCarac";
            grpOrdenCarac.Size = new Size(120, 102);
            grpOrdenCarac.TabIndex = 1;
            grpOrdenCarac.TabStop = false;
            grpOrdenCarac.Text = "Caracteristica";
            // 
            // grpOrden
            // 
            grpOrden.Controls.Add(BtnDescendente);
            grpOrden.Controls.Add(BtnAscendente);
            grpOrden.Location = new Point(635, 63);
            grpOrden.Name = "grpOrden";
            grpOrden.Size = new Size(120, 102);
            grpOrden.TabIndex = 2;
            grpOrden.TabStop = false;
            grpOrden.Text = "Orden";
            // 
            // BtnDescendente
            // 
            BtnDescendente.AutoSize = true;
            BtnDescendente.Location = new Point(12, 56);
            BtnDescendente.Name = "BtnDescendente";
            BtnDescendente.Size = new Size(97, 19);
            BtnDescendente.TabIndex = 2;
            BtnDescendente.Text = "Descendiente";
            BtnDescendente.UseVisualStyleBackColor = true;
            // 
            // BtnAscendente
            // 
            BtnAscendente.AutoSize = true;
            BtnAscendente.Location = new Point(12, 31);
            BtnAscendente.Name = "BtnAscendente";
            BtnAscendente.Size = new Size(88, 19);
            BtnAscendente.TabIndex = 1;
            BtnAscendente.Text = "Ascendente";
            BtnAscendente.UseVisualStyleBackColor = true;
            // 
            // BtnOrdenar
            // 
            BtnOrdenar.Location = new Point(483, 178);
            BtnOrdenar.Name = "BtnOrdenar";
            BtnOrdenar.Size = new Size(272, 29);
            BtnOrdenar.TabIndex = 3;
            BtnOrdenar.Text = "Ordenar";
            BtnOrdenar.UseVisualStyleBackColor = true;
            BtnOrdenar.Click += BtnOrdenar_Click;
            // 
            // BtnVer
            // 
            BtnVer.Location = new Point(483, 229);
            BtnVer.Name = "BtnVer";
            BtnVer.Size = new Size(272, 29);
            BtnVer.TabIndex = 4;
            BtnVer.Text = "Ver";
            BtnVer.UseVisualStyleBackColor = true;
            BtnVer.Click += BtnVer_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(483, 331);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(272, 29);
            BtnModificar.TabIndex = 5;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(483, 381);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(272, 29);
            BtnEliminar.TabIndex = 7;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(483, 281);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(272, 29);
            BtnAgregar.TabIndex = 8;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // LblUsuarioConectado
            // 
            LblUsuarioConectado.AutoSize = true;
            LblUsuarioConectado.Location = new Point(483, 31);
            LblUsuarioConectado.Name = "LblUsuarioConectado";
            LblUsuarioConectado.Size = new Size(105, 15);
            LblUsuarioConectado.TabIndex = 9;
            LblUsuarioConectado.Text = "UsuarioConectado";
            LblUsuarioConectado.Click += LblUsuarioConectado_Click;
            // 
            // FrmCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblUsuarioConectado);
            Controls.Add(BtnAgregar);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnModificar);
            Controls.Add(BtnVer);
            Controls.Add(BtnOrdenar);
            Controls.Add(grpOrden);
            Controls.Add(grpOrdenCarac);
            Controls.Add(lstBox);
            Name = "FrmCrud";
            Text = "FrmCrud";
            Load += FrmCrud_Load;
            grpOrden.ResumeLayout(false);
            grpOrden.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ListBox lstBox;
        public GroupBox grpOrdenCarac;
        public GroupBox grpOrden;
        public CheckBox BtnAscendente;
        public CheckBox BtnDescendente;
        public Button BtnOrdenar;
        public Button BtnVer;
        public Button BtnModificar;
        public Button BtnEliminar;
        public Button BtnAgregar;
        public Label LblUsuarioConectado;
    }
}