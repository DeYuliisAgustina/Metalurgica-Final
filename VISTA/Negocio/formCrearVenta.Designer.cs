namespace VISTA.Negocio
{
    partial class formCrearVenta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAutogenerar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            this.btnbuscarcliente = new FontAwesome.Sharp.IconButton();
            this.btnagregarproducto = new FontAwesome.Sharp.IconButton();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.txtcodproducto = new System.Windows.Forms.TextBox();
            this.txtdoccliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtpagocon = new System.Windows.Forms.TextBox();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCrearVenta = new FontAwesome.Sharp.IconButton();
            this.btnCancelarVenta = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAutogenerar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(-44, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 143);
            this.panel1.TabIndex = 41;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(816, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(411, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOTAS DE VENTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Métallon s.r.l";
            // 
            // btnAutogenerar
            // 
            this.btnAutogenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.btnAutogenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutogenerar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutogenerar.Location = new System.Drawing.Point(499, 102);
            this.btnAutogenerar.Name = "btnAutogenerar";
            this.btnAutogenerar.Size = new System.Drawing.Size(205, 23);
            this.btnAutogenerar.TabIndex = 28;
            this.btnAutogenerar.Text = "AUTOGENERADO";
            this.btnAutogenerar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(384, 105);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nro Nota de venta:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.btnbuscarproducto);
            this.groupBox1.Controls.Add(this.btnbuscarcliente);
            this.groupBox1.Controls.Add(this.btnagregarproducto);
            this.groupBox1.Controls.Add(this.txtstock);
            this.groupBox1.Controls.Add(this.txtprecioventa);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.txtproducto);
            this.groupBox1.Controls.Add(this.txtnombrecliente);
            this.groupBox1.Controls.Add(this.txtcodproducto);
            this.groupBox1.Controls.Add(this.txtdoccliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 149);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(727, 155);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.BackColor = System.Drawing.Color.Black;
            this.btnbuscarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarproducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarproducto.ForeColor = System.Drawing.Color.White;
            this.btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarproducto.IconColor = System.Drawing.Color.White;
            this.btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarproducto.IconSize = 20;
            this.btnbuscarproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarproducto.Location = new System.Drawing.Point(284, 53);
            this.btnbuscarproducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Size = new System.Drawing.Size(80, 25);
            this.btnbuscarproducto.TabIndex = 16;
            this.btnbuscarproducto.Text = "Buscar";
            this.btnbuscarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarproducto.UseVisualStyleBackColor = false;
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.BackColor = System.Drawing.Color.Black;
            this.btnbuscarcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarcliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarcliente.ForeColor = System.Drawing.Color.White;
            this.btnbuscarcliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarcliente.IconColor = System.Drawing.Color.White;
            this.btnbuscarcliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarcliente.IconSize = 20;
            this.btnbuscarcliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarcliente.Location = new System.Drawing.Point(284, 22);
            this.btnbuscarcliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Size = new System.Drawing.Size(80, 25);
            this.btnbuscarcliente.TabIndex = 15;
            this.btnbuscarcliente.Text = "Buscar";
            this.btnbuscarcliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarcliente.UseVisualStyleBackColor = false;
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.BackColor = System.Drawing.Color.Black;
            this.btnagregarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarproducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarproducto.ForeColor = System.Drawing.Color.White;
            this.btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnagregarproducto.IconColor = System.Drawing.Color.White;
            this.btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregarproducto.IconSize = 20;
            this.btnagregarproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnagregarproducto.Location = new System.Drawing.Point(478, 114);
            this.btnagregarproducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.Size = new System.Drawing.Size(227, 34);
            this.btnagregarproducto.TabIndex = 14;
            this.btnagregarproducto.Text = "Agregar";
            this.btnagregarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnagregarproducto.UseVisualStyleBackColor = false;
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(117, 117);
            this.txtstock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtstock.Name = "txtstock";
            this.txtstock.ReadOnly = true;
            this.txtstock.Size = new System.Drawing.Size(154, 20);
            this.txtstock.TabIndex = 13;
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Location = new System.Drawing.Point(478, 86);
            this.txtprecioventa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(227, 20);
            this.txtprecioventa.TabIndex = 12;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(117, 87);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtcantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtcantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(155, 20);
            this.txtcantidad.TabIndex = 11;
            this.txtcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(478, 56);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.ReadOnly = true;
            this.txtproducto.Size = new System.Drawing.Size(227, 20);
            this.txtproducto.TabIndex = 10;
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(478, 24);
            this.txtnombrecliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(227, 20);
            this.txtnombrecliente.TabIndex = 9;
            // 
            // txtcodproducto
            // 
            this.txtcodproducto.Location = new System.Drawing.Point(117, 55);
            this.txtcodproducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtcodproducto.Name = "txtcodproducto";
            this.txtcodproducto.Size = new System.Drawing.Size(154, 20);
            this.txtcodproducto.TabIndex = 8;
            // 
            // txtdoccliente
            // 
            this.txtdoccliente.Location = new System.Drawing.Point(117, 24);
            this.txtdoccliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdoccliente.Name = "txtdoccliente";
            this.txtdoccliente.Size = new System.Drawing.Size(154, 20);
            this.txtdoccliente.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(19, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(376, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio Venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(19, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(376, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cod. Producto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(376, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nombre Cliente:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(19, 27);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Doc. Cliente:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(448, 588);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 50;
            this.label14.Text = "Paga con:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(613, 588);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 16);
            this.label13.TabIndex = 49;
            this.label13.Text = "Cambio:";
            // 
            // txtpagocon
            // 
            this.txtpagocon.Location = new System.Drawing.Point(521, 585);
            this.txtpagocon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtpagocon.Name = "txtpagocon";
            this.txtpagocon.Size = new System.Drawing.Size(74, 20);
            this.txtpagocon.TabIndex = 48;
            // 
            // txtcambio
            // 
            this.txtcambio.Location = new System.Drawing.Point(678, 585);
            this.txtcambio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.ReadOnly = true;
            this.txtcambio.Size = new System.Drawing.Size(74, 20);
            this.txtcambio.TabIndex = 47;
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.Location = new System.Drawing.Point(678, 557);
            this.txttotalpagar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.ReadOnly = true;
            this.txttotalpagar.Size = new System.Drawing.Size(74, 20);
            this.txttotalpagar.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(584, 560);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "Total a Pagar:";
            // 
            // btnCrearVenta
            // 
            this.btnCrearVenta.BackColor = System.Drawing.Color.Black;
            this.btnCrearVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearVenta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearVenta.ForeColor = System.Drawing.Color.White;
            this.btnCrearVenta.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnCrearVenta.IconColor = System.Drawing.Color.White;
            this.btnCrearVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearVenta.IconSize = 20;
            this.btnCrearVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearVenta.Location = new System.Drawing.Point(206, 562);
            this.btnCrearVenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCrearVenta.Name = "btnCrearVenta";
            this.btnCrearVenta.Size = new System.Drawing.Size(138, 35);
            this.btnCrearVenta.TabIndex = 45;
            this.btnCrearVenta.Text = "Crear Venta";
            this.btnCrearVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearVenta.UseVisualStyleBackColor = false;
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.BackColor = System.Drawing.Color.Black;
            this.btnCancelarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarVenta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenta.ForeColor = System.Drawing.Color.White;
            this.btnCancelarVenta.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnCancelarVenta.IconColor = System.Drawing.Color.Red;
            this.btnCancelarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarVenta.IconSize = 20;
            this.btnCancelarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarVenta.Location = new System.Drawing.Point(41, 562);
            this.btnCancelarVenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(138, 35);
            this.btnCancelarVenta.TabIndex = 46;
            this.btnCancelarVenta.Text = "Cancelar Venta";
            this.btnCancelarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarVenta.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(727, 241);
            this.dataGridView1.TabIndex = 51;
            // 
            // formCrearVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(803, 609);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtpagocon);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.txttotalpagar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCrearVenta);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCrearVenta";
            this.Text = "formCrearVenta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAutogenerar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private FontAwesome.Sharp.IconButton btnbuscarcliente;
        private FontAwesome.Sharp.IconButton btnagregarproducto;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.TextBox txtcodproducto;
        private System.Windows.Forms.TextBox txtdoccliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtpagocon;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.TextBox txttotalpagar;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton btnCrearVenta;
        private FontAwesome.Sharp.IconButton btnCancelarVenta;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}