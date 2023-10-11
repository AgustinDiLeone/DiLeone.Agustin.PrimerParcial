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
            this.clientes = new List<Cliente>();
        }
        private void ActualizarVisor()
        {
            lstBox.Items.Clear();
            foreach (Cliente cliente in this.clientes)
            {
                lstBox.Items.Add(cliente.MostrarVisor());
            }
        }
        public void FrmClientes_Load(object sender, EventArgs e)
        {
            this.DeserializacionXml();
            this.ActualizarVisor();
        }

        public override void BtnVer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funciona");
        }
        public override void BtnAgregar_Click(object sender, EventArgs e)
        {
            lstBox.Items.Add("gfdhsjkgf");

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
            FrmEliminar frmEliminar = new FrmEliminar("cliente");

            //DialogResult result = MessageBox.Show("Deseas eliminar el producto", "ATENCION", MessageBoxButtons.YesNo);
            //if (result == System.Windows.Forms.DialogResult.Yes)
            if (frmEliminar.Respuesta)
            {
                this.clientes.RemoveAt(index);
                this.ActualizarVisor();
            }

        }
        public override void BtnModificar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
    }
}
