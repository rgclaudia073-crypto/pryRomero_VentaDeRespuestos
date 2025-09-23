namespace pryRomero_VentaDeRespuestos
{
    partial class frmVentaDeRepuestos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMarca = new Label();
            lblOrigen = new Label();
            label3 = new Label();
            label4 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            mskPrecio = new MaskedTextBox();
            cmbNúmero = new ComboBox();
            cmbOrigen = new ComboBox();
            ltbDescripción = new ListBox();
            cmbMarca = new ComboBox();
            label5 = new Label();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblMarca.Location = new Point(6, 23);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(55, 21);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblOrigen.Location = new Point(210, 23);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(60, 21);
            lblOrigen.TabIndex = 1;
            lblOrigen.Text = "Origen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(6, 80);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 2;
            label3.Text = "Número";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(6, 191);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 3;
            label4.Text = "Descripción";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(29, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(473, 375);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(mskPrecio);
            tabPage1.Controls.Add(cmbNúmero);
            tabPage1.Controls.Add(cmbOrigen);
            tabPage1.Controls.Add(ltbDescripción);
            tabPage1.Controls.Add(cmbMarca);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(lblMarca);
            tabPage1.Controls.Add(lblOrigen);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(465, 347);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // mskPrecio
            // 
            mskPrecio.Location = new Point(302, 82);
            mskPrecio.Mask = "$999999";
            mskPrecio.Name = "mskPrecio";
            mskPrecio.Size = new Size(100, 23);
            mskPrecio.TabIndex = 10;
            // 
            // cmbNúmero
            // 
            cmbNúmero.FormattingEnabled = true;
            cmbNúmero.Location = new Point(82, 82);
            cmbNúmero.Name = "cmbNúmero";
            cmbNúmero.Size = new Size(131, 23);
            cmbNúmero.TabIndex = 9;
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Location = new Point(302, 21);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(131, 23);
            cmbOrigen.TabIndex = 8;
            cmbOrigen.SelectedIndexChanged += cmbOrigen_SelectedIndexChanged;
            // 
            // ltbDescripción
            // 
            ltbDescripción.FormattingEnabled = true;
            ltbDescripción.ItemHeight = 15;
            ltbDescripción.Location = new Point(6, 234);
            ltbDescripción.Name = "ltbDescripción";
            ltbDescripción.Size = new Size(199, 94);
            ltbDescripción.TabIndex = 7;
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(67, 21);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(119, 23);
            cmbMarca.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(240, 80);
            label5.Name = "label5";
            label5.Size = new Size(56, 21);
            label5.TabIndex = 3;
            label5.Text = "Precio";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(465, 347);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmVentaDeRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "frmVentaDeRepuestos";
            Text = "Venta De Repuestos";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMarca;
        private Label lblOrigen;
        private Label label3;
        private Label label4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label5;
        private ComboBox cmbMarca;
        private ComboBox cmbOrigen;
        private ListBox ltbDescripción;
        private MaskedTextBox mskPrecio;
        private ComboBox cmbNúmero;
    }
}
