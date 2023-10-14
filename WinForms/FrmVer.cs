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
        private DispositivoElectronico dispositivo;
        public FrmVer(DispositivoElectronico dispositivo)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.dispositivo = dispositivo;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVer_Load(object sender, EventArgs e)
        {
            TxtDispositivo.SelectionStart = 0;
            TxtDispositivo.SelectionLength = 0;
            TxtDispositivo.Text = this.dispositivo.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
