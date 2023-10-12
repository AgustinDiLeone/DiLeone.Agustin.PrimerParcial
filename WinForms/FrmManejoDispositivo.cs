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
    public partial class FrmManejoDispositivo : Form
    {
        public bool seCreo;
        public DispositivoElectronico dispositivo;
        public FrmManejoDispositivo()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        public FrmManejoDispositivo(DispositivoElectronico dispositivo) : this()
        {
            this.dispositivo = dispositivo;
            TxtId.Text = this.dispositivo.Id.ToString();
            TxtCantidad.Text = this.dispositivo.Cantidad.ToString();
            TxtMarca.Text = this.dispositivo.Marca;
            TxtModelo.Text = this.dispositivo.Modelo;
            TxtPrecio.Text = this.dispositivo.PrecioUnitario.ToString();
            CmbDispositivos.Enabled = false;
            //CmbTipo.SelectedItem = this.dispositivo.TipoCliente;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmManejoDispositivo_Load(object sender, EventArgs e)
        {
            var tipos = EFactura.GetValues(typeof(EFactura));

            CmbTipo.DataSource = tipos;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(this.TxtId.Text, out int id)))
            {
                MessageBox.Show("Ingrese un id valido", "ERROR");
                return;
            }
            if (!(int.TryParse(this.TxtCantidad.Text, out int cantidad)))
            {
                MessageBox.Show("Ingrese una cantidad valido", "ERROR");
                return;
            }
            if (!(double.TryParse(this.TxtPrecio.Text, out double precio)))
            {
                MessageBox.Show("Ingrese un precio valido", "ERROR");
                return;
            }

            string marca = this.TxtMarca.Text;
            string modelo = this.TxtModelo.Text;
            EFactura tipo = (EFactura)this.CmbTipo.SelectedItem;


            if (marca.Length == 0 || modelo.Length == 0 || id <= 0 || cantidad <=0 || precio <= 0)
            {
                MessageBox.Show("Ingrese datos validos", "ERROR");
                return;
            }
            else
            {
                this.seCreo = true;
                this.dispositivo = new Celular(id,cantidad,precio,modelo,marca,tipo);
                this.DialogResult = DialogResult.OK;
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
