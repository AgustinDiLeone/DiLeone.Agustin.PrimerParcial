using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WinForms
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedIndex.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente p3 = new Cliente(24478569746, "Juansito", ETipos.Exento, "BuenosAires");

            DispositivoElectronico d = new Celular(10, 20, 254.4);
            DispositivoElectronico d1 = new Celular(25, 8, 25415);
            DispositivoElectronico d2 = new Celular();
            DispositivoElectronico d3 = new Celular(18, 1, 24817, "samsung", "a23", EFactura.C, 20, 256, 10, 5);
            DispositivoElectronico d4 = new Celular(74, 58, 47, "Samsung", "S8+", EFactura.C);
            DispositivoElectronico t = new Televisor(2, 10, 2547, "samsung", "a23", EFactura.C, 80, 1080, true);


            p3 += d4;
            p3 += t;

            listBox1.Items.Add(p3.MostrarVisor());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Selecciona el elemento que deseas modificar", "ERROR");
                return;
            }

            CRUD frm1 = new CRUD();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
            //if (frm1.DialogResult == DialogResult.OK)
            {
                //this.productos[index] = frm1.producto;
                //this.ActualizarVisor();
            }
        }

        private void CRUD_Load(object sender, EventArgs e)
        {

        }
    }
}
