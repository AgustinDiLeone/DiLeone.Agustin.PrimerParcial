using System.Text.Json;
using System.Text.Json.Serialization;

namespace WinForms
{
    public partial class FrmLogIn : Form
    {
        public bool validacionClaveUsuario = false;
        public FrmLogIn()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text == "" || txtCorreo.Text == "")
            {
                MessageBox.Show("Ingresa datos validos", "ERROR");
                return;
            }
            List<Usuario> list = DeserealizarUsuarios();

            foreach (Usuario usuario in list)
            {
                if (txtCorreo.Text == usuario.correo)
                {
                    if (txtClave.Text == usuario.clave)
                    {
                        this.validacionClaveUsuario = true;
                        this.Close();
                        return;
                    }
                }
            }
            MessageBox.Show("El usuario es invalido", "ERROR");

        }
        private static List<Usuario> DeserealizarUsuarios()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\MOCK_DATA.json";
            string jsonString = File.ReadAllText(path);


            // Lee el contenido del archivo JSON en una cadena

            // Deserializa la cadena JSON en una lista de objetos de tipo Usuario
            List<Usuario> listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(jsonString);

            return listaUsuarios;
        }

        private void FrmLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas cerrar el formulario?", "Confirmar Cierre", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                e.Cancel = true; 
            }
        }
    }
}