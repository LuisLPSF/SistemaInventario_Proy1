namespace SistemaInventario_Proy1
{
    partial class FormReportes
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dgvReportes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(30, 91);
            button1.Name = "button1";
            button1.Size = new Size(116, 66);
            button1.TabIndex = 0;
            button1.Text = "Inventario Total";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnTotal_Click;
            // 
            // button2
            // 
            button2.Location = new Point(30, 177);
            button2.Name = "button2";
            button2.Size = new Size(116, 92);
            button2.TabIndex = 1;
            button2.Text = "Productos con Stock Bajo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnStockBajo_Click;
            // 
            // button3
            // 
            button3.Location = new Point(30, 287);
            button3.Name = "button3";
            button3.Size = new Size(116, 71);
            button3.TabIndex = 2;
            button3.Text = "Productos Agotados";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnAgotados_Click;
            // 
            // dgvReportes
            // 
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.ColumnHeadersVisible = false;
            dgvReportes.Location = new Point(171, 77);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.RowHeadersVisible = false;
            dgvReportes.RowHeadersWidth = 51;
            dgvReportes.Size = new Size(510, 300);
            dgvReportes.TabIndex = 3;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvReportes);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormReportes";
            Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dgvReportes;
    }
}