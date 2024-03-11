using ProyectoPuntoVenta.Formularios;
using ProyectoPuntoVenta.Logica;
using ProyectoPuntoVenta.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPuntoVenta
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            Persona oPersona = PersonaLogica.Instancia.Listar().Where(p => p.Codigo == txtcodigo.Text && p.Clave == txtclave.Text && p.oTipoPersona.IdTipoPersona != 3).FirstOrDefault();
            if (oPersona != null)
            {
                frmMenuInicio frm = new frmMenuInicio();
                frm.Show();
                this.Hide();
                frm.FormClosing += Frm_Closing;
            }
            else
            {
                MessageBox.Show("No se econtraron coincidencias del usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Frm_Closing(object sender, FormClosingEventArgs e)
        {
            txtcodigo.Text = "";
            txtclave.Text = "";
            txtcodigo.Focus();
            this.Show();
        }
    }
}
