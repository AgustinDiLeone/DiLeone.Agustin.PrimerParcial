using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class FrmVer : Form
    {
        protected string tipo;
        protected Cliente cliente;
        public FrmVer(string tipo, Cliente cliente)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.cliente = cliente;
        }

        private void ActualizarForm()
        {
            if (this.tipo == "cliente")
            {
                LblTitulo.Text = this.cliente.Nombre;
                LblMostrar.Text = this.cliente.ToString();
            }


        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmVer_Load(object sender, EventArgs e)
        {
            this.ActualizarForm();
        }
    }
}
