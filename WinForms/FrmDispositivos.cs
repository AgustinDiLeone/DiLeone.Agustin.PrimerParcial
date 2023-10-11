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
    public partial class FrmDispositivos : FrmCrud
    {
        protected Cliente cliente;
        public FrmDispositivos(Cliente cliente)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.cliente = cliente;

            Celular celular = new Celular(10,251,5478,"Samsung","A23",EFactura.B,20,264,8,3);
            this.cliente += celular;
        }

        private void ActualizarForm()
        {
            lblCliente.Text = this.cliente.ToString();
            foreach (DispositivoElectronico dispo in this.cliente.Dispositivos)
            {
                lstBox.Items.Add(dispo.MostrarVisor());
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

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            int index = this.lstBox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Selecciona el elemento que deseas eliminar", "ERROR");
                return;
            }
            DispositivoElectronico dispo = this.cliente.Dispositivos[index];
            FrmEliminar frmEliminar = new FrmEliminar("dispositivo", dispo);
            frmEliminar.ShowDialog();
            if (frmEliminar.Respuesta)
            {
                this.cliente.Dispositivos.RemoveAt(index);
                this.ActualizarForm();
            }
        }
        public Cliente ClienteModificado()
        {
            return this.cliente;
        }
    }
}
