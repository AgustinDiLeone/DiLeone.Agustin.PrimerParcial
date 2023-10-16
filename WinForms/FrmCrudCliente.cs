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
        private Usuario usuarioIngresado;
        public FrmCrudCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.clientes = new List<Cliente>();

        }
        public FrmCrudCliente(Usuario usuario):this() 
        {
            this.usuarioIngresado = usuario;
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
            FrmCrudDispositivos frmVer = new FrmCrudDispositivos(cliente);

            this.Hide();
            frmVer.ShowDialog();
            this.clientes[index] = frmVer.ClienteModificado();
            this.Show();
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

        public void SerializaciónXml(List<Cliente> listaClientes, string nombreArchivo)
        {
            try
            { 
                XmlSerializer serializer = new XmlSerializer(typeof(List<Cliente>));

                using (TextWriter writer = new StreamWriter(nombreArchivo))
                {
                    serializer.Serialize(writer, listaClientes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de serialización del archivo, llamar al equipo tecnico","ERROR");
            }
        }

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
                MessageBox.Show("Error en la deserealizacion del archivo, llamar al equipo tecnico", "ERROR");
                return this.clientes = new List<Cliente>();
            }

        }

        private void FrmCrudCliente_Load(object sender, EventArgs e)
        {
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //path += @"\ListaDeClientes.xml";
            string path = @"..\..\..\..\WinForms\ListaDeClientes.xml";

            this.clientes = this.DeserializacionXml(path);
            if (this.clientes == null)
                this.clientes = new List<Cliente>();
            //LblUsuarioConectado.Text = this.usuarioIngresado.nombre + " - " + DateTime.Now.ToString();
            /*
            Cliente x = new Cliente(1486245, "juanito", ETipos.Monotributista, "Buenos Aires");
            DispositivoElectronico y = new Celular();
            DispositivoElectronico t = new Celular(25,254,24,"dfg","df",EFactura.B,25,57,3);

            DispositivoElectronico z = new Celular(10, 2000, 542.4, "Samsung", "A23", EFactura.B, 20, 264, 18, 3);
            x += y;
            x += z;
            x+= t;
            this.clientes.Add(x);
            
            */
            //MessageBox.Show(this.clientes.ToString());
            this.ActualizarVisor();
        }

        private void FrmCrudCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //path += @"\ListaDeClientes.xml";
            string path = @"..\..\..\..\WinForms\ListaDeClientes.xml";
            this.SerializaciónXml(this.clientes, path);
        }


        private void FrmCrudCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Estas seguro de cerrar la aplicacion", "ATENCION",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Evita el cierre del formulario
            }
        }
    }
}
