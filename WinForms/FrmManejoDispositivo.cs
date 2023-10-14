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
        private int id;
        private int cantidad;
        private double precio;
        public string marca;
        public string modelo;
        private EFactura tipo;
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
            if (true)
            {

            }
            else
            {
                this.seCreo = true;
                this.dispositivo = new Celular(id, cantidad, precio, modelo, marca, tipo);
                this.DialogResult = DialogResult.OK;
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void VerificarDatosGenerales()
        {
            if (!int.TryParse(this.TxtId.Text, out this.id))
            {
                MessageBox.Show("Ingrese un id valido", "ERROR");
                return;
            }
            if (!int.TryParse(this.TxtCantidad.Text, out this.cantidad))
            {
                MessageBox.Show("Ingrese una cantidad valido", "ERROR");
                return;
            }
            if (!double.TryParse(this.TxtPrecio.Text, out this.precio))
            {
                MessageBox.Show("Ingrese un precio valido", "ERROR");
                return;
            }

            this.marca = this.TxtMarca.Text;
            this.modelo = this.TxtModelo.Text;
            this.tipo = (EFactura)this.CmbTipo.SelectedItem;


            if (marca.Length == 0 || modelo.Length == 0 || id <= 0 || cantidad <= 0 || precio <= 0)
            {
                MessageBox.Show("Ingrese datos validos", "ERROR");
                return;
            }
        }
    }
}
