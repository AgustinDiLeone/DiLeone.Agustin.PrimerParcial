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
using Microsoft.VisualBasic.ApplicationServices;

namespace WinForms
{
    public partial class FrmCrudCliente : FrmCrud
    {
        private List<Cliente> clientes;
        public FrmCrudCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.clientes = new List<Cliente>();

        }
        private void ActualizarVisor()
        {
            lstBox.Items.Clear();
            if (this.clientes != null)
            {
                foreach (Cliente cliente in this.clientes)
                {
                    lstBox.Items.Add(cliente.MostrarVisor());
                }
            }

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
            FrmManejoCliente frmAgregarCliente = new FrmManejoCliente();
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
            FrmManejoCliente frmAgregarCliente = new FrmManejoCliente(this.clientes[index]);
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
        /*
        private void SerializaciónXml()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\ListaDeClientes.xml";
            //string path = @"..\..\..\..\WinForms\ListaDeClientes.xml";
            try
            {

                using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8))
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
        */
        public void SerializaciónXml(List<Cliente> listaClientes, string nombreArchivo)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Cliente>));

            using (TextWriter writer = new StreamWriter(nombreArchivo))
            {
                serializer.Serialize(writer, listaClientes);
            }
        }
        /*
        private void DeserializacionXml()
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                path += @"\ListaDeClientes.xml";
                using (XmlTextReader reader = new XmlTextReader(path))
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
        */
        public List<Cliente> DeserializacionXml(string nombreArchivo)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Cliente>));

                using (TextReader reader = new StreamReader(nombreArchivo))
                {
                    return (List<Cliente>)serializer.Deserialize(reader);
                }
            }
            catch 
            { 
                return this.clientes = new List<Cliente>();
            }

        }

        private void FrmCrudCliente_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\ListaDeClientes.xml";
            this.clientes = this.DeserializacionXml(path);
            if (this.clientes == null)
                this.clientes = new List<Cliente>();
             /*
            this.clientes = new List<Cliente>();
            Cliente x = new Cliente(1486245, "juanito", ETipos.Monotributista, "Buenos Aires");
            DispositivoElectronico y = new Celular(10, 2000, 542.4, "Samsung", "A23", EFactura.B, 20, 264, 18, 3);
            DispositivoElectronico z = new Celular(10, 2000, 542.4, "Samsung", "A23", EFactura.B, 20, 264, 18, 3);
            x += y;
            x += z;
            this.clientes.Add(x);
            */
            
            //MessageBox.Show(this.clientes.ToString());
            this.ActualizarVisor();
        }

        private void FrmCrudCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\ListaDeClientes.xml";
            this.SerializaciónXml(this.clientes, path);
        }


        private void FrmCrudCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Estas seguro de cerrar la aplicacion", "ATENCION",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
