namespace SistemaInventario_Proy1
{
    partial class FormMovimientos
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
            cmbTipo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtIDProducto = new TextBox();
            txtCantidad = new TextBox();
            txtReferencia = new TextBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Entrada", "Salida" });
            cmbTipo.Location = new Point(51, 56);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(151, 28);
            cmbTipo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 143);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 1;
            label1.Text = "ID Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 199);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 255);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 3;
            label3.Text = "Referencia";
            // 
            // txtIDProducto
            // 
            txtIDProducto.Location = new Point(195, 143);
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.Size = new Size(125, 27);
            txtIDProducto.TabIndex = 5;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(195, 199);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 6;
            // 
            // txtReferencia
            // 
            txtReferencia.Location = new Point(195, 255);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(125, 27);
            txtReferencia.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(402, 294);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 61);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar Movimiento";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // FormMovimientos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrar);
            Controls.Add(txtReferencia);
            Controls.Add(txtCantidad);
            Controls.Add(txtIDProducto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbTipo);
            Name = "FormMovimientos";
            Text = "FormMovimientos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIDProducto;
        private TextBox txtCantidad;
        private TextBox txtReferencia;
        private Button btnRegistrar;
    }
}