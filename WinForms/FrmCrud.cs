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
    public abstract partial class FrmCrud : Form
    {
        public FrmCrud()
        {
            InitializeComponent();
        }

        public abstract void BtnVer_Click(object sender, EventArgs e);

        public abstract void BtnAgregar_Click(object sender, EventArgs e);

        public abstract void BtnModificar_Click(object sender, EventArgs e);

        public abstract void BtnEliminar_Click(object sender, EventArgs e);

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public abstract void BtnOrdenar_Click(object sender, EventArgs e);

        private void LblUsuarioConectado_Click(object sender, EventArgs e)
        {

        }

        private void FrmCrud_Load(object sender, EventArgs e)
        {

        }
    }
}

