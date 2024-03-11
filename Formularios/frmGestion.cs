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
    public partial class frmGestion : Form
    {
        public frmGestion()
        {
            InitializeComponent();
        }

        private void frmGestion_Load(object sender, EventArgs e)
        {

            //AGREGAR BOTON ELIMINAR
            DataGridViewButtonColumn BotonProducto = new DataGridViewButtonColumn();
            BotonProducto.HeaderText = "Seleccionar";
            BotonProducto.Width = 80;
            BotonProducto.Text = "";
            BotonProducto.Name = "btnSeleccionar";
            BotonProducto.UseColumnTextForButtonValue = true;

            //AGREGAMOS LOS BOTONES
            dgdataproducto.Columns.Add(BotonProducto);
            dgdataproducto.Columns.Add("Id", "Id");
            dgdataproducto.Columns.Add("Codigo", "Codigo");
            dgdataproducto.Columns.Add("Marca", "Marca");
            dgdataproducto.Columns.Add("Modelo", "Modelo");
            dgdataproducto.Columns.Add("Color", "Color");
            dgdataproducto.Columns.Add("Stock", "Stock");

            dgdataproducto.Columns["btnSeleccionar"].Width = 90;
            dgdataproducto.Columns["Codigo"].Width = 100;
            dgdataproducto.Columns["Marca"].Width = 200;
            dgdataproducto.Columns["Modelo"].Width = 210;
            dgdataproducto.Columns["Color"].Width = 150;

            dgdataproducto.Columns["Id"].Visible = false;

            foreach (DataGridViewColumn cl in dgdataproducto.Columns)
            {
                if (cl.Visible == true && cl.Name != "btnSeleccionar")
                {
                    cbobuscarproducto.Items.Add(new ComboBoxItem() { Value = cl.Name, Text = cl.HeaderText });
                }
            }
            cbobuscarproducto.DisplayMember = "Text";
            cbobuscarproducto.ValueMember = "Value";
            cbobuscarproducto.SelectedIndex = 0;

            foreach (Producto p in ProductoLogica.Instancia.Listar())
            {
                int rowId = dgdataproducto.Rows.Add();
                DataGridViewRow row = dgdataproducto.Rows[rowId];
                row.Cells["Id"].Value = p.IdProducto.ToString();
                row.Cells["Codigo"].Value = p.Codigo;
                row.Cells["Marca"].Value = p.Marca;
                row.Cells["Modelo"].Value = p.Modelo;
                row.Cells["Color"].Value = p.Color;
                row.Cells["Stock"].Value = p.Stock;
            }

        }

        private void btnguardarproducto_Click(object sender, EventArgs e)
        {

            Producto objeto = new Producto()
            {
                IdProducto = int.Parse(txtidproducto.Text),
                Codigo = txtcodigoproducto.Text.Trim(),
                Marca = txtmarcaproducto.Text.Trim(),
                Modelo = txtmodeloproducto.Text.Trim(),
                Color = txtcolorproducto.Text.Trim(),
            };

            var resultado = false;
            if (int.Parse(txtidproducto.Text) == 0)
            {
                int id = ProductoLogica.Instancia.Registrar(objeto);
                resultado = id != 0 ? true : false;
                if (resultado)
                {
                    int rowId = dgdataproducto.Rows.Add();
                    DataGridViewRow row = dgdataproducto.Rows[rowId];
                    row.Cells["Id"].Value = id.ToString();
                    row.Cells["Codigo"].Value = txtcodigoproducto.Text.Trim();
                    row.Cells["Marca"].Value = txtmarcaproducto.Text.Trim();
                    row.Cells["Modelo"].Value = txtmodeloproducto.Text.Trim();
                    row.Cells["Color"].Value = txtcolorproducto.Text.Trim();
                    row.Cells["Stock"].Value = "0";
                }

            }
            else
            {
                resultado = ProductoLogica.Instancia.Modificar(objeto);
                if (resultado)
                {
                    DataGridViewRow row = dgdataproducto.Rows[int.Parse(txtindexproducto.Text) - 1];
                    row.Cells["Id"].Value = txtidproducto.Text;
                    row.Cells["Codigo"].Value = txtcodigoproducto.Text.Trim();
                    row.Cells["Marca"].Value = txtmarcaproducto.Text.Trim();
                    row.Cells["Modelo"].Value = txtmodeloproducto.Text.Trim();
                    row.Cells["Color"].Value = txtcolorproducto.Text.Trim();
                }

            }

            if (resultado)
                LimpiarProducto();
            else
                MessageBox.Show("No se pudo guardar los cambios\nRevise los datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dgdataproducto_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                string colname = dgdataproducto.Columns[e.ColumnIndex].Name;
                if (colname != "btnSeleccionar")
                {
                    dgdataproducto.Cursor = Cursors.Default;
                }
                else
                {
                    dgdataproducto.Cursor = Cursors.Hand;
                }
            }
        }

        private void dgdataproducto_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void btnlimpiarproducto_Click(object sender, EventArgs e)
        {
            LimpiarProducto();
        }


        private void LimpiarProducto()
        {
            txtindexproducto.Text = "0";
            txtidproducto.Text = "0";
            txtcodigoproducto.Text = "";
            txtmarcaproducto.Text = "";
            txtmodeloproducto.Text = "";
            txtcolorproducto.Text = "";
        }

        private void dgdataproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgdataproducto.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    txtindexproducto.Text = (index + 1).ToString();
                    txtidproducto.Text = dgdataproducto.Rows[index].Cells["Id"].Value.ToString();
                    txtcodigoproducto.Text = dgdataproducto.Rows[index].Cells["Codigo"].Value.ToString();
                    txtmarcaproducto.Text = dgdataproducto.Rows[index].Cells["Marca"].Value.ToString();
                    txtmodeloproducto.Text = dgdataproducto.Rows[index].Cells["Modelo"].Value.ToString();
                    txtcolorproducto.Text = dgdataproducto.Rows[index].Cells["Color"].Value.ToString();

                }
            }
        }

        private void btneliminarproducto_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtindexproducto.Text) > 0)
            {
                if (MessageBox.Show("¿Desea eliminar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                    bool respuesta = ProductoLogica.Instancia.Eliminar(int.Parse(txtidproducto.Text));
                    if (respuesta)
                    {
                        dgdataproducto.Rows.RemoveAt(int.Parse(txtindexproducto.Text) - 1);
                        LimpiarProducto();
                    }
                    else
                        MessageBox.Show("No se pudo eliminar el registro\nRevise los datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                

            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((ComboBoxItem)cbobuscarproducto.SelectedItem).Value.ToString();

            if (dgdataproducto.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgdataproducto.Rows)
                {
                    string valor = row.Cells[columnaFiltro].Value.ToString().Trim();

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().Contains(txtbuscarproducto.Text.Trim()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbuscarproducto.Text = "";
            foreach (DataGridViewRow row in dgdataproducto.Rows)
            {
                row.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
