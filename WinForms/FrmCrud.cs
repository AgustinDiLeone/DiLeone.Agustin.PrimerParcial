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
    public partial class FrmCrud : Form
    {
        public FrmCrud()
        {
            InitializeComponent();
            BtnCaracteristicaUno.Checked = true;
            BtnAscendente.Checked = true;
        }

        public virtual void BtnVer_Click(object sender, EventArgs e) { }

        public virtual void BtnAgregar_Click(object sender, EventArgs e) { }

        public virtual void BtnModificar_Click(object sender, EventArgs e) { }

        public virtual void BtnEliminar_Click(object sender, EventArgs e) { }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public virtual void BtnOrdenar_Click(object sender, EventArgs e) { }

        public virtual void LblUsuarioConectado_Click(object sender, EventArgs e)
        {

        }

        private void FrmCrud_Load(object sender, EventArgs e)
        {

        }
    }
}

