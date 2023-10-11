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
using System.Xml.Serialization;
using System.Xml;

namespace WinForms
{
    public partial class FrmCrudCliente : FrmCrud
    {
        private List<Cliente> clientes;
        public FrmCrudCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void ActualizarVisor()
        {
            lstBox.Items.Clear();
            if (this.clientes.Count >= 0)
            {
                foreach (Cliente cliente in this.clientes)
                {
                    lstBox.Items.Add(cliente.MostrarVisor());
                }
            }

        }
        public void FrmClientes_Load(object sender, EventArgs e)
        {
            this.DeserializacionXml();
            this.ActualizarVisor();
        }

        public override void BtnVer_Click(object sender, EventArgs e)
        {
            int index = this.lstBox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Selecciona el elemento que deseas ver", "ERROR");
                return;
            }
            Cliente cliente = this.clientes[index];
            FrmVer frmVer = new FrmVer("cliente", cliente);
            frmVer.ShowDialog();
        }
        public override void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarCliente frmAgregarCliente = new FrmAgregarCliente();
            frmAgregarCliente.ShowDialog();
            if (frmAgregarCliente.seCreoCliente)
            {
                this.clientes.Add(frmAgregarCliente.cliente);
                this.ActualizarVisor();
            }

        }
        public override void BtnEliminar_Click(object sender, EventArgs e)
        {
            int index = this.lstBox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Selecciona el elemento que deseas eliminar", "ERROR");
                return;
            }
            Cliente cliente = this.clientes[index];
            FrmEliminar frmEliminar = new FrmEliminar("cliente", cliente);
            frmEliminar.ShowDialog();
            if (frmEliminar.Respuesta)
            {
                this.clientes.RemoveAt(index);
                this.ActualizarVisor();
            }

        }
        public override void BtnModificar_Click(object sender, EventArgs e)
        {
            int index = this.lstBox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Selecciona el elemento que deseas modificar", "ERROR");
                return;
            }
            FrmAgregarCliente frmAgregarCliente = new FrmAgregarCliente();
            frmAgregarCliente.ShowDialog();
            if (frmAgregarCliente.seCreoCliente)
            {
                frmAgregarCliente.cliente.Dispositivos = this.clientes[index].Dispositivos;
                this.clientes[index] = frmAgregarCliente.cliente;
                this.ActualizarVisor();
            }
        }
        public override void BtnOrdenar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void FrmClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.SerializaciónXml();
        }
        private void SerializaciónXml()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(path + @"\ListaDeProductos.xml", Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Cliente>)));
                    ser.Serialize(writer, this.clientes);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Error al Serializar los Datos");
            }

        }
        private void DeserializacionXml()
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                using (XmlTextReader reader = new XmlTextReader(path + @"\ListaDeProductos.xml"))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Cliente>)));

                    this.clientes = (List<Cliente>)ser.Deserialize(reader);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error al Deserializar los Datos");
            }
        }

        private void FrmCrudCliente_Load(object sender, EventArgs e)
        {
            this.clientes = new List<Cliente>();
            Cliente x = new Cliente(1486245, "juanito", ETipos.Monotributista, "Buenos Aires");
            DispositivoElectronico y = new Celular(10, 2000, 542.4, "Samsung", "A23", EFactura.B, 20, 264, 18, 3);
            x += y;
            this.clientes.Add(x);
            this.ActualizarVisor();
        }

        private void FrmCrudCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.SerializaciónXml();
        }

        private void FrmCrudCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Estas seguro de cerrar la aplicacion", "ATENCION",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
