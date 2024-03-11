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
    public partial class ModalProveedor : Form
    {
        public int idproveedor { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        
        public ModalProveedor()
        {
            InitializeComponent();
        }

        private void ModalProveedor_Load(object sender, EventArgs e)
        {


            //AGREGAR BOTON ELIMINAR
            DataGridViewButtonColumn Boton = new DataGridViewButtonColumn();

            Boton.HeaderText = "Seleccionar";
            Boton.Width = 80;
            Boton.Text = "";
            Boton.Name = "btnSeleccionar";
            Boton.UseColumnTextForButtonValue = true;

            //AGREGAMOS LOS BOTONES
            dgdata.Columns.Add(Boton);
            dgdata.Columns.Add("Id", "Id");
            dgdata.Columns.Add("Codigo", "Codigo");
            dgdata.Columns.Add("Nombre", "Nombre");
            dgdata.Columns.Add("Correo", "Correo");
            dgdata.Columns.Add("Telefono", "Telefono");
            dgdata.Columns.Add("Direccion", "Direccion");

            dgdata.Columns["btnSeleccionar"].Width = 80;
            dgdata.Columns["Codigo"].Width = 130;
            dgdata.Columns["Nombre"].Width = 160;
            dgdata.Columns["Correo"].Width = 150;
            dgdata.Columns["Id"].Visible = false;

            foreach (DataGridViewColumn cl in dgdata.Columns)
            {
                if (cl.Visible == true && cl.Name != "btnSeleccionar")
                {
                    cbobuscar.Items.Add(new ComboBoxItem() { Value = cl.Name, Text = cl.HeaderText });
                }
            }
            cbobuscar.DisplayMember = "Text";
            cbobuscar.ValueMember = "Value";
            cbobuscar.SelectedIndex = 0;

            foreach (Proveedor p in ProveedorLogica.Instancia.Listar())
            {
                int rowId = dgdata.Rows.Add();
                DataGridViewRow row = dgdata.Rows[rowId];
                row.Cells["Id"].Value = p.IdProveedor.ToString();
                row.Cells["Codigo"].Value = p.Codigo;
                row.Cells["Nombre"].Value = p.Nombre;
                row.Cells["Correo"].Value = p.Correo;
                row.Cells["Telefono"].Value = p.Telefono;
                row.Cells["Direccion"].Value = p.Direccion;
            }

        }

        private void dgdata_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                string colname = dgdata.Columns[e.ColumnIndex].Name;
                if (colname != "btnSeleccionar")
                {
                    dgdata.Cursor = Cursors.Default;
                }
                else
                {
                    dgdata.Cursor = Cursors.Hand;
                }
            }
        }

        private void dgdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgdata.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    idproveedor = Convert.ToInt32( dgdata.Rows[index].Cells["Id"].Value.ToString());
                    codigo = dgdata.Rows[index].Cells["Codigo"].Value.ToString();
                    nombre = dgdata.Rows[index].Cells["Nombre"].Value.ToString();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((ComboBoxItem)cbobuscar.SelectedItem).Value.ToString();

            if (dgdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgdata.Rows)
                {
                    string valor = row.Cells[columnaFiltro].Value.ToString().Trim();

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().Contains(txtbuscar.Text.Trim()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            foreach (DataGridViewRow row in dgdata.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
