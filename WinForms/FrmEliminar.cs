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
    public partial class FrmEliminar : Form
    {
        protected string tipo;
        protected bool respuesta;
        protected Cliente cliente;

        public bool Respuesta
        {
            get { return this.respuesta; }
        }

        public FrmEliminar(string tipo, Cliente cliente)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.tipo = tipo;
            this.cliente = cliente;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.respuesta = true;
            this.Close();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.respuesta = false;
            this.Close();
        }

        private void FrmEliminar_Load(object sender, EventArgs e)
        {
            this.ActualizarVisor();
        }
        private void ActualizarVisor()
        {
            if (this.tipo == "cliente")
            {
                LblCliente.Text = this.cliente.ToString();
            }

        }
    }
}
