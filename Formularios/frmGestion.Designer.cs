namespace ProyectoPuntoVenta
{
    partial class frmGestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestion));
            this.txtcolorproducto = new System.Windows.Forms.TextBox();
            this.txtindexproducto = new System.Windows.Forms.TextBox();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.dgdataproducto = new System.Windows.Forms.DataGridView();
            this.txtbuscarproducto = new System.Windows.Forms.TextBox();
            this.cbobuscarproducto = new System.Windows.Forms.ComboBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btneliminarproducto = new System.Windows.Forms.Button();
            this.btnlimpiarproducto = new System.Windows.Forms.Button();
            this.btnguardarproducto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmodeloproducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmarcaproducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcodigoproducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdataproducto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcolorproducto
            // 
            this.txtcolorproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcolorproducto.Location = new System.Drawing.Point(10, 246);
            this.txtcolorproducto.Name = "txtcolorproducto";
            this.txtcolorproducto.Size = new System.Drawing.Size(244, 21);
            this.txtcolorproducto.TabIndex = 66;
            // 
            // txtindexproducto
            // 
            this.txtindexproducto.Location = new System.Drawing.Point(206, 50);
            this.txtindexproducto.Name = "txtindexproducto";
            this.txtindexproducto.Size = new System.Drawing.Size(22, 20);
            this.txtindexproducto.TabIndex = 64;
            this.txtindexproducto.Text = "0";
            this.txtindexproducto.Visible = false;
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(232, 50);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(22, 20);
            this.txtidproducto.TabIndex = 65;
            this.txtidproducto.Text = "0";
            this.txtidproducto.Visible = false;
            // 
            // dgdataproducto
            // 
            this.dgdataproducto.AllowUserToAddRows = false;
            this.dgdataproducto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdataproducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgdataproducto.ColumnHeadersHeight = 30;
            this.dgdataproducto.EnableHeadersVisualStyles = false;
            this.dgdataproducto.GridColor = System.Drawing.Color.DimGray;
            this.dgdataproducto.Location = new System.Drawing.Point(293, 76);
            this.dgdataproducto.MultiSelect = false;
            this.dgdataproducto.Name = "dgdataproducto";
            this.dgdataproducto.ReadOnly = true;
            this.dgdataproducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdataproducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgdataproducto.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgdataproducto.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgdataproducto.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgdataproducto.RowTemplate.Height = 30;
            this.dgdataproducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdataproducto.Size = new System.Drawing.Size(952, 422);
            this.dgdataproducto.TabIndex = 63;
            this.dgdataproducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdataproducto_CellContentClick);
            this.dgdataproducto.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdataproducto_CellMouseEnter);
            this.dgdataproducto.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgdataproducto_CellPainting);
            // 
            // txtbuscarproducto
            // 
            this.txtbuscarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscarproducto.Location = new System.Drawing.Point(950, 45);
            this.txtbuscarproducto.Name = "txtbuscarproducto";
            this.txtbuscarproducto.Size = new System.Drawing.Size(195, 21);
            this.txtbuscarproducto.TabIndex = 62;
            // 
            // cbobuscarproducto
            // 
            this.cbobuscarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbobuscarproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobuscarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobuscarproducto.FormattingEnabled = true;
            this.cbobuscarproducto.Location = new System.Drawing.Point(739, 43);
            this.cbobuscarproducto.Name = "cbobuscarproducto";
            this.cbobuscarproducto.Size = new System.Drawing.Size(194, 23);
            this.cbobuscarproducto.TabIndex = 61;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Image = global::ProyectoPuntoVenta.Properties.Resources.clear16;
            this.btnclear.Location = new System.Drawing.Point(1204, 45);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(37, 21);
            this.btnclear.TabIndex = 59;
            this.btnclear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = global::ProyectoPuntoVenta.Properties.Resources.search16;
            this.btnbuscar.Location = new System.Drawing.Point(1161, 45);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(37, 21);
            this.btnbuscar.TabIndex = 60;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(655, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 38;
            this.label9.Text = "Buscar por:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(288, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 25);
            this.label10.TabIndex = 37;
            this.label10.Text = "Lista de Productos";
            // 
            // btneliminarproducto
            // 
            this.btneliminarproducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btneliminarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminarproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminarproducto.Location = new System.Drawing.Point(10, 392);
            this.btneliminarproducto.Name = "btneliminarproducto";
            this.btneliminarproducto.Size = new System.Drawing.Size(244, 38);
            this.btneliminarproducto.TabIndex = 35;
            this.btneliminarproducto.Text = "Eliminar";
            this.btneliminarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminarproducto.UseVisualStyleBackColor = false;
            this.btneliminarproducto.Click += new System.EventHandler(this.btneliminarproducto_Click);
            // 
            // btnlimpiarproducto
            // 
            this.btnlimpiarproducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnlimpiarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarproducto.Location = new System.Drawing.Point(10, 348);
            this.btnlimpiarproducto.Name = "btnlimpiarproducto";
            this.btnlimpiarproducto.Size = new System.Drawing.Size(244, 38);
            this.btnlimpiarproducto.TabIndex = 34;
            this.btnlimpiarproducto.Text = "Limpiar";
            this.btnlimpiarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiarproducto.UseVisualStyleBackColor = false;
            this.btnlimpiarproducto.Click += new System.EventHandler(this.btnlimpiarproducto_Click);
            // 
            // btnguardarproducto
            // 
            this.btnguardarproducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnguardarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardarproducto.Location = new System.Drawing.Point(10, 304);
            this.btnguardarproducto.Name = "btnguardarproducto";
            this.btnguardarproducto.Size = new System.Drawing.Size(244, 38);
            this.btnguardarproducto.TabIndex = 36;
            this.btnguardarproducto.Text = "Guardar";
            this.btnguardarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardarproducto.UseVisualStyleBackColor = false;
            this.btnguardarproducto.Click += new System.EventHandler(this.btnguardarproducto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Color:";
            // 
            // txtmodeloproducto
            // 
            this.txtmodeloproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodeloproducto.Location = new System.Drawing.Point(10, 187);
            this.txtmodeloproducto.Name = "txtmodeloproducto";
            this.txtmodeloproducto.Size = new System.Drawing.Size(244, 21);
            this.txtmodeloproducto.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Modelo:";
            // 
            // txtmarcaproducto
            // 
            this.txtmarcaproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmarcaproducto.Location = new System.Drawing.Point(10, 130);
            this.txtmarcaproducto.Name = "txtmarcaproducto";
            this.txtmarcaproducto.Size = new System.Drawing.Size(244, 21);
            this.txtmarcaproducto.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Marca:";
            // 
            // txtcodigoproducto
            // 
            this.txtcodigoproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoproducto.Location = new System.Drawing.Point(10, 76);
            this.txtcodigoproducto.Name = "txtcodigoproducto";
            this.txtcodigoproducto.Size = new System.Drawing.Size(244, 21);
            this.txtcodigoproducto.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Código / ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Datos de Producto";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(12, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 67;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1269, 568);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcolorproducto);
            this.Controls.Add(this.txtindexproducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtidproducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgdataproducto);
            this.Controls.Add(this.txtcodigoproducto);
            this.Controls.Add(this.txtbuscarproducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbobuscarproducto);
            this.Controls.Add(this.txtmarcaproducto);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtmodeloproducto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnguardarproducto);
            this.Controls.Add(this.btneliminarproducto);
            this.Controls.Add(this.btnlimpiarproducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdataproducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btneliminarproducto;
        private System.Windows.Forms.Button btnlimpiarproducto;
        private System.Windows.Forms.Button btnguardarproducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmodeloproducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmarcaproducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcodigoproducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbuscarproducto;
        private System.Windows.Forms.ComboBox cbobuscarproducto;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView dgdataproducto;
        private System.Windows.Forms.TextBox txtindexproducto;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.TextBox txtcolorproducto;
        private System.Windows.Forms.Button button1;
    }
}