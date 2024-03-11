using ProyectoPuntoVenta.Logica;
using ProyectoPuntoVenta.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPuntoVenta
{
    public partial class frmVenta : Form
    {
        private static int _IdPersona;
        public frmVenta(int idpersona = 0)
        {
            InitializeComponent();
            _IdPersona = idpersona;
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {

            //AGREGAR BOTON ELIMINAR
            DataGridViewButtonColumn Boton = new DataGridViewButtonColumn();

            Boton.HeaderText = "Eliminar";
            Boton.Width = 100;
            Boton.Text = "";
            Boton.Name = "btnEliminar";
            Boton.UseColumnTextForButtonValue = true;

            //AGREGAMOS LOS BOTONES
            dgdata.Columns.Add(Boton);
            dgdata.Columns.Add("IdProducto", "IdProducto");
            dgdata.Columns.Add("Modelo", "Modelo");
            dgdata.Columns.Add("Cantidad", "Cantidad");
            dgdata.Columns.Add("PrecioVenta", "Precio Venta");
            dgdata.Columns.Add("SubTotal", "SubTotal");

            dgdata.Columns["btnEliminar"].Width = 100;
            dgdata.Columns["Modelo"].Width = 280;
            dgdata.Columns["Cantidad"].Width = 140;
            dgdata.Columns["PrecioVenta"].Width = 140;
            dgdata.Columns["SubTotal"].Width = 140;

            dgdata.Columns["IdProducto"].Visible = false;
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            using (var form = new ModalPersona())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtcodigocliente.Text = form.codigo;
                    txtnombrecliente.Text = form.nombre;
                    txtidcliente.Text = form.idcliente;
                }
            }
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var form = new ModalProducto())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtcodigoproducto.Text = form.codigo;
                    txtstock.Text = form.stock;
                    txtmodeloproducto.Text = form.modelo;
                    txtidproducto.Text = form.idproducto.ToString();
                    txtprecioventa.Text = form.precioventa.ToLower();
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

                e.Graphics.DrawImage(Properties.Resources.delete32, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgdata_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                string colname = dgdata.Columns[e.ColumnIndex].Name;
                if (colname != "btnEliminar")
                {
                    dgdata.Cursor = Cursors.Default;
                }
                else
                {
                    dgdata.Cursor = Cursors.Hand;
                }
            }
        }

        private void dgdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgdata.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    int _idproducto = int.Parse(dgdata.Rows[index].Cells["IdProducto"].Value.ToString());
                    int _cantidad = int.Parse(dgdata.Rows[index].Cells["Cantidad"].Value.ToString());
                    bool resultado = VentaLogica.Instancia.ControlStock(_idproducto, _cantidad, false);

                    if (resultado) {
                        dgdata.Rows.RemoveAt(index);
                        calcularTotal();
                    }
                }
            }
        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            decimal precioventa = 0;
            decimal subtotal;
            bool producto_existe = false;




            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto primero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (int.Parse(txtstock.Text) < int.Parse(txtcantidad.Text))
            {
                MessageBox.Show("No hay suficiente stock del producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            bool errorVenta = false;
            try
            {
                precioventa = Convert.ToDecimal(txtprecioventa.Text.Trim(), new CultureInfo("es-PE"));
            }
            catch
            {
                errorVenta = true;
            }

            if (errorVenta)
            {
                MessageBox.Show("Error al convertir el tipo de moneda - Precio Venta\nEjemplo Formato ##.##", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow fila in dgdata.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe) {

                bool resultado = VentaLogica.Instancia.ControlStock(int.Parse(txtidproducto.Text),int.Parse(txtcantidad.Text.Trim()),true);

                if (resultado) {
                    int rowId = dgdata.Rows.Add();
                    DataGridViewRow row = dgdata.Rows[rowId];
                    subtotal = Convert.ToDecimal(txtcantidad.Text.Trim()) * precioventa;

                    row.Cells["IdProducto"].Value = txtidproducto.Text;
                    row.Cells["Modelo"].Value = txtmodeloproducto.Text.Trim();
                    row.Cells["Cantidad"].Value = txtcantidad.Text.Trim();
                    row.Cells["PrecioVenta"].Value = precioventa.ToString("0.00", new CultureInfo("es-PE"));
                    row.Cells["SubTotal"].Value = subtotal.ToString("0.00", new CultureInfo("es-PE"));

                    calcularTotal();
                    limpiarProducto();
                }
            }

            
        }

        public void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txtstock.Text = "0";
            txtcodigoproducto.Text = "";
            txtmodeloproducto.Text = "";
            txtcantidad.Value = 1;
            txtprecioventa.Text = "";
        }

        private void calcularTotal()
        {

            decimal total = 0;
            if (dgdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgdata.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString(), new CultureInfo("es-PE"));
                }
            }

            txttotalpagar.Text = total.ToString("0.00", new CultureInfo("es-PE"));

        }

        private void btnterminarventa_Click(object sender, EventArgs e)
        {
            if (txtcodigocliente.Text.Trim() == "" || txtnombrecliente.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar todos los datos del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar un producto como minimo\npara registrar una venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            Venta oVenta = new Venta()
            {
                oPersona = new Persona() { IdPersona = _IdPersona },
                CodigoCliente = txtcodigocliente.Text.Trim(),
                NombreCliente = txtnombrecliente.Text.Trim(),
                TotalPagar = Convert.ToDecimal(txttotalpagar.Text,new CultureInfo("es-PE")),
            };

            List<DetalleVenta> olista = new List<DetalleVenta>();
            if (dgdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgdata.Rows)
                {
                    olista.Add(new DetalleVenta()
                    {
                        oProducto = new Producto() { IdProducto = int.Parse(row.Cells["IdProducto"].Value.ToString()) },
                        Cantidad = int.Parse(row.Cells["Cantidad"].Value.ToString()),
                        PrecioVenta = Convert.ToDecimal(row.Cells["PrecioVenta"].Value.ToString(), new CultureInfo("es-PE")),
                        SubTotal = Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString(), new CultureInfo("es-PE"))
                    });
                }
            }
            oVenta.oDetalleVenta = olista;

            int idventa = VentaLogica.Instancia.Registrar(oVenta);
            if (idventa != 0)
            {
                limpiar();
                MessageBox.Show("La venta fue registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("No se pudo registrar la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }
        private void limpiar()
        {
            txtcodigocliente.Text = "";
            txtnombrecliente.Text = "";
            txttotalpagar.Text = "0";
            dgdata.Rows.Clear();

        }



        private void txtcodigoproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                Producto pr = ProductoLogica.Instancia.Listar().Where(p => p.Codigo == txtcodigoproducto.Text.Trim()).FirstOrDefault();
                if (pr != null) {
                    txtcodigoproducto.Text = pr.Codigo;
                    txtstock.Text = pr.Stock.ToString();
                    txtmodeloproducto.Text = pr.Modelo;
                    txtidproducto.Text = pr.IdProducto.ToString();
                    txtprecioventa.Text = pr.PrecioVenta.ToString("0.00", new CultureInfo("es-PE"));
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
